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
    public partial class AdicionarConjunto : Form
    {
        //identificação do Usuário
        int us;
        int codioma, id;
        public AdicionarConjunto(int id)
        {
            us = id;
            InitializeComponent();
            AtualizarComboBox();
        }

        public AdicionarConjunto(int id, string idioma, string nome, string descricao)
        {
            InitializeComponent();
            AtualizarComboBox();
            idiomaComboBox.Text = idioma;
            nomeCRTextBox.Text = nome;
            descricaoTextBox.Text = descricao;
            addButton.Text = "Atualizar";
            this.id = id;
        }

        private void AtualizarComboBox()
        {
            idiomaComboBox.Items.Clear();
            IdiomaDAO idmDao = new IdiomaDAO();

            List<Idioma> idm = idmDao.ListarIdiomas(us);
            if (idm.Count > 0)
            {
                foreach (var i in idm)
                {
                    idiomaComboBox.Items.Add(i.Nome);
                }
            }
        }

        private void Limpar()
        {
            nomeCRTextBox.Clear();
            descricaoTextBox.Clear();
            idiomaComboBox.Text = " ";
        }

        private void AdicionarConjunto_Load(object sender, EventArgs e)
        {

        }

        private void addButton_Click(object sender, EventArgs e)
        {
            if(addButton.Text == "Adicionar")
            {
                try
                {
                    ConjuntoRevisao cjn = new ConjuntoRevisao(nomeCRTextBox.Text, descricaoTextBox.Text, idiomaComboBox.Text, codioma);
                    ConjuntoRevisaoDAO cjnInserir = new ConjuntoRevisaoDAO();
                    cjnInserir.Inserir(cjn);
                    MessageBox.Show("Conjunto de revisão: " + cjn.Nome + " inserido com sucesso!", "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                try
                {
                    ConjuntoRevisao cjn = new ConjuntoRevisao(id ,nomeCRTextBox.Text, descricaoTextBox.Text, idiomaComboBox.Text, codioma);
                    ConjuntoRevisaoDAO cjnAlterar = new ConjuntoRevisaoDAO();
                    cjnAlterar.Alterar(cjn);
                    MessageBox.Show("Conjunto de revisão: " + cjn.Nome + " atualizado com sucesso!", "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void limparButton_Click(object sender, EventArgs e)
        {
            const string message = "Deseja limpar todos os campos?";
            const string caption = "Limpar todos os campos";

            var result = MessageBox.Show(message, caption, MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning);

            if (result == DialogResult.Yes)
                Limpar();
        }

        private void idiomaComboBox_TextChanged(object sender, EventArgs e)
        {
            IdiomaDAO idmDao = new IdiomaDAO();
            List<Idioma> idm = idmDao.ListarIdiomas(us);

            foreach(var cj in idm)
            {
                if (cj.Nome == idiomaComboBox.Text)
                    codioma = cj.Id;
            }
        }
    }
}
