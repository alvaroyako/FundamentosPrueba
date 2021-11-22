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
    public partial class Form4DiaNacimiento : Form
    {
        public Form4DiaNacimiento()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            int dia, mes, año;
            dia = int.Parse(this.txtDia.Text);
            mes = int.Parse(this.txtMes.Text);
            año = int.Parse(this.txtAño.Text);

            if (mes == 1)
            {
                mes = 13;
                año = año - 1;
            }else if (mes == 2)
            {
                mes = 14;
                año = año - 1;
            }

            //Paso 1
            int paso1 = ((mes + 1) * 3) / 5;

            //Paso 2
            int paso2 = año / 4;

            //Paso 3
            int paso3 = año / 100;

            //Paso 4
            int paso4 = año / 400;

            //Paso 5
            int paso5 = dia + (mes * 2) + año + paso1 + paso2 - paso3 + paso4 + 2;

            //Paso 6
            int paso6 = paso5 / 7;

            //Psao 7
            int paso7 = paso5 - (paso6 * 7);


            switch (paso7)
            {
                case 0: this.lblResultado.Text = "Sabado";
                    break;
                case 1:
                    this.lblResultado.Text = "Domingo";
                    break;
                case 2:
                    this.lblResultado.Text = "Lunes";
                    break;
                case 3:
                    this.lblResultado.Text = "Martes";
                    break;
                case 4:
                    this.lblResultado.Text = "Miercoles";
                    break;
                case 5:
                    this.lblResultado.Text = "Jueves";
                    break;
                case 6:
                    this.lblResultado.Text = "Viernes";
                    break;
            }
        }
    }
}
