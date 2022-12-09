
namespace ProjetoHenrique
{
    partial class ListarPalavras
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
            this.PalavrasListView = new System.Windows.Forms.ListView();
            this.CodPalavra = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.idiomaColumnHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.textoColumnHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.definicaoColumnHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.pronunciaColumnHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.animoColumnHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.utilidadeColumnHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.relevanciaColumnHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.classificacaoColumnHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.morfologiaColumnHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.fonteColumnHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.temaColumnHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.observacaoColumnHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.idiomaComboBox = new System.Windows.Forms.ComboBox();
            this.morfologiaComboBox = new System.Windows.Forms.ComboBox();
            this.classificacaoComboBox = new System.Windows.Forms.ComboBox();
            this.pesquisaTextBox = new System.Windows.Forms.TextBox();
            this.adicionarButton = new System.Windows.Forms.Button();
            this.atualizarButton = new System.Windows.Forms.Button();
            this.limparPesquisaButton = new System.Windows.Forms.Button();
            this.excluirButton = new System.Windows.Forms.Button();
            this.criarCRButton = new System.Windows.Forms.Button();
            this.sairButton = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // PalavrasListView
            // 
            this.PalavrasListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.CodPalavra,
            this.idiomaColumnHeader,
            this.textoColumnHeader,
            this.definicaoColumnHeader,
            this.pronunciaColumnHeader,
            this.animoColumnHeader,
            this.utilidadeColumnHeader,
            this.relevanciaColumnHeader,
            this.classificacaoColumnHeader,
            this.morfologiaColumnHeader,
            this.fonteColumnHeader,
            this.temaColumnHeader,
            this.observacaoColumnHeader});
            this.PalavrasListView.FullRowSelect = true;
            this.PalavrasListView.HideSelection = false;
            this.PalavrasListView.Location = new System.Drawing.Point(13, 116);
            this.PalavrasListView.Margin = new System.Windows.Forms.Padding(4);
            this.PalavrasListView.Name = "PalavrasListView";
            this.PalavrasListView.Size = new System.Drawing.Size(1171, 454);
            this.PalavrasListView.TabIndex = 1;
            this.PalavrasListView.UseCompatibleStateImageBehavior = false;
            this.PalavrasListView.View = System.Windows.Forms.View.Details;
            this.PalavrasListView.Click += new System.EventHandler(this.PalavrasListView_Click);
            // 
            // CodPalavra
            // 
            this.CodPalavra.Width = 1;
            // 
            // idiomaColumnHeader
            // 
            this.idiomaColumnHeader.Text = "Idioma";
            this.idiomaColumnHeader.Width = 70;
            // 
            // textoColumnHeader
            // 
            this.textoColumnHeader.Text = "Palavra";
            this.textoColumnHeader.Width = 70;
            // 
            // definicaoColumnHeader
            // 
            this.definicaoColumnHeader.Text = "Definição";
            this.definicaoColumnHeader.Width = 70;
            // 
            // pronunciaColumnHeader
            // 
            this.pronunciaColumnHeader.Text = "Pronuncia";
            this.pronunciaColumnHeader.Width = 70;
            // 
            // animoColumnHeader
            // 
            this.animoColumnHeader.Text = "Ânimo ao usar";
            this.animoColumnHeader.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.animoColumnHeader.Width = 100;
            // 
            // utilidadeColumnHeader
            // 
            this.utilidadeColumnHeader.Text = "Grau de utilidade";
            this.utilidadeColumnHeader.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.utilidadeColumnHeader.Width = 100;
            // 
            // relevanciaColumnHeader
            // 
            this.relevanciaColumnHeader.Text = "Relevância";
            this.relevanciaColumnHeader.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.relevanciaColumnHeader.Width = 100;
            // 
            // classificacaoColumnHeader
            // 
            this.classificacaoColumnHeader.DisplayIndex = 12;
            this.classificacaoColumnHeader.Text = "Classificação";
            this.classificacaoColumnHeader.Width = 70;
            // 
            // morfologiaColumnHeader
            // 
            this.morfologiaColumnHeader.DisplayIndex = 8;
            this.morfologiaColumnHeader.Text = "Morfologia";
            this.morfologiaColumnHeader.Width = 70;
            // 
            // fonteColumnHeader
            // 
            this.fonteColumnHeader.DisplayIndex = 9;
            this.fonteColumnHeader.Text = "Fonte";
            this.fonteColumnHeader.Width = 70;
            // 
            // temaColumnHeader
            // 
            this.temaColumnHeader.DisplayIndex = 10;
            this.temaColumnHeader.Text = "Tema";
            this.temaColumnHeader.Width = 70;
            // 
            // observacaoColumnHeader
            // 
            this.observacaoColumnHeader.DisplayIndex = 11;
            this.observacaoColumnHeader.Text = "Observação";
            this.observacaoColumnHeader.Width = 70;
            // 
            // idiomaComboBox
            // 
            this.idiomaComboBox.FormattingEnabled = true;
            this.idiomaComboBox.Location = new System.Drawing.Point(13, 85);
            this.idiomaComboBox.Name = "idiomaComboBox";
            this.idiomaComboBox.Size = new System.Drawing.Size(80, 24);
            this.idiomaComboBox.TabIndex = 2;
            this.idiomaComboBox.TextChanged += new System.EventHandler(this.idiomaComboBox_TextChanged);
            // 
            // morfologiaComboBox
            // 
            this.morfologiaComboBox.FormattingEnabled = true;
            this.morfologiaComboBox.Items.AddRange(new object[] {
            "Substantivo",
            "Adjetivo",
            "Pronome",
            "Numeral",
            "Artigo",
            "Verbo",
            "Preposição",
            "Conjunção",
            "Interjeição",
            "Advérbio"});
            this.morfologiaComboBox.Location = new System.Drawing.Point(745, 87);
            this.morfologiaComboBox.Name = "morfologiaComboBox";
            this.morfologiaComboBox.Size = new System.Drawing.Size(80, 24);
            this.morfologiaComboBox.TabIndex = 3;
            this.morfologiaComboBox.TextChanged += new System.EventHandler(this.morfologiaComboBox_TextChanged);
            // 
            // classificacaoComboBox
            // 
            this.classificacaoComboBox.FormattingEnabled = true;
            this.classificacaoComboBox.Items.AddRange(new object[] {
            "Falar",
            "Conhecer"});
            this.classificacaoComboBox.Location = new System.Drawing.Point(1092, 85);
            this.classificacaoComboBox.Name = "classificacaoComboBox";
            this.classificacaoComboBox.Size = new System.Drawing.Size(80, 24);
            this.classificacaoComboBox.TabIndex = 4;
            this.classificacaoComboBox.TextChanged += new System.EventHandler(this.classificacaoComboBox_TextChanged);
            // 
            // pesquisaTextBox
            // 
            this.pesquisaTextBox.Location = new System.Drawing.Point(99, 87);
            this.pesquisaTextBox.Name = "pesquisaTextBox";
            this.pesquisaTextBox.Size = new System.Drawing.Size(640, 22);
            this.pesquisaTextBox.TabIndex = 5;
            this.pesquisaTextBox.TextChanged += new System.EventHandler(this.pesquisaTextBox_TextChanged);
            this.pesquisaTextBox.Enter += new System.EventHandler(this.pesquisaTextBox_Enter);
            this.pesquisaTextBox.Leave += new System.EventHandler(this.pesquisaTextBox_Leave);
            // 
            // adicionarButton
            // 
            this.adicionarButton.Location = new System.Drawing.Point(-1, 13);
            this.adicionarButton.Name = "adicionarButton";
            this.adicionarButton.Size = new System.Drawing.Size(153, 33);
            this.adicionarButton.TabIndex = 6;
            this.adicionarButton.Text = "Adicionar Palavra";
            this.adicionarButton.UseVisualStyleBackColor = true;
            this.adicionarButton.Click += new System.EventHandler(this.adicionarButton_Click);
            // 
            // atualizarButton
            // 
            this.atualizarButton.Location = new System.Drawing.Point(170, 13);
            this.atualizarButton.Name = "atualizarButton";
            this.atualizarButton.Size = new System.Drawing.Size(153, 33);
            this.atualizarButton.TabIndex = 7;
            this.atualizarButton.Text = "Atualizar Palavra";
            this.atualizarButton.UseVisualStyleBackColor = true;
            this.atualizarButton.Click += new System.EventHandler(this.atualizarButton_Click);
            // 
            // limparPesquisaButton
            // 
            this.limparPesquisaButton.Location = new System.Drawing.Point(831, 80);
            this.limparPesquisaButton.Name = "limparPesquisaButton";
            this.limparPesquisaButton.Size = new System.Drawing.Size(150, 33);
            this.limparPesquisaButton.TabIndex = 8;
            this.limparPesquisaButton.Text = "Limpar Pesquisa";
            this.limparPesquisaButton.UseVisualStyleBackColor = true;
            this.limparPesquisaButton.Click += new System.EventHandler(this.limparPesquisaButton_Click);
            // 
            // excluirButton
            // 
            this.excluirButton.Location = new System.Drawing.Point(341, 13);
            this.excluirButton.Name = "excluirButton";
            this.excluirButton.Size = new System.Drawing.Size(153, 33);
            this.excluirButton.TabIndex = 9;
            this.excluirButton.Text = "Excluir Palavra";
            this.excluirButton.UseVisualStyleBackColor = true;
            this.excluirButton.Click += new System.EventHandler(this.excluirButton_Click);
            // 
            // criarCRButton
            // 
            this.criarCRButton.Location = new System.Drawing.Point(818, 13);
            this.criarCRButton.Name = "criarCRButton";
            this.criarCRButton.Size = new System.Drawing.Size(203, 33);
            this.criarCRButton.TabIndex = 10;
            this.criarCRButton.Text = "Criar Conjunto de Revisão";
            this.criarCRButton.UseVisualStyleBackColor = true;
            this.criarCRButton.Click += new System.EventHandler(this.criarCRButton_Click);
            // 
            // sairButton
            // 
            this.sairButton.Location = new System.Drawing.Point(1047, 13);
            this.sairButton.Name = "sairButton";
            this.sairButton.Size = new System.Drawing.Size(75, 33);
            this.sairButton.TabIndex = 11;
            this.sairButton.Text = "Sair";
            this.sairButton.UseVisualStyleBackColor = true;
            this.sairButton.Click += new System.EventHandler(this.sairButton_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.adicionarButton);
            this.panel1.Controls.Add(this.atualizarButton);
            this.panel1.Controls.Add(this.sairButton);
            this.panel1.Controls.Add(this.excluirButton);
            this.panel1.Controls.Add(this.criarCRButton);
            this.panel1.Location = new System.Drawing.Point(13, 606);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1146, 75);
            this.panel1.TabIndex = 13;
            // 
            // ListarPalavras
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(1265, 714);
            this.ControlBox = false;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.limparPesquisaButton);
            this.Controls.Add(this.pesquisaTextBox);
            this.Controls.Add(this.classificacaoComboBox);
            this.Controls.Add(this.morfologiaComboBox);
            this.Controls.Add(this.idiomaComboBox);
            this.Controls.Add(this.PalavrasListView);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ListarPalavras";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "ListarPalavras";
            this.Load += new System.EventHandler(this.ListarPalavras_Load);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView PalavrasListView;
        private System.Windows.Forms.ColumnHeader CodPalavra;
        private System.Windows.Forms.ColumnHeader idiomaColumnHeader;
        private System.Windows.Forms.ColumnHeader textoColumnHeader;
        private System.Windows.Forms.ColumnHeader definicaoColumnHeader;
        private System.Windows.Forms.ColumnHeader pronunciaColumnHeader;
        private System.Windows.Forms.ColumnHeader animoColumnHeader;
        private System.Windows.Forms.ColumnHeader utilidadeColumnHeader;
        private System.Windows.Forms.ColumnHeader relevanciaColumnHeader;
        private System.Windows.Forms.ColumnHeader classificacaoColumnHeader;
        private System.Windows.Forms.ColumnHeader morfologiaColumnHeader;
        private System.Windows.Forms.ColumnHeader fonteColumnHeader;
        private System.Windows.Forms.ColumnHeader temaColumnHeader;
        private System.Windows.Forms.ColumnHeader observacaoColumnHeader;
        private System.Windows.Forms.ComboBox idiomaComboBox;
        private System.Windows.Forms.ComboBox morfologiaComboBox;
        private System.Windows.Forms.ComboBox classificacaoComboBox;
        private System.Windows.Forms.TextBox pesquisaTextBox;
        private System.Windows.Forms.Button adicionarButton;
        private System.Windows.Forms.Button atualizarButton;
        private System.Windows.Forms.Button limparPesquisaButton;
        private System.Windows.Forms.Button excluirButton;
        private System.Windows.Forms.Button criarCRButton;
        private System.Windows.Forms.Button sairButton;
        private System.Windows.Forms.Panel panel1;
    }
}