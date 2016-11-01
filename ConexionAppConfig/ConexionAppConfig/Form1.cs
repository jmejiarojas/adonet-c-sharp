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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ClsNegocios objNegocios = new ClsNegocios();

            dgClientes.DataSource = objNegocios.listarClientes().Tables[0];
            dgClientes.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            lblCantidad.Text = objNegocios.listarClientes().Tables[0].Rows.Count.ToString();
        }
    }
}
