namespace ComunicacionesMendoza.UI.Consultas
{
    partial class cVentas
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
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.CriterioTextBox = new System.Windows.Forms.TextBox();
            this.FiltroComboBox = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.VentasDataGridView = new System.Windows.Forms.DataGridView();
            this.IconCerrar = new System.Windows.Forms.PictureBox();
            this.ButtonBuscar = new System.Windows.Forms.Button();
            this.ButtonImprimir = new System.Windows.Forms.Button();
            this.FechaCheckBox = new System.Windows.Forms.CheckBox();
            this.Fechaspanel = new System.Windows.Forms.Panel();
            this.HastaDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.DesdeDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.GeneralErrorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.VentasDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.IconCerrar)).BeginInit();
            this.Fechaspanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GeneralErrorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Font = new System.Drawing.Font("Rockwell", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(172, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(246, 24);
            this.label1.TabIndex = 104;
            this.label1.Text = "CONSULTA DE VENTAS";
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.CriterioTextBox);
            this.panel1.Controls.Add(this.FiltroComboBox);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Location = new System.Drawing.Point(8, 48);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(502, 31);
            this.panel1.TabIndex = 100;
            // 
            // CriterioTextBox
            // 
            this.CriterioTextBox.Location = new System.Drawing.Point(220, 4);
            this.CriterioTextBox.Name = "CriterioTextBox";
            this.CriterioTextBox.Size = new System.Drawing.Size(275, 20);
            this.CriterioTextBox.TabIndex = 21;
            // 
            // FiltroComboBox
            // 
            this.FiltroComboBox.FormattingEnabled = true;
            this.FiltroComboBox.Items.AddRange(new object[] {
            "VentaId",
            "Descripcion Venta",
            "Nombre Cliente",
            "Telefono Cliente",
            "Total",
            "Todos"});
            this.FiltroComboBox.Location = new System.Drawing.Point(41, 4);
            this.FiltroComboBox.Name = "FiltroComboBox";
            this.FiltroComboBox.Size = new System.Drawing.Size(121, 21);
            this.FiltroComboBox.TabIndex = 20;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Rockwell", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(170, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 14);
            this.label2.TabIndex = 19;
            this.label2.Text = "Criterio";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Rockwell", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(2, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 14);
            this.label3.TabIndex = 17;
            this.label3.Text = "Filtro";
            // 
            // VentasDataGridView
            // 
            this.VentasDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.VentasDataGridView.Location = new System.Drawing.Point(10, 124);
            this.VentasDataGridView.Name = "VentasDataGridView";
            this.VentasDataGridView.Size = new System.Drawing.Size(600, 297);
            this.VentasDataGridView.TabIndex = 98;
            // 
            // IconCerrar
            // 
            this.IconCerrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.IconCerrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.IconCerrar.Image = global::ComunicacionesMendoza.Properties.Resources.icons8_Close_Window_32;
            this.IconCerrar.Location = new System.Drawing.Point(596, 5);
            this.IconCerrar.Name = "IconCerrar";
            this.IconCerrar.Size = new System.Drawing.Size(20, 20);
            this.IconCerrar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.IconCerrar.TabIndex = 105;
            this.IconCerrar.TabStop = false;
            this.IconCerrar.Click += new System.EventHandler(this.IconCerrar_Click);
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
            this.ButtonBuscar.Location = new System.Drawing.Point(530, 69);
            this.ButtonBuscar.Name = "ButtonBuscar";
            this.ButtonBuscar.Size = new System.Drawing.Size(78, 27);
            this.ButtonBuscar.TabIndex = 101;
            this.ButtonBuscar.Text = "Buscar";
            this.ButtonBuscar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.ButtonBuscar.UseVisualStyleBackColor = false;
            this.ButtonBuscar.Click += new System.EventHandler(this.ButtonBuscar_Click);
            // 
            // ButtonImprimir
            // 
            this.ButtonImprimir.BackColor = System.Drawing.Color.MediumBlue;
            this.ButtonImprimir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ButtonImprimir.FlatAppearance.BorderSize = 0;
            this.ButtonImprimir.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkGray;
            this.ButtonImprimir.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(50)))));
            this.ButtonImprimir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonImprimir.Font = new System.Drawing.Font("Rockwell", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonImprimir.ForeColor = System.Drawing.Color.White;
            this.ButtonImprimir.Image = global::ComunicacionesMendoza.Properties.Resources.icons8_Printer_32;
            this.ButtonImprimir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ButtonImprimir.Location = new System.Drawing.Point(8, 426);
            this.ButtonImprimir.Name = "ButtonImprimir";
            this.ButtonImprimir.Size = new System.Drawing.Size(102, 42);
            this.ButtonImprimir.TabIndex = 99;
            this.ButtonImprimir.Text = "Imprimir";
            this.ButtonImprimir.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.ButtonImprimir.UseVisualStyleBackColor = false;
            this.ButtonImprimir.Click += new System.EventHandler(this.ButtonImprimir_Click);
            // 
            // FechaCheckBox
            // 
            this.FechaCheckBox.AutoSize = true;
            this.FechaCheckBox.BackColor = System.Drawing.Color.Transparent;
            this.FechaCheckBox.Font = new System.Drawing.Font("Rockwell", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FechaCheckBox.Location = new System.Drawing.Point(14, 92);
            this.FechaCheckBox.Name = "FechaCheckBox";
            this.FechaCheckBox.Size = new System.Drawing.Size(176, 18);
            this.FechaCheckBox.TabIndex = 107;
            this.FechaCheckBox.Text = "Filtrar Por Rango De Fecha:";
            this.FechaCheckBox.UseVisualStyleBackColor = false;
            // 
            // Fechaspanel
            // 
            this.Fechaspanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Fechaspanel.Controls.Add(this.HastaDateTimePicker);
            this.Fechaspanel.Controls.Add(this.label5);
            this.Fechaspanel.Controls.Add(this.DesdeDateTimePicker);
            this.Fechaspanel.Controls.Add(this.label6);
            this.Fechaspanel.Location = new System.Drawing.Point(184, 83);
            this.Fechaspanel.Margin = new System.Windows.Forms.Padding(2);
            this.Fechaspanel.Name = "Fechaspanel";
            this.Fechaspanel.Size = new System.Drawing.Size(326, 34);
            this.Fechaspanel.TabIndex = 106;
            // 
            // HastaDateTimePicker
            // 
            this.HastaDateTimePicker.CustomFormat = "dd/MM/yyyy";
            this.HastaDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.HastaDateTimePicker.Location = new System.Drawing.Point(225, 6);
            this.HastaDateTimePicker.Margin = new System.Windows.Forms.Padding(2);
            this.HastaDateTimePicker.Name = "HastaDateTimePicker";
            this.HastaDateTimePicker.Size = new System.Drawing.Size(95, 20);
            this.HastaDateTimePicker.TabIndex = 20;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Rockwell", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(182, 8);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(40, 14);
            this.label5.TabIndex = 19;
            this.label5.Text = "Hasta";
            // 
            // DesdeDateTimePicker
            // 
            this.DesdeDateTimePicker.CustomFormat = "dd/MM/yyyy";
            this.DesdeDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.DesdeDateTimePicker.Location = new System.Drawing.Point(50, 6);
            this.DesdeDateTimePicker.Margin = new System.Windows.Forms.Padding(2);
            this.DesdeDateTimePicker.Name = "DesdeDateTimePicker";
            this.DesdeDateTimePicker.Size = new System.Drawing.Size(95, 20);
            this.DesdeDateTimePicker.TabIndex = 18;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Rockwell", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(2, 9);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(45, 14);
            this.label6.TabIndex = 17;
            this.label6.Text = "Desde";
            // 
            // GeneralErrorProvider
            // 
            this.GeneralErrorProvider.ContainerControl = this;
            // 
            // cVentas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(620, 474);
            this.Controls.Add(this.FechaCheckBox);
            this.Controls.Add(this.Fechaspanel);
            this.Controls.Add(this.IconCerrar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ButtonBuscar);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.ButtonImprimir);
            this.Controls.Add(this.VentasDataGridView);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "cVentas";
            this.Text = "cVentas";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.VentasDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.IconCerrar)).EndInit();
            this.Fechaspanel.ResumeLayout(false);
            this.Fechaspanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GeneralErrorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox IconCerrar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button ButtonBuscar;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox CriterioTextBox;
        private System.Windows.Forms.ComboBox FiltroComboBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button ButtonImprimir;
        private System.Windows.Forms.DataGridView VentasDataGridView;
        private System.Windows.Forms.CheckBox FechaCheckBox;
        private System.Windows.Forms.Panel Fechaspanel;
        private System.Windows.Forms.DateTimePicker HastaDateTimePicker;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker DesdeDateTimePicker;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ErrorProvider GeneralErrorProvider;
    }
}