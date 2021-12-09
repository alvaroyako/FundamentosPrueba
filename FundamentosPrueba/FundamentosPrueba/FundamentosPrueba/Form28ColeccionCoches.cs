using ProyectoClases;
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
    public partial class Form28ColeccionCoches : Form
    {
        CochesCollection coches;
        HelperCoches helper;
        public Form28ColeccionCoches()
        {
            InitializeComponent();
            this.coches = new CochesCollection();
            this.helper = new HelperCoches();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            this.helper.GuardarSerialize();
            this.lstCoches.Items.Clear();
            this.coches.Clear();
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            Coche coche = new Coche();
            coche.Marca = this.txtMarca.Text;
            coche.Modelo = this.txtModelo.Text;
            this.helper.Coches.Add(coche);
            PintarCoches();
        }

        private void btnCargar_Click(object sender, EventArgs e)
        {

        }

        private void PintarCoches()
        {
            this.lstCoches.Items.Clear();
            foreach (Coche coche in this.helper.Coches)
            {
                this.lstCoches.Items.Add(coche.Marca);
            }
        }
    }
}
