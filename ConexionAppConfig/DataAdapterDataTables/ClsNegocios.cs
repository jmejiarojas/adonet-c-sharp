using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using  System.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace DataAdapterDataTables
{
    class ClsNegocios
    {
        SqlConnection cn = new SqlConnection(ConfigurationManager.ConnectionStrings["cn"].ConnectionString);

        public DataTable listarPedidosPorAnio(int anio)
        {
            SqlDataAdapter da = new SqlDataAdapter("SP_PEDIDOS_FECHA",cn);
            da.SelectCommand.CommandType = CommandType.StoredProcedure;
            da.SelectCommand.Parameters.AddWithValue("@ANIO", anio);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }

        public DataTable listarAniosPedidos()
        {
            SqlDataAdapter da = new SqlDataAdapter("SP_ANIO_PEDIDOS",cn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;

        }

        public DataTable listarClientes()
        {
            SqlDataAdapter da = new SqlDataAdapter("usp_ClientesListar",cn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }

        public DataTable listarPedidosPorCliente(String idCliente)
        {
            SqlDataAdapter da = new SqlDataAdapter("usp_PedidosXCliente", cn);
            da.SelectCommand.CommandType = CommandType.StoredProcedure;
            da.SelectCommand.Parameters.AddWithValue("@idCliente", idCliente);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }
    }
}
