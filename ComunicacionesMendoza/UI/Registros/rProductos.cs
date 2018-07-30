using ComunicacionesMendoza.BLL;
using ComunicacionesMendoza.Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ComunicacionesMendoza.UI.Registros
{
    public partial class rProductos : Form
    {
        public rProductos()
        {
            InitializeComponent();
            InventarioTextBox.Text = 0.ToString();
        }

        private Productos Llenaclase()
        {
            Productos producto = new Productos();

            producto.ProductoId = Convert.ToInt32(ProductoIdNumericUpDown.Value);
            producto.Descripcion = DescripcionTextBox.Text;
            producto.Costo = Convert.ToInt32(CostoNumericUpDown.Value);
            producto.Precio = Convert.ToInt32(PrecioNumericUpDown.Value);
            producto.Ganancia = Convert.ToInt32(GananciaNumericUpDown.Value);
            InventarioTextBox.Text = 0.ToString();
            producto.Inventario = Convert.ToInt32(InventarioTextBox.Text);

            return producto;
        }

        private void LimpiarCampos()
        {
            ProductoIdNumericUpDown.Value = 0;
            DescripcionTextBox.Clear();
            CostoNumericUpDown.Value = 0;
            PrecioNumericUpDown.Value = 0;
            GananciaNumericUpDown.Value = 0;
            InventarioTextBox.Clear();
            InventarioTextBox.Text = 0.ToString();

            GeneralErrorProvider.Clear();
        }

        private bool Validar(int error)
        {
            bool paso = false;

            if (error == 1 && ProductoIdNumericUpDown.Value == 0)
            {
                GeneralErrorProvider.SetError(ProductoIdNumericUpDown,
                    "Introduzca Id");
                paso = true;
            }

            if (error == 2 && PrecioNumericUpDown.Value == 0)
            {
                GeneralErrorProvider.SetError(PrecioNumericUpDown,
                    "Introduzca El Precio");
                paso = true;
            }

            if (error == 2 && GananciaNumericUpDown.Value == 0)
            {
                GeneralErrorProvider.SetError(GananciaNumericUpDown,
                    "Introduzca La Ganancia");
                paso = true;
            }

            if (error == 2 && CostoNumericUpDown.Value == 0)
            {
                GeneralErrorProvider.SetError(CostoNumericUpDown,
                    "Introduzca El Costo");
                paso = true;
            }

            if (error == 2 && string.IsNullOrEmpty(DescripcionTextBox.Text))
            {
                GeneralErrorProvider.SetError(DescripcionTextBox,
                    "Introduzca La Descripcion");
                paso = true;
            }

            return paso;
        }

        private void ButtonBuscar_Click(object sender, EventArgs e)
        {
            if (Validar(1))
            {
                MessageBox.Show("Introduzca El Id A Buscar!");
            }
            else
            {
                int id = Convert.ToInt32(ProductoIdNumericUpDown.Value);
                Productos producto = ProductosBLL.Buscar(id);

                if (producto != null)
                {
                    ProductoIdNumericUpDown.Value = producto.ProductoId;
                    DescripcionTextBox.Text = producto.Descripcion;
                    CostoNumericUpDown.Value = producto.Costo;
                    PrecioNumericUpDown.Value = producto.Precio;
                    GananciaNumericUpDown.Value = producto.Ganancia;
                    InventarioTextBox.Text = producto.Inventario.ToString();
                }
                else
                {
                    MessageBox.Show("No Fue Encontrado!", "Fallido",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                GeneralErrorProvider.Clear();
            }
        }

        private void ButtonGuardar_Click_1(object sender, EventArgs e)
        {
            bool paso = false;
            Productos producto = Llenaclase();

            if (Validar(2))
            {
                MessageBox.Show("Introduzca Las Casillas Correspondientes!");
            }
            else
            {
                if (ProductoIdNumericUpDown.Value == 0)
                {
                    paso = ProductosBLL.Guardar(producto);
                }
                else
                {
                    int id = Convert.ToInt32(ProductoIdNumericUpDown.Value);
                    var productos = ProductosBLL.Buscar(id);
                    if (productos != null)
                    {
                        paso = ProductosBLL.Modificar(producto);
                    }
                    else
                    {
                        MessageBox.Show("Id No Encotrado!", "Fallo",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                LimpiarCampos();
                GeneralErrorProvider.Clear();
                if (paso)
                {
                    MessageBox.Show("Guardado!", "Exitoso",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("No pudo Guardar!", "Fallo",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void ButtonEliminar_Click_1(object sender, EventArgs e)
        {
            if (Validar(1))
            {
                MessageBox.Show("Introduzca Un Id");
            }
            else
            {
                int id = Convert.ToInt32(ProductoIdNumericUpDown.Value);

                if (ProductosBLL.Eliminar(id))
                {
                    MessageBox.Show("Eliminado!", "Exitoso",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LimpiarCampos();
                }
                else
                {
                    MessageBox.Show("No Pudo Eliminar!", "Fallido!",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                GeneralErrorProvider.Clear();
            }
        }

        private void ButtonNuevo_Click_1(object sender, EventArgs e)
        {
            LimpiarCampos();
        }

        private void IconCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        
        private void PrecioNumericUpDown_ValueChanged(object sender, EventArgs e)
        {
            decimal costo = Convert.ToInt32(CostoNumericUpDown.Value);
            decimal precio = Convert.ToInt32(PrecioNumericUpDown.Value);
            decimal ganancia = Convert.ToDecimal(GananciaNumericUpDown.Value);

            if (PrecioNumericUpDown.Value > CostoNumericUpDown.Value && GananciaNumericUpDown.Value == 0)
            {
                GananciaNumericUpDown.Value = ProductosBLL.CalcularGanancia(precio, costo);

            }
        }        
    }
}
