using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace CapaDatos
{
    public class ConexionBD
    {
        private SqlConnection conexionSQL = new SqlConnection("Server= MSI\\SQLEXPRESS;DataBase=PRACTICA_TABLAS_REL;Integrated Security=true");

        public SqlConnection abrir()
        {
            if (conexionSQL.State == ConnectionState.Closed)
            {
                conexionSQL.Open();
            }
            return conexionSQL;
        }

        public SqlConnection cerrar()
        {
            if (conexionSQL.State == ConnectionState.Open)
            {
                conexionSQL.Close();
            }
            return conexionSQL;
        }

        public void m()
        { }

    }
}
