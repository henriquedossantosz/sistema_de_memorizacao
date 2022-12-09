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
    public partial class TelaLogin : Form
    {
        public TelaLogin()
        {
            InitializeComponent();
        }

        private void entrarButton_Click(object sender, EventArgs e)
        {
            if(usuarioTextBox.Text == "" || senhaTextBox.Text == "")
            {
                MessageBox.Show("Insira usuário e senha!");
            }
            else
            {
                Controle ctl = new Controle();
                ctl.Acessar(usuarioTextBox.Text, senhaTextBox.Text);
                if (ctl.Mensagem.Equals(""))
                {
                    if (!ctl.Acesso)
                    {
                        MessageBox.Show("Login não encontrado, verifique login e senha", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    }
                    else
                    {
                        Controle cc = new Controle();
                        TelaInicial frmIni = new TelaInicial(cc.RetornaId(usuarioTextBox.Text, senhaTextBox.Text));
                        this.Hide();
                        frmIni.ShowDialog();
                        this.Close();
                    }
                }
                else
                {
                    MessageBox.Show(ctl.Mensagem);
                }
            }
        }

        private void cadastrarButton_Click(object sender, EventArgs e)
        {
            Cadastrar telaCadastro = new Cadastrar();
            telaCadastro.Show();
        }
    }
}
