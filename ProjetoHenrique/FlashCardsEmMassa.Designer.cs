
namespace ProjetoHenrique
{
    partial class FlashCardsEmMassa
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
            this.frenteComboBox = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.versoComboBox = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.conjuntoComboBox = new System.Windows.Forms.ComboBox();
            this.adicionarButton = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(67, 196);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(338, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Selecione qual coluna será a frente dos Flash Cards";
            // 
            // frenteComboBox
            // 
            this.frenteComboBox.FormattingEnabled = true;
            this.frenteComboBox.Items.AddRange(new object[] {
            "Palavra",
            "Definição",
            "Pronúncia"});
            this.frenteComboBox.Location = new System.Drawing.Point(147, 235);
            this.frenteComboBox.Name = "frenteComboBox";
            this.frenteComboBox.Size = new System.Drawing.Size(172, 24);
            this.frenteComboBox.TabIndex = 1;
            this.frenteComboBox.TextChanged += new System.EventHandler(this.frenteComboBox_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(69, 287);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(336, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Selecione qual coluna será o verso dos Flash Cards";
            // 
            // versoComboBox
            // 
            this.versoComboBox.FormattingEnabled = true;
            this.versoComboBox.Location = new System.Drawing.Point(147, 317);
            this.versoComboBox.Name = "versoComboBox";
            this.versoComboBox.Size = new System.Drawing.Size(172, 24);
            this.versoComboBox.TabIndex = 3;
            this.versoComboBox.TextChanged += new System.EventHandler(this.versoComboBox_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(121, 121);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(228, 17);
            this.label3.TabIndex = 4;
            this.label3.Text = "Selecione um Conjunto de Revisão";
            // 
            // conjuntoComboBox
            // 
            this.conjuntoComboBox.FormattingEnabled = true;
            this.conjuntoComboBox.Location = new System.Drawing.Point(147, 141);
            this.conjuntoComboBox.Name = "conjuntoComboBox";
            this.conjuntoComboBox.Size = new System.Drawing.Size(172, 24);
            this.conjuntoComboBox.TabIndex = 5;
            this.conjuntoComboBox.TextChanged += new System.EventHandler(this.conjuntoComboBox_TextChanged);
            // 
            // adicionarButton
            // 
            this.adicionarButton.Location = new System.Drawing.Point(147, 369);
            this.adicionarButton.Name = "adicionarButton";
            this.adicionarButton.Size = new System.Drawing.Size(172, 23);
            this.adicionarButton.TabIndex = 6;
            this.adicionarButton.Text = "Adicionar Cartas";
            this.adicionarButton.UseVisualStyleBackColor = true;
            this.adicionarButton.Click += new System.EventHandler(this.adicionarButton_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(220, 57);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 17);
            this.label4.TabIndex = 7;
            this.label4.Text = "label4";
            // 
            // FlashCardsEmMassa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(479, 450);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.adicionarButton);
            this.Controls.Add(this.conjuntoComboBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.versoComboBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.frenteComboBox);
            this.Controls.Add(this.label1);
            this.Name = "FlashCardsEmMassa";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "FlashCardsEmMassa";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox frenteComboBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox versoComboBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox conjuntoComboBox;
        private System.Windows.Forms.Button adicionarButton;
        private System.Windows.Forms.Label label4;
    }
}