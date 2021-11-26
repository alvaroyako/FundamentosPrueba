using System;
using System.Collections;
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
    public partial class Form16ColeccionArrayList : Form
    {
        public Form16ColeccionArrayList()
        {
            InitializeComponent();
            ArrayList coleccion = new ArrayList();
            coleccion.Add(this.button1);
            coleccion.Add(this.button2);
            coleccion.Add(this.button3);
            coleccion.Add(this.textBox1);
            foreach(Control control in coleccion)
            {
                
                if(control is TextBox)
                {
                    control.BackColor = Color.Yellow;
                    ((TextBox)control).Paste();
                }
                else
                {
                    control.BackColor = Color.Fuchsia;
                }
            }
        }
    }
}
