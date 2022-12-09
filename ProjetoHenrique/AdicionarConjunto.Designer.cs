
namespace ProjetoHenrique
{
    partial class AdicionarConjunto
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.nomeCRTextBox = new System.Windows.Forms.TextBox();
            this.descricaoTextBox = new System.Windows.Forms.TextBox();
            this.idiomaComboBox = new System.Windows.Forms.ComboBox();
            this.addButton = new System.Windows.Forms.Button();
            this.limparButton = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(172, 157);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(125, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nome do Conjunto";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(192, 228);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Descrição";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(172, 84);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(120, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Selecionar Idioma";
            // 
            // nomeCRTextBox
            // 
            this.nomeCRTextBox.Location = new System.Drawing.Point(140, 177);
            this.nomeCRTextBox.Name = "nomeCRTextBox";
            this.nomeCRTextBox.Size = new System.Drawing.Size(175, 22);
            this.nomeCRTextBox.TabIndex = 3;
            // 
            // descricaoTextBox
            // 
            this.descricaoTextBox.Location = new System.Drawing.Point(140, 248);
            this.descricaoTextBox.Name = "descricaoTextBox";
            this.descricaoTextBox.Size = new System.Drawing.Size(175, 22);
            this.descricaoTextBox.TabIndex = 4;
            // 
            // idiomaComboBox
            // 
            this.idiomaComboBox.FormattingEnabled = true;
            this.idiomaComboBox.Location = new System.Drawing.Point(140, 104);
            this.idiomaComboBox.Name = "idiomaComboBox";
            this.idiomaComboBox.Size = new System.Drawing.Size(175, 24);
            this.idiomaComboBox.TabIndex = 5;
            this.idiomaComboBox.TextChanged += new System.EventHandler(this.idiomaComboBox_TextChanged);
            // 
            // addButton
            // 
            this.addButton.Location = new System.Drawing.Point(280, 304);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(87, 23);
            this.addButton.TabIndex = 6;
            this.addButton.Text = "Adicionar";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // limparButton
            // 
            this.limparButton.Location = new System.Drawing.Point(58, 304);
            this.limparButton.Name = "limparButton";
            this.limparButton.Size = new System.Drawing.Size(132, 23);
            this.limparButton.TabIndex = 7;
            this.limparButton.Text = "Limpar Campos";
            this.limparButton.UseVisualStyleBackColor = true;
            this.limparButton.Click += new System.EventHandler(this.limparButton_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(98, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(280, 25);
            this.label4.TabIndex = 8;
            this.label4.Text = "Adicionar Conjunto de Revisão";
            // 
            // AdicionarConjunto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(479, 450);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.limparButton);
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.idiomaComboBox);
            this.Controls.Add(this.descricaoTextBox);
            this.Controls.Add(this.nomeCRTextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "AdicionarConjunto";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "AdicionarConjunto";
            this.Load += new System.EventHandler(this.AdicionarConjunto_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox nomeCRTextBox;
        private System.Windows.Forms.TextBox descricaoTextBox;
        private System.Windows.Forms.ComboBox idiomaComboBox;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.Button limparButton;
        private System.Windows.Forms.Label label4;
    }
}