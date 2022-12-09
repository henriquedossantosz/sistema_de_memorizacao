
namespace ProjetoHenrique
{
    partial class TelaInicial
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
            this.principalMenuStrip = new System.Windows.Forms.MenuStrip();
            this.idiomasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.palavrasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.adicionarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listarTodasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.conjuntosDeRevisãoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.perfilDoUsuárioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.consultarUsuáriosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.principalMenuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // principalMenuStrip
            // 
            this.principalMenuStrip.BackColor = System.Drawing.Color.LightSteelBlue;
            this.principalMenuStrip.Dock = System.Windows.Forms.DockStyle.Left;
            this.principalMenuStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.principalMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.idiomasToolStripMenuItem,
            this.palavrasToolStripMenuItem,
            this.conjuntosDeRevisãoToolStripMenuItem,
            this.perfilDoUsuárioToolStripMenuItem,
            this.consultarUsuáriosToolStripMenuItem});
            this.principalMenuStrip.Location = new System.Drawing.Point(0, 0);
            this.principalMenuStrip.Name = "principalMenuStrip";
            this.principalMenuStrip.Size = new System.Drawing.Size(171, 709);
            this.principalMenuStrip.TabIndex = 1;
            this.principalMenuStrip.Text = "principalMenuStrip";
            // 
            // idiomasToolStripMenuItem
            // 
            this.idiomasToolStripMenuItem.Name = "idiomasToolStripMenuItem";
            this.idiomasToolStripMenuItem.Size = new System.Drawing.Size(158, 24);
            this.idiomasToolStripMenuItem.Text = "Idiomas";
            this.idiomasToolStripMenuItem.Click += new System.EventHandler(this.idiomasToolStripMenuItem_Click);
            // 
            // palavrasToolStripMenuItem
            // 
            this.palavrasToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.adicionarToolStripMenuItem,
            this.listarTodasToolStripMenuItem});
            this.palavrasToolStripMenuItem.Name = "palavrasToolStripMenuItem";
            this.palavrasToolStripMenuItem.Size = new System.Drawing.Size(158, 24);
            this.palavrasToolStripMenuItem.Text = "Palavras";
            // 
            // adicionarToolStripMenuItem
            // 
            this.adicionarToolStripMenuItem.BackColor = System.Drawing.Color.LightSteelBlue;
            this.adicionarToolStripMenuItem.Name = "adicionarToolStripMenuItem";
            this.adicionarToolStripMenuItem.Size = new System.Drawing.Size(170, 26);
            this.adicionarToolStripMenuItem.Text = "Adicionar";
            this.adicionarToolStripMenuItem.Click += new System.EventHandler(this.adicionarToolStripMenuItem_Click);
            // 
            // listarTodasToolStripMenuItem
            // 
            this.listarTodasToolStripMenuItem.BackColor = System.Drawing.Color.LightSteelBlue;
            this.listarTodasToolStripMenuItem.Name = "listarTodasToolStripMenuItem";
            this.listarTodasToolStripMenuItem.Size = new System.Drawing.Size(170, 26);
            this.listarTodasToolStripMenuItem.Text = "Listar Todas";
            this.listarTodasToolStripMenuItem.Click += new System.EventHandler(this.listarTodasToolStripMenuItem_Click);
            // 
            // conjuntosDeRevisãoToolStripMenuItem
            // 
            this.conjuntosDeRevisãoToolStripMenuItem.Name = "conjuntosDeRevisãoToolStripMenuItem";
            this.conjuntosDeRevisãoToolStripMenuItem.Size = new System.Drawing.Size(158, 24);
            this.conjuntosDeRevisãoToolStripMenuItem.Text = "Conjuntos de Revisão";
            this.conjuntosDeRevisãoToolStripMenuItem.Click += new System.EventHandler(this.conjuntosDeRevisãoToolStripMenuItem_Click);
            // 
            // perfilDoUsuárioToolStripMenuItem
            // 
            this.perfilDoUsuárioToolStripMenuItem.Name = "perfilDoUsuárioToolStripMenuItem";
            this.perfilDoUsuárioToolStripMenuItem.Size = new System.Drawing.Size(158, 24);
            this.perfilDoUsuárioToolStripMenuItem.Text = "Perfil do Usuário";
            this.perfilDoUsuárioToolStripMenuItem.Click += new System.EventHandler(this.perfilDoUsuárioToolStripMenuItem_Click);
            // 
            // consultarUsuáriosToolStripMenuItem
            // 
            this.consultarUsuáriosToolStripMenuItem.Name = "consultarUsuáriosToolStripMenuItem";
            this.consultarUsuáriosToolStripMenuItem.Size = new System.Drawing.Size(158, 24);
            this.consultarUsuáriosToolStripMenuItem.Text = "Consultar Usuários";
            this.consultarUsuáriosToolStripMenuItem.Click += new System.EventHandler(this.consultarUsuáriosToolStripMenuItem_Click);
            // 
            // TelaInicial
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1673, 709);
            this.Controls.Add(this.principalMenuStrip);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.principalMenuStrip;
            this.Name = "TelaInicial";
            this.Text = "TelaInicial";
            this.principalMenuStrip.ResumeLayout(false);
            this.principalMenuStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip principalMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem palavrasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem conjuntosDeRevisãoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem perfilDoUsuárioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem idiomasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem adicionarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listarTodasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem consultarUsuáriosToolStripMenuItem;
    }
}