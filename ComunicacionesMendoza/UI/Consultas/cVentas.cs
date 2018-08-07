using BLL;
using Entidades;
using ComunicacionesMendoza.UI.Ventana_Reportes;
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
    public partial class cVentas : Form
    {
        Expression<Func<Ventas, bool>> filtro = x => true;

        public cVentas()
        {
            InitializeComponent();
        }

        private void IconCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
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
            switch (FiltroComboBox.SelectedIndex)
            {
                case 0://VentaId
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
                        if (FechaCheckBox.Checked == true)
                        {
                            filtro = x => x.VentaId == id &&
                            (x.Fecha >= DesdeDateTimePicker.Value.Date &&
                            x.Fecha <= HastaDateTimePicker.Value.Date);
                        }
                        else
                        {
                            filtro = x => x.VentaId == id;
                        }

                        if (VentasBLL.GetList(filtro).Count() == 0)
                        {
                            MessageBox.Show("No Hay Existencia", "Aviso",
                                MessageBoxButtons.OK, MessageBoxIcon.Information);
                            return;
                        }
                    }
                    break;

                case 1://Descripcion

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
                        if (FechaCheckBox.Checked == true)
                        {
                            filtro = x => x.Descripcion.Contains(CriterioTextBox.Text) &&
                            (x.Fecha >= DesdeDateTimePicker.Value.Date &&
                            x.Fecha <= HastaDateTimePicker.Value.Date);
                        }
                        else
                        {
                            filtro = x => x.Descripcion.Contains(CriterioTextBox.Text);
                        }

                        if (VentasBLL.GetList(filtro).Count() == 0)
                        {
                            MessageBox.Show("No Hay Existencia", "Aviso",
                                MessageBoxButtons.OK, MessageBoxIcon.Information);

                        }
                    }
                    break;

                case 2://NombreCliente

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
                        if (FechaCheckBox.Checked == true)
                        {
                            filtro = x => x.NombreCliente.Contains(CriterioTextBox.Text) &&
                            (x.Fecha >= DesdeDateTimePicker.Value.Date &&
                            x.Fecha <= HastaDateTimePicker.Value.Date);
                        }
                        else
                        {
                            filtro = x => x.NombreCliente.Contains(CriterioTextBox.Text);
                        }

                        if (VentasBLL.GetList(filtro).Count() == 0)
                        {
                            MessageBox.Show("No Hay Existencia", "Aviso",
                                MessageBoxButtons.OK, MessageBoxIcon.Information);

                        }
                    }
                    break;

                case 3://TelefonoCliente

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
                        if (FechaCheckBox.Checked == true)
                        {
                            filtro = x => x.TelefonoCliente.Contains(CriterioTextBox.Text) &&
                            (x.Fecha >= DesdeDateTimePicker.Value.Date &&
                            x.Fecha <= HastaDateTimePicker.Value.Date);
                        }
                        else
                        {
                            filtro = x => x.TelefonoCliente.Contains(CriterioTextBox.Text);
                        }

                        if (VentasBLL.GetList(filtro).Count() == 0)
                        {
                            MessageBox.Show("No Hay Existencia", "Aviso",
                                MessageBoxButtons.OK, MessageBoxIcon.Information);

                        }
                    }
                    break;

                case 4://Total

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
                        decimal total = Convert.ToInt32(CriterioTextBox.Text);
                        if (FechaCheckBox.Checked == true)
                        {
                            filtro = x => x.Total == total &&
                            (x.Fecha >= DesdeDateTimePicker.Value.Date &&
                            x.Fecha <= HastaDateTimePicker.Value.Date);
                        }
                        else
                        {
                            filtro = x => x.Total == total;
                        }

                        if (VentasBLL.GetList(filtro).Count() == 0)
                        {
                            MessageBox.Show("No Hay Existencia", "Aviso",
                                MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                    break;
                case 5://Todos
                    filtro = x => true;
                    break;
            }
            VentasDataGridView.DataSource = VentasBLL.GetList(filtro);
            VentasDataGridView.Columns["Detalle"].Visible = false; 

            CriterioTextBox.Clear();
            GeneralErrorProvider.Clear();
        }

        private void ButtonImprimir_Click(object sender, EventArgs e)
        {
            vVentas ver = new vVentas(VentasBLL.GetList(filtro));
            ver.Show();
        }
    }
}
