
namespace ProjetoHenrique
{
    partial class AdicionarFlashCard
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
            this.crComboBox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.frenteTextBox = new System.Windows.Forms.TextBox();
            this.versoTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.limparButton = new System.Windows.Forms.Button();
            this.adicionarBbutton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // crComboBox
            // 
            this.crComboBox.FormattingEnabled = true;
            this.crComboBox.Location = new System.Drawing.Point(140, 104);
            this.crComboBox.Name = "crComboBox";
            this.crComboBox.Size = new System.Drawing.Size(175, 24);
            this.crComboBox.TabIndex = 0;
            this.crComboBox.TextChanged += new System.EventHandler(this.crComboBox_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(135, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(195, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Adicionar Flash Card";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(161, 84);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(135, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Selecionar Conjunto";
            // 
            // frenteTextBox
            // 
            this.frenteTextBox.Location = new System.Drawing.Point(140, 177);
            this.frenteTextBox.Name = "frenteTextBox";
            this.frenteTextBox.Size = new System.Drawing.Size(175, 22);
            this.frenteTextBox.TabIndex = 3;
            // 
            // versoTextBox
            // 
            this.versoTextBox.Location = new System.Drawing.Point(140, 248);
            this.versoTextBox.Name = "versoTextBox";
            this.versoTextBox.Size = new System.Drawing.Size(175, 22);
            this.versoTextBox.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(137, 157);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(178, 17);
            this.label3.TabIndex = 5;
            this.label3.Text = "Preencha a frente da carta";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(137, 228);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(200, 17);
            this.label4.TabIndex = 6;
            this.label4.Text = "Preencha a resposta da carta.";
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
            // adicionarBbutton
            // 
            this.adicionarBbutton.Location = new System.Drawing.Point(280, 304);
            this.adicionarBbutton.Name = "adicionarBbutton";
            this.adicionarBbutton.Size = new System.Drawing.Size(87, 23);
            this.adicionarBbutton.TabIndex = 8;
            this.adicionarBbutton.Text = "Adicionar";
            this.adicionarBbutton.UseVisualStyleBackColor = true;
            this.adicionarBbutton.Click += new System.EventHandler(this.adicionarBbutton_Click);
            // 
            // AdicionarFlashCard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(479, 450);
            this.Controls.Add(this.adicionarBbutton);
            this.Controls.Add(this.limparButton);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.versoTextBox);
            this.Controls.Add(this.frenteTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.crComboBox);
            this.Name = "AdicionarFlashCard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "AdicionarFlashCard";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox crComboBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox frenteTextBox;
        private System.Windows.Forms.TextBox versoTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button limparButton;
        private System.Windows.Forms.Button adicionarBbutton;
    }
}