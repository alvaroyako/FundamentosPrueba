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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void labelName_Click(object sender, EventArgs e)
        {

        }

        private void txtName_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnPulsame_Click(object sender, EventArgs e)
        {
            this.txtName.Width = 250;
            this.btnPrueba.Text = "Pulsado...";
            this.btnPrueba.Location = new Point(20, 50);
            this.btnPrueba.BackColor = Color.Yellow;
            this.txtName.TextAlign = HorizontalAlignment.Center;

        }

        private void btnPrueba_Click(object sender, EventArgs e)
        {
            int numeroMayor = 999;
            short numeroMenor = 888;
        
        }
    }
}
