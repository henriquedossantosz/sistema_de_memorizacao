namespace ProjetoHenrique
{
    partial class PraticarFrase
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
            this.InstrucaoLabel = new System.Windows.Forms.Label();
            this.ExemploLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // InstrucaoLabel
            // 
            this.InstrucaoLabel.AutoSize = true;
            this.InstrucaoLabel.Location = new System.Drawing.Point(324, 9);
            this.InstrucaoLabel.Name = "InstrucaoLabel";
            this.InstrucaoLabel.Size = new System.Drawing.Size(33, 13);
            this.InstrucaoLabel.TabIndex = 0;
            this.InstrucaoLabel.Text = "Label";
            // 
            // ExemploLabel
            // 
            this.ExemploLabel.AutoSize = true;
            this.ExemploLabel.Location = new System.Drawing.Point(362, 100);
            this.ExemploLabel.Name = "ExemploLabel";
            this.ExemploLabel.Size = new System.Drawing.Size(35, 13);
            this.ExemploLabel.TabIndex = 1;
            this.ExemploLabel.Text = "label1";
            this.ExemploLabel.Click += new System.EventHandler(this.ExemploLabel_Click);
            // 
            // PraticarFrase
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.ExemploLabel);
            this.Controls.Add(this.InstrucaoLabel);
            this.Name = "PraticarFrase";
            this.Text = "PraticarFrase";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label InstrucaoLabel;
        private System.Windows.Forms.Label ExemploLabel;
    }
}