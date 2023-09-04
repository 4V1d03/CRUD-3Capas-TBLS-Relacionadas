using CapaNegocio;


namespace CapaPresentacion
{
    public partial class Form1 : Form
    {
        CNProducto CNProducto = new CNProducto();
        private string idProducto = null;
        private string operacion = "insertar";

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Mostrarproductos();
            ListarCate();
            ListarMarca();
        }

        private void Mostrarproductos()
        {
            CNProducto CNobjeto = new CNProducto();
            dataGridView1.DataSource = CNobjeto.MostrarProductos();
        }

        private void ListarCate()
        {
            CNProducto CNobjeto = new CNProducto();
            cbcategoria.DataSource = CNobjeto.listarCategoria();
            cbcategoria.DisplayMember = "CATEGORIA";
            cbcategoria.ValueMember = "IDCATEG";
        }

        private void ListarMarca()
        {
            CNProducto CNobjeto = new CNProducto();
            cbmarca.DataSource = CNobjeto.listarMarca();
            cbmarca.DisplayMember = "MARCA";
            cbmarca.ValueMember = "IDMARCA";
        }

        private void limpiar()
        {
            txtdescripcion.Clear();
            txtprecio.Clear();
        }

        private void btnguardar_Click(object sender, EventArgs e)
        {
            if (operacion == "insertar")
            {
                CNProducto.insertar(Convert.ToInt32(cbcategoria.SelectedValue), Convert.ToInt32(cbmarca.SelectedValue), txtdescripcion.Text, txtprecio.Text);
                MessageBox.Show("Se Guardo Correctamente");
                Mostrarproductos();
                limpiar();
            }


            else if (operacion == "editar")
            {
                CNProducto.modificar(Convert.ToInt32(cbcategoria.SelectedValue), Convert.ToInt32(cbmarca.SelectedValue), txtdescripcion.Text, txtprecio.Text, idProducto);
                MessageBox.Show("Se Edito Correctamente");
                Mostrarproductos();
                limpiar();
                operacion = "insertar";



            }

        }

        private void btnmodificar_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                operacion = "editar";
                cbcategoria.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();// la cell debe de estar escrita igual que en la BD
                cbmarca.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
                txtdescripcion.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
                txtprecio.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
                idProducto = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            }

            else
            {
                MessageBox.Show("seleccione una fila por favor");
            }
        }

        private void btneliminar_Click(object sender, EventArgs e)
        {

        }

        private void btnmodificarPro_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                Mantenimiento_Producto mant = new Mantenimiento_Producto();
                mant.operacion = "editar";
                mant.ListarCate();
                mant.ListarMarca();
                //pasa los datos del data grid a los CB y TXT del formulario mantenimiento 
                mant.idProducto = dataGridView1.CurrentRow.Cells[0].Value.ToString(); //los txt y cb (controles) deben de estar en Public
                mant.cbcategoria.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
                mant.cbmarca.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
                mant.txtdescripcion.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
                mant.txtprecio.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
                mant.ShowDialog();
                Mostrarproductos();
            }

            else
            {
                MessageBox.Show("seleccione una fila por favor");
            }

        }





    }
}