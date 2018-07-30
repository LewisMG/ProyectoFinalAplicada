namespace ComunicacionesMendoza.UI.Registros
{
    partial class rVentas
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
            System.Windows.Forms.Label descripcionLabel;
            System.Windows.Forms.Label VentaIdLabel;
            this.VentaDetalleDataGridView = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.DescripcionTextBox = new System.Windows.Forms.TextBox();
            this.VentaIdNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.FechaVentaDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.ImporteTextBox = new System.Windows.Forms.TextBox();
            this.PrecioTextBox = new System.Windows.Forms.TextBox();
            this.CantidadNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.ProductoComboBox = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.TotalTextBox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.PanelCliente = new System.Windows.Forms.Panel();
            this.NombreClienteTextBox = new System.Windows.Forms.TextBox();
            this.TelefonomaskedTextBox = new System.Windows.Forms.MaskedTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.GeneralErrorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.label10 = new System.Windows.Forms.Label();
            this.UsuariosComboBox = new System.Windows.Forms.ComboBox();
            this.ButtonRemover = new System.Windows.Forms.Button();
            this.ButtonAgregar = new System.Windows.Forms.Button();
            this.ButtonBuscar = new System.Windows.Forms.Button();
            this.IconCerrar = new System.Windows.Forms.PictureBox();
            this.ButtonNuevo = new System.Windows.Forms.Button();
            this.ButtonEliminar = new System.Windows.Forms.Button();
            this.ButtonGuardar = new System.Windows.Forms.Button();
            this.ButtonRecibo = new System.Windows.Forms.Button();
            descripcionLabel = new System.Windows.Forms.Label();
            VentaIdLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.VentaDetalleDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.VentaIdNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CantidadNumericUpDown)).BeginInit();
            this.PanelCliente.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GeneralErrorProvider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.IconCerrar)).BeginInit();
            this.SuspendLayout();
            // 
            // descripcionLabel
            // 
            descripcionLabel.AutoSize = true;
            descripcionLabel.Font = new System.Drawing.Font("Rockwell", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            descripcionLabel.ForeColor = System.Drawing.Color.Black;
            descripcionLabel.Location = new System.Drawing.Point(12, 79);
            descripcionLabel.Name = "descripcionLabel";
            descripcionLabel.Size = new System.Drawing.Size(163, 15);
            descripcionLabel.TabIndex = 77;
            descripcionLabel.Text = "Descripcion de la Venta:";
            // 
            // VentaIdLabel
            // 
            VentaIdLabel.AutoSize = true;
            VentaIdLabel.Font = new System.Drawing.Font("Rockwell", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            VentaIdLabel.ForeColor = System.Drawing.Color.Black;
            VentaIdLabel.Location = new System.Drawing.Point(12, 46);
            VentaIdLabel.Name = "VentaIdLabel";
            VentaIdLabel.Size = new System.Drawing.Size(65, 15);
            VentaIdLabel.TabIndex = 76;
            VentaIdLabel.Text = "Venta Id:";
            // 
            // VentaDetalleDataGridView
            // 
            this.VentaDetalleDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.VentaDetalleDataGridView.Location = new System.Drawing.Point(12, 220);
            this.VentaDetalleDataGridView.Name = "VentaDetalleDataGridView";
            this.VentaDetalleDataGridView.Size = new System.Drawing.Size(601, 217);
            this.VentaDetalleDataGridView.TabIndex = 70;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Font = new System.Drawing.Font("Rockwell", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(242, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 25);
            this.label1.TabIndex = 71;
            this.label1.Text = "VENTAS";
            // 
            // DescripcionTextBox
            // 
            this.DescripcionTextBox.Location = new System.Drawing.Point(15, 95);
            this.DescripcionTextBox.Multiline = true;
            this.DescripcionTextBox.Name = "DescripcionTextBox";
            this.DescripcionTextBox.Size = new System.Drawing.Size(219, 52);
            this.DescripcionTextBox.TabIndex = 78;
            // 
            // VentaIdNumericUpDown
            // 
            this.VentaIdNumericUpDown.Location = new System.Drawing.Point(96, 46);
            this.VentaIdNumericUpDown.Maximum = new decimal(new int[] {
            -1486618624,
            232830643,
            0,
            0});
            this.VentaIdNumericUpDown.Minimum = new decimal(new int[] {
            1874919424,
            2328306,
            0,
            -2147483648});
            this.VentaIdNumericUpDown.Name = "VentaIdNumericUpDown";
            this.VentaIdNumericUpDown.Size = new System.Drawing.Size(120, 20);
            this.VentaIdNumericUpDown.TabIndex = 79;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Rockwell", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(367, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(108, 15);
            this.label2.TabIndex = 81;
            this.label2.Text = "Fecha de Venta:";
            // 
            // FechaVentaDateTimePicker
            // 
            this.FechaVentaDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.FechaVentaDateTimePicker.Location = new System.Drawing.Point(484, 46);
            this.FechaVentaDateTimePicker.Name = "FechaVentaDateTimePicker";
            this.FechaVentaDateTimePicker.Size = new System.Drawing.Size(129, 20);
            this.FechaVentaDateTimePicker.TabIndex = 82;
            // 
            // ImporteTextBox
            // 
            this.ImporteTextBox.Location = new System.Drawing.Point(430, 194);
            this.ImporteTextBox.Name = "ImporteTextBox";
            this.ImporteTextBox.ReadOnly = true;
            this.ImporteTextBox.Size = new System.Drawing.Size(93, 20);
            this.ImporteTextBox.TabIndex = 87;
            // 
            // PrecioTextBox
            // 
            this.PrecioTextBox.Location = new System.Drawing.Point(331, 194);
            this.PrecioTextBox.Name = "PrecioTextBox";
            this.PrecioTextBox.ReadOnly = true;
            this.PrecioTextBox.Size = new System.Drawing.Size(93, 20);
            this.PrecioTextBox.TabIndex = 86;
            this.PrecioTextBox.TextChanged += new System.EventHandler(this.PrecioTextBox_TextChanged);
            // 
            // CantidadNumericUpDown
            // 
            this.CantidadNumericUpDown.Location = new System.Drawing.Point(240, 194);
            this.CantidadNumericUpDown.Name = "CantidadNumericUpDown";
            this.CantidadNumericUpDown.Size = new System.Drawing.Size(86, 20);
            this.CantidadNumericUpDown.TabIndex = 85;
            this.CantidadNumericUpDown.ValueChanged += new System.EventHandler(this.CantidadNumericUpDown_ValueChanged);
            // 
            // ProductoComboBox
            // 
            this.ProductoComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ProductoComboBox.FormattingEnabled = true;
            this.ProductoComboBox.Location = new System.Drawing.Point(80, 193);
            this.ProductoComboBox.Name = "ProductoComboBox";
            this.ProductoComboBox.Size = new System.Drawing.Size(154, 21);
            this.ProductoComboBox.TabIndex = 84;
            this.ProductoComboBox.SelectedIndexChanged += new System.EventHandler(this.ProductoComboBox_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Rockwell", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(12, 196);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(69, 15);
            this.label5.TabIndex = 83;
            this.label5.Text = "Producto:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Rockwell", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(427, 173);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(63, 15);
            this.label9.TabIndex = 90;
            this.label9.Text = "Importe:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Rockwell", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(328, 176);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(53, 15);
            this.label8.TabIndex = 89;
            this.label8.Text = "Precio:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Rockwell", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(237, 176);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(72, 15);
            this.label7.TabIndex = 88;
            this.label7.Text = "Cantidad:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Rockwell", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(466, 445);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(41, 14);
            this.label12.TabIndex = 99;
            this.label12.Text = "Total:";
            // 
            // TotalTextBox
            // 
            this.TotalTextBox.Location = new System.Drawing.Point(513, 442);
            this.TotalTextBox.Name = "TotalTextBox";
            this.TotalTextBox.ReadOnly = true;
            this.TotalTextBox.Size = new System.Drawing.Size(100, 20);
            this.TotalTextBox.TabIndex = 101;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Rockwell", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.DarkBlue;
            this.label6.Location = new System.Drawing.Point(392, 78);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(206, 14);
            this.label6.TabIndex = 103;
            this.label6.Text = "Introducir Solo De Ser Requerido:";
            // 
            // PanelCliente
            // 
            this.PanelCliente.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PanelCliente.Controls.Add(this.NombreClienteTextBox);
            this.PanelCliente.Controls.Add(this.TelefonomaskedTextBox);
            this.PanelCliente.Controls.Add(this.label4);
            this.PanelCliente.Controls.Add(this.label3);
            this.PanelCliente.Location = new System.Drawing.Point(363, 95);
            this.PanelCliente.Name = "PanelCliente";
            this.PanelCliente.Size = new System.Drawing.Size(250, 65);
            this.PanelCliente.TabIndex = 104;
            // 
            // NombreClienteTextBox
            // 
            this.NombreClienteTextBox.Location = new System.Drawing.Point(116, 7);
            this.NombreClienteTextBox.Name = "NombreClienteTextBox";
            this.NombreClienteTextBox.Size = new System.Drawing.Size(129, 20);
            this.NombreClienteTextBox.TabIndex = 100;
            // 
            // TelefonomaskedTextBox
            // 
            this.TelefonomaskedTextBox.Location = new System.Drawing.Point(116, 33);
            this.TelefonomaskedTextBox.Mask = "(999)000-0000";
            this.TelefonomaskedTextBox.Name = "TelefonomaskedTextBox";
            this.TelefonomaskedTextBox.Size = new System.Drawing.Size(129, 20);
            this.TelefonomaskedTextBox.TabIndex = 99;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Rockwell", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(0, 36);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(117, 15);
            this.label4.TabIndex = 98;
            this.label4.Text = "Telefono Cliente:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Rockwell", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(1, 10);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(113, 15);
            this.label3.TabIndex = 97;
            this.label3.Text = "Nombre Cliente:";
            // 
            // GeneralErrorProvider
            // 
            this.GeneralErrorProvider.ContainerControl = this;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Rockwell", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(12, 156);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(62, 15);
            this.label10.TabIndex = 105;
            this.label10.Text = "Usuario:";
            // 
            // UsuariosComboBox
            // 
            this.UsuariosComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.UsuariosComboBox.FormattingEnabled = true;
            this.UsuariosComboBox.Location = new System.Drawing.Point(80, 156);
            this.UsuariosComboBox.Name = "UsuariosComboBox";
            this.UsuariosComboBox.Size = new System.Drawing.Size(154, 21);
            this.UsuariosComboBox.TabIndex = 106;
            // 
            // ButtonRemover
            // 
            this.ButtonRemover.BackColor = System.Drawing.Color.MediumBlue;
            this.ButtonRemover.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ButtonRemover.FlatAppearance.BorderSize = 0;
            this.ButtonRemover.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkGray;
            this.ButtonRemover.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(50)))));
            this.ButtonRemover.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonRemover.Font = new System.Drawing.Font("Rockwell", 7F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonRemover.ForeColor = System.Drawing.Color.White;
            this.ButtonRemover.Image = global::ComunicacionesMendoza.Properties.Resources.icons8_Delete_Row_16;
            this.ButtonRemover.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ButtonRemover.Location = new System.Drawing.Point(12, 443);
            this.ButtonRemover.Name = "ButtonRemover";
            this.ButtonRemover.Size = new System.Drawing.Size(84, 27);
            this.ButtonRemover.TabIndex = 92;
            this.ButtonRemover.Text = "Remover";
            this.ButtonRemover.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.ButtonRemover.UseVisualStyleBackColor = false;
            this.ButtonRemover.Click += new System.EventHandler(this.ButtonRemover_Click);
            // 
            // ButtonAgregar
            // 
            this.ButtonAgregar.BackColor = System.Drawing.Color.MediumBlue;
            this.ButtonAgregar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ButtonAgregar.FlatAppearance.BorderSize = 0;
            this.ButtonAgregar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkGray;
            this.ButtonAgregar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(50)))));
            this.ButtonAgregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonAgregar.Font = new System.Drawing.Font("Rockwell", 7F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonAgregar.ForeColor = System.Drawing.Color.White;
            this.ButtonAgregar.Image = global::ComunicacionesMendoza.Properties.Resources.icons8_Add_Row_16;
            this.ButtonAgregar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ButtonAgregar.Location = new System.Drawing.Point(529, 190);
            this.ButtonAgregar.Name = "ButtonAgregar";
            this.ButtonAgregar.Size = new System.Drawing.Size(84, 27);
            this.ButtonAgregar.TabIndex = 91;
            this.ButtonAgregar.Text = "Agregar";
            this.ButtonAgregar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.ButtonAgregar.UseVisualStyleBackColor = false;
            this.ButtonAgregar.Click += new System.EventHandler(this.ButtonAgregar_Click);
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
            this.ButtonBuscar.Location = new System.Drawing.Point(240, 46);
            this.ButtonBuscar.Name = "ButtonBuscar";
            this.ButtonBuscar.Size = new System.Drawing.Size(78, 27);
            this.ButtonBuscar.TabIndex = 80;
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
            this.IconCerrar.Location = new System.Drawing.Point(604, 0);
            this.IconCerrar.Name = "IconCerrar";
            this.IconCerrar.Size = new System.Drawing.Size(20, 20);
            this.IconCerrar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.IconCerrar.TabIndex = 75;
            this.IconCerrar.TabStop = false;
            this.IconCerrar.Click += new System.EventHandler(this.IconCerrar_Click);
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
            this.ButtonNuevo.Location = new System.Drawing.Point(96, 476);
            this.ButtonNuevo.Name = "ButtonNuevo";
            this.ButtonNuevo.Size = new System.Drawing.Size(102, 42);
            this.ButtonNuevo.TabIndex = 74;
            this.ButtonNuevo.Text = "Nuevo";
            this.ButtonNuevo.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.ButtonNuevo.UseVisualStyleBackColor = false;
            this.ButtonNuevo.Click += new System.EventHandler(this.ButtonNuevo_Click);
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
            this.ButtonEliminar.Location = new System.Drawing.Point(333, 476);
            this.ButtonEliminar.Name = "ButtonEliminar";
            this.ButtonEliminar.Size = new System.Drawing.Size(102, 42);
            this.ButtonEliminar.TabIndex = 73;
            this.ButtonEliminar.Text = "Eliminar";
            this.ButtonEliminar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.ButtonEliminar.UseVisualStyleBackColor = false;
            this.ButtonEliminar.Click += new System.EventHandler(this.ButtonEliminar_Click);
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
            this.ButtonGuardar.Location = new System.Drawing.Point(216, 476);
            this.ButtonGuardar.Name = "ButtonGuardar";
            this.ButtonGuardar.Size = new System.Drawing.Size(102, 42);
            this.ButtonGuardar.TabIndex = 72;
            this.ButtonGuardar.Text = "Guardar";
            this.ButtonGuardar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.ButtonGuardar.UseVisualStyleBackColor = false;
            this.ButtonGuardar.Click += new System.EventHandler(this.ButtonGuardar_Click);
            // 
            // ButtonRecibo
            // 
            this.ButtonRecibo.BackColor = System.Drawing.Color.MediumBlue;
            this.ButtonRecibo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ButtonRecibo.FlatAppearance.BorderSize = 0;
            this.ButtonRecibo.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkGray;
            this.ButtonRecibo.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(50)))));
            this.ButtonRecibo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonRecibo.Font = new System.Drawing.Font("Rockwell", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonRecibo.ForeColor = System.Drawing.Color.White;
            this.ButtonRecibo.Image = global::ComunicacionesMendoza.Properties.Resources.icons8_Printer_32;
            this.ButtonRecibo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ButtonRecibo.Location = new System.Drawing.Point(511, 476);
            this.ButtonRecibo.Name = "ButtonRecibo";
            this.ButtonRecibo.Size = new System.Drawing.Size(102, 42);
            this.ButtonRecibo.TabIndex = 107;
            this.ButtonRecibo.Text = "Recibo";
            this.ButtonRecibo.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.ButtonRecibo.UseVisualStyleBackColor = false;
            this.ButtonRecibo.Click += new System.EventHandler(this.ButtonRecibo_Click);
            // 
            // rVentas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(625, 524);
            this.Controls.Add(this.ButtonRecibo);
            this.Controls.Add(this.UsuariosComboBox);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.PanelCliente);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.TotalTextBox);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.ButtonRemover);
            this.Controls.Add(this.ButtonAgregar);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.ImporteTextBox);
            this.Controls.Add(this.PrecioTextBox);
            this.Controls.Add(this.CantidadNumericUpDown);
            this.Controls.Add(this.ProductoComboBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.FechaVentaDateTimePicker);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.ButtonBuscar);
            this.Controls.Add(this.VentaIdNumericUpDown);
            this.Controls.Add(this.DescripcionTextBox);
            this.Controls.Add(descripcionLabel);
            this.Controls.Add(VentaIdLabel);
            this.Controls.Add(this.IconCerrar);
            this.Controls.Add(this.ButtonNuevo);
            this.Controls.Add(this.ButtonEliminar);
            this.Controls.Add(this.ButtonGuardar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.VentaDetalleDataGridView);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "rVentas";
            this.Text = "rVentas";
            ((System.ComponentModel.ISupportInitialize)(this.VentaDetalleDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.VentaIdNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CantidadNumericUpDown)).EndInit();
            this.PanelCliente.ResumeLayout(false);
            this.PanelCliente.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GeneralErrorProvider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.IconCerrar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView VentaDetalleDataGridView;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button ButtonNuevo;
        private System.Windows.Forms.Button ButtonEliminar;
        private System.Windows.Forms.Button ButtonGuardar;
        private System.Windows.Forms.PictureBox IconCerrar;
        private System.Windows.Forms.TextBox DescripcionTextBox;
        private System.Windows.Forms.NumericUpDown VentaIdNumericUpDown;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker FechaVentaDateTimePicker;
        private System.Windows.Forms.TextBox ImporteTextBox;
        private System.Windows.Forms.TextBox PrecioTextBox;
        private System.Windows.Forms.NumericUpDown CantidadNumericUpDown;
        private System.Windows.Forms.ComboBox ProductoComboBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button ButtonAgregar;
        private System.Windows.Forms.Button ButtonRemover;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox TotalTextBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel PanelCliente;
        private System.Windows.Forms.TextBox NombreClienteTextBox;
        private System.Windows.Forms.MaskedTextBox TelefonomaskedTextBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ErrorProvider GeneralErrorProvider;
        private System.Windows.Forms.Button ButtonBuscar;
        private System.Windows.Forms.ComboBox UsuariosComboBox;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button ButtonRecibo;
    }
}