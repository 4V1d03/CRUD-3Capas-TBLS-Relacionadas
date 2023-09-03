namespace CapaPresentacion
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            dataGridView1 = new DataGridView();
            cbcategoria = new ComboBox();
            label1 = new Label();
            label2 = new Label();
            cbmarca = new ComboBox();
            txtdescripcion = new TextBox();
            label3 = new Label();
            label4 = new Label();
            txtprecio = new TextBox();
            btnguardar = new Button();
            btnmodificar = new Button();
            btneliminar = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(25, 25);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 29;
            dataGridView1.Size = new Size(677, 368);
            dataGridView1.TabIndex = 0;
            // 
            // cbcategoria
            // 
            cbcategoria.FormattingEnabled = true;
            cbcategoria.Location = new Point(826, 56);
            cbcategoria.Name = "cbcategoria";
            cbcategoria.Size = new Size(241, 28);
            cbcategoria.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(746, 59);
            label1.Name = "label1";
            label1.Size = new Size(74, 20);
            label1.TabIndex = 2;
            label1.Text = "Categoria";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(770, 93);
            label2.Name = "label2";
            label2.Size = new Size(50, 20);
            label2.TabIndex = 4;
            label2.Text = "Marca";
            // 
            // cbmarca
            // 
            cbmarca.FormattingEnabled = true;
            cbmarca.Location = new Point(826, 90);
            cbmarca.Name = "cbmarca";
            cbmarca.Size = new Size(241, 28);
            cbmarca.TabIndex = 3;
            // 
            // txtdescripcion
            // 
            txtdescripcion.Location = new Point(826, 124);
            txtdescripcion.Name = "txtdescripcion";
            txtdescripcion.Size = new Size(241, 27);
            txtdescripcion.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(733, 127);
            label3.Name = "label3";
            label3.Size = new Size(87, 20);
            label3.TabIndex = 6;
            label3.Text = "Descripcion";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(770, 160);
            label4.Name = "label4";
            label4.Size = new Size(50, 20);
            label4.TabIndex = 8;
            label4.Text = "Precio";
            // 
            // txtprecio
            // 
            txtprecio.Location = new Point(826, 157);
            txtprecio.Name = "txtprecio";
            txtprecio.Size = new Size(241, 27);
            txtprecio.TabIndex = 7;
            // 
            // btnguardar
            // 
            btnguardar.Location = new Point(746, 223);
            btnguardar.Name = "btnguardar";
            btnguardar.Size = new Size(321, 48);
            btnguardar.TabIndex = 9;
            btnguardar.Text = "Guardar";
            btnguardar.UseVisualStyleBackColor = true;
            btnguardar.Click += btnguardar_Click;
            // 
            // btnmodificar
            // 
            btnmodificar.Location = new Point(746, 277);
            btnmodificar.Name = "btnmodificar";
            btnmodificar.Size = new Size(321, 48);
            btnmodificar.TabIndex = 10;
            btnmodificar.Text = "Modificar";
            btnmodificar.UseVisualStyleBackColor = true;
            btnmodificar.Click += btnmodificar_Click;
            // 
            // btneliminar
            // 
            btneliminar.Location = new Point(746, 331);
            btneliminar.Name = "btneliminar";
            btneliminar.Size = new Size(321, 48);
            btneliminar.TabIndex = 11;
            btneliminar.Text = "Eliminar";
            btneliminar.UseVisualStyleBackColor = true;
            btneliminar.Click += btneliminar_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1083, 414);
            Controls.Add(btneliminar);
            Controls.Add(btnmodificar);
            Controls.Add(btnguardar);
            Controls.Add(label4);
            Controls.Add(txtprecio);
            Controls.Add(label3);
            Controls.Add(txtdescripcion);
            Controls.Add(label2);
            Controls.Add(cbmarca);
            Controls.Add(label1);
            Controls.Add(cbcategoria);
            Controls.Add(dataGridView1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private ComboBox cbcategoria;
        private Label label1;
        private Label label2;
        private ComboBox cbmarca;
        private TextBox txtdescripcion;
        private Label label3;
        private Label label4;
        private TextBox txtprecio;
        private Button btnguardar;
        private Button btnmodificar;
        private Button btneliminar;
    }
}