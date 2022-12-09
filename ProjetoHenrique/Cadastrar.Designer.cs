namespace ProjetoHenrique
{
    partial class Cadastrar
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
            this.LimparButton = new System.Windows.Forms.Button();
            this.InserirButton = new System.Windows.Forms.Button();
            this.senhaTextBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.UsuarioTextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.TelefoneTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.EmailTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.NomeCompletoTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.celMaskedTextBox = new System.Windows.Forms.MaskedTextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.nascimentoDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.label9 = new System.Windows.Forms.Label();
            this.cpfMaskedTextBox = new System.Windows.Forms.MaskedTextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.confTextBox = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.verCheckBox = new System.Windows.Forms.CheckBox();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.verCheckBox);
            this.panel1.Controls.Add(this.confTextBox);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.nascimentoDateTimePicker);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.cpfMaskedTextBox);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.celMaskedTextBox);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.LimparButton);
            this.panel1.Controls.Add(this.InserirButton);
            this.panel1.Controls.Add(this.senhaTextBox);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.UsuarioTextBox);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.TelefoneTextBox);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.EmailTextBox);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.NomeCompletoTextBox);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1067, 554);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // LimparButton
            // 
            this.LimparButton.Location = new System.Drawing.Point(648, 231);
            this.LimparButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.LimparButton.Name = "LimparButton";
            this.LimparButton.Size = new System.Drawing.Size(100, 28);
            this.LimparButton.TabIndex = 11;
            this.LimparButton.Text = "Limpar";
            this.LimparButton.UseVisualStyleBackColor = true;
            this.LimparButton.Click += new System.EventHandler(this.LimparButton_Click);
            // 
            // InserirButton
            // 
            this.InserirButton.Location = new System.Drawing.Point(436, 231);
            this.InserirButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.InserirButton.Name = "InserirButton";
            this.InserirButton.Size = new System.Drawing.Size(100, 28);
            this.InserirButton.TabIndex = 10;
            this.InserirButton.Text = "Inserir";
            this.InserirButton.UseVisualStyleBackColor = true;
            this.InserirButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // senhaTextBox
            // 
            this.senhaTextBox.Location = new System.Drawing.Point(437, 94);
            this.senhaTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.senhaTextBox.Name = "senhaTextBox";
            this.senhaTextBox.PasswordChar = '*';
            this.senhaTextBox.Size = new System.Drawing.Size(311, 22);
            this.senhaTextBox.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(433, 74);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(49, 17);
            this.label5.TabIndex = 8;
            this.label5.Text = "Senha";
            // 
            // UsuarioTextBox
            // 
            this.UsuarioTextBox.Location = new System.Drawing.Point(437, 31);
            this.UsuarioTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.UsuarioTextBox.Name = "UsuarioTextBox";
            this.UsuarioTextBox.Size = new System.Drawing.Size(311, 22);
            this.UsuarioTextBox.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(433, 11);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 17);
            this.label4.TabIndex = 6;
            this.label4.Text = "Usuário";
            // 
            // TelefoneTextBox
            // 
            this.TelefoneTextBox.Location = new System.Drawing.Point(37, 471);
            this.TelefoneTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.TelefoneTextBox.Name = "TelefoneTextBox";
            this.TelefoneTextBox.Size = new System.Drawing.Size(356, 22);
            this.TelefoneTextBox.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(37, 452);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 17);
            this.label3.TabIndex = 4;
            this.label3.Text = "Telefone";
            // 
            // EmailTextBox
            // 
            this.EmailTextBox.Location = new System.Drawing.Point(16, 94);
            this.EmailTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.EmailTextBox.Name = "EmailTextBox";
            this.EmailTextBox.Size = new System.Drawing.Size(356, 22);
            this.EmailTextBox.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 74);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "E-mail";
            // 
            // NomeCompletoTextBox
            // 
            this.NomeCompletoTextBox.Location = new System.Drawing.Point(20, 31);
            this.NomeCompletoTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.NomeCompletoTextBox.Name = "NomeCompletoTextBox";
            this.NomeCompletoTextBox.Size = new System.Drawing.Size(352, 22);
            this.NomeCompletoTextBox.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 11);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nome completo";
            // 
            // celMaskedTextBox
            // 
            this.celMaskedTextBox.CutCopyMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            this.celMaskedTextBox.Location = new System.Drawing.Point(16, 171);
            this.celMaskedTextBox.Mask = "(99)00000-0000";
            this.celMaskedTextBox.Name = "celMaskedTextBox";
            this.celMaskedTextBox.Size = new System.Drawing.Size(126, 22);
            this.celMaskedTextBox.TabIndex = 13;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(13, 138);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(52, 17);
            this.label6.TabIndex = 12;
            this.label6.Text = "Celular";
            // 
            // nascimentoDateTimePicker
            // 
            this.nascimentoDateTimePicker.Location = new System.Drawing.Point(19, 309);
            this.nascimentoDateTimePicker.Name = "nascimentoDateTimePicker";
            this.nascimentoDateTimePicker.Size = new System.Drawing.Size(289, 22);
            this.nascimentoDateTimePicker.TabIndex = 21;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(16, 277);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(136, 17);
            this.label9.TabIndex = 20;
            this.label9.Text = "Data de Nascimento";
            // 
            // cpfMaskedTextBox
            // 
            this.cpfMaskedTextBox.Location = new System.Drawing.Point(18, 231);
            this.cpfMaskedTextBox.Mask = "000.000.000-00";
            this.cpfMaskedTextBox.Name = "cpfMaskedTextBox";
            this.cpfMaskedTextBox.Size = new System.Drawing.Size(126, 22);
            this.cpfMaskedTextBox.TabIndex = 19;
            this.cpfMaskedTextBox.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(16, 211);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(34, 17);
            this.label7.TabIndex = 18;
            this.label7.Text = "CPF";
            // 
            // confTextBox
            // 
            this.confTextBox.Location = new System.Drawing.Point(437, 168);
            this.confTextBox.Name = "confTextBox";
            this.confTextBox.PasswordChar = '*';
            this.confTextBox.Size = new System.Drawing.Size(311, 22);
            this.confTextBox.TabIndex = 23;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(434, 148);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(112, 17);
            this.label8.TabIndex = 22;
            this.label8.Text = "Confirmar senha";
            // 
            // verCheckBox
            // 
            this.verCheckBox.AutoSize = true;
            this.verCheckBox.Location = new System.Drawing.Point(789, 134);
            this.verCheckBox.Name = "verCheckBox";
            this.verCheckBox.Size = new System.Drawing.Size(97, 21);
            this.verCheckBox.TabIndex = 24;
            this.verCheckBox.Text = "Ver Senha";
            this.verCheckBox.UseVisualStyleBackColor = true;
            this.verCheckBox.CheckedChanged += new System.EventHandler(this.verCheckBox_CheckedChanged);
            // 
            // Cadastrar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Cadastrar";
            this.Text = "Cadastrar";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button LimparButton;
        private System.Windows.Forms.Button InserirButton;
        private System.Windows.Forms.TextBox senhaTextBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox UsuarioTextBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox TelefoneTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox EmailTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox NomeCompletoTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MaskedTextBox celMaskedTextBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker nascimentoDateTimePicker;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.MaskedTextBox cpfMaskedTextBox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox confTextBox;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.CheckBox verCheckBox;
    }
}