
namespace ProjetoHenrique
{
    partial class Revisar
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
            this.certoButton = new System.Windows.Forms.Button();
            this.erradoButton = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.sairButton = new System.Windows.Forms.Button();
            this.progProgressBar = new System.Windows.Forms.ProgressBar();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(312, 77);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(680, 430);
            this.panel1.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(294, 358);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(99, 38);
            this.label2.TabIndex = 1;
            this.label2.Text = "Vazio";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(294, 42);
            this.label1.Name = "label1";
            this.label1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label1.Size = new System.Drawing.Size(99, 38);
            this.label1.TabIndex = 0;
            this.label1.Text = "Vazio";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // certoButton
            // 
            this.certoButton.Location = new System.Drawing.Point(312, 582);
            this.certoButton.Name = "certoButton";
            this.certoButton.Size = new System.Drawing.Size(144, 82);
            this.certoButton.TabIndex = 1;
            this.certoButton.Text = "Acertei";
            this.certoButton.UseVisualStyleBackColor = true;
            this.certoButton.Click += new System.EventHandler(this.certoButton_Click);
            // 
            // erradoButton
            // 
            this.erradoButton.Location = new System.Drawing.Point(848, 582);
            this.erradoButton.Name = "erradoButton";
            this.erradoButton.Size = new System.Drawing.Size(144, 82);
            this.erradoButton.TabIndex = 2;
            this.erradoButton.Text = "Errei";
            this.erradoButton.UseVisualStyleBackColor = true;
            this.erradoButton.Click += new System.EventHandler(this.erradoButton_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(631, 605);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 29);
            this.label3.TabIndex = 3;
            this.label3.Text = "0/0";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 38);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(0, 17);
            this.label4.TabIndex = 4;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(430, 28);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(457, 29);
            this.label5.TabIndex = 5;
            this.label5.Text = "Clique na palavra para revelar a resposta.";
            // 
            // sairButton
            // 
            this.sairButton.Location = new System.Drawing.Point(614, 637);
            this.sairButton.Name = "sairButton";
            this.sairButton.Size = new System.Drawing.Size(75, 23);
            this.sairButton.TabIndex = 2;
            this.sairButton.Text = "Sair";
            this.sairButton.UseVisualStyleBackColor = true;
            this.sairButton.Click += new System.EventHandler(this.sairButton_Click);
            // 
            // progProgressBar
            // 
            this.progProgressBar.Location = new System.Drawing.Point(312, 535);
            this.progProgressBar.Name = "progProgressBar";
            this.progProgressBar.Size = new System.Drawing.Size(680, 23);
            this.progProgressBar.TabIndex = 6;
            // 
            // Revisar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1330, 693);
            this.Controls.Add(this.progProgressBar);
            this.Controls.Add(this.sairButton);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.erradoButton);
            this.Controls.Add(this.certoButton);
            this.Controls.Add(this.panel1);
            this.Name = "Revisar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Revisar";
            this.Load += new System.EventHandler(this.Revisar_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button certoButton;
        private System.Windows.Forms.Button erradoButton;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button sairButton;
        private System.Windows.Forms.ProgressBar progProgressBar;
    }
}