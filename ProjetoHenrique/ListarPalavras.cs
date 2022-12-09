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
    public partial class ListarPalavras : Form
    {
        static int us = 0;

        string padrao;
        string select;
        public ListarPalavras(int id)
        {
            us = id;
            InitializeComponent();
            Inicializar();
        }

        public void Inicializar()
        {
            padrao = $"select Codigo_Palavra, Nome_Idioma, Palavra_Texto, Definicao, Palavra_Pronuncia, Palavra_Animo, Palavra_Utilidade, ((Palavra_Animo + Palavra_Utilidade)/2) as 'Relevancia', Classificacao, Morfologia, Fonte, Tema, Observacao, FK_Codigo_Idioma from Palavra inner join Idioma on Codigo_Idioma = FK_Codigo_Idioma and Idioma.FK_Codigo_Estudante = " + us;

            try
            {
                atualizarButton.Visible = false;
                excluirButton.Visible = false;
                AtualizarListView();
                AtualizarIdiomas();
                select = padrao;
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message, "AVISO DE ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void AtualizarListView()
        {
            PalavrasListView.Items.Clear();
            PalavraDAO palavraDao = new PalavraDAO();

            List<Palavra> plvs = palavraDao.GerarListaPalavra(padrao + " order by Relevancia desc");
            if (plvs.Count > 0)
            {
                foreach (var user in plvs)
                {
                    ListViewItem lv = new ListViewItem(user.Id.ToString());
                    lv.SubItems.Add(user.Idioma);
                    lv.SubItems.Add(user.Texto);
                    lv.SubItems.Add(user.Definicao);
                    lv.SubItems.Add(user.Pronuncia);
                    lv.SubItems.Add(user.Animo.ToString());
                    lv.SubItems.Add(user.Utilidade.ToString());
                    lv.SubItems.Add(user.Relevancia.ToString());
                    lv.SubItems.Add(user.Classificacao);
                    lv.SubItems.Add(user.Morfologia);
                    lv.SubItems.Add(user.Fonte);
                    lv.SubItems.Add(user.Tema);
                    lv.SubItems.Add(user.Observacao);

                    PalavrasListView.Items.Add(lv);
                }
            }
        }
        private void AtualizarIdiomas()
        {
            IdiomaDAO idm = new IdiomaDAO();
            List<Idioma> listidms = idm.ListarIdiomas(us);

            if(listidms.Count > 0)
            {
                foreach(var i in listidms)
                {
                    idiomaComboBox.Items.Add(i.Nome);
                }
            }
        }
    
        private void pesquisaTextBox_Enter(object sender, EventArgs e)
        {

        }

        protected void pesquisaTextBox_SetText()
        {
            this.pesquisaTextBox.Text = "Pesquisar: palavra, definição, tema, observação, etc...";
            pesquisaTextBox.ForeColor = Color.Gray;
        }

        private void pesquisaTextBox_Leave(object sender, EventArgs e)
        {
            if (pesquisaTextBox.Text.Trim() == "")
                pesquisaTextBox_SetText();
            if (pesquisaTextBox.Text == "Pesquisar: palavra, definição, tema, observação, etc...")
                AtualizarListView();
        }

        protected void pesquisaTextBox_Focus(object sender, EventArgs e)
        {
            if (pesquisaTextBox.ForeColor == Color.Black)
                return;
            pesquisaTextBox.Text = "";
            pesquisaTextBox.ForeColor = Color.Black;
        }
        private void ListarPalavras_Load(object sender, EventArgs e)
        {
            this.pesquisaTextBox.GotFocus += new EventHandler(pesquisaTextBox_Focus);
            this.pesquisaTextBox.Leave += new EventHandler(pesquisaTextBox_Leave);
            pesquisaTextBox_SetText();
        }

        private void pesquisaTextBox_TextChanged(object sender, EventArgs e)
        {
            if(pesquisaTextBox.ForeColor == Color.Black && pesquisaTextBox.Text !="")
            {
                FiltarFunction();
                /*string strPesquisa = pesquisaTextBox.Text;
                string selecao = padrao +
                    $" WHERE Palavra_Texto LIKE N'%{strPesquisa}%' OR Definicao LIKE '%{strPesquisa}%'" +
                    $" OR Palavra_Pronuncia LIKE '%{strPesquisa}%' OR Fonte LIKE '%{strPesquisa}%' OR Tema LIKE '%{strPesquisa}%' OR Observacao LIKE '%{strPesquisa}%'";
                PalavrasListView.Items.Clear();

                PalavraDAO plv = new PalavraDAO();

                List<Palavra> pvls = plv.GerarListaPalavra(selecao);
                if (pvls.Count > 0)
                {
                    foreach (var user in pvls)
                    {
                        ListViewItem lv = new ListViewItem(user.Id.ToString());
                        lv.SubItems.Add(user.Idioma);
                        lv.SubItems.Add(user.Texto);
                        lv.SubItems.Add(user.Definicao);
                        lv.SubItems.Add(user.Pronuncia);
                        lv.SubItems.Add(user.Animo.ToString());
                        lv.SubItems.Add(user.Utilidade.ToString());
                        lv.SubItems.Add(user.Relevancia.ToString());
                        lv.SubItems.Add(user.Classificacao);
                        lv.SubItems.Add(user.Morfologia);
                        lv.SubItems.Add(user.Fonte);
                        lv.SubItems.Add(user.Tema);
                        lv.SubItems.Add(user.Observacao);

                        PalavrasListView.Items.Add(lv);
                    }
                }*/
            }
        }
        private void FiltarFunction()
        {
            string str1 = pesquisaTextBox.Text, str2 = morfologiaComboBox.Text, str3 = classificacaoComboBox.Text;

            string selecao = padrao + " where ";
            if (!String.IsNullOrEmpty(idiomaComboBox.Text))
            {
                IdiomaDAO idm = new IdiomaDAO();
                List<Idioma> listidms = idm.ListarIdiomas(us);

                if (listidms.Count > 0)
                {
                    foreach (var i in listidms)
                    {
                        if(i.Nome == idiomaComboBox.Text)
                        {
                            selecao = selecao + "FK_Codigo_Idioma = " + i.Id + " ";
                        }
                    }
                }
            }
            if (!String.IsNullOrEmpty(morfologiaComboBox.Text))
            {
                if (selecao == padrao + " where ")
                {
                    selecao = selecao + $"Morfologia like '{str2}' ";
                }
                else
                {
                    selecao = selecao + $"and Morfologia like '{str2}' ";
                }
            }
            if (!String.IsNullOrEmpty(classificacaoComboBox.Text))
            {
                if (selecao == padrao + " where ")
                {
                    selecao = selecao + $"Classificacao like '{str3}' ";
                }
                else
                {
                    selecao = selecao + $"and Classificacao like '{str3}' ";
                }
            }
            if(!String.IsNullOrEmpty(pesquisaTextBox.Text) && pesquisaTextBox.ForeColor == Color.Black)
            {
                if (selecao == padrao + " where ")
                {
                    selecao = selecao + $"Palavra_Texto LIKE N'%{str1}%' OR Definicao LIKE '%{str1}%'" +
                    $" OR Palavra_Pronuncia LIKE '%{str1}%' OR Fonte LIKE '%{str1}%' OR Tema LIKE '%{str1}%' " +
                    $"OR Observacao LIKE '%{str1}%'";
                }
                else
                {
                    selecao = selecao + $"and (Palavra_Texto LIKE N'%{str1}%' OR Definicao LIKE '%{str1}%'" +
                    $" OR Palavra_Pronuncia LIKE '%{str1}%' OR Fonte LIKE '%{str1}%' OR Tema LIKE '%{str1}%' " +
                    $"OR Observacao LIKE '%{str1}%')";
                }
            }

            PalavrasListView.Items.Clear();

            //MessageBox.Show(selecao);

            PalavraDAO palavraDao = new PalavraDAO();

            select = selecao + " and Idioma.FK_Codigo_Estudante = " + us;
            //MessageBox.Show(select);

            List<Palavra> plvs = palavraDao.GerarListaPalavra(selecao);
            if (plvs.Count > 0)
            {
                foreach (var user in plvs)
                {
                    ListViewItem lv = new ListViewItem(user.Id.ToString());
                    lv.SubItems.Add(user.Idioma);
                    lv.SubItems.Add(user.Texto);
                    lv.SubItems.Add(user.Definicao);
                    lv.SubItems.Add(user.Pronuncia);
                    lv.SubItems.Add(user.Animo.ToString());
                    lv.SubItems.Add(user.Utilidade.ToString());
                    lv.SubItems.Add(user.Relevancia.ToString());
                    lv.SubItems.Add(user.Classificacao);
                    lv.SubItems.Add(user.Morfologia);
                    lv.SubItems.Add(user.Fonte);
                    lv.SubItems.Add(user.Tema);
                    lv.SubItems.Add(user.Observacao);

                    PalavrasListView.Items.Add(lv);
                }
            }
        }

        private void idiomaComboBox_TextChanged(object sender, EventArgs e)
        {
            if (idiomaComboBox.Text != "")
                FiltarFunction();
            else
                AtualizarListView();
        }

        private void morfologiaComboBox_TextChanged(object sender, EventArgs e)
        {
            if(morfologiaComboBox.Text != "")
                FiltarFunction();
            else
                AtualizarListView();
        }

        private void classificacaoComboBox_TextChanged(object sender, EventArgs e)
        {
            if(classificacaoComboBox.Text != "")
                FiltarFunction();
            else
                AtualizarListView();
        }

        private void adicionarButton_Click(object sender, EventArgs e)
        {
            SalvarPalavras salvarPalavras = new SalvarPalavras(us);
            salvarPalavras.ShowDialog();
            this.Visible = true;
        }

        private void PalavrasListView_Click(object sender, EventArgs e)
        {
            atualizarButton.Visible = true;
            excluirButton.Visible = true;
        }

        private void atualizarButton_Click(object sender, EventArgs e)
        {
            //this.Visible = false;

            int index = PalavrasListView.FocusedItem.Index;
            int id = int.Parse(PalavrasListView.Items[index].SubItems[0].Text);
            string idioma = PalavrasListView.Items[index].SubItems[1].Text;
            string palavra = PalavrasListView.Items[index].SubItems[2].Text;
            string definicao = PalavrasListView.Items[index].SubItems[3].Text;
            string pronuncia = PalavrasListView.Items[index].SubItems[4].Text;
            int animo = Convert.ToInt32(PalavrasListView.Items[index].SubItems[5].Text);
            int utilidade = Convert.ToInt32(PalavrasListView.Items[index].SubItems[6].Text);
            string morfologia = PalavrasListView.Items[index].SubItems[9].Text;
            string fonte = PalavrasListView.Items[index].SubItems[10].Text;
            string tema = PalavrasListView.Items[index].SubItems[11].Text;
            string observacao = PalavrasListView.Items[index].SubItems[12].Text;
            string classificacao = PalavrasListView.Items[index].SubItems[8].Text;

            SalvarPalavras salvarPalavras = new SalvarPalavras(id, idioma, palavra, definicao, pronuncia, animo, utilidade, morfologia, fonte, tema, observacao, classificacao);
            salvarPalavras.ShowDialog();
            AtualizarListView();
            this.Visible = true;
        }

        private void limparPesquisaButton_Click(object sender, EventArgs e)
        {
            idiomaComboBox.Text = "";
            morfologiaComboBox.Text = "";
            classificacaoComboBox.Text = "";
            pesquisaTextBox_SetText();
            AtualizarListView();
        }

        private void excluirButton_Click(object sender, EventArgs e)
        {
            const string message = "Tem certeza que deseja excluir a palavra selecionada?";
            const string caption = "Excluir palavra.";

            var result = MessageBox.Show(message, caption, MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning);

            if (result == DialogResult.Yes)
            {
                int index = PalavrasListView.FocusedItem.Index;
                int id = int.Parse(PalavrasListView.Items[index].SubItems[0].Text);

                PalavraDAO palavra = new PalavraDAO();
                palavra.Excluir(id);
                AtualizarListView();
            }
        }

        private void criarCRButton_Click(object sender, EventArgs e)
        {
            FlashCardsEmMassa telaFCM = new FlashCardsEmMassa(select, us);
            telaFCM.ShowDialog();
        }

        private void sairButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
