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
    public partial class Form8SumarNumerosString : Form
    {
        public Form8SumarNumerosString()
        {
            InitializeComponent();
        }

        private void btnSumar_Click(object sender, EventArgs e)
        {
            bool isNumber = true;
            String textoNumeros = this.txtNumero.Text;
            for(int i = 0; i < textoNumeros.Length; i++)
            {
                if (char.IsDigit(textoNumeros[i]) == false)
                {
                    isNumber = false;
                    break;
                }
            }


            if (isNumber == false)
            {
                MessageBox.Show("Debe escribir numeros en la caja", "Warning");
                this.txtNumero.SelectAll();
                this.txtNumero.Focus();
            }
            else
            {
                int suma = 0;
                for(int i = 0; i < textoNumeros.Length; i++)
                {
                    char caracter = textoNumeros[i];
                    int numero = int.Parse(caracter.ToString());
                    suma += numero;
                }
                this.lblResultado.Text = "La suma es " + suma.ToString();
            }
        }
    }
}
