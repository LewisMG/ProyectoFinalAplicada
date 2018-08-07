using BLL;
using Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Windows.Forms;

namespace ComunicacionesMendoza.UI.Consultas
{
    public partial class cVentasDetalles : Form
    {
        public cVentasDetalles()
        {
            InitializeComponent();
        }

        private bool Validar(int error)
        {
            bool paso = false;
            int num = 0;

            if (error == 1 && string.IsNullOrEmpty(CriterioTextBox.Text))
            {
                GeneralErrorProvider.SetError(CriterioTextBox, "Por Favor, Llenar Casilla!");
                paso = true;
            }
            if (error == 2 && int.TryParse(CriterioTextBox.Text, out num) == false)
            {
                GeneralErrorProvider.SetError(CriterioTextBox, "Ingrese un Numero");
                paso = true;
            }
            if (error == 3 && int.TryParse(CriterioTextBox.Text, out num) == true)
            {
                GeneralErrorProvider.SetError(CriterioTextBox, "Ingrese un Nombre");
                paso = true;
            }

            return paso;
        }

        private void ButtonBuscar_Click(object sender, EventArgs e)
        {
            Expression<Func<VentasDetalle, bool>> filtro = x => true;

            switch (FiltroComboBox.SelectedIndex)
            {
                case 0://VDetalleId
                    if (Validar(1))
                    {
                        MessageBox.Show("Llenar Casilla ", "Fallido",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    if (Validar(2))
                    {
                        MessageBox.Show("Ingrese un Numero!", "Fallido",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    else
                    {
                        int id = Convert.ToInt32(CriterioTextBox.Text);                       
                        filtro = x => x.VDetalleId == id;                        

                        if (VentasBLL.GetListDetalle(filtro).Count() == 0)
                        {
                            MessageBox.Show("No Hay Existencia", "Aviso",
                                MessageBoxButtons.OK, MessageBoxIcon.Information);
                            return;
                        }
                    }
                    break;

                case 1://VentaId

                    if (Validar(1))
                    {
                        MessageBox.Show("Llenar Casilla ", "Fallido",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    if (Validar(3))
                    {
                        MessageBox.Show("Ingrese una Descripcion!", "Fallido",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    else
                    {
                        int id = Convert.ToInt32(CriterioTextBox.Text);
                        filtro = x => x.VentaId == id;

                        if (VentasBLL.GetListDetalle(filtro).Count() == 0)
                        {
                            MessageBox.Show("No Hay Existencia", "Aviso",
                                MessageBoxButtons.OK, MessageBoxIcon.Information);
                            return;
                        }
                    }
                    break;

                case 2://ProductoId

                    if (Validar(1))
                    {
                        MessageBox.Show("Llenar Casilla ", "Fallido",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    if (Validar(3))
                    {
                        MessageBox.Show("Ingrese un Nombre!", "Fallido",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    else
                    {
                        int id = Convert.ToInt32(CriterioTextBox.Text);
                        filtro = x => x.ProductoId == id;

                        if (VentasBLL.GetListDetalle(filtro).Count() == 0)
                        {
                            MessageBox.Show("No Hay Existencia", "Aviso",
                                MessageBoxButtons.OK, MessageBoxIcon.Information);
                            return;
                        }
                    }
                    break;

                case 3://Producto

                    if (Validar(1))
                    {
                        MessageBox.Show("Llenar Casilla ", "Fallido",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    if (Validar(2))
                    {
                        MessageBox.Show("Ingrese un Telefono!", "Fallido",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    else
                    {                        
                       filtro = x => x.Producto.Contains(CriterioTextBox.Text);
                       
                       if (VentasBLL.GetListDetalle(filtro).Count() == 0)
                       {
                           MessageBox.Show("No Hay Existencia", "Aviso",
                               MessageBoxButtons.OK, MessageBoxIcon.Information);
                       }
                    }
                    break;

                case 4://Cantidad

                    if (Validar(1))
                    {
                        MessageBox.Show("Llenar Casilla!!", "Fallido",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    if (Validar(2))
                    {
                        MessageBox.Show("Ingrese una Cantidad!!", "Fallido",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    else
                    {
                        int cantidad = Convert.ToInt32(CriterioTextBox.Text);
                        filtro = x => x.Cantidad == cantidad;
                       
                        if (VentasBLL.GetListDetalle(filtro).Count() == 0)
                        {
                            MessageBox.Show("No Hay Existencia", "Aviso",
                                MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                    break;

                case 5://Precio

                    if (Validar(1))
                    {
                        MessageBox.Show("Llenar Casilla!!", "Fallido",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    if (Validar(2))
                    {
                        MessageBox.Show("Ingrese una Cantidad!!", "Fallido",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    else
                    {
                        decimal Precio = Convert.ToInt32(CriterioTextBox.Text);
                        filtro = x => x.Precio == Precio;

                        if (VentasBLL.GetListDetalle(filtro).Count() == 0)
                        {
                            MessageBox.Show("No Hay Existencia", "Aviso",
                                MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                    break;

                case 6://Importe

                    if (Validar(1))
                    {
                        MessageBox.Show("Llenar Casilla!!", "Fallido",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    if (Validar(2))
                    {
                        MessageBox.Show("Ingrese una Cantidad!!", "Fallido",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    else
                    {
                        int importe = Convert.ToInt32(CriterioTextBox.Text);
                        filtro = x => x.Importe == importe;

                        if (VentasBLL.GetListDetalle(filtro).Count() == 0)
                        {
                            MessageBox.Show("No Hay Existencia", "Aviso",
                                MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                    break;

                case 7://Todos
                    filtro = x => true;
                    break;
            }
            VentasDataGridView.DataSource = VentasBLL.GetListDetalle(filtro);
            VentasDataGridView.Columns["Productos"].Visible = false;

            CriterioTextBox.Clear();
            GeneralErrorProvider.Clear();
        }

        private void IconCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
