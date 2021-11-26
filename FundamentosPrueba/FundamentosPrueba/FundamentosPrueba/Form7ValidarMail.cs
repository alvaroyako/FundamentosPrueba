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
    public partial class Form7ValidarMail : Form
    {
        public Form7ValidarMail()
        {
            InitializeComponent();
        }

        private void btnComprobar_Click(object sender, EventArgs e)
        {
            String mail = this.txtMail.Text;
            String error = "";

            int posPunto = mail.LastIndexOf(".");
            String comprobarDom = mail.Substring(posPunto +1);

            int contador = 0;


            if (mail.Contains("@")==false)
            {
                error+="-Email sin @ \n";
                contador++;
            }
            if (mail.StartsWith("@") == false)
            {
                error += "-Falta el @ en el principio del mail \n";
                contador++;
            }
            if(mail.EndsWith("@") == false)
            {
                error += "-Falta el @ al final del mail \n";
                contador++;
            }
            if(mail.Contains(".") == false)
            {
                error += "-Email sin . \n";
            }
            if (mail.Contains("@.") == false)
            {
                error += "-No hay punto despues de @ \n";
                contador++;
            }
            if(comprobarDom.Length<=2 && comprobarDom.Length>=4)
            {
                error += "-El dominio tiene que tener de 2 a 4 caracteres\n";
            }
            if (contador >= 2)
            {
                error += "-Hacen falta mas @\n";
            }
            if (comprobarDom == "")
            {
                error += "-Falta el dominio\n";
            }

            this.txtError.Text = error;
        }
    }
}
