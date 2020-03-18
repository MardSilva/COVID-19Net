namespace Covid19NET
{
    partial class frmPrincipal
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPrincipal));
            this.mTabAbas = new MetroFramework.Controls.MetroTabControl();
            this.mtInicio = new MetroFramework.Controls.MetroTabPage();
            this.metroLabel9 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel10 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel8 = new MetroFramework.Controls.MetroLabel();
            this.mtMundial = new MetroFramework.Controls.MetroTabPage();
            this.mtlblAtualizando = new MetroFramework.Controls.MetroLabel();
            this.mtlblRecuperados = new MetroFramework.Controls.MetroLabel();
            this.metroLabel17 = new MetroFramework.Controls.MetroLabel();
            this.mtlblMortesMundiais = new MetroFramework.Controls.MetroLabel();
            this.metroLabel15 = new MetroFramework.Controls.MetroLabel();
            this.mtlblCasosMundiais = new MetroFramework.Controls.MetroLabel();
            this.metroLabel13 = new MetroFramework.Controls.MetroLabel();
            this.mtbAtualizarMundial = new MetroFramework.Controls.MetroButton();
            this.metroLabel12 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel11 = new MetroFramework.Controls.MetroLabel();
            this.mtPaises = new MetroFramework.Controls.MetroTabPage();
            this.mtrgrdDataGrid = new MetroFramework.Controls.MetroGrid();
            this.mtlblTabela = new MetroFramework.Controls.MetroLabel();
            this.mtbExportarCSV = new MetroFramework.Controls.MetroButton();
            this.mtAtualizarDadosTabela = new MetroFramework.Controls.MetroButton();
            this.mtOpcoes = new MetroFramework.Controls.MetroTabPage();
            this.mtLinkEymardGithub = new MetroFramework.Controls.MetroLink();
            this.mtLinkSite = new MetroFramework.Controls.MetroLink();
            this.metroLabel7 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel6 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel5 = new MetroFramework.Controls.MetroLabel();
            this.mtcbCores = new MetroFramework.Controls.MetroComboBox();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.mtcbTemas = new MetroFramework.Controls.MetroComboBox();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.metroTile2 = new MetroFramework.Controls.MetroTile();
            this.metroTile1 = new MetroFramework.Controls.MetroTile();
            this.mtbGerais = new MetroFramework.Controls.MetroButton();
            this.mtbInicio = new MetroFramework.Controls.MetroButton();
            this.mtsmGerenciadordeEstilo = new MetroFramework.Components.MetroStyleManager(this.components);
            this.mtbPais = new MetroFramework.Controls.MetroButton();
            this.mtbConfigGerais = new MetroFramework.Controls.MetroButton();
            this.mtlSobre = new MetroFramework.Controls.MetroLink();
            this.metroLink2 = new MetroFramework.Controls.MetroLink();
            this.mtbVersao = new MetroFramework.Controls.MetroButton();
            this.mtChangelog = new MetroFramework.Controls.MetroTabPage();
            this.metroLabel14 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel16 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel18 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel19 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel20 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel21 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel22 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel23 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel24 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel25 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel26 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel27 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel28 = new MetroFramework.Controls.MetroLabel();
            this.mTabAbas.SuspendLayout();
            this.mtInicio.SuspendLayout();
            this.mtMundial.SuspendLayout();
            this.mtPaises.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mtrgrdDataGrid)).BeginInit();
            this.mtOpcoes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mtsmGerenciadordeEstilo)).BeginInit();
            this.mtChangelog.SuspendLayout();
            this.SuspendLayout();
            // 
            // mTabAbas
            // 
            this.mTabAbas.Appearance = System.Windows.Forms.TabAppearance.Buttons;
            this.mTabAbas.Controls.Add(this.mtInicio);
            this.mTabAbas.Controls.Add(this.mtMundial);
            this.mTabAbas.Controls.Add(this.mtPaises);
            this.mTabAbas.Controls.Add(this.mtOpcoes);
            this.mTabAbas.Controls.Add(this.mtChangelog);
            this.mTabAbas.FontSize = MetroFramework.MetroTabControlSize.Tall;
            this.mTabAbas.Location = new System.Drawing.Point(39, 81);
            this.mTabAbas.Name = "mTabAbas";
            this.mTabAbas.SelectedIndex = 4;
            this.mTabAbas.Size = new System.Drawing.Size(1132, 540);
            this.mTabAbas.TabIndex = 0;
            this.mTabAbas.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.mTabAbas.UseSelectable = true;
            // 
            // mtInicio
            // 
            this.mtInicio.Controls.Add(this.metroLabel9);
            this.mtInicio.Controls.Add(this.metroLabel10);
            this.mtInicio.Controls.Add(this.metroLabel8);
            this.mtInicio.HorizontalScrollbarBarColor = true;
            this.mtInicio.HorizontalScrollbarHighlightOnWheel = false;
            this.mtInicio.HorizontalScrollbarSize = 10;
            this.mtInicio.Location = new System.Drawing.Point(4, 47);
            this.mtInicio.Name = "mtInicio";
            this.mtInicio.Size = new System.Drawing.Size(1124, 489);
            this.mtInicio.TabIndex = 0;
            this.mtInicio.Text = "Início";
            this.mtInicio.VerticalScrollbarBarColor = true;
            this.mtInicio.VerticalScrollbarHighlightOnWheel = false;
            this.mtInicio.VerticalScrollbarSize = 10;
            // 
            // metroLabel9
            // 
            this.metroLabel9.AutoSize = true;
            this.metroLabel9.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel9.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel9.Location = new System.Drawing.Point(45, 79);
            this.metroLabel9.Name = "metroLabel9";
            this.metroLabel9.Size = new System.Drawing.Size(1044, 275);
            this.metroLabel9.TabIndex = 2;
            this.metroLabel9.Text = resources.GetString("metroLabel9.Text");
            this.metroLabel9.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // metroLabel10
            // 
            this.metroLabel10.AutoSize = true;
            this.metroLabel10.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel10.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel10.Location = new System.Drawing.Point(264, 423);
            this.metroLabel10.Name = "metroLabel10";
            this.metroLabel10.Size = new System.Drawing.Size(614, 25);
            this.metroLabel10.TabIndex = 2;
            this.metroLabel10.Text = "Para usá-lo, navegue pelas abas na parte superior. Ou use os botões abaixo.";
            // 
            // metroLabel8
            // 
            this.metroLabel8.AutoSize = true;
            this.metroLabel8.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel8.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel8.Location = new System.Drawing.Point(322, 35);
            this.metroLabel8.Name = "metroLabel8";
            this.metroLabel8.Size = new System.Drawing.Size(528, 25);
            this.metroLabel8.TabIndex = 2;
            this.metroLabel8.Text = "Olá, bem vindo ao Aplicativo de Informações sobre o COVID-19!";
            // 
            // mtMundial
            // 
            this.mtMundial.Controls.Add(this.mtlblAtualizando);
            this.mtMundial.Controls.Add(this.mtlblRecuperados);
            this.mtMundial.Controls.Add(this.metroLabel17);
            this.mtMundial.Controls.Add(this.mtlblMortesMundiais);
            this.mtMundial.Controls.Add(this.metroLabel15);
            this.mtMundial.Controls.Add(this.mtlblCasosMundiais);
            this.mtMundial.Controls.Add(this.metroLabel13);
            this.mtMundial.Controls.Add(this.mtbAtualizarMundial);
            this.mtMundial.Controls.Add(this.metroLabel12);
            this.mtMundial.Controls.Add(this.metroLabel11);
            this.mtMundial.HorizontalScrollbarBarColor = true;
            this.mtMundial.HorizontalScrollbarHighlightOnWheel = false;
            this.mtMundial.HorizontalScrollbarSize = 10;
            this.mtMundial.Location = new System.Drawing.Point(4, 47);
            this.mtMundial.Name = "mtMundial";
            this.mtMundial.Size = new System.Drawing.Size(1124, 489);
            this.mtMundial.TabIndex = 1;
            this.mtMundial.Text = "Casos Mundiais";
            this.mtMundial.VerticalScrollbarBarColor = true;
            this.mtMundial.VerticalScrollbarHighlightOnWheel = false;
            this.mtMundial.VerticalScrollbarSize = 10;
            // 
            // mtlblAtualizando
            // 
            this.mtlblAtualizando.AutoSize = true;
            this.mtlblAtualizando.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.mtlblAtualizando.ForeColor = System.Drawing.SystemColors.Control;
            this.mtlblAtualizando.Location = new System.Drawing.Point(393, 435);
            this.mtlblAtualizando.Name = "mtlblAtualizando";
            this.mtlblAtualizando.Size = new System.Drawing.Size(431, 19);
            this.mtlblAtualizando.TabIndex = 7;
            this.mtlblAtualizando.Text = "Os dados estão sendo atualizados, por favor aguarde um momento...";
            // 
            // mtlblRecuperados
            // 
            this.mtlblRecuperados.AutoSize = true;
            this.mtlblRecuperados.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.mtlblRecuperados.Location = new System.Drawing.Point(618, 266);
            this.mtlblRecuperados.Name = "mtlblRecuperados";
            this.mtlblRecuperados.Size = new System.Drawing.Size(221, 25);
            this.mtlblRecuperados.TabIndex = 6;
            this.mtlblRecuperados.Text = "Atualize os dados por favor.";
            // 
            // metroLabel17
            // 
            this.metroLabel17.AutoSize = true;
            this.metroLabel17.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel17.Location = new System.Drawing.Point(364, 266);
            this.metroLabel17.Name = "metroLabel17";
            this.metroLabel17.Size = new System.Drawing.Size(239, 25);
            this.metroLabel17.TabIndex = 5;
            this.metroLabel17.Text = "Recuperados (mundialmente):";
            // 
            // mtlblMortesMundiais
            // 
            this.mtlblMortesMundiais.AutoSize = true;
            this.mtlblMortesMundiais.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.mtlblMortesMundiais.Location = new System.Drawing.Point(618, 226);
            this.mtlblMortesMundiais.Name = "mtlblMortesMundiais";
            this.mtlblMortesMundiais.Size = new System.Drawing.Size(225, 25);
            this.mtlblMortesMundiais.TabIndex = 6;
            this.mtlblMortesMundiais.Text = "Atualize os dados, por favor.";
            // 
            // metroLabel15
            // 
            this.metroLabel15.AutoSize = true;
            this.metroLabel15.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel15.Location = new System.Drawing.Point(409, 226);
            this.metroLabel15.Name = "metroLabel15";
            this.metroLabel15.Size = new System.Drawing.Size(194, 25);
            this.metroLabel15.TabIndex = 5;
            this.metroLabel15.Text = "Mortes (mundialmente):";
            // 
            // mtlblCasosMundiais
            // 
            this.mtlblCasosMundiais.AutoSize = true;
            this.mtlblCasosMundiais.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.mtlblCasosMundiais.Location = new System.Drawing.Point(618, 185);
            this.mtlblCasosMundiais.Name = "mtlblCasosMundiais";
            this.mtlblCasosMundiais.Size = new System.Drawing.Size(225, 25);
            this.mtlblCasosMundiais.TabIndex = 6;
            this.mtlblCasosMundiais.Text = "Atualize os dados, por favor.";
            // 
            // metroLabel13
            // 
            this.metroLabel13.AutoSize = true;
            this.metroLabel13.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel13.Location = new System.Drawing.Point(418, 185);
            this.metroLabel13.Name = "metroLabel13";
            this.metroLabel13.Size = new System.Drawing.Size(185, 25);
            this.metroLabel13.TabIndex = 5;
            this.metroLabel13.Text = "Casos (mundialmente):";
            // 
            // mtbAtualizarMundial
            // 
            this.mtbAtualizarMundial.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.mtbAtualizarMundial.Location = new System.Drawing.Point(511, 329);
            this.mtbAtualizarMundial.Name = "mtbAtualizarMundial";
            this.mtbAtualizarMundial.Size = new System.Drawing.Size(186, 38);
            this.mtbAtualizarMundial.TabIndex = 4;
            this.mtbAtualizarMundial.Text = "Atualizar Dados Mundiais";
            this.mtbAtualizarMundial.UseSelectable = true;
            this.mtbAtualizarMundial.Click += new System.EventHandler(this.mtbAtualizarMundial_Click);
            // 
            // metroLabel12
            // 
            this.metroLabel12.AutoSize = true;
            this.metroLabel12.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel12.Location = new System.Drawing.Point(184, 81);
            this.metroLabel12.Name = "metroLabel12";
            this.metroLabel12.Size = new System.Drawing.Size(765, 25);
            this.metroLabel12.TabIndex = 3;
            this.metroLabel12.Text = "As informações mundiais, são, os dados considerando todo o planeta. Os números at" +
    "ualizados são:";
            // 
            // metroLabel11
            // 
            this.metroLabel11.AutoSize = true;
            this.metroLabel11.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel11.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel11.Location = new System.Drawing.Point(412, 42);
            this.metroLabel11.Name = "metroLabel11";
            this.metroLabel11.Size = new System.Drawing.Size(322, 25);
            this.metroLabel11.TabIndex = 2;
            this.metroLabel11.Text = "O que são as Informações Mundiais?";
            // 
            // mtPaises
            // 
            this.mtPaises.Controls.Add(this.mtrgrdDataGrid);
            this.mtPaises.Controls.Add(this.mtlblTabela);
            this.mtPaises.Controls.Add(this.mtbExportarCSV);
            this.mtPaises.Controls.Add(this.mtAtualizarDadosTabela);
            this.mtPaises.HorizontalScrollbarBarColor = true;
            this.mtPaises.HorizontalScrollbarHighlightOnWheel = false;
            this.mtPaises.HorizontalScrollbarSize = 10;
            this.mtPaises.Location = new System.Drawing.Point(4, 47);
            this.mtPaises.Name = "mtPaises";
            this.mtPaises.Size = new System.Drawing.Size(1124, 489);
            this.mtPaises.TabIndex = 3;
            this.mtPaises.Text = "Casos Por País";
            this.mtPaises.VerticalScrollbarBarColor = true;
            this.mtPaises.VerticalScrollbarHighlightOnWheel = false;
            this.mtPaises.VerticalScrollbarSize = 10;
            // 
            // mtrgrdDataGrid
            // 
            this.mtrgrdDataGrid.AllowUserToAddRows = false;
            this.mtrgrdDataGrid.AllowUserToDeleteRows = false;
            this.mtrgrdDataGrid.AllowUserToOrderColumns = true;
            this.mtrgrdDataGrid.AllowUserToResizeColumns = false;
            this.mtrgrdDataGrid.AllowUserToResizeRows = false;
            this.mtrgrdDataGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.mtrgrdDataGrid.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.mtrgrdDataGrid.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.mtrgrdDataGrid.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.mtrgrdDataGrid.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.mtrgrdDataGrid.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.mtrgrdDataGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.mtrgrdDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.mtrgrdDataGrid.DefaultCellStyle = dataGridViewCellStyle5;
            this.mtrgrdDataGrid.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.mtrgrdDataGrid.EnableHeadersVisualStyles = false;
            this.mtrgrdDataGrid.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.mtrgrdDataGrid.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.mtrgrdDataGrid.Location = new System.Drawing.Point(3, 3);
            this.mtrgrdDataGrid.Name = "mtrgrdDataGrid";
            this.mtrgrdDataGrid.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.mtrgrdDataGrid.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.mtrgrdDataGrid.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.mtrgrdDataGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.mtrgrdDataGrid.ShowEditingIcon = false;
            this.mtrgrdDataGrid.Size = new System.Drawing.Size(1118, 449);
            this.mtrgrdDataGrid.TabIndex = 3;
            // 
            // mtlblTabela
            // 
            this.mtlblTabela.AutoSize = true;
            this.mtlblTabela.Location = new System.Drawing.Point(3, 458);
            this.mtlblTabela.Name = "mtlblTabela";
            this.mtlblTabela.Size = new System.Drawing.Size(377, 19);
            this.mtlblTabela.TabIndex = 4;
            this.mtlblTabela.Text = "Por favor, para visualizar os dados, clique em \'Atualizar Tabela\'.";
            // 
            // mtbExportarCSV
            // 
            this.mtbExportarCSV.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.mtbExportarCSV.Location = new System.Drawing.Point(980, 458);
            this.mtbExportarCSV.Name = "mtbExportarCSV";
            this.mtbExportarCSV.Size = new System.Drawing.Size(141, 30);
            this.mtbExportarCSV.TabIndex = 3;
            this.mtbExportarCSV.Text = "Exportar para CSV";
            this.mtbExportarCSV.UseSelectable = true;
            this.mtbExportarCSV.Click += new System.EventHandler(this.mtbExportarCSV_Click);
            // 
            // mtAtualizarDadosTabela
            // 
            this.mtAtualizarDadosTabela.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.mtAtualizarDadosTabela.Location = new System.Drawing.Point(828, 459);
            this.mtAtualizarDadosTabela.Name = "mtAtualizarDadosTabela";
            this.mtAtualizarDadosTabela.Size = new System.Drawing.Size(141, 30);
            this.mtAtualizarDadosTabela.TabIndex = 3;
            this.mtAtualizarDadosTabela.Text = "Atualizar Tabela";
            this.mtAtualizarDadosTabela.UseSelectable = true;
            this.mtAtualizarDadosTabela.Click += new System.EventHandler(this.mtAtualizarDadosTabela_Click);
            // 
            // mtOpcoes
            // 
            this.mtOpcoes.Controls.Add(this.metroLink2);
            this.mtOpcoes.Controls.Add(this.mtLinkEymardGithub);
            this.mtOpcoes.Controls.Add(this.mtLinkSite);
            this.mtOpcoes.Controls.Add(this.metroLabel7);
            this.mtOpcoes.Controls.Add(this.metroLabel6);
            this.mtOpcoes.Controls.Add(this.metroLabel5);
            this.mtOpcoes.Controls.Add(this.mtcbCores);
            this.mtOpcoes.Controls.Add(this.metroLabel4);
            this.mtOpcoes.Controls.Add(this.mtcbTemas);
            this.mtOpcoes.Controls.Add(this.metroLabel3);
            this.mtOpcoes.Controls.Add(this.metroLabel2);
            this.mtOpcoes.Controls.Add(this.metroLabel1);
            this.mtOpcoes.Controls.Add(this.metroTile2);
            this.mtOpcoes.Controls.Add(this.metroTile1);
            this.mtOpcoes.HorizontalScrollbarBarColor = true;
            this.mtOpcoes.HorizontalScrollbarHighlightOnWheel = false;
            this.mtOpcoes.HorizontalScrollbarSize = 10;
            this.mtOpcoes.Location = new System.Drawing.Point(4, 47);
            this.mtOpcoes.Name = "mtOpcoes";
            this.mtOpcoes.Size = new System.Drawing.Size(1124, 489);
            this.mtOpcoes.TabIndex = 2;
            this.mtOpcoes.Text = "Configurações Gerais";
            this.mtOpcoes.VerticalScrollbarBarColor = true;
            this.mtOpcoes.VerticalScrollbarHighlightOnWheel = false;
            this.mtOpcoes.VerticalScrollbarSize = 10;
            // 
            // mtLinkEymardGithub
            // 
            this.mtLinkEymardGithub.FontSize = MetroFramework.MetroLinkSize.Tall;
            this.mtLinkEymardGithub.Location = new System.Drawing.Point(382, 301);
            this.mtLinkEymardGithub.Name = "mtLinkEymardGithub";
            this.mtLinkEymardGithub.Size = new System.Drawing.Size(377, 34);
            this.mtLinkEymardGithub.TabIndex = 11;
            this.mtLinkEymardGithub.Text = "Visitar meu Github";
            this.mtLinkEymardGithub.UseSelectable = true;
            this.mtLinkEymardGithub.Click += new System.EventHandler(this.mtLinkEymardGithub_Click);
            // 
            // mtLinkSite
            // 
            this.mtLinkSite.FontSize = MetroFramework.MetroLinkSize.Tall;
            this.mtLinkSite.Location = new System.Drawing.Point(382, 415);
            this.mtLinkSite.Name = "mtLinkSite";
            this.mtLinkSite.Size = new System.Drawing.Size(377, 33);
            this.mtLinkSite.TabIndex = 11;
            this.mtLinkSite.Text = "Acessar Site";
            this.mtLinkSite.UseSelectable = true;
            this.mtLinkSite.Click += new System.EventHandler(this.mtLinkSite_Click);
            // 
            // metroLabel7
            // 
            this.metroLabel7.AutoSize = true;
            this.metroLabel7.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel7.Location = new System.Drawing.Point(166, 392);
            this.metroLabel7.Name = "metroLabel7";
            this.metroLabel7.Size = new System.Drawing.Size(803, 25);
            this.metroLabel7.TabIndex = 10;
            this.metroLabel7.Text = "Este aplicativo consome dados de uma API através de endpoints. E a fonte desses d" +
    "ados estão neste site:";
            // 
            // metroLabel6
            // 
            this.metroLabel6.AutoSize = true;
            this.metroLabel6.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel6.Location = new System.Drawing.Point(453, 265);
            this.metroLabel6.Name = "metroLabel6";
            this.metroLabel6.Size = new System.Drawing.Size(250, 25);
            this.metroLabel6.TabIndex = 10;
            this.metroLabel6.Text = "Desenvolvido por: Eymard Silva";
            // 
            // metroLabel5
            // 
            this.metroLabel5.AutoSize = true;
            this.metroLabel5.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel5.Location = new System.Drawing.Point(410, 239);
            this.metroLabel5.Name = "metroLabel5";
            this.metroLabel5.Size = new System.Drawing.Size(356, 25);
            this.metroLabel5.TabIndex = 9;
            this.metroLabel5.Text = "Sobre o COVID-19.NET - Informações Globais";
            // 
            // mtcbCores
            // 
            this.mtcbCores.FormattingEnabled = true;
            this.mtcbCores.ItemHeight = 23;
            this.mtcbCores.Items.AddRange(new object[] {
            "Padrão (Default)",
            "Preto (Black)",
            "Branco (White)",
            "Prateado (Silver)",
            "Azul (Blue)",
            "Verde (Green)",
            "Verde-Limão (Lime)",
            "Verde-Azulado (Teal)",
            "Laranja (Orange)",
            "Marrom (Brown)",
            "Rosa (Pink)",
            "Magenta",
            "Roxo (Purple)",
            "Vermelho (Red)",
            "Amarelo (Yellow)"});
            this.mtcbCores.Location = new System.Drawing.Point(855, 140);
            this.mtcbCores.Name = "mtcbCores";
            this.mtcbCores.Size = new System.Drawing.Size(222, 29);
            this.mtcbCores.TabIndex = 8;
            this.mtcbCores.UseSelectable = true;
            this.mtcbCores.SelectedIndexChanged += new System.EventHandler(this.mtcbCores_SelectedIndexChanged);
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel4.Location = new System.Drawing.Point(699, 140);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(125, 25);
            this.metroLabel4.TabIndex = 7;
            this.metroLabel4.Text = "Cores do App: ";
            // 
            // mtcbTemas
            // 
            this.mtcbTemas.FormattingEnabled = true;
            this.mtcbTemas.ItemHeight = 23;
            this.mtcbTemas.Items.AddRange(new object[] {
            "Escuro (Dark)",
            "Claro (Light)"});
            this.mtcbTemas.Location = new System.Drawing.Point(166, 140);
            this.mtcbTemas.Name = "mtcbTemas";
            this.mtcbTemas.Size = new System.Drawing.Size(222, 29);
            this.mtcbTemas.TabIndex = 6;
            this.mtcbTemas.UseSelectable = true;
            this.mtcbTemas.SelectedIndexChanged += new System.EventHandler(this.mtcbTemas_SelectedIndexChanged);
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel3.Location = new System.Drawing.Point(26, 140);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(116, 25);
            this.metroLabel3.TabIndex = 5;
            this.metroLabel3.Text = "Tema do App:";
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel2.Location = new System.Drawing.Point(468, 97);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(184, 25);
            this.metroLabel2.TabIndex = 4;
            this.metroLabel2.Text = "Configurações - Temas";
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel1.Location = new System.Drawing.Point(406, 17);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(333, 25);
            this.metroLabel1.TabIndex = 2;
            this.metroLabel1.Text = "Bem-vindo as Configurações do Aplicativo";
            // 
            // metroTile2
            // 
            this.metroTile2.ActiveControl = null;
            this.metroTile2.Location = new System.Drawing.Point(0, 194);
            this.metroTile2.Name = "metroTile2";
            this.metroTile2.Size = new System.Drawing.Size(1128, 23);
            this.metroTile2.TabIndex = 3;
            this.metroTile2.Text = "metroTile1";
            this.metroTile2.UseSelectable = true;
            // 
            // metroTile1
            // 
            this.metroTile1.ActiveControl = null;
            this.metroTile1.Location = new System.Drawing.Point(0, 56);
            this.metroTile1.Name = "metroTile1";
            this.metroTile1.Size = new System.Drawing.Size(1128, 23);
            this.metroTile1.TabIndex = 3;
            this.metroTile1.Text = "metroTile1";
            this.metroTile1.UseSelectable = true;
            // 
            // mtbGerais
            // 
            this.mtbGerais.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.mtbGerais.Location = new System.Drawing.Point(568, 652);
            this.mtbGerais.Name = "mtbGerais";
            this.mtbGerais.Size = new System.Drawing.Size(135, 37);
            this.mtbGerais.TabIndex = 1;
            this.mtbGerais.Text = "Casos Mundiais";
            this.mtbGerais.UseSelectable = true;
            this.mtbGerais.Click += new System.EventHandler(this.mtbGerais_Click);
            // 
            // mtbInicio
            // 
            this.mtbInicio.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.mtbInicio.Location = new System.Drawing.Point(413, 652);
            this.mtbInicio.Name = "mtbInicio";
            this.mtbInicio.Size = new System.Drawing.Size(135, 37);
            this.mtbInicio.TabIndex = 1;
            this.mtbInicio.Text = "Voltar ao Início";
            this.mtbInicio.UseSelectable = true;
            this.mtbInicio.Click += new System.EventHandler(this.mtbInicio_Click);
            // 
            // mtsmGerenciadordeEstilo
            // 
            this.mtsmGerenciadordeEstilo.Owner = this;
            // 
            // mtbPais
            // 
            this.mtbPais.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.mtbPais.Location = new System.Drawing.Point(723, 652);
            this.mtbPais.Name = "mtbPais";
            this.mtbPais.Size = new System.Drawing.Size(135, 37);
            this.mtbPais.TabIndex = 1;
            this.mtbPais.Text = "Casos Por País";
            this.mtbPais.UseSelectable = true;
            this.mtbPais.Click += new System.EventHandler(this.mtbPais_Click);
            // 
            // mtbConfigGerais
            // 
            this.mtbConfigGerais.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.mtbConfigGerais.Location = new System.Drawing.Point(877, 652);
            this.mtbConfigGerais.Name = "mtbConfigGerais";
            this.mtbConfigGerais.Size = new System.Drawing.Size(135, 37);
            this.mtbConfigGerais.TabIndex = 1;
            this.mtbConfigGerais.Text = "Config. Gerais";
            this.mtbConfigGerais.UseSelectable = true;
            this.mtbConfigGerais.Click += new System.EventHandler(this.mtbConfigGerais_Click);
            // 
            // mtlSobre
            // 
            this.mtlSobre.FontSize = MetroFramework.MetroLinkSize.Medium;
            this.mtlSobre.Location = new System.Drawing.Point(39, 652);
            this.mtlSobre.Name = "mtlSobre";
            this.mtlSobre.Size = new System.Drawing.Size(350, 37);
            this.mtlSobre.TabIndex = 2;
            this.mtlSobre.Text = "Criador por Eymard Silva | www.esware.com.br";
            this.mtlSobre.UseSelectable = true;
            this.mtlSobre.Click += new System.EventHandler(this.mtlSobre_Click);
            // 
            // metroLink2
            // 
            this.metroLink2.FontSize = MetroFramework.MetroLinkSize.Tall;
            this.metroLink2.Location = new System.Drawing.Point(382, 327);
            this.metroLink2.Name = "metroLink2";
            this.metroLink2.Size = new System.Drawing.Size(377, 34);
            this.metroLink2.TabIndex = 11;
            this.metroLink2.Text = "Visitar Repositório da Aplicação";
            this.metroLink2.UseSelectable = true;
            this.metroLink2.Click += new System.EventHandler(this.mtLinkEymardGithub_Click);
            // 
            // mtbVersao
            // 
            this.mtbVersao.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.mtbVersao.Location = new System.Drawing.Point(1032, 652);
            this.mtbVersao.Name = "mtbVersao";
            this.mtbVersao.Size = new System.Drawing.Size(135, 37);
            this.mtbVersao.TabIndex = 1;
            this.mtbVersao.Text = "Sobre a Versão";
            this.mtbVersao.UseSelectable = true;
            this.mtbVersao.Click += new System.EventHandler(this.mtbVersao_Click);
            // 
            // mtChangelog
            // 
            this.mtChangelog.Controls.Add(this.metroLabel28);
            this.mtChangelog.Controls.Add(this.metroLabel25);
            this.mtChangelog.Controls.Add(this.metroLabel26);
            this.mtChangelog.Controls.Add(this.metroLabel27);
            this.mtChangelog.Controls.Add(this.metroLabel24);
            this.mtChangelog.Controls.Add(this.metroLabel23);
            this.mtChangelog.Controls.Add(this.metroLabel22);
            this.mtChangelog.Controls.Add(this.metroLabel21);
            this.mtChangelog.Controls.Add(this.metroLabel20);
            this.mtChangelog.Controls.Add(this.metroLabel18);
            this.mtChangelog.Controls.Add(this.metroLabel14);
            this.mtChangelog.Controls.Add(this.metroLabel19);
            this.mtChangelog.Controls.Add(this.metroLabel16);
            this.mtChangelog.HorizontalScrollbarBarColor = true;
            this.mtChangelog.HorizontalScrollbarHighlightOnWheel = false;
            this.mtChangelog.HorizontalScrollbarSize = 10;
            this.mtChangelog.Location = new System.Drawing.Point(4, 47);
            this.mtChangelog.Name = "mtChangelog";
            this.mtChangelog.Size = new System.Drawing.Size(1124, 489);
            this.mtChangelog.TabIndex = 4;
            this.mtChangelog.Text = "Changelog";
            this.mtChangelog.VerticalScrollbarBarColor = true;
            this.mtChangelog.VerticalScrollbarHighlightOnWheel = false;
            this.mtChangelog.VerticalScrollbarSize = 10;
            // 
            // metroLabel14
            // 
            this.metroLabel14.AutoSize = true;
            this.metroLabel14.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel14.Location = new System.Drawing.Point(370, 53);
            this.metroLabel14.Name = "metroLabel14";
            this.metroLabel14.Size = new System.Drawing.Size(378, 25);
            this.metroLabel14.TabIndex = 5;
            this.metroLabel14.Text = "Olá, bem-vindo ao Changelog do COVID-19Net.";
            // 
            // metroLabel16
            // 
            this.metroLabel16.AutoSize = true;
            this.metroLabel16.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel16.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel16.Location = new System.Drawing.Point(462, 12);
            this.metroLabel16.Name = "metroLabel16";
            this.metroLabel16.Size = new System.Drawing.Size(198, 25);
            this.metroLabel16.TabIndex = 4;
            this.metroLabel16.Text = "O que é o Changelog?";
            // 
            // metroLabel18
            // 
            this.metroLabel18.AutoSize = true;
            this.metroLabel18.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel18.Location = new System.Drawing.Point(68, 78);
            this.metroLabel18.Name = "metroLabel18";
            this.metroLabel18.Size = new System.Drawing.Size(997, 50);
            this.metroLabel18.TabIndex = 5;
            this.metroLabel18.Text = resources.GetString("metroLabel18.Text");
            this.metroLabel18.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // metroLabel19
            // 
            this.metroLabel19.AutoSize = true;
            this.metroLabel19.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel19.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel19.Location = new System.Drawing.Point(399, 151);
            this.metroLabel19.Name = "metroLabel19";
            this.metroLabel19.Size = new System.Drawing.Size(316, 25);
            this.metroLabel19.TabIndex = 4;
            this.metroLabel19.Text = "Histórico de Versões - COVID-19Net";
            // 
            // metroLabel20
            // 
            this.metroLabel20.AutoSize = true;
            this.metroLabel20.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel20.Location = new System.Drawing.Point(502, 185);
            this.metroLabel20.Name = "metroLabel20";
            this.metroLabel20.Size = new System.Drawing.Size(113, 25);
            this.metroLabel20.TabIndex = 6;
            this.metroLabel20.Text = "Versão 1.0.0.X";
            // 
            // metroLabel21
            // 
            this.metroLabel21.AutoSize = true;
            this.metroLabel21.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel21.Location = new System.Drawing.Point(268, 210);
            this.metroLabel21.Name = "metroLabel21";
            this.metroLabel21.Size = new System.Drawing.Size(592, 25);
            this.metroLabel21.TabIndex = 7;
            this.metroLabel21.Text = "- Adição das APIs, e criação dos arquivos para serem salvos na pasta (JSON).";
            // 
            // metroLabel22
            // 
            this.metroLabel22.AutoSize = true;
            this.metroLabel22.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel22.Location = new System.Drawing.Point(268, 235);
            this.metroLabel22.Name = "metroLabel22";
            this.metroLabel22.Size = new System.Drawing.Size(571, 25);
            this.metroLabel22.TabIndex = 7;
            this.metroLabel22.Text = "- Criação de um Instalador Simplificado através do Visual Studio (Publish);";
            this.metroLabel22.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // metroLabel23
            // 
            this.metroLabel23.AutoSize = true;
            this.metroLabel23.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel23.Location = new System.Drawing.Point(425, 260);
            this.metroLabel23.Name = "metroLabel23";
            this.metroLabel23.Size = new System.Drawing.Size(265, 25);
            this.metroLabel23.TabIndex = 7;
            this.metroLabel23.Text = "- Publicação do Fonte no GitHub;";
            this.metroLabel23.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // metroLabel24
            // 
            this.metroLabel24.AutoSize = true;
            this.metroLabel24.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel24.Location = new System.Drawing.Point(502, 294);
            this.metroLabel24.Name = "metroLabel24";
            this.metroLabel24.Size = new System.Drawing.Size(116, 25);
            this.metroLabel24.TabIndex = 8;
            this.metroLabel24.Text = "Versão 2.0.0.X";
            // 
            // metroLabel25
            // 
            this.metroLabel25.AutoSize = true;
            this.metroLabel25.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel25.Location = new System.Drawing.Point(358, 373);
            this.metroLabel25.Name = "metroLabel25";
            this.metroLabel25.Size = new System.Drawing.Size(419, 25);
            this.metroLabel25.TabIndex = 9;
            this.metroLabel25.Text = "- Correções de melhorias e establidades da aplicação;";
            this.metroLabel25.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // metroLabel26
            // 
            this.metroLabel26.AutoSize = true;
            this.metroLabel26.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel26.Location = new System.Drawing.Point(399, 348);
            this.metroLabel26.Name = "metroLabel26";
            this.metroLabel26.Size = new System.Drawing.Size(318, 25);
            this.metroLabel26.TabIndex = 10;
            this.metroLabel26.Text = "- Criação do novo instalador do sistema;";
            this.metroLabel26.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // metroLabel27
            // 
            this.metroLabel27.AutoSize = true;
            this.metroLabel27.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel27.Location = new System.Drawing.Point(399, 323);
            this.metroLabel27.Name = "metroLabel27";
            this.metroLabel27.Size = new System.Drawing.Size(337, 25);
            this.metroLabel27.TabIndex = 11;
            this.metroLabel27.Text = "- Refatoração de código e métodos (geral);";
            // 
            // metroLabel28
            // 
            this.metroLabel28.AutoSize = true;
            this.metroLabel28.Location = new System.Drawing.Point(132, 466);
            this.metroLabel28.Name = "metroLabel28";
            this.metroLabel28.Size = new System.Drawing.Size(859, 19);
            this.metroLabel28.TabIndex = 12;
            this.metroLabel28.Text = "Agradecimentos: Eduardo Jorge Moreira (pelas issues abertas), Cheila Xavier (Dica" +
    "s gerais de melhorias) e todos que estão usando a ferramenta!";
            this.metroLabel28.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1206, 709);
            this.Controls.Add(this.mtlSobre);
            this.Controls.Add(this.mtbInicio);
            this.Controls.Add(this.mtbVersao);
            this.Controls.Add(this.mtbConfigGerais);
            this.Controls.Add(this.mtbPais);
            this.Controls.Add(this.mtbGerais);
            this.Controls.Add(this.mTabAbas);
            this.ForeColor = System.Drawing.SystemColors.GrayText;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmPrincipal";
            this.Resizable = false;
            this.ShadowType = MetroFramework.Forms.MetroFormShadowType.SystemShadow;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "Informações do COVID-19 | Mundial";
            this.Load += new System.EventHandler(this.frmPrincipal_Load);
            this.mTabAbas.ResumeLayout(false);
            this.mtInicio.ResumeLayout(false);
            this.mtInicio.PerformLayout();
            this.mtMundial.ResumeLayout(false);
            this.mtMundial.PerformLayout();
            this.mtPaises.ResumeLayout(false);
            this.mtPaises.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mtrgrdDataGrid)).EndInit();
            this.mtOpcoes.ResumeLayout(false);
            this.mtOpcoes.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mtsmGerenciadordeEstilo)).EndInit();
            this.mtChangelog.ResumeLayout(false);
            this.mtChangelog.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroTabControl mTabAbas;
        private MetroFramework.Controls.MetroTabPage mtInicio;
        private MetroFramework.Controls.MetroTabPage mtMundial;
        private MetroFramework.Controls.MetroTabPage mtOpcoes;
        private MetroFramework.Controls.MetroButton mtbGerais;
        private MetroFramework.Controls.MetroButton mtbInicio;
        private MetroFramework.Controls.MetroComboBox mtcbCores;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroComboBox mtcbTemas;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroTile metroTile2;
        private MetroFramework.Controls.MetroTile metroTile1;
        private MetroFramework.Controls.MetroLabel metroLabel6;
        private MetroFramework.Controls.MetroLabel metroLabel5;
        private MetroFramework.Controls.MetroLabel metroLabel7;
        private MetroFramework.Controls.MetroLink mtLinkSite;
        private MetroFramework.Components.MetroStyleManager mtsmGerenciadordeEstilo;
        private MetroFramework.Controls.MetroTabPage mtPaises;
        private MetroFramework.Controls.MetroLabel metroLabel9;
        private MetroFramework.Controls.MetroLabel metroLabel10;
        private MetroFramework.Controls.MetroLabel metroLabel8;
        private MetroFramework.Controls.MetroButton mtbConfigGerais;
        private MetroFramework.Controls.MetroButton mtbPais;
        private MetroFramework.Controls.MetroLink mtLinkEymardGithub;
        private MetroFramework.Controls.MetroLabel metroLabel12;
        private MetroFramework.Controls.MetroLabel metroLabel11;
        private MetroFramework.Controls.MetroButton mtbAtualizarMundial;
        private MetroFramework.Controls.MetroLabel mtlblRecuperados;
        private MetroFramework.Controls.MetroLabel metroLabel17;
        private MetroFramework.Controls.MetroLabel mtlblMortesMundiais;
        private MetroFramework.Controls.MetroLabel metroLabel15;
        private MetroFramework.Controls.MetroLabel mtlblCasosMundiais;
        private MetroFramework.Controls.MetroLabel metroLabel13;
        private MetroFramework.Controls.MetroLink mtlSobre;
        private MetroFramework.Controls.MetroLabel mtlblAtualizando;
        private MetroFramework.Controls.MetroButton mtAtualizarDadosTabela;
        private MetroFramework.Controls.MetroLabel mtlblTabela;
        private MetroFramework.Controls.MetroGrid mtrgrdDataGrid;
        private MetroFramework.Controls.MetroButton mtbExportarCSV;
        private MetroFramework.Controls.MetroLink metroLink2;
        private MetroFramework.Controls.MetroTabPage mtChangelog;
        private MetroFramework.Controls.MetroButton mtbVersao;
        private MetroFramework.Controls.MetroLabel metroLabel18;
        private MetroFramework.Controls.MetroLabel metroLabel14;
        private MetroFramework.Controls.MetroLabel metroLabel19;
        private MetroFramework.Controls.MetroLabel metroLabel16;
        private MetroFramework.Controls.MetroLabel metroLabel28;
        private MetroFramework.Controls.MetroLabel metroLabel25;
        private MetroFramework.Controls.MetroLabel metroLabel26;
        private MetroFramework.Controls.MetroLabel metroLabel27;
        private MetroFramework.Controls.MetroLabel metroLabel24;
        private MetroFramework.Controls.MetroLabel metroLabel23;
        private MetroFramework.Controls.MetroLabel metroLabel22;
        private MetroFramework.Controls.MetroLabel metroLabel21;
        private MetroFramework.Controls.MetroLabel metroLabel20;
    }
}

