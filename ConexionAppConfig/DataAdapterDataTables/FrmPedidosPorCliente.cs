using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DataAdapterDataTables
{
    public partial class FrmPedidosPorCliente : Form
    {
        ClsNegocios objNegocios = new ClsNegocios();

        public FrmPedidosPorCliente()
        {
            InitializeComponent();
        }

        private void FrmPedidosPorCliente_Load(object sender, EventArgs e)
        {
            cboClientes.DataSource = objNegocios.listarClientes();
            cboClientes.DisplayMember = "Cliente";
            cboClientes.ValueMember = "Codigo";
            cboClientes_SelectedIndexChanged(sender, e);
        }

        private void llenarClientes(object sender, EventArgs e)
        {
            

        }

        private void cboClientes_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                dgPedidos.DataSource = objNegocios.listarPedidosPorCliente(cboClientes.SelectedValue.ToString());
                lblCantidad.Text = objNegocios.listarPedidosPorCliente(cboClientes.SelectedValue.ToString()).Rows.Count.ToString();
            }
            catch (Exception)
            {
                
                MessageBox.Show("Ha ocurrido un error");
            }
        }
    }
}
