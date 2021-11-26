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
    public partial class Form20Temperaturas : Form
    {
        string[] meses = new string[] {"ENERO","FEBRERO","MARZO","ABRIL","MAYO","JUNIO","JULIO","AGOSTO","SEPTIEMBRE","OCTUBRE","NOVIEMBRE","DICIEMBRE" };
        
        int maxima = 0;
        int minima = 0;
        int media = 0;
        
        public Form20Temperaturas()
        {
            InitializeComponent();
        }

        private void btnMeses_Click(object sender, EventArgs e)
        {
            Random random = new Random();
            int[] temperaturas = new int[meses.Length];

            for(int i = 0; i < temperaturas.Length; i++)
            {
                int num = random.Next(1, 50);
                temperaturas[i] = num;
            }

            for(int i = 0; i < meses.Length; i++)
            {
                string texto = meses[i] + ": " + temperaturas[i] + "º";
                this.lstMeses.Items.Add(texto);
            }

            maxima = temperaturas.Max();
            minima = temperaturas.Min();
            media =(int)temperaturas.Average();


        }

        private void btnMostrar_Click(object sender, EventArgs e)
        {
            this.txtMaxima.Text = maxima.ToString();
            this.txtMinima.Text = minima.ToString();
            this.txtMedia.Text = media.ToString();
        }
    }
}
