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
    public partial class Entrar : Form
    {
        public Entrar()
        {
            InitializeComponent();
        }

        private void Entrar_Load(object sender, EventArgs e)
        {

        }

        private void CadastrarButton_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            Cadastrar telinha = new Cadastrar();
            telinha.ShowDialog();
            this.Visible = true;
        }

        private void EntrarButton_Click(object sender, EventArgs e)
        {
            UsuariosDAO usuario = new UsuariosDAO();
            usuario.Logar(UsuarioTextBox.Text, SenhaTextBox.Text);
        }
    }
}
