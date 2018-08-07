using BLL;
using DAL;
using Entidades;
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
    public partial class rEntradaProductos : Form
    {
        public rEntradaProductos()
        {
            InitializeComponent();
            LlenarComboBox();
        }

        private void IconCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        private EntradaProductos Llenarclase()
        {
            EntradaProductos entradaProducto = new EntradaProductos();
            entradaProducto.EntradapId = Convert.ToInt32(EntradaIdNumericUpDown.Value);
            entradaProducto.Fecha = fechaDateTimePicker.Value;
            entradaProducto.ProductoId = (int)ProductosComboBox.SelectedValue;
            entradaProducto.Cantidad = Convert.ToInt32(CantidadNumericUpDown.Value);

            return entradaProducto;
        }

        private void LimpiarCampos()
        {
            EntradaIdNumericUpDown.Value = 0;
            CantidadNumericUpDown.Value = 0;
            fechaDateTimePicker.Value = DateTime.Now;

            GeneralErrorProvider.Clear();
        }

        private void LlenarComboBox()
        {
            Repositorio<Productos> repositorio = new Repositorio<Productos>(new Contexto());
            ProductosComboBox.DataSource = repositorio.GetList(c => true);
            ProductosComboBox.ValueMember = "ProductoId";
            ProductosComboBox.DisplayMember = "Descripcion";
        }

        private bool Validar(int error)
        {
            bool errores = false;

            if (error == 1 && EntradaIdNumericUpDown.Value == 0)
            {
                GeneralErrorProvider.SetError(EntradaIdNumericUpDown, "Introduzca un Id");
                errores = true;
            }

            if (error == 2 && CantidadNumericUpDown.Value == 0)
            {
                GeneralErrorProvider.SetError(CantidadNumericUpDown, "Introduzca un Nombre");
                errores = true;
            }
            return errores;
        }

        private void ButtonBuscar_Click(object sender, EventArgs e)
        {
            if (Validar(1))
            {
                MessageBox.Show("Introducir Id");
            }
            else
            {
                int id = Convert.ToInt32(EntradaIdNumericUpDown.Value);
                EntradaProductos entradaProducto = EntradaProductosBLL.Buscar(id);

                if (entradaProducto != null)
                {
                    EntradaIdNumericUpDown.Value = entradaProducto.EntradapId;
                    ProductosComboBox.SelectedValue = entradaProducto.ProductoId;
                    CantidadNumericUpDown.Value = entradaProducto.Cantidad;
                }
                else
                {
                    MessageBox.Show("No Fue Encontrado!",
                        "Fallo!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                GeneralErrorProvider.Clear();
            }
        }

        private void ButtonNuevo_Click(object sender, EventArgs e)
        {
            LimpiarCampos();
        }

        private void ButtonGuardar_Click(object sender, EventArgs e)
        {
            bool paso = false;
            EntradaProductos entradaProducto = Llenarclase();

            if (Validar(2))
            {
                MessageBox.Show("Favor de Llenar las Casillas");
            }
            else
            {
                if (EntradaIdNumericUpDown.Value == 0)
                {
                    paso = EntradaProductosBLL.Guardar(entradaProducto);
                }
                else
                {
                    var V = EntradaProductosBLL.Buscar(Convert.ToInt32(EntradaIdNumericUpDown.Value));

                    if (V != null)
                    {
                        paso = EntradaProductosBLL.Modificar(entradaProducto);
                    }
                }
                LimpiarCampos();
                GeneralErrorProvider.Clear();
                if (paso)
                {
                    MessageBox.Show("Guardado!", "Exitoso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("No pudo Guardar!", "Fallo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void ButtonEliminar_Click(object sender, EventArgs e)
        {
            if (Validar(1))
            {
                MessageBox.Show("Introduzca Un Id");
            }
            else
            {
                int id = Convert.ToInt32(EntradaIdNumericUpDown.Value);

                if (EntradaProductosBLL.Eliminar(id))
                {
                    MessageBox.Show("Eliminado!",
                        "Exitosamente", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LimpiarCampos();
                }
                else
                {
                    MessageBox.Show("No se Pudo Eliminar!",
                        "Fallo!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                GeneralErrorProvider.Clear();
            }
        }

        private void rEntradaProductos_Load(object sender, EventArgs e)
        {

        }

        private void EntradaIdNumericUpDown_ValueChanged(object sender, EventArgs e)
        {

        }

        private void fechaDateTimePicker_ValueChanged(object sender, EventArgs e)
        {

        }

        private void ProductosComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void CantidadNumericUpDown_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
