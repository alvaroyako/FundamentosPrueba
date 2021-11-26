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
    public partial class Form19TablaMultiplicar : Form
    {
        List<TextBox> resultados;


        public Form19TablaMultiplicar()
        {
            InitializeComponent();
            this.resultados = new List<TextBox>();
            foreach (TextBox txt in this.groupBox1.Controls)
            {
                    this.resultados.Add(txt);
            }
            this.resultados.Reverse();
        }

        private void btnTabla_Click(object sender, EventArgs e)
        {
            for(int i = this.resultados.Count; i >= 1; i--)
            {
                int num =int.Parse(this.txtNumero.Text);
                int res = num * i;
                this.resultados[i-1].Text = res.ToString();
            }
        }
    }
}
