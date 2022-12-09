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
    public partial class ListarUsuarios : Form
    {
        public ListarUsuarios()
        {
            InitializeComponent();
            CarregarListView();
        }

        public void CarregarListView()
        {
            try
            {
                AtualizarListView();
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message, "AVISO DE ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void UsuariosListView_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateBbutton.Visible = true;
            ExcluirButton.Visible = true;
        }

        private void LimparCB()
        {
            comboBox1.Items.Clear();
            comboBox2.Items.Clear();
            comboBox3.Items.Clear();
            comboBox4.Items.Clear();
            comboBox5.Items.Clear();
        }

        private void AtualizarListView()
        {
            UsuariosListView.Items.Clear();
            LimparCB();
            UsuariosDAO usuarioDao = new UsuariosDAO();

            List<Usuarios> usuarios = usuarioDao.GerarListaUsuarios("SELECT * FROM Usuarios");
            if (usuarios.Count > 0)
            {
                foreach (var user in usuarios)
                {
                    ListViewItem lv = new ListViewItem(user.Id.ToString());
                    lv.SubItems.Add(user.Nome);
                    lv.SubItems.Add(user.Email);
                    lv.SubItems.Add(user.Telefone);
                    lv.SubItems.Add(user.User);

                    comboBox1.Items.Add(user.Id);
                    comboBox2.Items.Add(user.Nome);
                    comboBox3.Items.Add(user.Email);
                    comboBox4.Items.Add(user.Telefone);
                    comboBox5.Items.Add(user.User);

                    UsuariosListView.Items.Add(lv);  
                }
            }
        }

        private void ListarUsuarios_Load (object sender, EventArgs e)
        {
            try
            {
                AtualizarListView();
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message, "AVISO DE ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void CadastrarButton_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            Cadastrar telaCadastro = new Cadastrar();
            telaCadastro.ShowDialog();
            this.Visible = true;
            CarregarListView();
        }

        private void ListarUsuarios_Load_1(object sender, EventArgs e)
        {
            UpdateBbutton.Visible = false;
            ExcluirButton.Visible = false;
        }

        private void ExcluirButton_Click(object sender, EventArgs e)
        {
            int index = UsuariosListView.FocusedItem.Index;
            int id = int.Parse(UsuariosListView.Items[index].SubItems[0].Text);
            UsuariosDAO usuarioExcluir = new UsuariosDAO();
            usuarioExcluir.Excluir(id);
            CarregarListView();
        }

        private void UpdateBbutton_Click(object sender, EventArgs e)
        {
            //this.Visible = false;

            int index = UsuariosListView.FocusedItem.Index;
            int id = int.Parse(UsuariosListView.Items[index].SubItems[0].Text);
            string Nome = UsuariosListView.Items[index].SubItems[1].Text;
            string Email = UsuariosListView.Items[index].SubItems[2].Text;
            string Telefone = UsuariosListView.Items[index].SubItems[3].Text;
            string Usuario = UsuariosListView.Items[index].SubItems[4].Text;

            Cadastrar telaCadastro = new Cadastrar(id, Nome, Email, Telefone, Usuario);
            telaCadastro.ShowDialog();
            this.Visible = true;
            CarregarListView();
        }

        private void filtrarButton_Click(object sender, EventArgs e)
        {

        }

        //Apagar daqui pra baixo

        private void FiltarFunction()
        {
            string tx1 = comboBox2.Text, tx2 = comboBox3.Text, tx3 = comboBox4.Text, tx4 = comboBox5.Text;

            //Adicionar sugestão do Gabriel, caso seja vazio, listar tudo.

            string selecao = "SELECT * FROM Usuarios where ";

            if (!String.IsNullOrEmpty(comboBox1.Text))
            {
                selecao = selecao + "id = " + comboBox1.Text + " ";
            }

            if (!String.IsNullOrEmpty(comboBox2.Text))
            {
                if (selecao == "SELECT * FROM Usuarios where ")
                {
                    selecao = selecao + $"Nome = '{tx1}' ";
                }
                else
                {
                    selecao = selecao + $"and Nome = '{tx1}' ";
                }
            }

            if (!String.IsNullOrEmpty(comboBox3.Text))
            {
                if (selecao == "SELECT * FROM Usuarios where ")
                {
                    selecao = selecao + $"Email = '{tx2}' ";
                }
                else
                {
                    selecao = selecao + $"and Email = '{tx2}' ";
                }
            }

            if (!String.IsNullOrEmpty(comboBox4.Text))
            {
                if (selecao == "SELECT * FROM Usuarios where ")
                {
                    selecao = selecao + $"Telefone = '{tx3}' ";
                }
                else
                {
                    selecao = selecao + $"and Telefone = '{tx3}' ";
                }
            }

            if (!String.IsNullOrEmpty(comboBox5.Text))
            {
                if (selecao == "SELECT * FROM Usuarios where ")
                {
                    selecao = selecao + $"NomeUsuario = '{tx4}' ";
                }
                else
                {
                    selecao = selecao + $"and NomeUsuario = '{tx4}' ";
                }
            }

            UsuariosListView.Items.Clear();

            UsuariosDAO usuarioDao = new UsuariosDAO();

            List<Usuarios> usuarios = usuarioDao.GerarListaUsuarios(selecao);
            if (usuarios.Count > 0)
            {
                foreach (var user in usuarios)
                {
                    ListViewItem lv = new ListViewItem(user.Id.ToString());
                    lv.SubItems.Add(user.Nome);
                    lv.SubItems.Add(user.Email);
                    lv.SubItems.Add(user.Telefone);
                    lv.SubItems.Add(user.User);
                    UsuariosListView.Items.Add(lv);
                }
            }
        }

        //Apagar daqui pra cima

        private void LimparFiltrobutton_Click(object sender, EventArgs e)
        {
            LimparCB();
            AtualizarListView();
            //comboBox1.Text = " ";
        }

        private void comboBox1_TextChanged(object sender, EventArgs e)
        {
            //fu~ção de pesuisa
            FiltarFunction();
        }

        private void comboBox2_TextChanged(object sender, EventArgs e)
        {
            FiltarFunction();
        }

        private void comboBox3_TextChanged(object sender, EventArgs e)
        {
            FiltarFunction();
        }

        private void comboBox4_TextChanged(object sender, EventArgs e)
        {
            FiltarFunction();
        }

        private void comboBox5_TextChanged(object sender, EventArgs e)
        {
            FiltarFunction();
        }

        private void PesquisaTextBox_TextChanged(object sender, EventArgs e)
        {

            string strPesquisa = PesquisaTextBox.Text; 
            string selecao = $"SELECT * FROM Usuarios where Nome like '%{strPesquisa}%' or Email like '%{strPesquisa}%' or Celular like '%{strPesquisa}%'" +
                $" or NomeUsuario like '%{strPesquisa}%'";

            UsuariosListView.Items.Clear();

            UsuariosDAO usuarioDao = new UsuariosDAO();

            List<Usuarios> usuarios = usuarioDao.GerarListaUsuarios(selecao);
            if (usuarios.Count > 0)
            {
                foreach (var user in usuarios)
                {
                    ListViewItem lv = new ListViewItem(user.Id.ToString());
                    lv.SubItems.Add(user.Nome);
                    lv.SubItems.Add(user.Email);
                    lv.SubItems.Add(user.Telefone);
                    lv.SubItems.Add(user.User);
                    UsuariosListView.Items.Add(lv);
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
