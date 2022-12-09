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
    public partial class ListarIdiomas : Form
    {
        int us;
        int cidm;
        public ListarIdiomas(int id)
        {
            us = id;
            InitializeComponent();
            AtualizarListViewIdioma();
        }

        public void AtualizarListViewIdioma()
        {
            idiomaListView.Items.Clear();
            IdiomaDAO idmdao = new IdiomaDAO();

            List<Idioma> idiomas = idmdao.ListarIdiomas(us);

            if(idiomas.Count > 0)
            {
                foreach(var idm in idiomas)
                {
                    ListViewItem lv = new ListViewItem(idm.Id.ToString());
                    lv.SubItems.Add(idm.Nome);

                    idiomaListView.Items.Add(lv);
                }
            }
        }

        public void AtualizarListViewCR()
        {
            crListView.Items.Clear();
            ConjuntoRevisaoDAO crdao = new ConjuntoRevisaoDAO();

            List<CRAuxiliar> listacr = crdao.ContarCards(cidm);

            if (listacr.Count > 0)
            {
                foreach(var cr in listacr)
                {
                    ListViewItem lv = new ListViewItem(cr.codcr.ToString());
                    lv.SubItems.Add(cr.conjunto);
                    lv.SubItems.Add(cr.contagem.ToString());

                    crListView.Items.Add(lv);
                }
            }
        }

        public void AtualizarListPalavra()
        {
            palavraListView.Items.Clear();
            PalavraDAO plvdao = new PalavraDAO();

            List<Palavra> listaplv = plvdao.GerarListaPalavra("select Codigo_Palavra, Nome_Idioma, Palavra_Texto, Definicao, Palavra_Pronuncia, Palavra_Animo, Palavra_Utilidade, ((Palavra_Animo + Palavra_Utilidade)/2) as 'Relevancia', Classificacao, Morfologia, Fonte, Tema, Observacao, FK_Codigo_Idioma from Palavra inner join Idioma on Codigo_Idioma = FK_Codigo_Idioma where FK_Codigo_Idioma = " + cidm);

            if(listaplv.Count > 0)
            {
                foreach(var plv in listaplv)
                {
                    ListViewItem lv = new ListViewItem(plv.Id.ToString());
                    lv.SubItems.Add(plv.Texto);
                    lv.SubItems.Add(plv.Definicao);
                    lv.SubItems.Add(plv.Morfologia);

                    palavraListView.Items.Add(lv);
                }
            }
        }

        private void adicionarButton_Click(object sender, EventArgs e)
        {
            AdicionarIdioma adicionar = new AdicionarIdioma(us);
            adicionar.ShowDialog();
            AtualizarListViewIdioma();
        }

        private void idiomaListView_Click(object sender, EventArgs e)
        {
            int index = idiomaListView.FocusedItem.Index;
            cidm = int.Parse(idiomaListView.Items[index].SubItems[0].Text);

            AtualizarListViewCR();
            AtualizarListPalavra();
        }

        private void alterarButton_Click(object sender, EventArgs e)
        {
            int index = idiomaListView.FocusedItem.Index;
            cidm = int.Parse(idiomaListView.Items[index].SubItems[0].Text);
            string nome = idiomaListView.Items[index].SubItems[1].Text;

            AdicionarIdioma adicionar = new AdicionarIdioma(cidm, nome);
            adicionar.ShowDialog();
            AtualizarListViewIdioma();
        }

        private void excluirButton_Click(object sender, EventArgs e)
        {
            const string message = "Tem certeza que deseja excluir o idioma selecionado?";
            const string caption = "Excluir idioma.";

            var result = MessageBox.Show(message, caption, MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning);

            if (result == DialogResult.Yes)
            {
                int index = idiomaListView.FocusedItem.Index;
                int id = int.Parse(idiomaListView.Items[index].SubItems[0].Text);

                IdiomaDAO idmdao = new IdiomaDAO();

                try
                {
                    idmdao.Excluir(id);
                    AtualizarListViewIdioma();
                }
                catch(Exception err)
                {
                    MessageBox.Show("Erro ao excluir idioma\n" + err);
                }
            }
        }

        private void sairButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

