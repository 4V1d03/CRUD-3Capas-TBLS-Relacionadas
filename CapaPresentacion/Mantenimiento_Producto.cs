using CapaNegocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaPresentacion
{
    public partial class Mantenimiento_Producto : Form
    {
        CNProducto CNProducto = new CNProducto();
        public string idProducto = null;
        public string operacion = "insertar";

        public Mantenimiento_Producto()
        {
            InitializeComponent();
        }

        private void Mantenimiento_Producto_Load(object sender, EventArgs e)
        {
            /*
            ListarCate();
            ListarMarca();
            */        
        }

        public void ListarCate()
        {
            CNProducto CNobjeto = new CNProducto();
            cbcategoria.DataSource = CNobjeto.listarCategoria();
            cbcategoria.DisplayMember = "CATEGORIA";
            cbcategoria.ValueMember = "IDCATEG";
        }

        public void ListarMarca()
        {
            CNProducto CNobjeto = new CNProducto();
            cbmarca.DataSource = CNobjeto.listarMarca();
            cbmarca.DisplayMember = "MARCA";
            cbmarca.ValueMember = "IDMARCA";
        }

        private void btnguardar_Click(object sender, EventArgs e)
        {
            if (operacion == "insertar")
            {
                CNProducto.insertar(Convert.ToInt32(cbcategoria.SelectedValue), Convert.ToInt32(cbmarca.SelectedValue), txtdescripcion.Text, txtprecio.Text);
                MessageBox.Show("Se Guardo Correctamente");

            }


            else if (operacion == "editar")
            {
                CNProducto.modificar(Convert.ToInt32(cbcategoria.SelectedValue), Convert.ToInt32(cbmarca.SelectedValue), txtdescripcion.Text, txtprecio.Text, idProducto);
                MessageBox.Show("Se Edito Correctamente");
                operacion = "insertar";
            }
        }


    }
}
