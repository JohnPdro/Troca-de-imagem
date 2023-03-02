using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Troca_de_imagem
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnMostrar_Click(object sender, EventArgs e)
        {
            this.pctrBoxImagem.Visible = true;
            
        }

        private void btnOcultar_Click(object sender, EventArgs e)
        {
            this.pctrBoxImagem.Visible = false;
            
        }

        private void pctrBoxImagem2_Click(object sender, EventArgs e)
        {
        }

        private void btnMostrar2_Click(object sender, EventArgs e)
        {
            this.pctrBoxImagem2.Visible = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.pctrBoxImagem.Visible = false;
            this.pctrBoxImagem2.Visible = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.pctrBoxImagem.Visible = true;
            this.pctrBoxImagem2.Visible = true;
        }

        private void btnOcultar2_Click(object sender, EventArgs e)
        {
            this.pctrBoxImagem2.Visible = false;
        }
    }
}
