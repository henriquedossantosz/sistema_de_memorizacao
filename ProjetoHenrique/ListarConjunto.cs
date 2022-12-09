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
    public partial class ListarConjunto : Form
    {
        //id usuario
        int us;
        int codioma;
        public ListarConjunto(int id)
        {
            us = id;
            InitializeComponent();
            AtualizarListView();
            AtualizarComboBox();
            praticarButton.Visible = false;
            infoButton.Visible = false;
            excluirButton.Visible = false;
            atualizarButton.Visible = false;
            hojeLabel.Text = DateTime.Now.ToString("dd/MM/yyyy");
        }
        private void AtualizarListView()
        {
            CRListView.Items.Clear();
            ConjuntoRevisaoDAO crDAO = new ConjuntoRevisaoDAO();
            CardsDAO cardsDAO = new CardsDAO();

            List<ConjuntoRevisao> crl = crDAO.ListarConjuntos(us);
            if (crl.Count > 0)
            {
                foreach (var user in crl)
                {
                    ListViewItem lv = new ListViewItem(user.Id.ToString());
                    lv.SubItems.Add(user.Nome);
                    lv.SubItems.Add(user.Descricao);
                    lv.SubItems.Add(user.Idioma);
                    CRListView.Items.Add(lv);
                }
            }
        }

        private void AtualizarComboBox()
        {
            IdiomaDAO idm = new IdiomaDAO();
            List<Idioma> listidms = idm.ListarIdiomas(us);

            if (listidms.Count > 0)
            {
                foreach (var i in listidms)
                {
                    idiomaComboBox.Items.Add(i.Nome);
                }
            }
        }

        private void ListarConjunto_Load(object sender, EventArgs e)
        {

        }

        private void praticarButton_Click(object sender, EventArgs e)
        {
            int index = CRListView.FocusedItem.Index;
            int id = int.Parse(CRListView.Items[index].SubItems[0].Text);

            this.Visible = false;
            Revisar telaRvisar = new Revisar(id);
            telaRvisar.ShowDialog();
            this.Visible = true;
            AtualizarListView();
        }

        private void CRListView_SelectedIndexChanged(object sender, EventArgs e)
        {
            //praticarButton.Visible = true;
        }

        private void CRListView_ItemActivate(object sender, EventArgs e)
        {
            //praticarButton.Visible = true;
            //infoButton.Visible = true;
        }

        private void infoButton_Click(object sender, EventArgs e)
        {
            int index = CRListView.FocusedItem.Index;
            int id = int.Parse(CRListView.Items[index].SubItems[0].Text);
            string nome = CRListView.Items[index].SubItems[1].Text;
            string idioma = CRListView.Items[index].SubItems[3].Text;

            this.Visible = false;
            InfoConjunto telaInfo = new InfoConjunto(id, nome, idioma);
            telaInfo.ShowDialog();
            this.Visible = true;
            AtualizarListView();
        }

        private void addCRbutton_Click(object sender, EventArgs e)
        {
            AdicionarConjunto telaAdd = new AdicionarConjunto(us);
            telaAdd.ShowDialog();
            AtualizarListView();
        }

        private void CRListView_MouseClick(object sender, MouseEventArgs e)
        {
            praticarButton.Visible = true;
            infoButton.Visible = true;
            excluirButton.Visible = true;
            atualizarButton.Visible = true;
        }

        private void addFCutton_Click(object sender, EventArgs e)
        {

        }

        private void excluirButton_Click(object sender, EventArgs e)
        {
            const string message = "Tem certeza que deseja excluir o conjunto de revisão, incluindo todos os Flash Cards contidos?";
            const string caption = "Excluir Conjunto de Revisão.";

            var result = MessageBox.Show(message, caption, MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning);

            if (result == DialogResult.Yes)
            {
                int index = CRListView.FocusedItem.Index;
                int id = int.Parse(CRListView.Items[index].SubItems[0].Text);

                ConjuntoRevisaoDAO cj = new ConjuntoRevisaoDAO();
                cj.Excluir(id);
                AtualizarListView();
            }
        }

        private void atualizarButton_Click(object sender, EventArgs e)
        {
            int index = CRListView.FocusedItem.Index;
            int id = int.Parse(CRListView.Items[index].SubItems[0].Text);
            string nome = CRListView.Items[index].SubItems[1].Text;
            string descricao = CRListView.Items[index].SubItems[2].Text;
            string idioma = CRListView.Items[index].SubItems[3].Text;

            AdicionarConjunto telaAlter= new AdicionarConjunto(id, idioma, nome, descricao);
            telaAlter.ShowDialog();
            AtualizarListView();
        }

        private void idiomaComboBox_TextChanged(object sender, EventArgs e)
        {
            IdiomaDAO idmDao = new IdiomaDAO();
            List<Idioma> idm = idmDao.ListarIdiomas(us);

            foreach (var cj in idm)
            {
                if (cj.Nome == idiomaComboBox.Text)
                    codioma = cj.Id;
            }

            if(idiomaComboBox.Text == "")
            {
                AtualizarListView();
            }
            else
            {
                CRListView.Items.Clear();
                ConjuntoRevisaoDAO crDAO = new ConjuntoRevisaoDAO();

                List<ConjuntoRevisao> crl = crDAO.FiltrarConjuntos(codioma);
                if (crl.Count > 0)
                {
                    foreach (var user in crl)
                    {
                        ListViewItem lv = new ListViewItem(user.Id.ToString());
                        lv.SubItems.Add(user.Nome);
                        lv.SubItems.Add(user.Descricao);
                        lv.SubItems.Add(user.Idioma);
                        CRListView.Items.Add(lv);
                    }
                }
            }

            /*CRListView.Items.Clear();
            ConjuntoRevisaoDAO crDAO = new ConjuntoRevisaoDAO();

            List<ConjuntoRevisao> crl = crDAO.FiltrarConjuntos(codioma);
            if (crl.Count > 0)
            {
                foreach (var user in crl)
                {
                    ListViewItem lv = new ListViewItem(user.Id.ToString());
                    lv.SubItems.Add(user.Nome);
                    lv.SubItems.Add(user.Descricao);
                    lv.SubItems.Add(user.Idioma);
                    CRListView.Items.Add(lv);
                }
            }*/
        }

        private void sairButton_Click(object sender, EventArgs e)
        {
            this.Close(); 
        }
    }
}
