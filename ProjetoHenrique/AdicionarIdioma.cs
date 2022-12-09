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
    public partial class AdicionarIdioma : Form
    {
        int id;
        int us;
        public AdicionarIdioma(int id)
        {
            us = id;
            InitializeComponent();
        }

        public AdicionarIdioma(int id, string nome)
        {
            InitializeComponent();
            label1.Text = "Alterar Idioma";
            label2.Visible = false;
            addButton.Text = "Alterar";
            nomeTextBox.Text = nome;
            this.id = id;
            //this.nome = nome;
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            IdiomaDAO idmdao = new IdiomaDAO();

            if(addButton.Text == "Adicionar")
            {
                try
                {
                    Idioma idm = new Idioma(nomeTextBox.Text);
                    idmdao.Inserir(idm.Nome, us);
                    MessageBox.Show("Idioma inserido com sucesso!");
                    this.Close();
                }
                catch (Exception err)
                {
                    MessageBox.Show("Erro ao inserir idioma!\n" + err);
                }
            }
            else
            {
                try
                {
                    Idioma idm = new Idioma(id, nomeTextBox.Text);
                    
                    idmdao.Alterar(idm);
                    MessageBox.Show("Idioma alterado com sucesso!");
                    this.Close();
                }
                catch (Exception err)
                {
                    MessageBox.Show("Erro ao inserir idioma!\n" + err);
                }
            }
        }
    }
}
