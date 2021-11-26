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
    public partial class Form13Aleatorios : Form
    {
        public Form13Aleatorios()
        {
            InitializeComponent();
        }

        private void btnGenerar_Click(object sender, EventArgs e)
        {
            Random random = new Random();
            for(int i = 0; i < 10; i++)
            {
                int num = random.Next(1, 10);
                this.lstNumeros.Items.Add(num);
            }
        }

        private void btnMostrar_Click(object sender, EventArgs e)
        {
            int sumapares = 0;
            int sumaimpares = 0;
            int total = 0;
            foreach(int item in this.lstNumeros.Items)
            {
                total += item;
                if (item % 2 == 0)
                {
                    sumapares += item;
                }
                else
                {
                    sumaimpares += item;
                }
            }

            this.txtSuma.Text =total.ToString();
            this.txtPares.Text = sumapares.ToString();
            this.txtImpares.Text = sumaimpares.ToString();
        }
    }
}
