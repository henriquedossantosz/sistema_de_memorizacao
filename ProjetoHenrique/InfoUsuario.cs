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
    public partial class InfoUsuario : Form
    {
        int id;
        Usuarios user;
        public InfoUsuario(int id)
        {
            this.id = id;
            InitializeComponent();
            RetornaUsuario();
            DesativarTudo();
        }

        public void DesativarTudo()
        {
            nomeTextBox.Enabled = false;
            emailTextBox.Enabled = false;
            celMaskedTextBox.Enabled = false;
            cpfMaskedTextBox.Enabled = false;
            cpfMaskedTextBox.Enabled = false;
            nomeuserTextBox.Enabled = false;
            senhaTextBox.Enabled = false;
            confTextBox.Enabled = false;
            nascimentoDateTimePicker.Enabled = false;
            salvarButton.Visible = false;
            destravarButton.Visible = true;
        }

        public void AtivarTudo()
        {
            nomeTextBox.Enabled = true;
            emailTextBox.Enabled = true;
            celMaskedTextBox.Enabled = true;
            cpfMaskedTextBox.Enabled = true;
            cpfMaskedTextBox.Enabled = true;
            nomeuserTextBox.Enabled = true;
            senhaTextBox.Enabled = true;
            confTextBox.Enabled = true;
            nascimentoDateTimePicker.Enabled = true;
            destravarButton.Visible = false;
        }

        public void RetornaUsuario()
        {
            UsuariosDAO usuariosDAO = new UsuariosDAO();

            try
            {
                user = usuariosDAO.RetornaUsuario(id);
                nomeTextBox.Text = user.Nome;
                emailTextBox.Text = user.Email;
                celMaskedTextBox.Text = user.Telefone;
                cpfMaskedTextBox.Text = user.CPF;
                nomeuserTextBox.Text = user.User;
                senhaTextBox.Text = user.Senha;
                nascimentoDateTimePicker.Value = user.Nascimento;
            }
            catch(Exception err)
            {
                MessageBox.Show("Erro ao retornar usuário.\n" + err);
            }
        }

        private void destravarButton_Click(object sender, EventArgs e)
        {
            AtivarTudo();
            salvarButton.Visible = true;
        }

        private void salvarButton_Click(object sender, EventArgs e)
        {
            if(VrificarSenhas())
            {
                try
                {
                    Usuarios atualizado = new Usuarios(id, nomeTextBox.Text, emailTextBox.Text, celMaskedTextBox.Text, cpfMaskedTextBox.Text, nomeuserTextBox.Text, nascimentoDateTimePicker.Value, senhaTextBox.Text);

                    UsuariosDAO usuariosdao = new UsuariosDAO();
                    usuariosdao.Alterar(atualizado);
                    DesativarTudo();
                }
                catch (Exception err)
                {
                    throw new Exception("Erro ao atualizar\n" + err);
                }
            }
            else
            {
                MessageBox.Show("Senhas não combinam!");
            }

        }

        private void verCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (verCheckBox.Checked)
            {
                senhaTextBox.PasswordChar = '\0';
                confTextBox.PasswordChar = '\0';
            }
            else
            {
                senhaTextBox.PasswordChar = '*';
                confTextBox.PasswordChar = '*';
            }
        }

        public bool VrificarSenhas()
        {
            if (senhaTextBox.Text == confTextBox.Text)
                return true;
            else
                return false;
        }

        private void sairButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
