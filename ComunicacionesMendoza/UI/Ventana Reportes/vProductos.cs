using ComunicacionesMendoza.Entidades;
using ComunicacionesMendoza.UI.Reportes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ComunicacionesMendoza.UI.Ventana_Reportes
{
    public partial class vProductos : Form
    {
        List<Productos> productos = new List<Productos>();

        public vProductos(List<Productos> Lista)
        {
            InitializeComponent();
            productos = Lista;
        }

        private void ProductoCrystalReportViewer_Load(object sender, EventArgs e)
        {
            Producto ver = new Producto();
            ver.SetDataSource(productos);

            ProductoCrystalReportViewer.ReportSource = ver;
            ProductoCrystalReportViewer.Refresh();
        }

        private void iconMaximizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            IconRestaurarMaximizar.Visible = true;
            iconMaximizar.Visible = false;
        }

        private void IconRestaurarMaximizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Normal;
            IconRestaurarMaximizar.Visible = false;
            iconMaximizar.Visible = true;
        }

        private void IconCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
