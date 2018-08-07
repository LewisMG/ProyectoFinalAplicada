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
    public partial class vUsuarios : Form
    {
        List<Usuarios> usuarios = new List<Usuarios>();

        public vUsuarios(List<Usuarios> Lista)
        {
            InitializeComponent();
            usuarios = Lista;
        }

        private void UsuarioCrystalReportViewer_Load(object sender, EventArgs e)
        {
            Usuario ver = new Usuario();
            ver.SetDataSource(usuarios);

            UsuarioCrystalReportViewer.ReportSource = ver;
            UsuarioCrystalReportViewer.Refresh();
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
