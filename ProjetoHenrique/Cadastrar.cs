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
    public partial class Cadastrar : Form
    {
        int id;
        public Cadastrar()
        {
            InitializeComponent();
            //InserirButton.Text = "Inserir";
        }

        public Cadastrar(int id, string Nome, string Email, string Telefone, string Usuario)
        {
            InitializeComponent();
            NomeCompletoTextBox.Text = Nome;
            EmailTextBox.Text = Email;
            celMaskedTextBox.Text = Telefone;
            UsuarioTextBox.Text = Usuario;
            InserirButton.Text = "Alterar";
            this.id = id;
        }

        private void Limpar()
        {
            NomeCompletoTextBox.Clear();
            EmailTextBox.Clear();
            celMaskedTextBox.Clear();
            UsuarioTextBox.Clear();
            senhaTextBox.Clear();
            celMaskedTextBox.Clear();
            cpfMaskedTextBox.Clear();
            confTextBox.Clear();
            nascimentoDateTimePicker.Value = DateTime.Now;
        }

        public bool VerificarSenhas()
        {
            if (senhaTextBox.Text == confTextBox.Text)
                return true;
            else
                return false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(VerificarSenhas())
            {
                if (InserirButton.Text == "Inserir")
                {
                    try
                    {
                        Usuarios usuario = new Usuarios(NomeCompletoTextBox.Text, EmailTextBox.Text, celMaskedTextBox.Text, cpfMaskedTextBox.Text, UsuarioTextBox.Text, nascimentoDateTimePicker.Value, senhaTextBox.Text);
                        UsuariosDAO usuarioInserir = new UsuariosDAO();
                        usuarioInserir.Inserir(usuario);
                        MessageBox.Show("Usuário " + usuario.Nome + " inserido com sucesso!", "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Limpar();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    try
                    {
                        Usuarios usuario = new Usuarios(id, NomeCompletoTextBox.Text, EmailTextBox.Text, celMaskedTextBox.Text, cpfMaskedTextBox.Text, UsuarioTextBox.Text, nascimentoDateTimePicker.Value, senhaTextBox.Text);
                        UsuariosDAO usuarioAlterar = new UsuariosDAO();
                        usuarioAlterar.Alterar(usuario);
                        MessageBox.Show("Usuário " + usuario.Nome + " atualizado com sucesso!", "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Limpar();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else
            {
                MessageBox.Show("Senhas não combinam!");
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void LimparButton_Click(object sender, EventArgs e)
        {
            Limpar();
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
    }
}
