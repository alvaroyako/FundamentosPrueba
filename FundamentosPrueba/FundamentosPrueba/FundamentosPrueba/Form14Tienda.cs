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
    public partial class Form14Tienda : Form
    {
        public Form14Tienda()
        {
            InitializeComponent();
        }

        private void btnInsertar_Click(object sender, EventArgs e)
        {
            string elem = this.txtProducto.Text;
            this.lstTienda.Items.Add(elem);
            this.txtProducto.Text = "";
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            int seleccionados = this.lstTienda.SelectedIndices.Count-1;
            for(int i = seleccionados; i >= 0; i--)
            {
                int indice = this.lstTienda.SelectedIndices[i];
                this.lstTienda.Items.RemoveAt(indice);
            }
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            string elem = this.txtProducto.Text;
            int indice = this.lstTienda.SelectedIndex;
            this.lstTienda.Items[indice] = elem;
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            this.lstTienda.Items.Clear();
        }

        private void btnSeleccion_Click(object sender, EventArgs e)
        {
            int seleccionados = this.lstTienda.SelectedIndices.Count - 1;
            for (int i = seleccionados; i >= 0; i--)
            {
                int indice = this.lstTienda.SelectedIndices[i];   
                this.lstAlmacen.Items.Add(this.lstTienda.Items[indice]);
                this.lstTienda.Items.RemoveAt(indice);
            }
        }

        private void btnTodos_Click(object sender, EventArgs e)
        {
            this.lstAlmacen.Items.AddRange(this.lstTienda.Items);
            this.lstTienda.Items.Clear();


        }

        private void btnSubir_Click(object sender, EventArgs e)
        {
            int indice = this.lstAlmacen.SelectedIndex;
            string elem = this.lstAlmacen.SelectedItem.ToString();
            this.lstAlmacen.Items.RemoveAt(indice);
            this.lstAlmacen.Items.Insert(indice - 1, elem);
            this.lstAlmacen.SelectedIndex = indice - 1;
        }

        private void btnBajar_Click(object sender, EventArgs e)
        {
            int indice = this.lstAlmacen.SelectedIndex;
            string elem = this.lstAlmacen.SelectedItem.ToString();
            this.lstAlmacen.Items.RemoveAt(indice);
            this.lstAlmacen.Items.Insert(indice + 1, elem);
            this.lstAlmacen.SelectedIndex = indice + 1;
        }

        private void lstAlmacen_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.lstAlmacen.SelectedIndex == 0)
            {
                this.btnSubir.Enabled = false;
            }
            else
            {
                this.btnSubir.Enabled = true;
            }
            if(this.lstAlmacen.SelectedIndex==this.lstAlmacen.Items.Count-1)
            {
                this.btnBajar.Enabled = false;
            }
            else
            {
                this.btnBajar.Enabled = true;
            }
        }
    }
}
