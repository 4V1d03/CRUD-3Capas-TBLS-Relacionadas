namespace CapaPresentacion
{
    partial class Mantenimiento_Producto
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnguardar = new Button();
            label4 = new Label();
            txtprecio = new TextBox();
            label3 = new Label();
            txtdescripcion = new TextBox();
            label2 = new Label();
            cbmarca = new ComboBox();
            label1 = new Label();
            cbcategoria = new ComboBox();
            SuspendLayout();
            // 
            // btnguardar
            // 
            btnguardar.Location = new Point(126, 191);
            btnguardar.Name = "btnguardar";
            btnguardar.Size = new Size(299, 48);
            btnguardar.TabIndex = 20;
            btnguardar.Text = "Guardar";
            btnguardar.UseVisualStyleBackColor = true;
            btnguardar.Click += btnguardar_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(56, 144);
            label4.Name = "label4";
            label4.Size = new Size(59, 23);
            label4.TabIndex = 19;
            label4.Text = "Precio";
            // 
            // txtprecio
            // 
            txtprecio.Location = new Point(126, 143);
            txtprecio.Name = "txtprecio";
            txtprecio.Size = new Size(299, 27);
            txtprecio.TabIndex = 18;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(19, 109);
            label3.Name = "label3";
            label3.Size = new Size(103, 23);
            label3.TabIndex = 17;
            label3.Text = "Descripcion";
            // 
            // txtdescripcion
            // 
            txtdescripcion.Location = new Point(126, 108);
            txtdescripcion.Name = "txtdescripcion";
            txtdescripcion.Size = new Size(299, 27);
            txtdescripcion.TabIndex = 16;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(56, 73);
            label2.Name = "label2";
            label2.Size = new Size(59, 23);
            label2.TabIndex = 15;
            label2.Text = "Marca";
            // 
            // cbmarca
            // 
            cbmarca.FormattingEnabled = true;
            cbmarca.Location = new Point(126, 72);
            cbmarca.Name = "cbmarca";
            cbmarca.Size = new Size(299, 28);
            cbmarca.TabIndex = 14;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(32, 37);
            label1.Name = "label1";
            label1.Size = new Size(88, 23);
            label1.TabIndex = 13;
            label1.Text = "Categoria";
            // 
            // cbcategoria
            // 
            cbcategoria.FormattingEnabled = true;
            cbcategoria.Location = new Point(126, 36);
            cbcategoria.Name = "cbcategoria";
            cbcategoria.Size = new Size(299, 28);
            cbcategoria.TabIndex = 12;
            // 
            // Mantenimiento_Producto
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(478, 290);
            Controls.Add(btnguardar);
            Controls.Add(label4);
            Controls.Add(txtprecio);
            Controls.Add(label3);
            Controls.Add(txtdescripcion);
            Controls.Add(label2);
            Controls.Add(cbmarca);
            Controls.Add(label1);
            Controls.Add(cbcategoria);
            Name = "Mantenimiento_Producto";
            Text = "Mantenimiento_Producto";
            Load += Mantenimiento_Producto_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnguardar;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        public TextBox txtprecio;
        public TextBox txtdescripcion;
        public ComboBox cbmarca;
        public ComboBox cbcategoria;
    }
}