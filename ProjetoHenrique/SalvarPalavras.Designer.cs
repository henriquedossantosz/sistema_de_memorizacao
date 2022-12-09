namespace ProjetoHenrique
{
    partial class SalvarPalavras
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
            this.SairButton = new System.Windows.Forms.Button();
            this.palavraTextBox = new System.Windows.Forms.TextBox();
            this.SaveButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pronunciaTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.definicaoTextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.MorfologiaComboBox = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.ObservacaoTextBox = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.FonteTextBox = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.idiomaComboBox = new System.Windows.Forms.ComboBox();
            this.animoNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.utilidadeNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.label11 = new System.Windows.Forms.Label();
            this.relevanciaTextBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.limparButton = new System.Windows.Forms.Button();
            this.label12 = new System.Windows.Forms.Label();
            this.temaTextBox = new System.Windows.Forms.TextBox();
            this.falarRadioButton = new System.Windows.Forms.RadioButton();
            this.conhecerRadioButton = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.animoNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.utilidadeNumericUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // SairButton
            // 
            this.SairButton.AutoSize = true;
            this.SairButton.Location = new System.Drawing.Point(9, 415);
            this.SairButton.Name = "SairButton";
            this.SairButton.Size = new System.Drawing.Size(75, 27);
            this.SairButton.TabIndex = 1;
            this.SairButton.Text = "Voltar";
            this.SairButton.UseVisualStyleBackColor = true;
            this.SairButton.Click += new System.EventHandler(this.SairButton_Click);
            // 
            // palavraTextBox
            // 
            this.palavraTextBox.Location = new System.Drawing.Point(93, 96);
            this.palavraTextBox.Name = "palavraTextBox";
            this.palavraTextBox.Size = new System.Drawing.Size(147, 22);
            this.palavraTextBox.TabIndex = 2;
            // 
            // SaveButton
            // 
            this.SaveButton.Location = new System.Drawing.Point(93, 415);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(75, 27);
            this.SaveButton.TabIndex = 3;
            this.SaveButton.Text = "Salvar";
            this.SaveButton.UseVisualStyleBackColor = true;
            this.SaveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 96);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 17);
            this.label1.TabIndex = 4;
            this.label1.Text = "Palavra";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 212);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 17);
            this.label2.TabIndex = 6;
            this.label2.Text = "Pronúncia";
            // 
            // pronunciaTextBox
            // 
            this.pronunciaTextBox.Location = new System.Drawing.Point(93, 209);
            this.pronunciaTextBox.Name = "pronunciaTextBox";
            this.pronunciaTextBox.Size = new System.Drawing.Size(147, 22);
            this.pronunciaTextBox.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 153);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 17);
            this.label3.TabIndex = 8;
            this.label3.Text = "Definição";
            // 
            // definicaoTextBox
            // 
            this.definicaoTextBox.Location = new System.Drawing.Point(93, 153);
            this.definicaoTextBox.Name = "definicaoTextBox";
            this.definicaoTextBox.Size = new System.Drawing.Size(147, 22);
            this.definicaoTextBox.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(659, 52);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(74, 17);
            this.label4.TabIndex = 10;
            this.label4.Text = "Morfologia";
            // 
            // MorfologiaComboBox
            // 
            this.MorfologiaComboBox.FormattingEnabled = true;
            this.MorfologiaComboBox.Items.AddRange(new object[] {
            "Numeral",
            "Verbo",
            "Interjeição",
            "Advérbio",
            "Pronome",
            "Substantivo",
            "Preposição",
            "Artigo",
            "Adjetivo",
            "Conjunção"});
            this.MorfologiaComboBox.Location = new System.Drawing.Point(751, 46);
            this.MorfologiaComboBox.Name = "MorfologiaComboBox";
            this.MorfologiaComboBox.Size = new System.Drawing.Size(156, 24);
            this.MorfologiaComboBox.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(255, 53);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(355, 17);
            this.label6.TabIndex = 14;
            this.label6.Text = "Ânimo ao usar a palavra (selecione valor entre 0 a 10!)";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(659, 256);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(90, 17);
            this.label7.TabIndex = 16;
            this.label7.Text = "Classificação";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(659, 211);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(85, 17);
            this.label8.TabIndex = 21;
            this.label8.Text = "Observação";
            // 
            // ObservacaoTextBox
            // 
            this.ObservacaoTextBox.Location = new System.Drawing.Point(751, 211);
            this.ObservacaoTextBox.Name = "ObservacaoTextBox";
            this.ObservacaoTextBox.Size = new System.Drawing.Size(156, 22);
            this.ObservacaoTextBox.TabIndex = 20;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(659, 109);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(44, 17);
            this.label9.TabIndex = 19;
            this.label9.Text = "Fonte";
            // 
            // FonteTextBox
            // 
            this.FonteTextBox.Location = new System.Drawing.Point(751, 104);
            this.FonteTextBox.Name = "FonteTextBox";
            this.FonteTextBox.Size = new System.Drawing.Size(156, 22);
            this.FonteTextBox.TabIndex = 18;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(12, 26);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(115, 17);
            this.label10.TabIndex = 22;
            this.label10.Text = "Selecione Idioma";
            // 
            // idiomaComboBox
            // 
            this.idiomaComboBox.FormattingEnabled = true;
            this.idiomaComboBox.Location = new System.Drawing.Point(12, 46);
            this.idiomaComboBox.Name = "idiomaComboBox";
            this.idiomaComboBox.Size = new System.Drawing.Size(121, 24);
            this.idiomaComboBox.TabIndex = 23;
            // 
            // animoNumericUpDown
            // 
            this.animoNumericUpDown.Location = new System.Drawing.Point(391, 96);
            this.animoNumericUpDown.Name = "animoNumericUpDown";
            this.animoNumericUpDown.Size = new System.Drawing.Size(82, 22);
            this.animoNumericUpDown.TabIndex = 24;
            this.animoNumericUpDown.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.animoNumericUpDown.ValueChanged += new System.EventHandler(this.animoNumericUpDown_ValueChanged);
            // 
            // utilidadeNumericUpDown
            // 
            this.utilidadeNumericUpDown.Location = new System.Drawing.Point(391, 148);
            this.utilidadeNumericUpDown.Name = "utilidadeNumericUpDown";
            this.utilidadeNumericUpDown.Size = new System.Drawing.Size(82, 22);
            this.utilidadeNumericUpDown.TabIndex = 25;
            this.utilidadeNumericUpDown.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.utilidadeNumericUpDown.ValueChanged += new System.EventHandler(this.utilidadeNumericUpDown_ValueChanged);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(255, 121);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(381, 17);
            this.label11.TabIndex = 26;
            this.label11.Text = "Grau de utilidade da palavra (selecione valor entre 0 a 10!)";
            // 
            // relevanciaTextBox
            // 
            this.relevanciaTextBox.BackColor = System.Drawing.SystemColors.Window;
            this.relevanciaTextBox.Enabled = false;
            this.relevanciaTextBox.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.relevanciaTextBox.Location = new System.Drawing.Point(391, 213);
            this.relevanciaTextBox.Name = "relevanciaTextBox";
            this.relevanciaTextBox.ReadOnly = true;
            this.relevanciaTextBox.Size = new System.Drawing.Size(82, 22);
            this.relevanciaTextBox.TabIndex = 27;
            this.relevanciaTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(388, 186);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(78, 17);
            this.label5.TabIndex = 28;
            this.label5.Text = "Relevância";
            // 
            // limparButton
            // 
            this.limparButton.Location = new System.Drawing.Point(174, 415);
            this.limparButton.Name = "limparButton";
            this.limparButton.Size = new System.Drawing.Size(124, 27);
            this.limparButton.TabIndex = 29;
            this.limparButton.Text = "Limpar campos";
            this.limparButton.UseVisualStyleBackColor = true;
            this.limparButton.Click += new System.EventHandler(this.limparButton_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(659, 163);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(44, 17);
            this.label12.TabIndex = 30;
            this.label12.Text = "Tema";
            // 
            // temaTextBox
            // 
            this.temaTextBox.Location = new System.Drawing.Point(751, 163);
            this.temaTextBox.Name = "temaTextBox";
            this.temaTextBox.Size = new System.Drawing.Size(156, 22);
            this.temaTextBox.TabIndex = 31;
            // 
            // falarRadioButton
            // 
            this.falarRadioButton.AutoSize = true;
            this.falarRadioButton.Location = new System.Drawing.Point(662, 276);
            this.falarRadioButton.Name = "falarRadioButton";
            this.falarRadioButton.Size = new System.Drawing.Size(61, 21);
            this.falarRadioButton.TabIndex = 32;
            this.falarRadioButton.TabStop = true;
            this.falarRadioButton.Text = "Falar";
            this.falarRadioButton.UseVisualStyleBackColor = true;
            this.falarRadioButton.CheckedChanged += new System.EventHandler(this.falarRadioButton_CheckedChanged);
            // 
            // conhecerRadioButton
            // 
            this.conhecerRadioButton.AutoSize = true;
            this.conhecerRadioButton.Location = new System.Drawing.Point(662, 303);
            this.conhecerRadioButton.Name = "conhecerRadioButton";
            this.conhecerRadioButton.Size = new System.Drawing.Size(90, 21);
            this.conhecerRadioButton.TabIndex = 33;
            this.conhecerRadioButton.TabStop = true;
            this.conhecerRadioButton.Text = "Conhecer";
            this.conhecerRadioButton.UseVisualStyleBackColor = true;
            this.conhecerRadioButton.CheckedChanged += new System.EventHandler(this.conhecerRadioButton_CheckedChanged);
            // 
            // SalvarPalavras
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(1012, 564);
            this.Controls.Add(this.conhecerRadioButton);
            this.Controls.Add(this.falarRadioButton);
            this.Controls.Add(this.temaTextBox);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.limparButton);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.relevanciaTextBox);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.utilidadeNumericUpDown);
            this.Controls.Add(this.animoNumericUpDown);
            this.Controls.Add(this.idiomaComboBox);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.ObservacaoTextBox);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.FonteTextBox);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.MorfologiaComboBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.definicaoTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pronunciaTextBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.SaveButton);
            this.Controls.Add(this.palavraTextBox);
            this.Controls.Add(this.SairButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "SalvarPalavras";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SalvarPalavras";
            this.Load += new System.EventHandler(this.SalvarPalavras_Load);
            ((System.ComponentModel.ISupportInitialize)(this.animoNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.utilidadeNumericUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button SairButton;
        private System.Windows.Forms.TextBox palavraTextBox;
        private System.Windows.Forms.Button SaveButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox pronunciaTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox definicaoTextBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox MorfologiaComboBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox ObservacaoTextBox;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox FonteTextBox;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox idiomaComboBox;
        private System.Windows.Forms.NumericUpDown animoNumericUpDown;
        private System.Windows.Forms.NumericUpDown utilidadeNumericUpDown;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox relevanciaTextBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button limparButton;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox temaTextBox;
        private System.Windows.Forms.RadioButton falarRadioButton;
        private System.Windows.Forms.RadioButton conhecerRadioButton;
    }
}