using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace FundamentosPrueba
{
    public partial class Form9InvertirTextStringBuilder : Form
    {
        public Form9InvertirTextStringBuilder()
        {
            InitializeComponent();
        }

        private void btnString_Click(object sender, EventArgs e)
        {
            String texto = this.txtTexto.Text;
            Stopwatch krono = new Stopwatch();
            krono.Start();
            int longitud = texto.Length;
            for(int i = 0; i < longitud; i++)
            {
                char letra = texto[longitud - 1];
                texto = texto.Remove(longitud - 1, 1);
                texto = texto.Insert(i, letra.ToString());

            }
            this.txtTexto.Text = texto;
            krono.Stop();
            this.lblTiempo.Text="Segundos: "+krono.Elapsed.TotalSeconds+"/"+krono.Elapsed.TotalMilliseconds;
        }

        private void btnStringBuilder_Click(object sender, EventArgs e)
        {
            StringBuilder texto = new StringBuilder();
            Stopwatch krono = new Stopwatch();
            texto.Append(this.txtTexto.Text);
            krono.Start();
            int longitud = texto.Length;
            for(int i=0;i<longitud;i++)
            {
                char letra = texto[longitud - 1];
                texto = texto.Remove(longitud - 1, 1);
                texto = texto.Insert(i, letra);
            }
            this.txtTexto.Text = texto.ToString();
            krono.Stop();
            this.lblTiempo.Text = "Segundos: " + krono.Elapsed.TotalSeconds + "/" + krono.Elapsed.TotalMilliseconds;
        }
    }
}
