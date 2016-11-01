using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace ConexionAppConfig
{
    class ClsNegocios
    {
        //Crear un objeto SqlConnection para la conexion con la BD, haciendo ref. al app.config
        SqlConnection cn = new SqlConnection(ConfigurationManager.ConnectionStrings["cn"].ConnectionString);

        public DataSet listarClientes()
        {
            SqlDataAdapter da = new SqlDataAdapter("SP_LISTADO_CLIENTES",cn);
            DataSet ds = new DataSet();
            da.Fill(ds);
            return ds;
        }

        //Ahora con DataTable
        public DataTable productosNombreListar(String nombre)
        {
            SqlDataAdapter da = new SqlDataAdapter("SP_PRODUCTOS_NOMBRE",cn);
            DataTable dt = new DataTable();
            da.SelectCommand.CommandType = CommandType.StoredProcedure;
            da.SelectCommand.Parameters.AddWithValue("@NOMBRE", nombre);
            da.Fill(dt);
            return dt;
        }
    }
}
