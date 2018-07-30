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
    public partial class vVentas : Form
    {
        List<Ventas> Ventas = new List<Ventas>();

        public vVentas(List<Ventas> Lista)
        {
            InitializeComponent();
            Ventas = Lista;
        }

        private void VentaCrystalReportViewer_Load(object sender, EventArgs e)
        {
            Venta ver = new Venta();
            ver.SetDataSource(Ventas);

            VentaCrystalReportViewer.ReportSource = ver;
            VentaCrystalReportViewer.Refresh();
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
