using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using MetroFramework.Forms;
using System.Windows.Forms;
using System.Diagnostics;
using System.Net;
using Newtonsoft.Json;
using System.Net.Http;
using System.IO;
using Newtonsoft.Json.Linq;

namespace Covid19NET
{
    public partial class frmPrincipal : MetroFramework.Forms.MetroForm
    {
        public frmPrincipal()
        {
            InitializeComponent();

            //Definindo o StyleManager para o objeto mtsmGerenciadordeEstilo
            StyleManager = mtsmGerenciadordeEstilo;
        }

        private void mtcbTemas_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch(mtcbTemas.SelectedIndex)
            {
                case 0:
                    mtsmGerenciadordeEstilo.Theme = MetroFramework.MetroThemeStyle.Dark; //Dark Color
                    break;
                case 1:
                    mtsmGerenciadordeEstilo.Theme = MetroFramework.MetroThemeStyle.Light; //Light color
                    break;
            }
        }

        private void mtcbCores_SelectedIndexChanged(object sender, EventArgs e)
        {
            mtsmGerenciadordeEstilo.Style = (MetroFramework.MetroColorStyle)Convert.ToInt32(mtcbCores.SelectedIndex);
        }

        private void frmPrincipal_Load(object sender, EventArgs e)
        {
            mtlblAtualizando.Visible = false;
            mTabAbas.SelectTab("mtInicio");
        }

        private void mtbInicio_Click(object sender, EventArgs e)
        {
            mTabAbas.SelectTab("mtInicio");
        }

        private void mtbGerais_Click(object sender, EventArgs e)
        {
            mTabAbas.SelectTab("mtMundial");
        }

        private void mtbPais_Click(object sender, EventArgs e)
        {
            mTabAbas.SelectTab("mtPaises");
        }

        private void mtbConfigGerais_Click(object sender, EventArgs e)
        {
            mTabAbas.SelectTab("mtOpcoes");
        }

        private void metroLink1_Click(object sender, EventArgs e)
        {
            Process.Start("https://github.com/javieraviles/covidAPI");
        }

        private void mtLinkEymardGithub_Click(object sender, EventArgs e)
        {
            Process.Start("https://www.github.com/MardSilva");
        }

        private void mtlSobre_Click(object sender, EventArgs e)
        {
            Process.Start("https://www.esware.com.br");
        }

        private void mtbAtualizarMundial_Click(object sender, EventArgs e)
        {
            DialogResult drResultado = MessageBox.Show("Você deseja obter os dados mais atualizados do COVID-19?", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (drResultado == DialogResult.Yes)
            {
                mtlblAtualizando.Visible = true;
                mtlblAtualizando.Text = "";

                string strLink = "https://coronavirus-19-api.herokuapp.com/all";

                if (Uri.IsWellFormedUriString(strLink, UriKind.Absolute))
                {
                    Uri novoUrl = new Uri(strLink);

                    HttpWebRequest requisicaoHTTP = WebRequest.Create(novoUrl) as HttpWebRequest;
                    requisicaoHTTP.Method = "GET";
                    requisicaoHTTP.ContentType = "application/json";

                    mtlblAtualizando.Text = "Os dados estão sendo atualizados, por favor aguarde...";

                    using (HttpWebResponse respostaHTTP = requisicaoHTTP.GetResponse() as HttpWebResponse)
                    {
                        StreamReader novoLeitorStream = new StreamReader(respostaHTTP.GetResponseStream());
                        string strTexto = novoLeitorStream.ReadToEnd();

                        mtlblAtualizando.Text = "Os dados foram baixados/atualizados. Por favor, aguarde...";

                        DialogResult drResultadoJson = MessageBox.Show("Você deseja salvar o conteúdo atualizado na pasta do programa? Nota: Ele será salvo no Formato JSON.", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                        if (drResultadoJson == DialogResult.Yes)
                        {
                            string strJSON = strTexto;
                            strJSON = JsonConvert.SerializeObject(strJSON, Formatting.Indented);

                            string strDiretorio = @"C:\COVID-19.NET\Data\JSON\Dados Mundiais";


                            if (!Directory.Exists(strDiretorio))
                            {
                                Directory.CreateDirectory(strDiretorio);
                            }

                            string strArquivoJSON = Path.GetDirectoryName(strDiretorio) + "\\Dados Mundiais\\" + "DadosMundiais_" + DateTime.Today.ToString("dd-MM-yy") + ".json";

                            if (!File.Exists(strArquivoJSON))
                            {
                                File.Create(strArquivoJSON).Dispose();
                            }

                            using (StreamWriter swEscreverJSON = File.AppendText(strArquivoJSON))
                            {
                                swEscreverJSON.WriteLine(strJSON);
                                swEscreverJSON.Close();
                            }
                        }

                        try
                        {
                            mtlblAtualizando.Text = "Recuperando informações...";

                            DadosGerais novoDadosGerais = new DadosGerais();
                            novoDadosGerais = JsonConvert.DeserializeObject<DadosGerais>(strTexto);

                            mtlblCasosMundiais.Text = novoDadosGerais.Cases.ToString() + " Casos Confirmados";
                            mtlblMortesMundiais.Text = novoDadosGerais.Deaths.ToString() + " Mortes Confirmadas";
                            mtlblRecuperados.Text = novoDadosGerais.Recovered.ToString() + " Casos Revertidos";

                            mtlblAtualizando.Text = "Os dados baixados/atualizados foram exibidos com sucesso!";

                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.ToString());
                        }
                    }
            }
                else
                {
                    mtlblAtualizando.Text = "";
                    mtlblAtualizando.Text = "Não foi possível obter os dados agora. Tente novamente mais tarde!";
                    MessageBox.Show("Os dados não puderam ser atualizados. Provavelmente, o servidor da API deve estar em manutenção ou então, atualizando as informações. \nPor favor, tente novamente mais tarde.", "Confirmação", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

            }

        }

        private void mtAtualizarDados_Click(object sender, EventArgs e)
        {

            string strLink = "https://coronavirus-19-api.herokuapp.com/countries";
            Uri novoUrl = new Uri(strLink);

            HttpWebRequest requisicaoHTTP = WebRequest.Create(novoUrl) as HttpWebRequest;
            requisicaoHTTP.Method = "GET";
            requisicaoHTTP.ContentType = "application/json";

            mtlblTabela.Text = "";

            using (HttpWebResponse respostaHTTP = requisicaoHTTP.GetResponse() as HttpWebResponse)
            {
                mtlblTabela.Text = "Atualizando os dados da tabela...";

                StreamReader novoLeitorStream = new StreamReader(respostaHTTP.GetResponseStream());
                string strTexto = novoLeitorStream.ReadToEnd();

                if(!string.IsNullOrEmpty(strTexto))
                {
                    mtlblTabela.Text = "";

                    mtrgrdDataGrid.DataSource = JsonConvert.DeserializeObject<List<ClassePaises>>(strTexto);

                    mtlblTabela.Text = "Pronto! Os dados foram atualizados.";
                    //var listaJSON = JsonConvert.DeserializeObject<List<ClassePaises>>(strTexto);
                }
                else
                {
                    mtlblTabela.Text = "";
                    mtlblTabela.Text = "Não foi possível obter os dados agora. Tente novamente mais tarde!";
                    MessageBox.Show("Os dados não puderam ser atualizados. Provavelmente, o servidor da API deve estar em manutenção ou então, atualizando as informações. \nPor favor, tente novamente mais tarde.", "Confirmação", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }
    }
}
