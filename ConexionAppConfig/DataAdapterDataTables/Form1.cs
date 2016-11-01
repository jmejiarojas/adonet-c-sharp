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
    public partial class Form1 : Form
    {
        ClsNegocios objNegocios = new ClsNegocios();

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
           

            //dtPedidos = objNegocios.listarPedidosPorAnio()

        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            DataTable dtPedidos = new DataTable();

            if (txtAnio.Text.Trim() != String.Empty)
            {
                int anio = int.Parse(txtAnio.Text);
                dtPedidos = objNegocios.listarPedidosPorAnio(anio);

                if (dtPedidos.Rows.Count > 0)
                {
                    dgPedidos.DataSource = dtPedidos;
                    dgPedidos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
                    lblCantidad.Text = dtPedidos.Rows.Count.ToString();
                }
                else
                {
                    dgPedidos.DataSource = null;
                    lblCantidad.Text = "0";
                    MessageBox.Show("No se encontraron pedidos...", "Aviso");
                }
            }
            else
            {
                MessageBox.Show("Ingrese un año", "Aviso");
            }
        }
    }
}
