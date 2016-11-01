using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ConexionAppConfig
{
    public partial class FrmConsultaProductos : Form
    {
        ClsNegocios objNegocios = new ClsNegocios();

        public FrmConsultaProductos()
        {
            InitializeComponent();
        }

        private void FrmConsultaProductos_Load(object sender, EventArgs e)
        {
            dgProductos.DataSource = objNegocios.productosNombreListar(String.Empty);
            dgProductos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            lblCantidad.Text = objNegocios.productosNombreListar(String.Empty).Rows.Count.ToString();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            try
            {
                dgProductos.DataSource = objNegocios.productosNombreListar(txtProducto.Text.Trim());
                lblCantidad.Text = objNegocios.productosNombreListar(txtProducto.Text.Trim()).Rows.Count.ToString();
            }
            catch (Exception)
            {
                
                throw;
            }
        }
    }
}
