
namespace ProjetoHenrique
{
    partial class ListarConjunto
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
            this.CRListView = new System.Windows.Forms.ListView();
            this.NomeCR = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.DescricaoCR = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.praticarButton = new System.Windows.Forms.Button();
            this.hojeLabel = new System.Windows.Forms.Label();
            this.infoButton = new System.Windows.Forms.Button();
            this.addCRbutton = new System.Windows.Forms.Button();
            this.excluirButton = new System.Windows.Forms.Button();
            this.atualizarButton = new System.Windows.Forms.Button();
            this.idiomaComboBox = new System.Windows.Forms.ComboBox();
            this.sairButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // CRListView
            // 
            this.CRListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.NomeCR,
            this.DescricaoCR,
            this.columnHeader1,
            this.columnHeader2});
            this.CRListView.FullRowSelect = true;
            this.CRListView.HideSelection = false;
            this.CRListView.Location = new System.Drawing.Point(366, 73);
            this.CRListView.Name = "CRListView";
            this.CRListView.Size = new System.Drawing.Size(509, 562);
            this.CRListView.TabIndex = 0;
            this.CRListView.UseCompatibleStateImageBehavior = false;
            this.CRListView.View = System.Windows.Forms.View.Details;
            this.CRListView.ItemActivate += new System.EventHandler(this.CRListView_ItemActivate);
            this.CRListView.MouseClick += new System.Windows.Forms.MouseEventHandler(this.CRListView_MouseClick);
            // 
            // NomeCR
            // 
            this.NomeCR.Text = "";
            this.NomeCR.Width = 1;
            // 
            // DescricaoCR
            // 
            this.DescricaoCR.Text = "Conjunto ";
            this.DescricaoCR.Width = 148;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Descrição";
            this.columnHeader1.Width = 131;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Idioma";
            this.columnHeader2.Width = 100;
            // 
            // praticarButton
            // 
            this.praticarButton.Location = new System.Drawing.Point(414, 641);
            this.praticarButton.Name = "praticarButton";
            this.praticarButton.Size = new System.Drawing.Size(75, 40);
            this.praticarButton.TabIndex = 1;
            this.praticarButton.Text = "Praticar";
            this.praticarButton.UseVisualStyleBackColor = true;
            this.praticarButton.Click += new System.EventHandler(this.praticarButton_Click);
            // 
            // hojeLabel
            // 
            this.hojeLabel.AutoSize = true;
            this.hojeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hojeLabel.Location = new System.Drawing.Point(12, 9);
            this.hojeLabel.Name = "hojeLabel";
            this.hojeLabel.Size = new System.Drawing.Size(103, 38);
            this.hojeLabel.TabIndex = 2;
            this.hojeLabel.Text = "label1";
            // 
            // infoButton
            // 
            this.infoButton.Location = new System.Drawing.Point(495, 641);
            this.infoButton.Name = "infoButton";
            this.infoButton.Size = new System.Drawing.Size(133, 40);
            this.infoButton.TabIndex = 3;
            this.infoButton.Text = "Ver Informações";
            this.infoButton.UseVisualStyleBackColor = true;
            this.infoButton.Click += new System.EventHandler(this.infoButton_Click);
            // 
            // addCRbutton
            // 
            this.addCRbutton.Location = new System.Drawing.Point(248, 641);
            this.addCRbutton.Name = "addCRbutton";
            this.addCRbutton.Size = new System.Drawing.Size(160, 40);
            this.addCRbutton.TabIndex = 5;
            this.addCRbutton.Text = "Adicionar Conjunto";
            this.addCRbutton.UseVisualStyleBackColor = true;
            this.addCRbutton.Click += new System.EventHandler(this.addCRbutton_Click);
            // 
            // excluirButton
            // 
            this.excluirButton.Location = new System.Drawing.Point(634, 641);
            this.excluirButton.Name = "excluirButton";
            this.excluirButton.Size = new System.Drawing.Size(153, 40);
            this.excluirButton.TabIndex = 6;
            this.excluirButton.Text = "Excluir Conjunto";
            this.excluirButton.UseVisualStyleBackColor = true;
            this.excluirButton.Click += new System.EventHandler(this.excluirButton_Click);
            // 
            // atualizarButton
            // 
            this.atualizarButton.Location = new System.Drawing.Point(793, 641);
            this.atualizarButton.Name = "atualizarButton";
            this.atualizarButton.Size = new System.Drawing.Size(144, 40);
            this.atualizarButton.TabIndex = 7;
            this.atualizarButton.Text = "Atualizar Conjuto";
            this.atualizarButton.UseVisualStyleBackColor = true;
            this.atualizarButton.Click += new System.EventHandler(this.atualizarButton_Click);
            // 
            // idiomaComboBox
            // 
            this.idiomaComboBox.FormattingEnabled = true;
            this.idiomaComboBox.Location = new System.Drawing.Point(754, 43);
            this.idiomaComboBox.Name = "idiomaComboBox";
            this.idiomaComboBox.Size = new System.Drawing.Size(121, 24);
            this.idiomaComboBox.TabIndex = 8;
            this.idiomaComboBox.TextChanged += new System.EventHandler(this.idiomaComboBox_TextChanged);
            // 
            // sairButton
            // 
            this.sairButton.Location = new System.Drawing.Point(943, 641);
            this.sairButton.Name = "sairButton";
            this.sairButton.Size = new System.Drawing.Size(75, 40);
            this.sairButton.TabIndex = 9;
            this.sairButton.Text = "Sair";
            this.sairButton.UseVisualStyleBackColor = true;
            this.sairButton.Click += new System.EventHandler(this.sairButton_Click);
            // 
            // ListarConjunto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1330, 693);
            this.Controls.Add(this.sairButton);
            this.Controls.Add(this.idiomaComboBox);
            this.Controls.Add(this.atualizarButton);
            this.Controls.Add(this.excluirButton);
            this.Controls.Add(this.addCRbutton);
            this.Controls.Add(this.infoButton);
            this.Controls.Add(this.hojeLabel);
            this.Controls.Add(this.praticarButton);
            this.Controls.Add(this.CRListView);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ListarConjunto";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ListarConjunto";
            this.Load += new System.EventHandler(this.ListarConjunto_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView CRListView;
        private System.Windows.Forms.ColumnHeader NomeCR;
        private System.Windows.Forms.ColumnHeader DescricaoCR;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.Button praticarButton;
        private System.Windows.Forms.Label hojeLabel;
        private System.Windows.Forms.Button infoButton;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.Button addCRbutton;
        private System.Windows.Forms.Button excluirButton;
        private System.Windows.Forms.Button atualizarButton;
        private System.Windows.Forms.ComboBox idiomaComboBox;
        private System.Windows.Forms.Button sairButton;
    }
}