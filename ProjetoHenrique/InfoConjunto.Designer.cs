
namespace ProjetoHenrique
{
    partial class InfoConjunto
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
            this.conjuntoLabel = new System.Windows.Forms.Label();
            this.flashCardListView = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.addFCbutton = new System.Windows.Forms.Button();
            this.praticarButton = new System.Windows.Forms.Button();
            this.excluirButton = new System.Windows.Forms.Button();
            this.AtualizarButton = new System.Windows.Forms.Button();
            this.sairButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // conjuntoLabel
            // 
            this.conjuntoLabel.AutoSize = true;
            this.conjuntoLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.conjuntoLabel.Location = new System.Drawing.Point(12, 42);
            this.conjuntoLabel.Name = "conjuntoLabel";
            this.conjuntoLabel.Size = new System.Drawing.Size(53, 20);
            this.conjuntoLabel.TabIndex = 0;
            this.conjuntoLabel.Text = "label1";
            // 
            // flashCardListView
            // 
            this.flashCardListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6,
            this.columnHeader7});
            this.flashCardListView.FullRowSelect = true;
            this.flashCardListView.HideSelection = false;
            this.flashCardListView.Location = new System.Drawing.Point(16, 107);
            this.flashCardListView.Name = "flashCardListView";
            this.flashCardListView.Size = new System.Drawing.Size(1087, 384);
            this.flashCardListView.TabIndex = 1;
            this.flashCardListView.UseCompatibleStateImageBehavior = false;
            this.flashCardListView.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Numero";
            this.columnHeader1.Width = 1;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Frente";
            this.columnHeader2.Width = 130;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Verso";
            this.columnHeader3.Width = 130;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Próxima Revisão";
            this.columnHeader4.Width = 130;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Data de Criação";
            this.columnHeader5.Width = 130;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Total de acertos";
            this.columnHeader6.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader6.Width = 116;
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "Total de erros";
            this.columnHeader7.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader7.Width = 116;
            // 
            // addFCbutton
            // 
            this.addFCbutton.Location = new System.Drawing.Point(1130, 151);
            this.addFCbutton.Name = "addFCbutton";
            this.addFCbutton.Size = new System.Drawing.Size(138, 23);
            this.addFCbutton.TabIndex = 2;
            this.addFCbutton.Text = "Novo Flash Card";
            this.addFCbutton.UseVisualStyleBackColor = true;
            this.addFCbutton.Click += new System.EventHandler(this.addFCbutton_Click);
            // 
            // praticarButton
            // 
            this.praticarButton.Location = new System.Drawing.Point(1130, 107);
            this.praticarButton.Name = "praticarButton";
            this.praticarButton.Size = new System.Drawing.Size(138, 23);
            this.praticarButton.TabIndex = 3;
            this.praticarButton.Text = "Praticar";
            this.praticarButton.UseVisualStyleBackColor = true;
            this.praticarButton.Click += new System.EventHandler(this.praticarButton_Click);
            // 
            // excluirButton
            // 
            this.excluirButton.Location = new System.Drawing.Point(1130, 242);
            this.excluirButton.Name = "excluirButton";
            this.excluirButton.Size = new System.Drawing.Size(138, 23);
            this.excluirButton.TabIndex = 4;
            this.excluirButton.Text = "Excluir Flash Card";
            this.excluirButton.UseVisualStyleBackColor = true;
            this.excluirButton.Click += new System.EventHandler(this.excluirButton_Click);
            // 
            // AtualizarButton
            // 
            this.AtualizarButton.Location = new System.Drawing.Point(1130, 196);
            this.AtualizarButton.Name = "AtualizarButton";
            this.AtualizarButton.Size = new System.Drawing.Size(138, 23);
            this.AtualizarButton.TabIndex = 5;
            this.AtualizarButton.Text = "Atualizar Flash Card";
            this.AtualizarButton.UseVisualStyleBackColor = true;
            this.AtualizarButton.Click += new System.EventHandler(this.AtualizarButton_Click);
            // 
            // sairButton
            // 
            this.sairButton.Location = new System.Drawing.Point(1130, 293);
            this.sairButton.Name = "sairButton";
            this.sairButton.Size = new System.Drawing.Size(138, 23);
            this.sairButton.TabIndex = 6;
            this.sairButton.Text = "Sair";
            this.sairButton.UseVisualStyleBackColor = true;
            this.sairButton.Click += new System.EventHandler(this.sairButton_Click);
            // 
            // InfoConjunto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1330, 693);
            this.Controls.Add(this.sairButton);
            this.Controls.Add(this.AtualizarButton);
            this.Controls.Add(this.excluirButton);
            this.Controls.Add(this.praticarButton);
            this.Controls.Add(this.addFCbutton);
            this.Controls.Add(this.flashCardListView);
            this.Controls.Add(this.conjuntoLabel);
            this.Name = "InfoConjunto";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "InfoConjunto";
            this.Load += new System.EventHandler(this.InfoConjunto_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label conjuntoLabel;
        private System.Windows.Forms.ListView flashCardListView;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.Button addFCbutton;
        private System.Windows.Forms.Button praticarButton;
        private System.Windows.Forms.Button excluirButton;
        private System.Windows.Forms.Button AtualizarButton;
        private System.Windows.Forms.Button sairButton;
    }
}