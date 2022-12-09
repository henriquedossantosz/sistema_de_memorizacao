namespace ProjetoHenrique
{
    partial class ListarUsuarios
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.PesquisaTextBox = new System.Windows.Forms.TextBox();
            this.LimparFiltrobutton = new System.Windows.Forms.Button();
            this.filtrarButton = new System.Windows.Forms.Button();
            this.comboBox5 = new System.Windows.Forms.ComboBox();
            this.comboBox4 = new System.Windows.Forms.ComboBox();
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.UpdateBbutton = new System.Windows.Forms.Button();
            this.ExcluirButton = new System.Windows.Forms.Button();
            this.CadastrarButton = new System.Windows.Forms.Button();
            this.UsuariosListView = new System.Windows.Forms.ListView();
            this.IdColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.NomeColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.EmailColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.TelefoneColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.NomeUsuarioColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.button1 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.PesquisaTextBox);
            this.panel1.Controls.Add(this.LimparFiltrobutton);
            this.panel1.Controls.Add(this.filtrarButton);
            this.panel1.Controls.Add(this.comboBox5);
            this.panel1.Controls.Add(this.comboBox4);
            this.panel1.Controls.Add(this.comboBox3);
            this.panel1.Controls.Add(this.comboBox2);
            this.panel1.Controls.Add(this.comboBox1);
            this.panel1.Controls.Add(this.UpdateBbutton);
            this.panel1.Controls.Add(this.ExcluirButton);
            this.panel1.Controls.Add(this.CadastrarButton);
            this.panel1.Controls.Add(this.UsuariosListView);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1067, 554);
            this.panel1.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(255, 7);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(137, 17);
            this.label2.TabIndex = 16;
            this.label2.Text = "Selecionar Filtragem";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(663, 31);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 17);
            this.label1.TabIndex = 15;
            this.label1.Text = "Pesquisar";
            // 
            // PesquisaTextBox
            // 
            this.PesquisaTextBox.Location = new System.Drawing.Point(741, 27);
            this.PesquisaTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.PesquisaTextBox.Name = "PesquisaTextBox";
            this.PesquisaTextBox.Size = new System.Drawing.Size(308, 22);
            this.PesquisaTextBox.TabIndex = 14;
            this.PesquisaTextBox.TextChanged += new System.EventHandler(this.PesquisaTextBox_TextChanged);
            // 
            // LimparFiltrobutton
            // 
            this.LimparFiltrobutton.Location = new System.Drawing.Point(820, 522);
            this.LimparFiltrobutton.Margin = new System.Windows.Forms.Padding(4);
            this.LimparFiltrobutton.Name = "LimparFiltrobutton";
            this.LimparFiltrobutton.Size = new System.Drawing.Size(100, 28);
            this.LimparFiltrobutton.TabIndex = 13;
            this.LimparFiltrobutton.Text = "Limpar";
            this.LimparFiltrobutton.UseVisualStyleBackColor = true;
            this.LimparFiltrobutton.Click += new System.EventHandler(this.LimparFiltrobutton_Click);
            // 
            // filtrarButton
            // 
            this.filtrarButton.Location = new System.Drawing.Point(712, 522);
            this.filtrarButton.Margin = new System.Windows.Forms.Padding(4);
            this.filtrarButton.Name = "filtrarButton";
            this.filtrarButton.Size = new System.Drawing.Size(100, 28);
            this.filtrarButton.TabIndex = 10;
            this.filtrarButton.Text = "Filtrar";
            this.filtrarButton.UseVisualStyleBackColor = true;
            this.filtrarButton.Click += new System.EventHandler(this.filtrarButton_Click);
            // 
            // comboBox5
            // 
            this.comboBox5.FormattingEnabled = true;
            this.comboBox5.Location = new System.Drawing.Point(436, 27);
            this.comboBox5.Margin = new System.Windows.Forms.Padding(4);
            this.comboBox5.Name = "comboBox5";
            this.comboBox5.Size = new System.Drawing.Size(129, 24);
            this.comboBox5.TabIndex = 9;
            this.comboBox5.TextChanged += new System.EventHandler(this.comboBox5_TextChanged);
            // 
            // comboBox4
            // 
            this.comboBox4.FormattingEnabled = true;
            this.comboBox4.Location = new System.Drawing.Point(319, 27);
            this.comboBox4.Margin = new System.Windows.Forms.Padding(4);
            this.comboBox4.Name = "comboBox4";
            this.comboBox4.Size = new System.Drawing.Size(108, 24);
            this.comboBox4.TabIndex = 8;
            this.comboBox4.TextChanged += new System.EventHandler(this.comboBox4_TextChanged);
            // 
            // comboBox3
            // 
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.Location = new System.Drawing.Point(201, 27);
            this.comboBox3.Margin = new System.Windows.Forms.Padding(4);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(108, 24);
            this.comboBox3.TabIndex = 7;
            this.comboBox3.TextChanged += new System.EventHandler(this.comboBox3_TextChanged);
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(85, 27);
            this.comboBox2.Margin = new System.Windows.Forms.Padding(4);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(107, 24);
            this.comboBox2.TabIndex = 6;
            this.comboBox2.TextChanged += new System.EventHandler(this.comboBox2_TextChanged);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(16, 27);
            this.comboBox1.Margin = new System.Windows.Forms.Padding(4);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(60, 24);
            this.comboBox1.TabIndex = 5;
            this.comboBox1.TextChanged += new System.EventHandler(this.comboBox1_TextChanged);
            // 
            // UpdateBbutton
            // 
            this.UpdateBbutton.Location = new System.Drawing.Point(124, 523);
            this.UpdateBbutton.Margin = new System.Windows.Forms.Padding(4);
            this.UpdateBbutton.Name = "UpdateBbutton";
            this.UpdateBbutton.Size = new System.Drawing.Size(127, 28);
            this.UpdateBbutton.TabIndex = 4;
            this.UpdateBbutton.Text = "Atualizar Dados";
            this.UpdateBbutton.UseVisualStyleBackColor = true;
            this.UpdateBbutton.Click += new System.EventHandler(this.UpdateBbutton_Click);
            // 
            // ExcluirButton
            // 
            this.ExcluirButton.Location = new System.Drawing.Point(259, 523);
            this.ExcluirButton.Margin = new System.Windows.Forms.Padding(4);
            this.ExcluirButton.Name = "ExcluirButton";
            this.ExcluirButton.Size = new System.Drawing.Size(100, 28);
            this.ExcluirButton.TabIndex = 3;
            this.ExcluirButton.Text = "Excluir";
            this.ExcluirButton.UseVisualStyleBackColor = true;
            this.ExcluirButton.Click += new System.EventHandler(this.ExcluirButton_Click);
            // 
            // CadastrarButton
            // 
            this.CadastrarButton.Location = new System.Drawing.Point(16, 523);
            this.CadastrarButton.Margin = new System.Windows.Forms.Padding(4);
            this.CadastrarButton.Name = "CadastrarButton";
            this.CadastrarButton.Size = new System.Drawing.Size(100, 28);
            this.CadastrarButton.TabIndex = 2;
            this.CadastrarButton.Text = "Cadastrar";
            this.CadastrarButton.UseVisualStyleBackColor = true;
            this.CadastrarButton.Click += new System.EventHandler(this.CadastrarButton_Click);
            // 
            // UsuariosListView
            // 
            this.UsuariosListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.IdColumn,
            this.NomeColumn,
            this.EmailColumn,
            this.TelefoneColumn,
            this.NomeUsuarioColumn});
            this.UsuariosListView.FullRowSelect = true;
            this.UsuariosListView.HideSelection = false;
            this.UsuariosListView.Location = new System.Drawing.Point(16, 60);
            this.UsuariosListView.Margin = new System.Windows.Forms.Padding(4);
            this.UsuariosListView.Name = "UsuariosListView";
            this.UsuariosListView.Size = new System.Drawing.Size(1033, 454);
            this.UsuariosListView.TabIndex = 0;
            this.UsuariosListView.UseCompatibleStateImageBehavior = false;
            this.UsuariosListView.View = System.Windows.Forms.View.Details;
            this.UsuariosListView.SelectedIndexChanged += new System.EventHandler(this.UsuariosListView_SelectedIndexChanged);
            // 
            // IdColumn
            // 
            this.IdColumn.Text = "Id";
            this.IdColumn.Width = 41;
            // 
            // NomeColumn
            // 
            this.NomeColumn.Text = "Nome";
            this.NomeColumn.Width = 91;
            // 
            // EmailColumn
            // 
            this.EmailColumn.Text = "E-mail";
            this.EmailColumn.Width = 87;
            // 
            // TelefoneColumn
            // 
            this.TelefoneColumn.Text = "Telefone";
            this.TelefoneColumn.Width = 88;
            // 
            // NomeUsuarioColumn
            // 
            this.NomeUsuarioColumn.Text = "Nome de usuário";
            this.NomeUsuarioColumn.Width = 104;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(945, 521);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(104, 27);
            this.button1.TabIndex = 17;
            this.button1.Text = "Sair";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // ListarUsuarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "ListarUsuarios";
            this.Text = "ListarUsuarios";
            this.Load += new System.EventHandler(this.ListarUsuarios_Load_1);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ListView UsuariosListView;
        private System.Windows.Forms.ColumnHeader NomeColumn;
        private System.Windows.Forms.ColumnHeader EmailColumn;
        private System.Windows.Forms.ColumnHeader TelefoneColumn;
        private System.Windows.Forms.ColumnHeader NomeUsuarioColumn;
        private System.Windows.Forms.ColumnHeader IdColumn;
        private System.Windows.Forms.Button ExcluirButton;
        private System.Windows.Forms.Button CadastrarButton;
        private System.Windows.Forms.Button UpdateBbutton;
        private System.Windows.Forms.ComboBox comboBox5;
        private System.Windows.Forms.ComboBox comboBox4;
        private System.Windows.Forms.ComboBox comboBox3;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button filtrarButton;
        private System.Windows.Forms.Button LimparFiltrobutton;
        private System.Windows.Forms.TextBox PesquisaTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
    }
}