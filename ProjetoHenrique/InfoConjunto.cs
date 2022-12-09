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
    public partial class InfoConjunto : Form
    {
        int idd;
        string crnome;
        public InfoConjunto(int id, string nome, string idioma)
        {
            InitializeComponent();
            conjuntoLabel.Text = "Conjunto: " + nome + ", " + idioma + ".";
            idd = id;
            crnome = nome;
            AtualizarListView();
        }

        private void AtualizarListView()
        {
            //MessageBox.Show("Entrou");
            flashCardListView.Items.Clear();
            CardsDAO cdDAO = new CardsDAO();

            List<Cards> crl = cdDAO.ListarCards(idd);
            if (crl.Count > 0)
            {
                foreach (var car in crl)
                {
                    ListViewItem lv = new ListViewItem(car.Id.ToString());
                    lv.SubItems.Add(car.Frente);
                    lv.SubItems.Add(car.Verso);
                    lv.SubItems.Add(car.ProxRevisao.ToString("dd/MM/yyyy"));
                    lv.SubItems.Add(car.Criacao.ToString("dd/MM/yyyy"));
                    lv.SubItems.Add(car.Acerto.ToString());
                    lv.SubItems.Add(car.Erro.ToString());
                    flashCardListView.Items.Add(lv);
                }
            }
        }

        private void InfoConjunto_Load(object sender, EventArgs e)
        {

        }

        private void addFCbutton_Click(object sender, EventArgs e)
        {
            AdicionarFlashCard telaadicionar = new AdicionarFlashCard(crnome);
            telaadicionar.ShowDialog();
            AtualizarListView();
        }

        private void praticarButton_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            Revisar telaRevisar = new Revisar(idd);
            telaRevisar.ShowDialog();
            this.Visible = true;
            AtualizarListView();
        }

        private void sairButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void AtualizarButton_Click(object sender, EventArgs e)
        {
            int index = flashCardListView.FocusedItem.Index;

            int id = int.Parse(flashCardListView.Items[index].SubItems[0].Text);
            string frente = flashCardListView.Items[index].SubItems[1].Text;
            string verso = flashCardListView.Items[index].SubItems[2].Text;

            AdicionarFlashCard addfctela = new AdicionarFlashCard(id, crnome, frente, verso);
            addfctela.ShowDialog();
            AtualizarListView();
        }

        private void excluirButton_Click(object sender, EventArgs e)
        {
            const string message = "Tem certeza que deseja excluir o flash card selecionado?";
            const string caption = "Excluir Flash Card.";

            var result = MessageBox.Show(message, caption, MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning);

            if (result == DialogResult.Yes)
            {
                int index = flashCardListView.FocusedItem.Index;
                int id = int.Parse(flashCardListView.Items[index].SubItems[0].Text);

                CardsDAO cj = new CardsDAO();
                cj.Excluir(id);
                AtualizarListView();
            }
        }
    }
}
