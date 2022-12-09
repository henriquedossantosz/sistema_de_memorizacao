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
    public partial class Revisar : Form
    {
        int index = 0, total;
        static List<Cards> Baralho = new List<Cards>();

        CardsDAO c = new CardsDAO();

        public Revisar(int cod)
        {
            InitializeComponent();

            Baralho = c.ListarTodasCards(cod);

            if (Baralho.Count > 0)
            {
                total = Baralho.Count - 1;
                MudarCarta(Baralho[index]);
                //sairButton.Visible = false;
            }
            else
            {
                desativaTudo();
                MessageBox.Show("Não há o que revisar hoje. Volte ao menu anterior.");
            }

            progProgressBar.Maximum = total;
        }

        private void MudarCarta(Cards carta)
        {
            label1.Text = carta.Frente;
            label2.Text = carta.Verso;

            int la1 = index + 1;
            int la2 = total + 1;

            progProgressBar.Value = index;

            label3.Text =  la1 + "/" + la2;
            desativaTudo();
        }
        private void label1_Click(object sender, EventArgs e)
        {
            ativaTudo();
        }

        void ativaTudo()
        {
            label2.Visible = true;
            certoButton.Enabled = true;
            erradoButton.Enabled = true;
        }

        void desativaTudo()
        {
            label2.Visible = false;
            certoButton.Enabled = false;
            erradoButton.Enabled = false;
        }

        private void erradoButton_Click(object sender, EventArgs e)
        {
            Baralho[index].Erro++;
            Baralho[index].AddDias = 1;
            c = new CardsDAO();

            if (index != total)
            {
                c.AtualizarCards(Baralho[index]);
                index++;
                MudarCarta(Baralho[index]);
            }
            else
            {
                c.AtualizarCards(Baralho[index]);
                MessageBox.Show("O baralho foi todo revisado");
                this.Close();
            }
            desativaTudo();
        }

        private void Revisar_Load(object sender, EventArgs e)
        {

        }

        private void certoButton_Click(object sender, EventArgs e)
        {
            var mddt = Baralho[index].ProxRevisao.AddDays(Baralho[index].AddDias);
            Baralho[index].ProxRevisao = mddt;
            Baralho[index].AddDias++;
            Baralho[index].Acerto++;

            c = new CardsDAO();
            if (index != total)
            {
                //Revisados.Add(Baralho[index]);
                c.AtualizarCards(Baralho[index]);
                index++;
                MudarCarta(Baralho[index]);
            }
            else
            {
                //Revisados.Add(Baralho[index]);
                c.AtualizarCards(Baralho[index]);
                //AtualizarRevisoes();
                MessageBox.Show("O baralho foi todo revisado");
                this.Close();
            }
            desativaTudo();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void sairButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public void AtualizarRevisoes()
        {
            /*foreach(var carta in Revisados)
            {
                c.AtualizarCards(carta);
            }*/

            c.AtualizarCards(Baralho[3]);
        }
    }
}
