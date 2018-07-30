﻿namespace ComunicacionesMendoza.UI.Ventana_Reportes
{
    partial class vUsuarios
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
            this.UsuarioCrystalReportViewer = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.IconCerrar = new System.Windows.Forms.PictureBox();
            this.iconMaximizar = new System.Windows.Forms.PictureBox();
            this.IconRestaurarMaximizar = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.IconCerrar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconMaximizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.IconRestaurarMaximizar)).BeginInit();
            this.SuspendLayout();
            // 
            // UsuarioCrystalReportViewer
            // 
            this.UsuarioCrystalReportViewer.ActiveViewIndex = -1;
            this.UsuarioCrystalReportViewer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.UsuarioCrystalReportViewer.Cursor = System.Windows.Forms.Cursors.Default;
            this.UsuarioCrystalReportViewer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.UsuarioCrystalReportViewer.Location = new System.Drawing.Point(0, 0);
            this.UsuarioCrystalReportViewer.Name = "UsuarioCrystalReportViewer";
            this.UsuarioCrystalReportViewer.Size = new System.Drawing.Size(800, 450);
            this.UsuarioCrystalReportViewer.TabIndex = 0;
            this.UsuarioCrystalReportViewer.Load += new System.EventHandler(this.UsuarioCrystalReportViewer_Load);
            // 
            // IconCerrar
            // 
            this.IconCerrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.IconCerrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.IconCerrar.Image = global::ComunicacionesMendoza.Properties.Resources.icons8_Close_Window_32;
            this.IconCerrar.Location = new System.Drawing.Point(606, 0);
            this.IconCerrar.Name = "IconCerrar";
            this.IconCerrar.Size = new System.Drawing.Size(20, 20);
            this.IconCerrar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.IconCerrar.TabIndex = 91;
            this.IconCerrar.TabStop = false;
            this.IconCerrar.Click += new System.EventHandler(this.IconCerrar_Click);
            // 
            // iconMaximizar
            // 
            this.iconMaximizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.iconMaximizar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.iconMaximizar.Image = global::ComunicacionesMendoza.Properties.Resources.icons8_Maximize_Window_32;
            this.iconMaximizar.Location = new System.Drawing.Point(554, 0);
            this.iconMaximizar.Name = "iconMaximizar";
            this.iconMaximizar.Size = new System.Drawing.Size(20, 20);
            this.iconMaximizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.iconMaximizar.TabIndex = 90;
            this.iconMaximizar.TabStop = false;
            this.iconMaximizar.Click += new System.EventHandler(this.iconMaximizar_Click);
            // 
            // IconRestaurarMaximizar
            // 
            this.IconRestaurarMaximizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.IconRestaurarMaximizar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.IconRestaurarMaximizar.Image = global::ComunicacionesMendoza.Properties.Resources.icons8_Maximize_Window_32;
            this.IconRestaurarMaximizar.Location = new System.Drawing.Point(580, 0);
            this.IconRestaurarMaximizar.Name = "IconRestaurarMaximizar";
            this.IconRestaurarMaximizar.Size = new System.Drawing.Size(20, 20);
            this.IconRestaurarMaximizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.IconRestaurarMaximizar.TabIndex = 89;
            this.IconRestaurarMaximizar.TabStop = false;
            this.IconRestaurarMaximizar.Visible = false;
            this.IconRestaurarMaximizar.Click += new System.EventHandler(this.IconRestaurarMaximizar_Click);
            // 
            // vUsuarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.IconCerrar);
            this.Controls.Add(this.iconMaximizar);
            this.Controls.Add(this.IconRestaurarMaximizar);
            this.Controls.Add(this.UsuarioCrystalReportViewer);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "vUsuarios";
            this.Text = "vUsuarios";
            ((System.ComponentModel.ISupportInitialize)(this.IconCerrar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconMaximizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.IconRestaurarMaximizar)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private CrystalDecisions.Windows.Forms.CrystalReportViewer UsuarioCrystalReportViewer;
        private System.Windows.Forms.PictureBox IconCerrar;
        private System.Windows.Forms.PictureBox iconMaximizar;
        private System.Windows.Forms.PictureBox IconRestaurarMaximizar;
    }
}