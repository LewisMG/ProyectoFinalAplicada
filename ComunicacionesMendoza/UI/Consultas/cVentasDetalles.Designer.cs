namespace ComunicacionesMendoza.UI.Consultas
{
    partial class cVentasDetalles
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
            this.IconCerrar = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.ButtonBuscar = new System.Windows.Forms.Button();
            this.ButtonNuevo = new System.Windows.Forms.Button();
            this.VentasDataGridView = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.CriterioTextBox = new System.Windows.Forms.TextBox();
            this.FiltroComboBox = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.GeneralErrorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.IconCerrar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.VentasDataGridView)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GeneralErrorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // IconCerrar
            // 
            this.IconCerrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.IconCerrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.IconCerrar.Image = global::ComunicacionesMendoza.Properties.Resources.icons8_Close_Window_32;
            this.IconCerrar.Location = new System.Drawing.Point(600, 3);
            this.IconCerrar.Name = "IconCerrar";
            this.IconCerrar.Size = new System.Drawing.Size(20, 20);
            this.IconCerrar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.IconCerrar.TabIndex = 113;
            this.IconCerrar.TabStop = false;
            this.IconCerrar.Click += new System.EventHandler(this.IconCerrar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Font = new System.Drawing.Font("Rockwell", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(123, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(358, 24);
            this.label1.TabIndex = 112;
            this.label1.Text = "CONSULTA DE VENTAS DETALLES";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Rockwell", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(171, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 14);
            this.label2.TabIndex = 108;
            this.label2.Text = "Criterio";
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
            this.ButtonBuscar.Location = new System.Drawing.Point(533, 53);
            this.ButtonBuscar.Name = "ButtonBuscar";
            this.ButtonBuscar.Size = new System.Drawing.Size(78, 27);
            this.ButtonBuscar.TabIndex = 111;
            this.ButtonBuscar.Text = "Buscar";
            this.ButtonBuscar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.ButtonBuscar.UseVisualStyleBackColor = false;
            this.ButtonBuscar.Click += new System.EventHandler(this.ButtonBuscar_Click);
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
            this.ButtonNuevo.Image = global::ComunicacionesMendoza.Properties.Resources.icons8_Printer_32;
            this.ButtonNuevo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ButtonNuevo.Location = new System.Drawing.Point(9, 387);
            this.ButtonNuevo.Name = "ButtonNuevo";
            this.ButtonNuevo.Size = new System.Drawing.Size(102, 42);
            this.ButtonNuevo.TabIndex = 110;
            this.ButtonNuevo.Text = "Imprimir";
            this.ButtonNuevo.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.ButtonNuevo.UseVisualStyleBackColor = false;
            // 
            // VentasDataGridView
            // 
            this.VentasDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.VentasDataGridView.Location = new System.Drawing.Point(9, 84);
            this.VentasDataGridView.Name = "VentasDataGridView";
            this.VentasDataGridView.Size = new System.Drawing.Size(600, 297);
            this.VentasDataGridView.TabIndex = 109;
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.CriterioTextBox);
            this.panel1.Controls.Add(this.FiltroComboBox);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Location = new System.Drawing.Point(11, 48);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(502, 31);
            this.panel1.TabIndex = 116;
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
            "Venta Detalle Id",
            "Venta Id",
            "Producto Id",
            "Producto",
            "Cantidad",
            "Precio",
            "Importe",
            "Todos"});
            this.FiltroComboBox.Location = new System.Drawing.Point(41, 4);
            this.FiltroComboBox.Name = "FiltroComboBox";
            this.FiltroComboBox.Size = new System.Drawing.Size(121, 21);
            this.FiltroComboBox.TabIndex = 20;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Rockwell", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(170, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 14);
            this.label3.TabIndex = 19;
            this.label3.Text = "Criterio";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Rockwell", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(2, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(39, 14);
            this.label4.TabIndex = 17;
            this.label4.Text = "Filtro";
            // 
            // GeneralErrorProvider
            // 
            this.GeneralErrorProvider.ContainerControl = this;
            // 
            // cVentasDetalles
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(624, 434);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.IconCerrar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.ButtonBuscar);
            this.Controls.Add(this.ButtonNuevo);
            this.Controls.Add(this.VentasDataGridView);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "cVentasDetalles";
            this.Text = "cVentasDetalles";
            ((System.ComponentModel.ISupportInitialize)(this.IconCerrar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.VentasDataGridView)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GeneralErrorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox IconCerrar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button ButtonBuscar;
        private System.Windows.Forms.Button ButtonNuevo;
        private System.Windows.Forms.DataGridView VentasDataGridView;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox CriterioTextBox;
        private System.Windows.Forms.ComboBox FiltroComboBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ErrorProvider GeneralErrorProvider;
    }
}