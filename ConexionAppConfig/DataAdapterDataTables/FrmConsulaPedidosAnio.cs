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
    public partial class FrmConsulaPedidosAnio : Form
    {
        ClsNegocios objNegocios = new ClsNegocios();

        public FrmConsulaPedidosAnio()
        {
            InitializeComponent();
        }

        private void FrmConsulaPedidosAnio_Load(object sender, EventArgs e)
        {
            cboAnioPedidos.DataSource = objNegocios.listarAniosPedidos();
            cboAnioPedidos.ValueMember = "ANIO";
            cboAnioPedidos.DisplayMember = "ANIO";
        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            DataTable dtPedidos = new DataTable();

            int anio = int.Parse(cboAnioPedidos.Text);
            dtPedidos = objNegocios.listarPedidosPorAnio(anio);

            if (dtPedidos.Rows.Count > 0)
            {
                dgPedidos.DataSource = dtPedidos;
                dgPedidos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
                lblCantidad.Text = dtPedidos.Rows.Count.ToString();
            }
        }
    }
}
