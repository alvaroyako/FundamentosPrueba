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
    public partial class Form15EjemploMetodos : Form
    {
        public Form15EjemploMetodos()
        {
            InitializeComponent();

            CheckBox chk = new CheckBox();
            chk.Checked = true;
            Object obj = chk;
            ((CheckBox)obj).Checked = true;

        }

        void DobleNumero(int numero)
        {
            numero = numero * 2;
        }

        void CambiarColorBoton(Button boton)
        {
            boton.BackColor = Color.Yellow;
        }

        void DobleNumeroReferencia(ref int numero)
        {
            numero = numero * 2;
        }

        int GetDoble(int numero)
        {
            return numero * 2;
        }

        private void btnValor_Click(object sender, EventArgs e)
        {
            int num = int.Parse(this.txtNumero.Text);
            int doble = this.GetDoble(num);
            this.lblResultado.Text = "Doble: " + doble;
        }

        private void btnReferencia_Click(object sender, EventArgs e)
        {
            int num = int.Parse(this.txtNumero.Text);
            this.DobleNumeroReferencia(ref num);
            this.lblResultado.Text = "Doble: " + num;
        }

        private void btnMetodo_Click(object sender, EventArgs e)
        {
            this.CambiarColorBoton(this.btnReferencia);
        }

        private void btnMetodo_MouseHover(object sender, EventArgs e)
        {

        }

        private void lblMouse_MouseMove(object sender, MouseEventArgs e)
        {
            this.lblMouse.Text = "X: " + e.X + ", Y: " + e.Y;
        }

        private void txtNumeros_KeyPress(object sender, KeyPressEventArgs e)
        {
            char teclaBack = (char)Keys.Back;
            if (char.IsDigit(e.KeyChar) == false && e.KeyChar!=teclaBack)
            {
                e.Handled = true;
            }
        }

        private void txtLetras_KeyPress(object sender, KeyPressEventArgs e)
        {
            char teclaBack = (char)Keys.Back;
            if (char.IsLetter(e.KeyChar) == false && e.KeyChar != teclaBack)
            {
                e.Handled = true;
            }
        }
    }
}
