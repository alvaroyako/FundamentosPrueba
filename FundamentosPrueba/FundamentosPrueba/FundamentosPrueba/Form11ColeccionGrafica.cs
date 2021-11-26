using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FundamentosPrueba
{
    public partial class Form11ColeccionGrafica : Form
    {
        public Form11ColeccionGrafica()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string elem = this.txtElemento.Text;
            this.lstElementos.Items.Add(elem);
        }

        private void lstElementos_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.lblPosicion.Text="Indice: " 
                +this.lstElementos.SelectedIndex.ToString();
            this.lblSeleccionado.Text = "Item: " +
                this.lstElementos.SelectedItem;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int index = this.lstElementos.SelectedIndex;
            this.lstElementos.Items.RemoveAt(index);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.lstElementos.Items.Clear();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string elem = this.txtElemento.Text;
            int indice = this.lstElementos.SelectedIndex;
            this.lstElementos.Items[indice] = elem;
        }
    }
}
