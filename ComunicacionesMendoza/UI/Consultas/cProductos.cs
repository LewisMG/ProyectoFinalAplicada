using ComunicacionesMendoza.BLL;
using ComunicacionesMendoza.Entidades;
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
    public partial class cProductos : Form
    {
        Expression<Func<Productos, bool>> filtro = x => true;


        public cProductos()
        {
            InitializeComponent();
        }

        private void ButtonBuscar_Click(object sender, EventArgs e)
        {
            switch (FiltroComboBox.SelectedIndex)
            {
                case 0://Id

                    if (Validar(1))
                    {
                        MessageBox.Show("Favor Llenar Casilla ", "Fallido", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    if (Validar(2))
                    {
                        MessageBox.Show("Debe Digitar un Numero!", "Fallido", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    else
                    {
                        int id = Convert.ToInt32(CriterioTextBox.Text);

                        filtro = x => x.ProductoId == id;

                        if (ProductosBLL.GetList(filtro).Count() == 0)
                        {
                            MessageBox.Show("Este ID, No Existe", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            return;
                        }
                    }
                    break;

                case 1://Descripcion

                    if (Validar(1))
                    {
                        MessageBox.Show("Favor Llenar Casilla ", "Fallido", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    if (Validar(3))
                    {
                        MessageBox.Show("Debe Digitar una Descripcion!", "Fallido", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    else
                    {
                        filtro = x => x.Descripcion.Contains(CriterioTextBox.Text);

                        if (ProductosBLL.GetList(filtro).Count() == 0)
                        {
                            MessageBox.Show("Esta Descripcion, No Existe", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        }
                    }
                    break;

                case 2://Costo

                    if (Validar(1))
                    {
                        MessageBox.Show("Favor Llenar Casilla ", "Fallido", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    if (Validar(2))
                    {
                        MessageBox.Show("Debe Digitar un Numero!", "Fallido", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    else
                    {
                        decimal costo = Convert.ToDecimal(CriterioTextBox.Text);
                        filtro = x => x.Costo == costo;


                        if (ProductosBLL.GetList(filtro).Count() == 0)
                        {
                            MessageBox.Show("Este Monto, No Existe", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        }
                    }
                    break;

                case 3://Ganancia

                    if (Validar(1))
                    {
                        MessageBox.Show("Favor Llenar Casilla ", "Fallido", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    if (Validar(2))
                    {
                        MessageBox.Show("Debe Digitar un Numero!", "Fallido", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    else
                    {
                        decimal Ganancia = Convert.ToDecimal(CriterioTextBox.Text);
                        filtro = x => x.Ganancia == Ganancia;


                        if (ProductosBLL.GetList(filtro).Count() == 0)
                        {
                            MessageBox.Show("Este Monto, No Existe", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        }
                    }
                    break;

                case 4://precio
                    if (Validar(1))
                    {
                        MessageBox.Show("Favor Llenar Casilla ", "Fallido", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    if (Validar(2))
                    {
                        MessageBox.Show("Debe Digitar un Numero!", "Fallido", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    else
                    {
                        decimal precio = Convert.ToDecimal(CriterioTextBox.Text);
                        filtro = x => x.Precio == precio;


                        if (ProductosBLL.GetList(filtro).Count() == 0)
                        {
                            MessageBox.Show("Este precio, No Existe", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        }
                    }

                    break;

                case 5://Inventario
                    if (Validar(1))
                    {
                        MessageBox.Show("Favor Llenar Casilla ", "Fallido", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    if (Validar(2))
                    {
                        MessageBox.Show("Debe Digitar un Numero!", "Fallido", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    else
                    {
                        decimal Invetario = Convert.ToDecimal(CriterioTextBox.Text);
                        filtro = x => x.Inventario == Invetario;


                        if (ProductosBLL.GetList(filtro).Count() == 0)
                        {
                            MessageBox.Show("No  hay Existencia", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        }
                    }

                    break;

                case 6://Todo
                    filtro = x => true;
                    break;
            }

            ProductosDataGridView.DataSource = ProductosBLL.GetList(filtro);
            CriterioTextBox.Clear();
            GeneralErrorProvider.Clear();
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
                GeneralErrorProvider.SetError(CriterioTextBox, "Ingrese Caracteres");
                paso = true;
            }

            return paso;
        }

        private void IconCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ButtonNuevo_Click(object sender, EventArgs e)
        {
           vProductos ver = new vProductos(BLL.ProductosBLL.GetList(filtro));
           ver.Show();
        }
    }
}
