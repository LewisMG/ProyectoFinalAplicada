using ComunicacionesMendoza.UI.Consultas;
using ComunicacionesMendoza.UI.Registros;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Windows.Forms;

namespace ComunicacionesMendoza
{
    public partial class MainForm : Form
    {      
        public MainForm()
        {
            InitializeComponent();
        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);

        private void ButtonSlide_Click_1(object sender, EventArgs e)
        {
            if (MenuVertical.Width == 194)
            {
                MenuVertical.Width = 69;
            }
            else
                MenuVertical.Width = 194;

            PanelConsulta.Visible = false;

        }

        private void IconCerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void iconRestaurarMaximizar_Click(object sender, EventArgs e)
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

        private void iconMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void PanelTitulo_Paint(object sender, PaintEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void ButtonProductos_Click(object sender, EventArgs e)
        {
            rProductos ver = new rProductos();
            ver.MdiParent = this;
            ver.Show();
        }

        private void ButtonEntradaProductos_Click(object sender, EventArgs e)
        {
            rEntradaProductos ver = new rEntradaProductos();
            ver.MdiParent = this;
            ver.Show();
        }

        private void ButtonVentas_Click(object sender, EventArgs e)
        {
            rVentas ver = new rVentas();
            ver.MdiParent = this;
            ver.Show();
        }

        private void productosToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            
        }

        private void ButtonUsuarios_Click(object sender, EventArgs e)
        {
            rUsuarios ver = new rUsuarios();
            ver.MdiParent = this;
            ver.Show();
        }

        private void ButtonConsultas_Click(object sender, EventArgs e)
        {
            if (MenuVertical.Width == 194)
            {
                MenuVertical.Width = 69;
            }
            else
                MenuVertical.Width = 194;

            PanelConsulta.Visible = true;            
        }        

        private void MainForm_Load(object sender, EventArgs e)
        {

        }

        private void ButtonCProductos_Click_1(object sender, EventArgs e)
        {
            cProductos ver = new cProductos();
            ver.MdiParent = this;
            ver.Show();
        }

        private void ButtonCUsuarios_Click_1(object sender, EventArgs e)
        {
            cUsuarios ver = new cUsuarios();
            ver.MdiParent = this;
            ver.Show();
        }

        private void ButtonEntradaP_Click_1(object sender, EventArgs e)
        {
            cEntradaP ver = new cEntradaP();
            ver.MdiParent = this;
            ver.Show();
        }

        private void ButtonCVentas_Click_1(object sender, EventArgs e)
        {
            cVentas ver = new cVentas();
            ver.MdiParent = this;
            ver.Show();
        }

        private void ButtonVentasDetalle_Click_1(object sender, EventArgs e)
        {
            cVentasDetalles ver = new cVentasDetalles();
            ver.MdiParent = this;
            ver.Show();
        }
    }
}
