using Entidades;
using BLL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using ComunicacionesMendoza.UI.Reportes;
using ComunicacionesMendoza.UI.Ventana_Reportes;

namespace ComunicacionesMendoza.UI
{
    public partial class PreguntaRecibo : Form
    {
        List<Ventas> ventas = new List<Ventas>();
        int id = 0;

        public PreguntaRecibo(int n)
        {           
            InitializeComponent();
            id = n;
        }

        private void FRMPreguntas_Load(object sender, EventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {

            Hide();
        }

        private void ButtonBuscar_Click(object sender, EventArgs e)
        {
            ventas = VentasBLL.GetList(v => v.VentaId == id);
            vRecibo recibo = new vRecibo(ventas);
            recibo.ShowDialog();
            Hide();
        }
    }
}
