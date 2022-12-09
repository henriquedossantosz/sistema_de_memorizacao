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
    public partial class Conjunto : Form
    {
        public Conjunto()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(label2.Text=="Esquerda")
            {
                label2.Text = "Direita";
            }
            if (label2.Text == "Direita")
            {
                label2.Text = "Esquerda";
            }
        }

        private void Conjunto_Load(object sender, EventArgs e)
        {

        }
    }
}
