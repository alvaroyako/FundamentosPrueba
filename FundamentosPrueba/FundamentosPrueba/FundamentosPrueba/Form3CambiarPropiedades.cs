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
    public partial class Form3CambiarPropiedades : Form
    {
        public Form3CambiarPropiedades()
        {
            InitializeComponent();
        }

        private void btnPosicion_Click(object sender, EventArgs e)
        {
            int x, y;
            x = int.Parse(this.txtX.Text);
            y = int.Parse(this.txtY.Text);
            this.btnPosicion.Location = new Point(x, y); 
        }

        private void btnColor_Click(object sender, EventArgs e)
        {
            int r, v, a;
            r = int.Parse(this.txtR.Text);
            v = int.Parse(this.txtV.Text);
            a = int.Parse(this.txtA.Text);

            this.BackColor = Color.FromArgb(r, v, a);
        }

        private void btnEvaluar_Click(object sender, EventArgs e)
        {
            int numero = int.Parse(this.txtNumero.Text);
            if (numero > 0)
            {
                this.lblResultado.Text = "Positivo";
                this.lblResultado.ForeColor = Color.BlueViolet;
            }else if (numero == 0)
            {
                this.lblResultado.Text = "Cero";
                this.lblResultado.ForeColor = Color.OrangeRed;
            }
            else
            {
                this.lblResultado.Text = "Negativo";
                this.lblResultado.ForeColor = Color.Green;
            }
        }
    }
}
