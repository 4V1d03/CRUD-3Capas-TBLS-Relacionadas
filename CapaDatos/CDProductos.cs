using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Collections;
using System.Text.RegularExpressions;

namespace CapaDatos
{
    public class CDProductos
    {
        private ConexionBD conexion = new ConexionBD();

        SqlDataReader leerfilas;
        DataTable tabla = new DataTable();
        SqlCommand comando = new SqlCommand();

        public DataTable mostrar()
        {
            comando.Connection = conexion.abrir();
            comando.CommandText = "mostrarProducto";
            comando.CommandType = CommandType.StoredProcedure;
            leerfilas = comando.ExecuteReader();//devuelve filas
            tabla.Load(leerfilas);
            conexion.cerrar();

            return tabla;
        }

        public DataTable listacategoria()
        {
            comando.Connection = conexion.abrir();
            comando.CommandText = "listaCategoria";
            comando.CommandType = CommandType.StoredProcedure;
            leerfilas = comando.ExecuteReader();//devuelve filas
            tabla.Load(leerfilas);
            conexion.cerrar();

            return tabla;
        }

        public DataTable listaMarca()
        {
            comando.Connection = conexion.abrir();
            comando.CommandText = "listaMarca";
            comando.CommandType = CommandType.StoredProcedure;
            leerfilas = comando.ExecuteReader();//devuelve filas
            tabla.Load(leerfilas);
            conexion.cerrar();

            return tabla;
        }

        public void Insertar(int idcat , int idmarca, string desc, double precio)
        {
            comando.Connection = conexion.abrir();
            comando.CommandText = "insetarProducto";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@idcat", idcat);
            comando.Parameters.AddWithValue("@idmarca", idmarca);
            comando.Parameters.AddWithValue("@desc", desc);
            comando.Parameters.AddWithValue("@precio", precio);
            comando.ExecuteNonQuery();
            comando.Parameters.Clear();
        }

        public void Modificar(int idcat, int idmarca, string desc, double precio, int IDPROD)
        {
            comando.Connection = conexion.abrir();
            comando.CommandText = "modificarProducto";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@idprod", IDPROD);
            comando.Parameters.AddWithValue("@idcat", idcat);
            comando.Parameters.AddWithValue("@idmarca", idmarca);
            comando.Parameters.AddWithValue("@desc", desc);
            comando.Parameters.AddWithValue("@precio", precio);
            comando.ExecuteNonQuery();
            comando.Parameters.Clear();
        }










    }
}
