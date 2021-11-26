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
    public partial class Form18SumarNumeros : Form
    {
        List<Button> botones;

        public Form18SumarNumeros()
        {
            InitializeComponent();
            this.botones = new List<Button>();
            foreach (Control control in this.panel1.Controls)
            {
                if (control is Button)
                {
                    this.botones.Add((Button)control);
                }
            }

            Random random = new Random();
            foreach (Button boton in this.botones)
            {
                int num = random.Next(1, 50);
                boton.Text = num.ToString();
                boton.Click += SumarNumero;
            }
        }

        private void SumarNumero(object sender, EventArgs e)
        {
            Button boton = (Button)sender;
            boton.BackColor = Color.LightGreen;
            int numero = int.Parse(boton.Text);
            int suma = int.Parse(this.txtSuma.Text);
            suma += numero;
            this.txtSuma.Text = suma.ToString();
        }

        private void btnReiniciar_Click(object sender, EventArgs e)
        {
            this.txtSuma.Text = "0";
            Random random = new Random();
            foreach (Button boton in this.botones)
            {
                int num = random.Next(1, 50);
                boton.Text = num.ToString();
                boton.BackColor = Color.FromKnownColor(KnownColor.Control);
            }
        }
    }

}
