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
    public partial class SalvarPalavras : Form
    {
        int us;
        int cod;
        string classificacao; 
        public SalvarPalavras(int id)
        {
            us = id;
            InitializeComponent();
            AtualizarIdiomas();
            relevanciaTextBox.Text = "0";
        }

        public SalvarPalavras(int id, string idioma, string palavra, string definicao, string pronuncia, int animo, int utilidade, string morfologia, string fonte, string tema, string observacao, string classificao)
        {
            InitializeComponent();
            AtualizarIdiomas();

            idiomaComboBox.Text = idioma;
            palavraTextBox.Text = palavra;
            definicaoTextBox.Text = definicao;
            pronunciaTextBox.Text = pronuncia;
            animoNumericUpDown.Value = animo;
            utilidadeNumericUpDown.Value = utilidade;
            MorfologiaComboBox.Text = morfologia;
            FonteTextBox.Text = fonte;
            ObservacaoTextBox.Text = observacao;
            //ClassificacaoComboBox.Text = classificao;

            if (classificacao == "Falar")
                falarRadioButton.Checked = true;
            else
                conhecerRadioButton.Checked = true;

            temaTextBox.Text = tema;
            cod = id;

            SaveButton.Text = "Atualizar";
        }

        private void AtualizarIdiomas()
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

        public void LimparCampos()
        {
            idiomaComboBox.Text = "";
            palavraTextBox.Text = "";
            definicaoTextBox.Text = "";
            pronunciaTextBox.Text = "";
            animoNumericUpDown.Value = 0;
            utilidadeNumericUpDown.Value = 0;
            MorfologiaComboBox.Text = "";
            FonteTextBox.Text = "";
            ObservacaoTextBox.Text = "";
            temaTextBox.Text = "";
        }

        private void SairButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void SalvarPalavras_Load(object sender, EventArgs e)
        {
            
        }

        private void animoNumericUpDown_ValueChanged(object sender, EventArgs e)
        {
            MudarRelevancia();
            if (animoNumericUpDown.Value > 10)
            {
                MessageBox.Show("Selecione um valor de 0 a 10 para o ânimo!");
                animoNumericUpDown.Value = 10;
            }
        }

        private void utilidadeNumericUpDown_ValueChanged(object sender, EventArgs e)
        {
            MudarRelevancia();
            if (utilidadeNumericUpDown.Value > 10)
            {
                MessageBox.Show("Selecione um valor de 0 a 10 para a utilidade!");
                utilidadeNumericUpDown.Value = 10;
            }
        }

        private void MudarRelevancia()
        {
            int v1 = Convert.ToInt32(animoNumericUpDown.Value), v2 = Convert.ToInt32(utilidadeNumericUpDown.Value), resultado;

            resultado = (v1 + v2) / 2;

            relevanciaTextBox.Text = resultado.ToString();
        }

        private void limparButton_Click(object sender, EventArgs e)
        {
            const string message = "Deseja limpar todos os campos?";
            const string caption = "Limpar todos os campos";

            var result = MessageBox.Show(message, caption, MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning);

            if(result == DialogResult.Yes)
                LimparCampos();
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            int fkidm = 0;
            IdiomaDAO idm = new IdiomaDAO();
            List<Idioma> listidms = idm.ListarIdiomas(us);

            if (listidms.Count > 0)
            {
                foreach (var i in listidms)
                {
                    if (i.Nome == idiomaComboBox.Text)
                    {
                        fkidm = i.Id;
                    }
                }
            }

            if(SaveButton.Text == "Salvar")
            {
                try
                {
                    Palavra palavra = new Palavra(idiomaComboBox.Text, palavraTextBox.Text, definicaoTextBox.Text, pronunciaTextBox.Text,
                        Convert.ToInt32(animoNumericUpDown.Value), Convert.ToInt32(utilidadeNumericUpDown.Value),
                        Convert.ToInt32(relevanciaTextBox.Text), classificacao,
                        MorfologiaComboBox.Text, FonteTextBox.Text, temaTextBox.Text, ObservacaoTextBox.Text, fkidm);

                    PalavraDAO plvDAO = new PalavraDAO();
                    plvDAO.Inserir(palavra);
                    MessageBox.Show("Palavra inserida com sucesso!", "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception err)
                {
                    MessageBox.Show("Preencha todos os campos!\n" + err.Message);
                }
            }
            else
            {
                try
                { 
                    Palavra palavra = new Palavra(cod, idiomaComboBox.Text, palavraTextBox.Text, definicaoTextBox.Text, pronunciaTextBox.Text,
                        Convert.ToInt32(animoNumericUpDown.Value), Convert.ToInt32(utilidadeNumericUpDown.Value),
                        Convert.ToInt32(relevanciaTextBox.Text), classificacao,
                        MorfologiaComboBox.Text, FonteTextBox.Text, temaTextBox.Text, ObservacaoTextBox.Text, fkidm);

                    PalavraDAO plvDAO = new PalavraDAO();
                    plvDAO.Atualizar(palavra);
                    MessageBox.Show("Palavra atualizada com sucesso!", "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception err)
                {
                    MessageBox.Show("Preencha todos os campos!\n" + err.Message);
                }
            }
        }

        private void falarRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            if(falarRadioButton.Checked)
            {
                classificacao = "Falar";
            }
        }

        private void conhecerRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            if(conhecerRadioButton.Checked)
            {
                classificacao = "Conhecer";
            }
        }
    }
}
