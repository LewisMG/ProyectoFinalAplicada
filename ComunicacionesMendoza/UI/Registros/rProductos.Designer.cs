namespace ComunicacionesMendoza.UI.Registros
{
    partial class rProductos
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label precioLabel;
            System.Windows.Forms.Label costoLabel;
            System.Windows.Forms.Label descripcionLabel;
            System.Windows.Forms.Label ProductoIdLabel;
            System.Windows.Forms.Label inventarioLabel;
            System.Windows.Forms.Label gananciaLabel;
            this.label1 = new System.Windows.Forms.Label();
            this.ProductoIdNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.DescripcionTextBox = new System.Windows.Forms.TextBox();
            this.PrecioNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.CostoNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.InventarioTextBox = new System.Windows.Forms.TextBox();
            this.GananciaNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.ButtonNuevo = new System.Windows.Forms.Button();
            this.ButtonEliminar = new System.Windows.Forms.Button();
            this.ButtonGuardar = new System.Windows.Forms.Button();
            this.ButtonBuscar = new System.Windows.Forms.Button();
            this.IconCerrar = new System.Windows.Forms.PictureBox();
            this.GeneralErrorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            precioLabel = new System.Windows.Forms.Label();
            costoLabel = new System.Windows.Forms.Label();
            descripcionLabel = new System.Windows.Forms.Label();
            ProductoIdLabel = new System.Windows.Forms.Label();
            inventarioLabel = new System.Windows.Forms.Label();
            gananciaLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.ProductoIdNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PrecioNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CostoNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GananciaNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.IconCerrar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GeneralErrorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // precioLabel
            // 
            precioLabel.AutoSize = true;
            precioLabel.Font = new System.Drawing.Font("Rockwell", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            precioLabel.ForeColor = System.Drawing.Color.Black;
            precioLabel.Location = new System.Drawing.Point(12, 178);
            precioLabel.Name = "precioLabel";
            precioLabel.Size = new System.Drawing.Size(86, 14);
            precioLabel.TabIndex = 13;
            precioLabel.Text = "Precio Venta:";
            // 
            // costoLabel
            // 
            costoLabel.AutoSize = true;
            costoLabel.Font = new System.Drawing.Font("Rockwell", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            costoLabel.ForeColor = System.Drawing.Color.Black;
            costoLabel.Location = new System.Drawing.Point(12, 136);
            costoLabel.Name = "costoLabel";
            costoLabel.Size = new System.Drawing.Size(100, 14);
            costoLabel.TabIndex = 12;
            costoLabel.Text = "Precio Compra:";
            // 
            // descripcionLabel
            // 
            descripcionLabel.AutoSize = true;
            descripcionLabel.Font = new System.Drawing.Font("Rockwell", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            descripcionLabel.ForeColor = System.Drawing.Color.Black;
            descripcionLabel.Location = new System.Drawing.Point(12, 91);
            descripcionLabel.Name = "descripcionLabel";
            descripcionLabel.Size = new System.Drawing.Size(84, 14);
            descripcionLabel.TabIndex = 11;
            descripcionLabel.Text = "Descripcion:";
            // 
            // ProductoIdLabel
            // 
            ProductoIdLabel.AutoSize = true;
            ProductoIdLabel.Font = new System.Drawing.Font("Rockwell", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            ProductoIdLabel.ForeColor = System.Drawing.Color.Black;
            ProductoIdLabel.Location = new System.Drawing.Point(12, 51);
            ProductoIdLabel.Name = "ProductoIdLabel";
            ProductoIdLabel.Size = new System.Drawing.Size(81, 14);
            ProductoIdLabel.TabIndex = 10;
            ProductoIdLabel.Text = "Producto Id:";
            // 
            // inventarioLabel
            // 
            inventarioLabel.AutoSize = true;
            inventarioLabel.Font = new System.Drawing.Font("Rockwell", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            inventarioLabel.ForeColor = System.Drawing.Color.Black;
            inventarioLabel.Location = new System.Drawing.Point(236, 176);
            inventarioLabel.Name = "inventarioLabel";
            inventarioLabel.Size = new System.Drawing.Size(73, 14);
            inventarioLabel.TabIndex = 23;
            inventarioLabel.Text = "Inventario:";
            // 
            // gananciaLabel
            // 
            gananciaLabel.AutoSize = true;
            gananciaLabel.Font = new System.Drawing.Font("Rockwell", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            gananciaLabel.ForeColor = System.Drawing.Color.Black;
            gananciaLabel.Location = new System.Drawing.Point(236, 136);
            gananciaLabel.Name = "gananciaLabel";
            gananciaLabel.Size = new System.Drawing.Size(69, 14);
            gananciaLabel.TabIndex = 22;
            gananciaLabel.Text = "Ganancia:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Font = new System.Drawing.Font("Rockwell", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(143, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(149, 25);
            this.label1.TabIndex = 2;
            this.label1.Text = "PRODUCTOS";
            // 
            // ProductoIdNumericUpDown
            // 
            this.ProductoIdNumericUpDown.Location = new System.Drawing.Point(95, 51);
            this.ProductoIdNumericUpDown.Maximum = new decimal(new int[] {
            -1486618624,
            232830643,
            0,
            0});
            this.ProductoIdNumericUpDown.Minimum = new decimal(new int[] {
            1874919424,
            2328306,
            0,
            -2147483648});
            this.ProductoIdNumericUpDown.Name = "ProductoIdNumericUpDown";
            this.ProductoIdNumericUpDown.Size = new System.Drawing.Size(120, 20);
            this.ProductoIdNumericUpDown.TabIndex = 17;
            // 
            // DescripcionTextBox
            // 
            this.DescripcionTextBox.Location = new System.Drawing.Point(95, 89);
            this.DescripcionTextBox.Name = "DescripcionTextBox";
            this.DescripcionTextBox.Size = new System.Drawing.Size(345, 20);
            this.DescripcionTextBox.TabIndex = 16;
            // 
            // PrecioNumericUpDown
            // 
            this.PrecioNumericUpDown.Location = new System.Drawing.Point(112, 178);
            this.PrecioNumericUpDown.Maximum = new decimal(new int[] {
            -1486618624,
            232830643,
            0,
            0});
            this.PrecioNumericUpDown.Minimum = new decimal(new int[] {
            1874919424,
            2328306,
            0,
            -2147483648});
            this.PrecioNumericUpDown.Name = "PrecioNumericUpDown";
            this.PrecioNumericUpDown.Size = new System.Drawing.Size(120, 20);
            this.PrecioNumericUpDown.TabIndex = 15;
            this.PrecioNumericUpDown.ValueChanged += new System.EventHandler(this.PrecioNumericUpDown_ValueChanged);
            // 
            // CostoNumericUpDown
            // 
            this.CostoNumericUpDown.Location = new System.Drawing.Point(112, 136);
            this.CostoNumericUpDown.Maximum = new decimal(new int[] {
            -1486618624,
            232830643,
            0,
            0});
            this.CostoNumericUpDown.Minimum = new decimal(new int[] {
            1874919424,
            2328306,
            0,
            -2147483648});
            this.CostoNumericUpDown.Name = "CostoNumericUpDown";
            this.CostoNumericUpDown.Size = new System.Drawing.Size(120, 20);
            this.CostoNumericUpDown.TabIndex = 14;
            // 
            // InventarioTextBox
            // 
            this.InventarioTextBox.Location = new System.Drawing.Point(320, 178);
            this.InventarioTextBox.Name = "InventarioTextBox";
            this.InventarioTextBox.ReadOnly = true;
            this.InventarioTextBox.Size = new System.Drawing.Size(120, 20);
            this.InventarioTextBox.TabIndex = 25;
            // 
            // GananciaNumericUpDown
            // 
            this.GananciaNumericUpDown.Location = new System.Drawing.Point(320, 136);
            this.GananciaNumericUpDown.Maximum = new decimal(new int[] {
            -1486618624,
            232830643,
            0,
            0});
            this.GananciaNumericUpDown.Minimum = new decimal(new int[] {
            1874919424,
            2328306,
            0,
            -2147483648});
            this.GananciaNumericUpDown.Name = "GananciaNumericUpDown";
            this.GananciaNumericUpDown.ReadOnly = true;
            this.GananciaNumericUpDown.Size = new System.Drawing.Size(120, 20);
            this.GananciaNumericUpDown.TabIndex = 24;
            // 
            // ButtonNuevo
            // 
            this.ButtonNuevo.BackColor = System.Drawing.Color.MediumBlue;
            this.ButtonNuevo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ButtonNuevo.FlatAppearance.BorderSize = 0;
            this.ButtonNuevo.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkGray;
            this.ButtonNuevo.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(50)))));
            this.ButtonNuevo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonNuevo.Font = new System.Drawing.Font("Rockwell", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonNuevo.ForeColor = System.Drawing.Color.White;
            this.ButtonNuevo.Image = global::ComunicacionesMendoza.Properties.Resources.icons8_Add_New_32;
            this.ButtonNuevo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ButtonNuevo.Location = new System.Drawing.Point(15, 245);
            this.ButtonNuevo.Name = "ButtonNuevo";
            this.ButtonNuevo.Size = new System.Drawing.Size(102, 42);
            this.ButtonNuevo.TabIndex = 29;
            this.ButtonNuevo.Text = "Nuevo";
            this.ButtonNuevo.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.ButtonNuevo.UseVisualStyleBackColor = false;
            this.ButtonNuevo.Click += new System.EventHandler(this.ButtonNuevo_Click_1);
            // 
            // ButtonEliminar
            // 
            this.ButtonEliminar.BackColor = System.Drawing.Color.MediumBlue;
            this.ButtonEliminar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ButtonEliminar.FlatAppearance.BorderSize = 0;
            this.ButtonEliminar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkGray;
            this.ButtonEliminar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(50)))));
            this.ButtonEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonEliminar.Font = new System.Drawing.Font("Rockwell", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonEliminar.ForeColor = System.Drawing.Color.White;
            this.ButtonEliminar.Image = global::ComunicacionesMendoza.Properties.Resources.icons8_Eraser_32;
            this.ButtonEliminar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ButtonEliminar.Location = new System.Drawing.Point(333, 245);
            this.ButtonEliminar.Name = "ButtonEliminar";
            this.ButtonEliminar.Size = new System.Drawing.Size(102, 42);
            this.ButtonEliminar.TabIndex = 28;
            this.ButtonEliminar.Text = "Eliminar";
            this.ButtonEliminar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.ButtonEliminar.UseVisualStyleBackColor = false;
            this.ButtonEliminar.Click += new System.EventHandler(this.ButtonEliminar_Click_1);
            // 
            // ButtonGuardar
            // 
            this.ButtonGuardar.BackColor = System.Drawing.Color.MediumBlue;
            this.ButtonGuardar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ButtonGuardar.FlatAppearance.BorderSize = 0;
            this.ButtonGuardar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkGray;
            this.ButtonGuardar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(50)))));
            this.ButtonGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonGuardar.Font = new System.Drawing.Font("Rockwell", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonGuardar.ForeColor = System.Drawing.Color.White;
            this.ButtonGuardar.Image = global::ComunicacionesMendoza.Properties.Resources.icons8_Save_32;
            this.ButtonGuardar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ButtonGuardar.Location = new System.Drawing.Point(176, 245);
            this.ButtonGuardar.Name = "ButtonGuardar";
            this.ButtonGuardar.Size = new System.Drawing.Size(102, 42);
            this.ButtonGuardar.TabIndex = 27;
            this.ButtonGuardar.Text = "Guardar";
            this.ButtonGuardar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.ButtonGuardar.UseVisualStyleBackColor = false;
            this.ButtonGuardar.Click += new System.EventHandler(this.ButtonGuardar_Click_1);
            // 
            // ButtonBuscar
            // 
            this.ButtonBuscar.BackColor = System.Drawing.Color.MediumBlue;
            this.ButtonBuscar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ButtonBuscar.FlatAppearance.BorderSize = 0;
            this.ButtonBuscar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkGray;
            this.ButtonBuscar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(50)))));
            this.ButtonBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonBuscar.Font = new System.Drawing.Font("Rockwell", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonBuscar.ForeColor = System.Drawing.Color.White;
            this.ButtonBuscar.Image = global::ComunicacionesMendoza.Properties.Resources.icons8_Google_Web_Search_16;
            this.ButtonBuscar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ButtonBuscar.Location = new System.Drawing.Point(239, 51);
            this.ButtonBuscar.Name = "ButtonBuscar";
            this.ButtonBuscar.Size = new System.Drawing.Size(78, 27);
            this.ButtonBuscar.TabIndex = 26;
            this.ButtonBuscar.Text = "Buscar";
            this.ButtonBuscar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.ButtonBuscar.UseVisualStyleBackColor = false;
            this.ButtonBuscar.Click += new System.EventHandler(this.ButtonBuscar_Click);
            // 
            // IconCerrar
            // 
            this.IconCerrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.IconCerrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.IconCerrar.Image = global::ComunicacionesMendoza.Properties.Resources.icons8_Close_Window_32;
            this.IconCerrar.Location = new System.Drawing.Point(441, 0);
            this.IconCerrar.Name = "IconCerrar";
            this.IconCerrar.Size = new System.Drawing.Size(20, 20);
            this.IconCerrar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.IconCerrar.TabIndex = 21;
            this.IconCerrar.TabStop = false;
            this.IconCerrar.Click += new System.EventHandler(this.IconCerrar_Click);
            // 
            // GeneralErrorProvider
            // 
            this.GeneralErrorProvider.ContainerControl = this;
            // 
            // rProductos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(461, 303);
            this.Controls.Add(this.ButtonNuevo);
            this.Controls.Add(this.ButtonEliminar);
            this.Controls.Add(this.ButtonGuardar);
            this.Controls.Add(this.ButtonBuscar);
            this.Controls.Add(this.InventarioTextBox);
            this.Controls.Add(this.GananciaNumericUpDown);
            this.Controls.Add(inventarioLabel);
            this.Controls.Add(gananciaLabel);
            this.Controls.Add(this.IconCerrar);
            this.Controls.Add(this.ProductoIdNumericUpDown);
            this.Controls.Add(this.DescripcionTextBox);
            this.Controls.Add(this.PrecioNumericUpDown);
            this.Controls.Add(this.CostoNumericUpDown);
            this.Controls.Add(precioLabel);
            this.Controls.Add(costoLabel);
            this.Controls.Add(descripcionLabel);
            this.Controls.Add(ProductoIdLabel);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "rProductos";
            this.Text = "rProductos";
            ((System.ComponentModel.ISupportInitialize)(this.ProductoIdNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PrecioNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CostoNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GananciaNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.IconCerrar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GeneralErrorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown ProductoIdNumericUpDown;
        private System.Windows.Forms.TextBox DescripcionTextBox;
        private System.Windows.Forms.NumericUpDown PrecioNumericUpDown;
        private System.Windows.Forms.NumericUpDown CostoNumericUpDown;
        private System.Windows.Forms.PictureBox IconCerrar;
        private System.Windows.Forms.TextBox InventarioTextBox;
        private System.Windows.Forms.NumericUpDown GananciaNumericUpDown;
        private System.Windows.Forms.Button ButtonBuscar;
        private System.Windows.Forms.Button ButtonNuevo;
        private System.Windows.Forms.Button ButtonEliminar;
        private System.Windows.Forms.Button ButtonGuardar;
        private System.Windows.Forms.ErrorProvider GeneralErrorProvider;
    }
}