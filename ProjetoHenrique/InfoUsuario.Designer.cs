
namespace ProjetoHenrique
{
    partial class InfoUsuario
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
            this.label1 = new System.Windows.Forms.Label();
            this.nomeTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.emailTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.celMaskedTextBox = new System.Windows.Forms.MaskedTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cpfMaskedTextBox = new System.Windows.Forms.MaskedTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.nomeuserTextBox = new System.Windows.Forms.TextBox();
            this.senhaTextBox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.confTextBox = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.nascimentoDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.destravarButton = new System.Windows.Forms.Button();
            this.salvarButton = new System.Windows.Forms.Button();
            this.verCheckBox = new System.Windows.Forms.CheckBox();
            this.sairButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(55, 106);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nome";
            // 
            // nomeTextBox
            // 
            this.nomeTextBox.Location = new System.Drawing.Point(58, 126);
            this.nomeTextBox.Name = "nomeTextBox";
            this.nomeTextBox.Size = new System.Drawing.Size(407, 22);
            this.nomeTextBox.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(55, 186);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "E-mail";
            // 
            // emailTextBox
            // 
            this.emailTextBox.Location = new System.Drawing.Point(58, 206);
            this.emailTextBox.Name = "emailTextBox";
            this.emailTextBox.Size = new System.Drawing.Size(407, 22);
            this.emailTextBox.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(54, 252);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 17);
            this.label3.TabIndex = 4;
            this.label3.Text = "Celular";
            // 
            // celMaskedTextBox
            // 
            this.celMaskedTextBox.CutCopyMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            this.celMaskedTextBox.Location = new System.Drawing.Point(57, 285);
            this.celMaskedTextBox.Mask = "(99)00000-0000";
            this.celMaskedTextBox.Name = "celMaskedTextBox";
            this.celMaskedTextBox.Size = new System.Drawing.Size(126, 22);
            this.celMaskedTextBox.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(55, 326);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(34, 17);
            this.label4.TabIndex = 6;
            this.label4.Text = "CPF";
            // 
            // cpfMaskedTextBox
            // 
            this.cpfMaskedTextBox.Location = new System.Drawing.Point(57, 346);
            this.cpfMaskedTextBox.Mask = "000.000.000-00";
            this.cpfMaskedTextBox.Name = "cpfMaskedTextBox";
            this.cpfMaskedTextBox.Size = new System.Drawing.Size(126, 22);
            this.cpfMaskedTextBox.TabIndex = 7;
            this.cpfMaskedTextBox.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(592, 106);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(116, 17);
            this.label5.TabIndex = 8;
            this.label5.Text = "Nome de usuário";
            // 
            // nomeuserTextBox
            // 
            this.nomeuserTextBox.Location = new System.Drawing.Point(595, 126);
            this.nomeuserTextBox.Name = "nomeuserTextBox";
            this.nomeuserTextBox.Size = new System.Drawing.Size(311, 22);
            this.nomeuserTextBox.TabIndex = 9;
            // 
            // senhaTextBox
            // 
            this.senhaTextBox.Location = new System.Drawing.Point(595, 206);
            this.senhaTextBox.Name = "senhaTextBox";
            this.senhaTextBox.PasswordChar = '*';
            this.senhaTextBox.Size = new System.Drawing.Size(311, 22);
            this.senhaTextBox.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(592, 186);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(49, 17);
            this.label6.TabIndex = 10;
            this.label6.Text = "Senha";
            // 
            // confTextBox
            // 
            this.confTextBox.Location = new System.Drawing.Point(595, 285);
            this.confTextBox.Name = "confTextBox";
            this.confTextBox.PasswordChar = '*';
            this.confTextBox.Size = new System.Drawing.Size(311, 22);
            this.confTextBox.TabIndex = 13;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(592, 265);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(112, 17);
            this.label7.TabIndex = 12;
            this.label7.Text = "Confirmar senha";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(55, 392);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(136, 17);
            this.label9.TabIndex = 15;
            this.label9.Text = "Data de Nascimento";
            // 
            // nascimentoDateTimePicker
            // 
            this.nascimentoDateTimePicker.Location = new System.Drawing.Point(58, 424);
            this.nascimentoDateTimePicker.Name = "nascimentoDateTimePicker";
            this.nascimentoDateTimePicker.Size = new System.Drawing.Size(289, 22);
            this.nascimentoDateTimePicker.TabIndex = 17;
            // 
            // destravarButton
            // 
            this.destravarButton.Location = new System.Drawing.Point(595, 345);
            this.destravarButton.Name = "destravarButton";
            this.destravarButton.Size = new System.Drawing.Size(92, 23);
            this.destravarButton.TabIndex = 18;
            this.destravarButton.Text = "Alterar";
            this.destravarButton.UseVisualStyleBackColor = true;
            this.destravarButton.Click += new System.EventHandler(this.destravarButton_Click);
            // 
            // salvarButton
            // 
            this.salvarButton.Location = new System.Drawing.Point(768, 346);
            this.salvarButton.Name = "salvarButton";
            this.salvarButton.Size = new System.Drawing.Size(138, 23);
            this.salvarButton.TabIndex = 19;
            this.salvarButton.Text = "Salvar Alterações";
            this.salvarButton.UseVisualStyleBackColor = true;
            this.salvarButton.Click += new System.EventHandler(this.salvarButton_Click);
            // 
            // verCheckBox
            // 
            this.verCheckBox.AutoSize = true;
            this.verCheckBox.Location = new System.Drawing.Point(940, 248);
            this.verCheckBox.Name = "verCheckBox";
            this.verCheckBox.Size = new System.Drawing.Size(97, 21);
            this.verCheckBox.TabIndex = 20;
            this.verCheckBox.Text = "Ver Senha";
            this.verCheckBox.UseVisualStyleBackColor = true;
            this.verCheckBox.CheckedChanged += new System.EventHandler(this.verCheckBox_CheckedChanged);
            // 
            // sairButton
            // 
            this.sairButton.Location = new System.Drawing.Point(58, 584);
            this.sairButton.Name = "sairButton";
            this.sairButton.Size = new System.Drawing.Size(75, 23);
            this.sairButton.TabIndex = 21;
            this.sairButton.Text = "Sair";
            this.sairButton.UseVisualStyleBackColor = true;
            this.sairButton.Click += new System.EventHandler(this.sairButton_Click);
            // 
            // InfoUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1319, 684);
            this.Controls.Add(this.sairButton);
            this.Controls.Add(this.verCheckBox);
            this.Controls.Add(this.salvarButton);
            this.Controls.Add(this.destravarButton);
            this.Controls.Add(this.nascimentoDateTimePicker);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.confTextBox);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.senhaTextBox);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.nomeuserTextBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cpfMaskedTextBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.celMaskedTextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.emailTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.nomeTextBox);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "InfoUsuario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "InfoUsuario";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox nomeTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox emailTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.MaskedTextBox celMaskedTextBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.MaskedTextBox cpfMaskedTextBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox nomeuserTextBox;
        private System.Windows.Forms.TextBox senhaTextBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox confTextBox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DateTimePicker nascimentoDateTimePicker;
        private System.Windows.Forms.Button destravarButton;
        private System.Windows.Forms.Button salvarButton;
        private System.Windows.Forms.CheckBox verCheckBox;
        private System.Windows.Forms.Button sairButton;
    }
}