namespace ComunicacionesMendoza.UI.Registros
{
    partial class rEntradaProductos
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
            System.Windows.Forms.Label fechaLabel;
            System.Windows.Forms.Label cantidadLabel;
            System.Windows.Forms.Label articulosLabel;
            System.Windows.Forms.Label entradaIdLabel;
            this.IconCerrar = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.ButtonNuevo = new System.Windows.Forms.Button();
            this.ButtonGuardar = new System.Windows.Forms.Button();
            this.ButtonEliminar = new System.Windows.Forms.Button();
            this.ButtonBuscar = new System.Windows.Forms.Button();
            this.fechaDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.EntradaIdNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.ProductosComboBox = new System.Windows.Forms.ComboBox();
            this.CantidadNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.GeneralErrorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            fechaLabel = new System.Windows.Forms.Label();
            cantidadLabel = new System.Windows.Forms.Label();
            articulosLabel = new System.Windows.Forms.Label();
            entradaIdLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.IconCerrar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.EntradaIdNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CantidadNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GeneralErrorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // fechaLabel
            // 
            fechaLabel.AutoSize = true;
            fechaLabel.Font = new System.Drawing.Font("Rockwell", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            fechaLabel.Location = new System.Drawing.Point(13, 91);
            fechaLabel.Name = "fechaLabel";
            fechaLabel.Size = new System.Drawing.Size(48, 14);
            fechaLabel.TabIndex = 54;
            fechaLabel.Text = "Fecha:";
            // 
            // cantidadLabel
            // 
            cantidadLabel.AutoSize = true;
            cantidadLabel.Font = new System.Drawing.Font("Rockwell", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            cantidadLabel.Location = new System.Drawing.Point(12, 153);
            cantidadLabel.Name = "cantidadLabel";
            cantidadLabel.Size = new System.Drawing.Size(66, 14);
            cantidadLabel.TabIndex = 53;
            cantidadLabel.Text = "Cantidad:";
            // 
            // articulosLabel
            // 
            articulosLabel.AutoSize = true;
            articulosLabel.Font = new System.Drawing.Font("Rockwell", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            articulosLabel.Location = new System.Drawing.Point(12, 120);
            articulosLabel.Name = "articulosLabel";
            articulosLabel.Size = new System.Drawing.Size(71, 14);
            articulosLabel.TabIndex = 52;
            articulosLabel.Text = "Productos:";
            // 
            // entradaIdLabel
            // 
            entradaIdLabel.AutoSize = true;
            entradaIdLabel.Font = new System.Drawing.Font("Rockwell", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            entradaIdLabel.Location = new System.Drawing.Point(12, 59);
            entradaIdLabel.Name = "entradaIdLabel";
            entradaIdLabel.Size = new System.Drawing.Size(74, 14);
            entradaIdLabel.TabIndex = 51;
            entradaIdLabel.Text = "Entrada Id:";
            // 
            // IconCerrar
            // 
            this.IconCerrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.IconCerrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.IconCerrar.Image = global::ComunicacionesMendoza.Properties.Resources.icons8_Close_Window_32;
            this.IconCerrar.Location = new System.Drawing.Point(281, 1);
            this.IconCerrar.Name = "IconCerrar";
            this.IconCerrar.Size = new System.Drawing.Size(20, 20);
            this.IconCerrar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.IconCerrar.TabIndex = 55;
            this.IconCerrar.TabStop = false;
            this.IconCerrar.Click += new System.EventHandler(this.IconCerrar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Font = new System.Drawing.Font("Rockwell", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(269, 23);
            this.label1.TabIndex = 56;
            this.label1.Text = "ENTRADA DE PRODUCTOS";
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
            this.ButtonNuevo.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.ButtonNuevo.Location = new System.Drawing.Point(16, 208);
            this.ButtonNuevo.Name = "ButtonNuevo";
            this.ButtonNuevo.Size = new System.Drawing.Size(75, 51);
            this.ButtonNuevo.TabIndex = 57;
            this.ButtonNuevo.Text = "Nuevo";
            this.ButtonNuevo.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.ButtonNuevo.UseVisualStyleBackColor = false;
            this.ButtonNuevo.Click += new System.EventHandler(this.ButtonNuevo_Click);
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
            this.ButtonGuardar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.ButtonGuardar.Location = new System.Drawing.Point(117, 208);
            this.ButtonGuardar.Name = "ButtonGuardar";
            this.ButtonGuardar.Size = new System.Drawing.Size(75, 51);
            this.ButtonGuardar.TabIndex = 58;
            this.ButtonGuardar.Text = "Guardar";
            this.ButtonGuardar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.ButtonGuardar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.ButtonGuardar.UseVisualStyleBackColor = false;
            this.ButtonGuardar.Click += new System.EventHandler(this.ButtonGuardar_Click);
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
            this.ButtonEliminar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.ButtonEliminar.Location = new System.Drawing.Point(214, 208);
            this.ButtonEliminar.Name = "ButtonEliminar";
            this.ButtonEliminar.Size = new System.Drawing.Size(75, 51);
            this.ButtonEliminar.TabIndex = 59;
            this.ButtonEliminar.Text = "Eliminar";
            this.ButtonEliminar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.ButtonEliminar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.ButtonEliminar.UseVisualStyleBackColor = false;
            this.ButtonEliminar.Click += new System.EventHandler(this.ButtonEliminar_Click);
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
            this.ButtonBuscar.Location = new System.Drawing.Point(215, 59);
            this.ButtonBuscar.Name = "ButtonBuscar";
            this.ButtonBuscar.Size = new System.Drawing.Size(74, 21);
            this.ButtonBuscar.TabIndex = 60;
            this.ButtonBuscar.Text = "Buscar";
            this.ButtonBuscar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.ButtonBuscar.UseVisualStyleBackColor = false;
            this.ButtonBuscar.Click += new System.EventHandler(this.ButtonBuscar_Click);
            // 
            // fechaDateTimePicker
            // 
            this.fechaDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.fechaDateTimePicker.Location = new System.Drawing.Point(83, 89);
            this.fechaDateTimePicker.Name = "fechaDateTimePicker";
            this.fechaDateTimePicker.Size = new System.Drawing.Size(109, 20);
            this.fechaDateTimePicker.TabIndex = 64;
            this.fechaDateTimePicker.ValueChanged += new System.EventHandler(this.fechaDateTimePicker_ValueChanged);
            // 
            // EntradaIdNumericUpDown
            // 
            this.EntradaIdNumericUpDown.Location = new System.Drawing.Point(84, 60);
            this.EntradaIdNumericUpDown.Name = "EntradaIdNumericUpDown";
            this.EntradaIdNumericUpDown.Size = new System.Drawing.Size(108, 20);
            this.EntradaIdNumericUpDown.TabIndex = 63;
            this.EntradaIdNumericUpDown.ValueChanged += new System.EventHandler(this.EntradaIdNumericUpDown_ValueChanged);
            // 
            // ProductosComboBox
            // 
            this.ProductosComboBox.BackColor = System.Drawing.Color.White;
            this.ProductosComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ProductosComboBox.FormattingEnabled = true;
            this.ProductosComboBox.Location = new System.Drawing.Point(83, 121);
            this.ProductosComboBox.Name = "ProductosComboBox";
            this.ProductosComboBox.Size = new System.Drawing.Size(198, 21);
            this.ProductosComboBox.TabIndex = 62;
            this.ProductosComboBox.SelectedIndexChanged += new System.EventHandler(this.ProductosComboBox_SelectedIndexChanged);
            // 
            // CantidadNumericUpDown
            // 
            this.CantidadNumericUpDown.Location = new System.Drawing.Point(84, 155);
            this.CantidadNumericUpDown.Maximum = new decimal(new int[] {
            1410065408,
            2,
            0,
            0});
            this.CantidadNumericUpDown.Minimum = new decimal(new int[] {
            1410065408,
            2,
            0,
            -2147483648});
            this.CantidadNumericUpDown.Name = "CantidadNumericUpDown";
            this.CantidadNumericUpDown.Size = new System.Drawing.Size(108, 20);
            this.CantidadNumericUpDown.TabIndex = 61;
            this.CantidadNumericUpDown.ValueChanged += new System.EventHandler(this.CantidadNumericUpDown_ValueChanged);
            // 
            // GeneralErrorProvider
            // 
            this.GeneralErrorProvider.ContainerControl = this;
            // 
            // rEntradaProductos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(303, 271);
            this.Controls.Add(this.fechaDateTimePicker);
            this.Controls.Add(this.EntradaIdNumericUpDown);
            this.Controls.Add(this.ProductosComboBox);
            this.Controls.Add(this.CantidadNumericUpDown);
            this.Controls.Add(this.ButtonBuscar);
            this.Controls.Add(this.ButtonEliminar);
            this.Controls.Add(this.ButtonGuardar);
            this.Controls.Add(this.ButtonNuevo);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.IconCerrar);
            this.Controls.Add(fechaLabel);
            this.Controls.Add(cantidadLabel);
            this.Controls.Add(articulosLabel);
            this.Controls.Add(entradaIdLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "rEntradaProductos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "rEntradaProductos";
            this.Load += new System.EventHandler(this.rEntradaProductos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.IconCerrar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.EntradaIdNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CantidadNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GeneralErrorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox IconCerrar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button ButtonNuevo;
        private System.Windows.Forms.Button ButtonGuardar;
        private System.Windows.Forms.Button ButtonEliminar;
        private System.Windows.Forms.Button ButtonBuscar;
        private System.Windows.Forms.DateTimePicker fechaDateTimePicker;
        private System.Windows.Forms.NumericUpDown EntradaIdNumericUpDown;
        private System.Windows.Forms.ComboBox ProductosComboBox;
        private System.Windows.Forms.NumericUpDown CantidadNumericUpDown;
        private System.Windows.Forms.ErrorProvider GeneralErrorProvider;
    }
}