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
    public partial class Form12SeleccionMultipleColeccion : Form
    {
        public Form12SeleccionMultipleColeccion()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string elem = this.txtElemento.Text;
            this.lstElementos.Items.Add(elem);
            this.txtElemento.SelectAll();
            this.txtElemento.Focus();
        }

        private void btnSeleccionados_Click(object sender, EventArgs e)
        {
            string indices = "";
            string items = "";
            foreach (int ind in this.lstElementos.SelectedIndices)
            {
                indices += ind + ",";
            }
            foreach(object obj in this.lstElementos.SelectedItems)
            {
                items += obj + ",";
            }
            this.lblPosiciones.Text = indices;
            this.lblSeleccionados.Text = items;
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            int numseleccionados = this.lstElementos.SelectedIndices.Count - 1;
            for (int i = numseleccionados; i >= 0; i--)
            {
                int indice = this.lstElementos.SelectedIndices[i];
                this.lstElementos.Items.RemoveAt(indice);
            }
        }
    }
}
