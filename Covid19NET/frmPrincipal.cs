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
using ChoETL;
using System.Xml.Linq;

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
            switch (mtcbTemas.SelectedIndex)
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

            mtcbCores.SelectedIndex = 0;
            mtcbTemas.SelectedIndex = 1;
        }

        #region Navegação - Botões
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

        private void mtbVersao_Click(object sender, EventArgs e)
        {
            mTabAbas.SelectTab("mtChangeLog");
        }

        #endregion Fim - Navegação Botões

        #region Links - Web
        private void mtLinkSite_Click(object sender, EventArgs e)
        {
            Process.Start("https://www.worldometers.info/");
        }

        private void mtLinkEymardGithub_Click(object sender, EventArgs e)
        {
            Process.Start("https://www.github.com/MardSilva");
        }

        private void mtlSobre_Click(object sender, EventArgs e)
        {
            Process.Start("https://www.esware.com.br");
        }

        #endregion Fim Links - Web

        private void mtbAtualizarMundial_Click(object sender, EventArgs e)
        {
            DialogResult drResultado = MessageBox.Show("Você deseja obter os dados mais atualizados do COVID-19?", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (drResultado == DialogResult.Yes)
            {
                mtlblAtualizando.Visible = true;
                mtlblAtualizando.Text = "";
                
                string strDadosAPI;
                
                mtlblAtualizando.Text = "Os dados estão sendo atualizados, por favor aguarde um momento...";
                strDadosAPI = BaixarDadosMundiaisAPI();

                #region Busca de Dados da API
                //Iniciando a busca dos dados da API
                if (!string.IsNullOrEmpty(strDadosAPI))
                {
                    mtlblAtualizando.Text = "";
                    mtlblAtualizando.Text = "Os dados da API foram baixados/atualizados com sucesso!";

                    DialogResult drSalvarResultado = MessageBox.Show("Deseja salvar o conteúdo baixado da API no seu computador?", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                    if(drSalvarResultado == DialogResult.Yes)
                    {
                        mtlblAtualizando.Text = "";
                        mtlblAtualizando.Text = "Salvando os dados no arquivo JSON... aguarde um momento.";
                        
                        SalvarDadosAPIMundial(strDadosAPI);

                        mtlblAtualizando.Text = "";
                        mtlblAtualizando.Text = "O arquivo JSON com os dados baixados da API foram salvos com sucesso!";

                        mtlblAtualizando.Text = "";
                        mtlblAtualizando.Text = "Recuperando e preenchendo as informações... por favor, aguarde.";

                        DadosGerais novoDadosGerais = new DadosGerais();
                        novoDadosGerais = JsonConvert.DeserializeObject<DadosGerais>(strDadosAPI);

                        mtlblCasosMundiais.Text = novoDadosGerais.Cases.ToString() + " Casos Confirmados";
                        mtlblMortesMundiais.Text = novoDadosGerais.Deaths.ToString() + " Mortes Confirmadas";
                        mtlblRecuperados.Text = novoDadosGerais.Recovered.ToString() + " Casos Revertidos";

                        mtlblAtualizando.Text = "";
                        mtlblAtualizando.Text = "Os dados baixados/atualizados da API foram exibidos com sucesso!";

                    }
                    else
                    {
                        mtlblAtualizando.Text = "";
                        mtlblAtualizando.Text = "O arquivo JSON com os dados baixados da API foram salvos com sucesso!";

                        mtlblAtualizando.Text = "";
                        mtlblAtualizando.Text = "Recuperando e preenchendo as informações... por favor, aguarde.";

                        DadosGerais novoDadosGerais = new DadosGerais();
                        novoDadosGerais = JsonConvert.DeserializeObject<DadosGerais>(strDadosAPI);

                        mtlblCasosMundiais.Text = novoDadosGerais.Cases.ToString() + " Casos Confirmados";
                        mtlblMortesMundiais.Text = novoDadosGerais.Deaths.ToString() + " Mortes Confirmadas";
                        mtlblRecuperados.Text = novoDadosGerais.Recovered.ToString() + " Casos Revertidos";

                        mtlblAtualizando.Text = "";
                        mtlblAtualizando.Text = "Os dados baixados/atualizados da API foram exibidos com sucesso!";
                    }
                }
                else
                {
                    mtlblAtualizando.Text = "";
                    mtlblAtualizando.Visible = false;
                    MessageBox.Show("Não foi possível obter os dados da API nesse momento. Possivelmente, estão atualizando os dados, caso contrário, verifique sua conexão com a internet.\n\nVerifque ou aguarde um momento e tente novamente.", "Confirmação", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                #endregion Fim - Busca de Dados da API
            }
            else
            {
                mtlblAtualizando.Text = "";
                mtlblAtualizando.Visible = false;
                MessageBox.Show("Nenhum dado foi obtido/atualizado. Por favor, tente novamente.", "Confirmação", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }

        private string BaixarDadosMundiaisAPI()
        {
            try
            {
                string strLink = "https://coronavirus-19-api.herokuapp.com/all";
                string strRetornoAPI;

                Uri novoUrl = new Uri(strLink);

                HttpWebRequest requisicaoHTTP = WebRequest.Create(novoUrl) as HttpWebRequest;
                requisicaoHTTP.Method = "GET";
                requisicaoHTTP.ContentType = "application/json";

                mtlblAtualizando.Text = "Os dados estão sendo atualizados, por favor aguarde...";

                using (HttpWebResponse respostaHTTP = requisicaoHTTP.GetResponse() as HttpWebResponse)
                {
                    StreamReader novoLeitorStream = new StreamReader(respostaHTTP.GetResponseStream());
                    strRetornoAPI = novoLeitorStream.ReadToEnd();

                    return strRetornoAPI;
                }
            }
            catch
            {
                MessageBox.Show("Não foi possível obter os dados da API nesse momento. Possivelmente, estão atualizando os dados, caso contrário, verifique sua conexão com a internet.\n\nVerifque ou aguarde um momento e tente novamente.", "Confirmação", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            return "";
        }

        private bool SalvarDadosAPIMundial(string strDados)
        {
            string strJSON = strDados;

            //Criando o JSON
            string strJSONAux = JsonConvert.SerializeObject(strJSON, Formatting.Indented);

            //Criando e salvando no diretório
            string strDir = @"C:\COVID-19Net\Dados\JSON\Dados Mundiais";

            if (!Directory.Exists(strDir))
            {
                Directory.CreateDirectory(strDir);
            }

            //Criação do arquivo JSON_DadosMundiais_DiaMesAno.json
            string strArquivoJSON = Path.GetDirectoryName(strDir) + "\\Dados Mundiais\\" + "JSON_DadosMundiais_" + DateTime.Today.ToString("dd_MM_yyyy") + "_" + DateTime.Now.ToString("HH_mm_ss") + ".json";

            if (!File.Exists(strArquivoJSON))
            {
                File.Create(strArquivoJSON).Dispose();
            }

            using (StreamWriter swEscreverJSON = File.AppendText(strArquivoJSON))
            {
                swEscreverJSON.WriteLine(strJSONAux);
                swEscreverJSON.Close();
            }

            MessageBox.Show("O arquivo foi salvo com sucesso. Ele se encontra na pasta: " + strDir.ToString() + ".", "Confirmação", MessageBoxButtons.OK, MessageBoxIcon.Information);
            return true;
        }

        private void mtAtualizarDadosTabela_Click(object sender, EventArgs e)
        {
            DialogResult drResultado = MessageBox.Show("Deseja obter os dados mais atualizados do COVID-19 de todos os países, e preencher a tabela com essas informações?", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if(drResultado == DialogResult.Yes)
            {
                mtlblTabela.Text = "";

                string strDadosAPI;

                mtlblTabela.Text = "Os dados estão sendo atualizados, por favor aguarde um momento...";
                strDadosAPI = BaixarDadosPaisesAPI();

                #region Baixar Dados da API
                if (!string.IsNullOrEmpty(strDadosAPI))
                {
                    mtlblTabela.Text = "";
                    mtlblTabela.Text = "Os dados da API foram baixados/atualizados com sucesso!";

                    DialogResult drSalvarResultado = MessageBox.Show("Deseja salvar o conteúdo baixado da API no seu computador?", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                    if(drSalvarResultado == DialogResult.Yes)
                    {
                        SalvarDadosAPIPaises(strDadosAPI);
                        
                        mtlblTabela.Text = "";

                        dtgvDadosTabela.DataSource = JsonConvert.DeserializeObject<List<ClassePaises>>(strDadosAPI);
                        mtlblTabela.Text = "Pronto! Os dados foram atualizados de acordo com a API e preenchidos na Tabela.";
                    }
                    else
                    {
                        mtlblTabela.Text = "";

                        dtgvDadosTabela.DataSource = JsonConvert.DeserializeObject<List<ClassePaises>>(strDadosAPI);
                        mtlblTabela.Text = "Pronto! Os dados foram atualizados de acordo com a API e preenchidos na Tabela.";
                    }
                }
                else
                {
                    mtlblTabela.Text = "";
                    mtlblTabela.Text = "Por favor, para visualizar os dados, clique em 'Atualizar Tabela'.";
                    return;
                }
                #endregion Fim - Baixar Dados da API

            }
            else
            {
                mtlblAtualizando.Text = "";
                mtlblTabela.Text = "Por favor, para visualizar os dados, clique em 'Atualizar Tabela'.";
                MessageBox.Show("Nenhum dado foi obtido/atualizado. Por favor, tente novamente.", "Confirmação", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private string BaixarDadosPaisesAPI()
        {
            try
            {
                string strLink = "https://coronavirus-19-api.herokuapp.com/countries";
                string strRetornoAPI;

                Uri novoUrl = new Uri(strLink);

                HttpWebRequest requisicaoHTTP = WebRequest.Create(novoUrl) as HttpWebRequest;
                requisicaoHTTP.Method = "GET";
                requisicaoHTTP.ContentType = "application/json";

                using (HttpWebResponse respostaHTTP = requisicaoHTTP.GetResponse() as HttpWebResponse)
                {
                    StreamReader novoLeitorStream = new StreamReader(respostaHTTP.GetResponseStream());
                    strRetornoAPI = novoLeitorStream.ReadToEnd();

                    return strRetornoAPI;
                }
            }
            catch
            {
                MessageBox.Show("Não foi possível obter os dados da API nesse momento. Possivelmente, estão atualizando os dados, caso contrário, verifique sua conexão com a internet.\n\nVerifque ou aguarde um momento e tente novamente.", "Confirmação", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            return "";
        }
        private bool SalvarDadosAPIPaises(string strDados)
        {
            string strJSON = strDados;

            //Criando o JSON
            string strJSONAux = JsonConvert.SerializeObject(strJSON, Formatting.Indented);

            //Criando e salvando no diretório
            string strDir = @"C:\COVID-19Net\Dados\JSON\Dados Paises";

            if (!Directory.Exists(strDir))
            {
                Directory.CreateDirectory(strDir);
            }

            //Criação do arquivo JSON_DadosMundiais_DiaMesAno.json
            string strArquivoJSON = Path.GetDirectoryName(strDir) + "\\Dados Paises\\" + "JSON_DadosPaises_" + DateTime.Today.ToString("dd_MM_yyyy") + "_" + DateTime.Now.ToString("HH_mm_ss") + ".json";

            if (!File.Exists(strArquivoJSON))
            {
                File.Create(strArquivoJSON).Dispose();
            }

            using (StreamWriter swEscreverJSON = File.AppendText(strArquivoJSON))
            {
                swEscreverJSON.WriteLine(strJSONAux);
                swEscreverJSON.Close();
            }

            MessageBox.Show("O arquivo foi salvo com sucesso. Ele se encontra na pasta: " + strDir.ToString() + ".", "Confirmação", MessageBoxButtons.OK, MessageBoxIcon.Information);
            return true;
        }

        private void mtbExportarCSV_Click(object sender, EventArgs e)
        {
            {
                MessageBox.Show("Funcionalidade ainda em desenvolvimento!", "Confirmação", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void dtgvDadosTabela_VisibleChanged(object sender, EventArgs e)
        {
            if(dtgvDadosTabela.Visible)
            {
                CentralizarDados();
            }
        }

        private void CentralizarDados()
        {
            //Definindo o alinhamento centralizado para as células
            dtgvDadosTabela.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
        }

        private void dtgvDadosTabela_Sorted(object sender, EventArgs e)
        {
            dtgvDadosTabela.Sort(dtgvDadosTabela.Columns[1], ListSortDirection.Ascending);
        }
    }
}
