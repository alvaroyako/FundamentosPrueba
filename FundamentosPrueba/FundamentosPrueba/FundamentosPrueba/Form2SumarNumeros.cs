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
    public partial class Form2SumarNumeros : Form
    {
        public Form2SumarNumeros()
        {
            InitializeComponent();
        }

        private void btnSumar_Click(object sender, EventArgs e)
        {
            int num1, num2;
            num1 = int.Parse(this.txtNum1.Text);
            num2 = int.Parse(this.txtNum2.Text);
            int suma = num1 + num2;
            this.lblResultado.Text = suma.ToString();
            
            
            
        }

    }
}
