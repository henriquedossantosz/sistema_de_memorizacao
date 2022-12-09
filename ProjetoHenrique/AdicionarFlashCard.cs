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
    public partial class AdicionarFlashCard : Form
    {
        int crid, id;
        int us;
        public AdicionarFlashCard(int id)
        {
            us = id;
            InitializeComponent();
            AtualizarComboBox();
        }

        public AdicionarFlashCard(string nomecr)
        {
            InitializeComponent();
            AtualizarComboBox();
            crComboBox.Text = nomecr;
        }

        public AdicionarFlashCard(int id, string nomecr, string frente, string verso)
        {
            InitializeComponent();
            AtualizarComboBox();
            crComboBox.Text = nomecr;
            frenteTextBox.Text = frente;
            versoTextBox.Text = verso;
            this.id = id;
            adicionarBbutton.Text = "Atualizar";
        }

        private void limparButton_Click(object sender, EventArgs e)
        {
            const string message = "Deseja limpar todos os campos?";
            const string caption = "Limpar todos os campos";

            var result = MessageBox.Show(message, caption, MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning);

            if (result == DialogResult.Yes)
            {
                crComboBox.Text = "";
                frenteTextBox.Text = "";
                versoTextBox.Text = "";
            }
        }

        public void AtualizarComboBox()
        {
            ConjuntoRevisaoDAO conjuntoDao = new ConjuntoRevisaoDAO();

            List<ConjuntoRevisao> conjuntoRevisaos = conjuntoDao.ListarConjuntos(us);
            if(conjuntoRevisaos.Count>0)
            {
                foreach(var c in conjuntoRevisaos)
                {
                    crComboBox.Items.Add(c.Nome);
                }
            }
        }

        private void crComboBox_TextChanged(object sender, EventArgs e)
        {
            ConjuntoRevisaoDAO cjDao = new ConjuntoRevisaoDAO();
            List<ConjuntoRevisao> cjr = cjDao.ListarConjuntos(us);

            foreach (var cj in cjr)
            {
                if (cj.Nome == crComboBox.Text)
                    crid = cj.Id;
            }
        }

        private void adicionarBbutton_Click(object sender, EventArgs e)
        {
            if(adicionarBbutton.Text == "Adicionar")
            {
                try
                {
                    Cards carta = new Cards(frenteTextBox.Text, versoTextBox.Text, DateTime.Now, DateTime.Now, 0, 0, 1, crid);
                    CardsDAO cardsDAO = new CardsDAO();
                    cardsDAO.Inserir(carta);
                    MessageBox.Show("Flash Card inserido com sucesso");
                    this.Close();
                }
                catch (Exception err)
                {
                    MessageBox.Show("Problemas ao inserir Flash Card! " + err);
                }
            }
            else
            {
                try
                {
                    Cards carta = new Cards(id, frenteTextBox.Text, versoTextBox.Text, DateTime.Now, DateTime.Now, 0, 0, 1, crid);
                    CardsDAO cardsDAO = new CardsDAO();
                    cardsDAO.Atualizar(carta);
                    MessageBox.Show("Flash Card atualizado com sucesso");
                    this.Close();
                }
                catch (Exception err)
                {
                    MessageBox.Show("Problemas ao inserir Flash Card! " + err);
                }
            }
        }
    }
}
