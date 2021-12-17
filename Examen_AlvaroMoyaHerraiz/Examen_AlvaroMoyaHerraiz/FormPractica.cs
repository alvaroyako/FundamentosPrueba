using Examen_AlvaroMoyaHerraiz.Context;
using Examen_AlvaroMoyaHerraiz.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoADO
{
    public partial class FormPractica : Form
    {
        ExamenContext context;
        public FormPractica()
        {
            InitializeComponent();
            this.context = new ExamenContext();
            List<string> empresas = this.context.GetClientes();
            foreach(string empresa in empresas)
            {
                this.cmbclientes.Items.Add(empresa);
            }
        }

        private void cmbclientes_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.lstpedidos.Items.Clear();
            string nombre = this.cmbclientes.Text;
            List<Cliente> datos = this.context.GetDatosCliente(nombre);
            foreach(Cliente cli in datos)
            {
                this.txtempresa.Text = cli.Empresa.ToString();
                this.txtcontacto.Text = cli.Contacto.ToString();
                this.txtcargo.Text = cli.Cargo.ToString();
                this.txtciudad.Text = cli.Ciudad.ToString();
                this.txttelefono.Text = cli.Telefono.ToString();
            }

            string codigo = this.context.GetCodigoCliente(nombre);
            List<Pedido> pedidos = this.context.GetPedidosCliente(codigo);
            foreach (Pedido ped in pedidos)
            {
                
                this.lstpedidos.Items.Add(ped.CodigoPedido);
            }
        }

        private void lstpedidos_SelectedIndexChanged(object sender, EventArgs e)
        {
            string codigopedido = this.lstpedidos.SelectedItem.ToString();
            List<Pedido> pedidos = this.context.GetDatosPedido(codigopedido);
            foreach(Pedido ped in pedidos)
            {
                this.txtcodigopedido.Text = ped.CodigoPedido.ToString();
                this.txtfechaentrega.Text = ped.FechaEntrega.ToString();
                this.txtformaenvio.Text = ped.FormaEnvio.ToString();
                this.txtimporte.Text = ped.Importe.ToString();
            }
           
        }

        private void btnnuevopedido_Click(object sender, EventArgs e)
        {
            string nombre = this.cmbclientes.Text;
            string codigocliente = this.context.GetCodigoCliente(nombre);
            string codigopedido = this.txtcodigopedido.Text;
            string fecha = this.txtfechaentrega.Text;
            string forma = this.txtformaenvio.Text;
            int importe = int.Parse(this.txtimporte.Text);
            this.context.InsertarPedido(codigopedido, codigocliente, fecha, forma, importe);
        }
    }
}
