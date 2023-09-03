using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using CapaDatos;

namespace CapaNegocio
{
    public class CNProducto
    {
        private CDProductos CDproducto = new CDProductos();

        public DataTable MostrarProductos()
        {
            DataTable tabla = new DataTable();
            tabla = CDproducto.mostrar();
            return tabla;
        }

        public DataTable listarCategoria()
        {
            DataTable cate = new DataTable();
            cate = CDproducto.listacategoria();
            return cate;
        }

        public DataTable listarMarca()
        {
            DataTable marca = new DataTable();
            marca = CDproducto.listaMarca();
            return marca;
        }

        public void insertar(int idcat, int idmarca, string desc, string precio)
        { 
            CDproducto.Insertar(idcat, idmarca, desc,Convert.ToDouble(precio));
        }

        public void modificar(int idcat, int idmarca, string desc, string precio, string idprod)
        {
            CDproducto.Modificar(idcat, idmarca, desc, Convert.ToDouble(precio), Convert.ToInt32(idprod));
        }

























    }
}
