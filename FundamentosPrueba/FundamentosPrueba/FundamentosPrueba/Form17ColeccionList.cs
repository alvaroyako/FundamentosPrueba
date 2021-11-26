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
    public partial class Form17ColeccionList : Form
    {
        int contador;
        List<Button> botones;
        public Form17ColeccionList()
        {
            InitializeComponent();
            this.contador = 0;
            this.botones = new List<Button>();
            foreach (Control control in this.Controls)
            {
                if (control is Button)
                {
                    this.botones.Add((Button)control);
                }
            }


            foreach (Button btn in botones)
            {
                btn.BackColor = Color.LightCyan;
                btn.Click += IncrementarContador; ;
            }

            

        }

        private void IncrementarContador(object sender, EventArgs e)
        {
            this.contador += 1;
            String name = ((Button)sender).Name;
            this.textBox1.Text =name+ ": " + this.contador;
        }
    }
}
