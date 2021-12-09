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
    public partial class Form22Meses : Form
    {
        List<Mes> meses;
        public Form22Meses()
        {
            InitializeComponent();
            this.meses = new List<Mes>();
        }

        private void btnMeses_Click(object sender, EventArgs e)
        {
            this.lstMeses.Items.Clear();
            this.meses.Clear();
            Random random = new Random();
            DateTime fecha = DateTime.Parse("01/01/2021");
            for (int i = 1; i <= 12; i++)
            {
                int tempMax = random.Next(-15, 45);
                int tempMin = random.Next(-15, 45);
                String nombreMes = fecha.ToString("MMMM");

                Mes mes = new Mes(nombreMes, tempMax, tempMin);
                this.meses.Add(mes);

                this.lstMeses.Items.Add(mes.Nombre.ToUpper());
                fecha = fecha.AddMonths(1);
            }

        }

        private void btnMostrar_Click(object sender, EventArgs e)
        {
            int elegido = this.lstMeses.SelectedIndex;
            int max= this.meses[elegido].Maxima;
            int min= this.meses[elegido].Minima;

            this.txtMaxima.Text = max.ToString();
            this.txtMinima.Text = min.ToString();

            int media = this.meses[elegido].Media(max, min);

            this.txtMedia.Text = media.ToString();
        }
    }
}
