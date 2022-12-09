using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetoHenrique
{
    public partial class TelaInicial : Form
    {
        int id;
        public TelaInicial()
        {
            InitializeComponent();
        }

        public TelaInicial(int id)
        {
            InitializeComponent();
            /*if(usuario == "henrique")
            {
                consultarUsuáriosToolStripMenuItem.Visible = true;
            }*/
            if(id ==1 )
            {
                consultarUsuáriosToolStripMenuItem.Visible = true;
            }
            else
            {
                consultarUsuáriosToolStripMenuItem.Visible = false;
            }
            this.id = id;
        }

        private void listarTodasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ListarPalavras telaPalavras = new ListarPalavras(id);
            telaPalavras.Show();
		    telaPalavras.MdiParent = this;
        }

        private void adicionarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SalvarPalavras salvarPalavras = new SalvarPalavras(id);
            salvarPalavras.Show();
            salvarPalavras.MdiParent = this;
        }

        private void conjuntosDeRevisãoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ListarConjunto listarConjunto = new ListarConjunto(id);
            listarConjunto.Show();
            listarConjunto.MdiParent = this;
        }

        private void idiomasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ListarIdiomas listarIdiomas = new ListarIdiomas(id);
            listarIdiomas.Show();
            listarIdiomas.MdiParent = this;
        }

        private void perfilDoUsuárioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            InfoUsuario infoUsuario = new InfoUsuario(id);
            infoUsuario.Show();
            infoUsuario.MdiParent = this;
        }

        private void consultarUsuáriosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ListarUsuarios listarUsuarios = new ListarUsuarios();
            listarUsuarios.Show();
            listarUsuarios.MdiParent = this;
        }
    }
}
