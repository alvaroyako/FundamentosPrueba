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
    public partial class Form10ISBN : Form
    {
        public Form10ISBN()
        {
            InitializeComponent();
            int[] numeros = new int[4] { 14, 49, 999, 333 };
            int suma = 0;
            foreach(int num in numeros)
            {
                suma += num;
            }
            this.lblResultado.Text = suma.ToString();

        }

        private void btnComprobar_Click(object sender, EventArgs e)
        {
            string isbn = this.txtISBN.Text;
            if (isbn.Length == 10)
            {
                int suma = 0;
                for(int i = 0; i < 10; i++)
                {
                    char caracter = isbn[i];
                    int num = int.Parse(caracter.ToString());
                    num = num *(i+1);
                    suma = suma + num;
                }
                if (suma % 11 == 0)
                {
                    this.lblResultado.Text = "ISBN Correcto";
                }
                else
                {
                    this.lblResultado.Text = "ISBN Incorrecto";
                }
            }
            else
            {
                MessageBox.Show("Tienen que haber 10 caracteres", "Warning");
                this.txtISBN.SelectAll();
                this.txtISBN.Focus();
            }
        }
    }
}
