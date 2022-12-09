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
    public partial class FlashCardsEmMassa : Form
    {
        string selecao;
        int caso, crid;
        int us;
        public FlashCardsEmMassa(string sel, int id)
        {
            us = id;
            InitializeComponent();
            AtualizarComboBox();
            selecao = sel;
            versoComboBox.Enabled = false;
        }
        public void AtualizarComboBox()
        {
            ConjuntoRevisaoDAO conjunto = new ConjuntoRevisaoDAO();
            List<ConjuntoRevisao> cjs = conjunto.ListarConjuntos(us);

            if(cjs.Count>0)
            {
                foreach(var cj in cjs)
                {
                    conjuntoComboBox.Items.Add(cj.Nome);
                }
            }
        }



        private void adicionarButton_Click(object sender, EventArgs e)
        {
            PalavraDAO pls = new PalavraDAO();
            List<Palavra> palavras = pls.GerarListaPalavra(selecao);

            List<Cards> listaCartas = new List<Cards>();

            switch (caso)
            {
                case 1:
                    MessageBox.Show("Palavra e Definição");
                    foreach (var palavra in palavras)
                    {
                        Cards c = new Cards(palavra.Texto, palavra.Definicao, crid);
                        listaCartas.Add(c);
                    }

                    break;
                case 2:
                    MessageBox.Show("Palavra e Pronúncia");
                    foreach (var palavra in palavras)
                    {
                        Cards c = new Cards(palavra.Texto, palavra.Pronuncia, crid);
                        listaCartas.Add(c);
                    }

                    break;
                case 3:
                    MessageBox.Show("Palavra e Morfologia");
                    foreach (var palavra in palavras)
                    {
                        Cards c = new Cards(palavra.Texto, palavra.Morfologia, crid);
                        listaCartas.Add(c);
                    }

                    break;
                case 4:
                    MessageBox.Show("Palavra e Observação");
                    foreach (var palavra in palavras)
                    {
                        Cards c = new Cards(palavra.Texto, palavra.Observacao, crid);
                        listaCartas.Add(c);
                    }

                    break;
                case 5:
                    MessageBox.Show("Definição e Palavra");
                    foreach (var palavra in palavras)
                    {
                        Cards c = new Cards(palavra.Definicao, palavra.Texto, crid);
                        listaCartas.Add(c);
                    }

                    break;
                case 6:
                    MessageBox.Show("Definição e Pronúncia");
                    foreach (var palavra in palavras)
                    {
                        Cards c = new Cards(palavra.Definicao, palavra.Pronuncia, crid);
                        listaCartas.Add(c);
                    }

                    break;
                case 7:
                    MessageBox.Show("Pronúncia e Palavra");
                    foreach (var palavra in palavras)
                    {
                        Cards c = new Cards(palavra.Pronuncia, palavra.Texto, crid);
                        listaCartas.Add(c);
                    }

                    break;
                case 8:
                    MessageBox.Show("Pronúncia e Definição");
                    foreach (var palavra in palavras)
                    {
                        Cards c = new Cards(palavra.Pronuncia, palavra.Definicao, crid);
                        listaCartas.Add(c);
                    }
                    break;
            }

            try
            {
                if (listaCartas.Count > 0)
                {
                    foreach (var c in listaCartas)
                    {
                        CardsDAO cdao = new CardsDAO();
                        cdao.Inserir(c);
                    }
                    MessageBox.Show("Flash Cards inseridos com sucesso!");
                    this.Close();
                }
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);
            }

        }
        private void versoComboBox_TextChanged(object sender, EventArgs e)
        {
            if(frenteComboBox.Text == "Palavra")
            {
                if (versoComboBox.Text == "Definição")
                    caso = 1;
                if (versoComboBox.Text == "Pronúncia")
                    caso = 2;
                if (versoComboBox.Text == "Morfologia")
                    caso = 3;
                if (versoComboBox.Text == "Observação")
                    caso = 4;
            }

            if(frenteComboBox.Text == "Definição")
            {
                if (versoComboBox.Text == "Palavra")
                    caso = 5;
                if (versoComboBox.Text == "Pronúncia")
                    caso = 6;
            }

            if (frenteComboBox.Text == "Pronúncia")
            {
                if (versoComboBox.Text == "Palavra")
                    caso = 7;
                if (versoComboBox.Text == "Definição")
                    caso = 8;
            }
        }

        private void frenteComboBox_TextChanged(object sender, EventArgs e)
        {
            if(frenteComboBox.Text != "")
                versoComboBox.Enabled = true;
            else
            {
                versoComboBox.Enabled = false;
            }

            if (frenteComboBox.Text == "Palavra")
            {
                versoComboBox.Items.Clear();
                versoComboBox.Text = "";
                versoComboBox.Items.Add("Definição");
                versoComboBox.Items.Add("Pronúncia");
                versoComboBox.Items.Add("Morfologia");
                versoComboBox.Items.Add("Observação");
            }

            if (frenteComboBox.Text == "Definição")
            {
                versoComboBox.Items.Clear();
                versoComboBox.Text = "";
                versoComboBox.Items.Add("Palavra");
                versoComboBox.Items.Add("Pronúncia");
            }

            if(frenteComboBox.Text == "Pronúncia")
            {
                versoComboBox.Items.Clear();
                versoComboBox.Text = "";
                versoComboBox.Items.Add("Palavra");
                versoComboBox.Items.Add("Definição");
            }
        }


        //CONTINUAR AQUI
        /*public List<Cards> PalDef(string frente, v)
        {
            List<Cards> cards = new List<Cards>();

            foreach(var p in palavras)
            {
                Cards c = new Cards(p.Texto, p.Definicao, crid);
                cards.Add(c);
            }

            return cards;
        }*/

        private void conjuntoComboBox_TextChanged(object sender, EventArgs e)
        {
            ConjuntoRevisaoDAO cjDao = new ConjuntoRevisaoDAO();
            List<ConjuntoRevisao> cjr = cjDao.ListarConjuntos(us);

            foreach (var cj in cjr)
            {
                if (cj.Nome == conjuntoComboBox.Text)
                    crid = cj.Id;
            }
        }
    }
}
