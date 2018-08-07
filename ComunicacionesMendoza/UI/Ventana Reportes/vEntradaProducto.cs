using Entidades;
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
    public partial class vEntradaProducto : Form
    {
        List<EntradaProductos> entradaProductos = new List<EntradaProductos>();
        
        public vEntradaProducto(List<EntradaProductos> Lista)
        {
            InitializeComponent();
            entradaProductos = Lista;
        }

        private void EntradaCrystalReportViewer_Load(object sender, EventArgs e)
        {
            EntradaProducto ver = new EntradaProducto();
            ver.SetDataSource(entradaProductos);

            EntradaCrystalReportViewer.ReportSource = ver;
            EntradaCrystalReportViewer.Refresh();
        }

        private void IconCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void IconRestaurarMaximizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Normal;
            IconRestaurarMaximizar.Visible = false;
            iconMaximizar.Visible = true;
        }

        private void iconMaximizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            IconRestaurarMaximizar.Visible = true;
            iconMaximizar.Visible = false;
        }
    }
}
