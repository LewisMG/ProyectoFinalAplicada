using ComunicacionesMendoza.BLL;
using ComunicacionesMendoza.DAL;
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
    public partial class rVentas : Form
    {
        //    decimal Total = 0;

        public rVentas()
        {
            InitializeComponent();
            LlenarCombobox();
        }

        public void LimpiarCampos()
        {
            VentaIdNumericUpDown.Value = 0;
            FechaVentaDateTimePicker.Value = DateTime.Now;
            DescripcionTextBox.Clear();
            NombreClienteTextBox.Clear();
            TelefonomaskedTextBox.Clear();
            CantidadNumericUpDown.Value = 0;
            TotalTextBox.Clear();

            ImporteTextBox.Clear();
            TotalTextBox.Text = 0.ToString();
            VentaDetalleDataGridView.DataSource = null;

            //Total = 0;
            
            GeneralErrorProvider.Clear();
        }

        //private decimal ToDecimal(object valor)
        //{
        //    decimal retorno = 1;
        //    decimal.TryParse(valor.ToString(), out retorno);
        //    return retorno;
        //}

        private int ToInt(object valor)
        {
            int retorno = 0;
            int.TryParse(valor.ToString(), out retorno);
            return retorno;
        }

        private void LlenarImporte()
        {
            int Cantidad, Precio;

            Cantidad = ToInt(CantidadNumericUpDown.Value);
            Precio = ToInt(PrecioTextBox.Text);
            ImporteTextBox.Text = VentasBLL.CalcularImporte(Precio, Cantidad).ToString();
        }

        private Ventas LlenaClase()
        {
            Ventas ventas = new Ventas();

            ventas.VentaId = Convert.ToInt32(VentaIdNumericUpDown.Value);
            ventas.Fecha = FechaVentaDateTimePicker.Value;
            ventas.Descripcion = DescripcionTextBox.Text;
            ventas.UsuarioId = Convert.ToInt32(UsuariosComboBox.SelectedValue);
            ventas.NombreCliente = NombreClienteTextBox.Text;
            ventas.TelefonoCliente = TelefonomaskedTextBox.Text; 
            ventas.Total = Convert.ToDecimal(TotalTextBox.Text);

            foreach (DataGridViewRow item in VentaDetalleDataGridView.Rows)
            {
                ventas.AgregarDetalle
                (ToInt(item.Cells["VDetalleId"].Value),
                ventas.VentaId,
                ToInt(item.Cells["productoId"].Value),
                Convert.ToString(item.Cells["producto"].Value),
                ToInt(item.Cells["Cantidad"].Value),
                ToInt(item.Cells["Precio"].Value),
                ToInt(item.Cells["Importe"].Value));
            }
            return ventas;
        }

        private void LlenarCampos(Ventas ventas)
        {
            LimpiarCampos();
            VentaIdNumericUpDown.Value = ventas.VentaId;
            FechaVentaDateTimePicker.Value = ventas.Fecha;
            DescripcionTextBox.Text = ventas.Descripcion;
            NombreClienteTextBox.Text = ventas.NombreCliente;
            TelefonomaskedTextBox.Text = ventas.TelefonoCliente;
            TotalTextBox.Text = ventas.Total.ToString();

            VentaDetalleDataGridView.DataSource = ventas.Detalle;
            QuitarColumnas();
        }

        private void LlenarCombobox()
        {
            Repositorio<Usuarios> usuarios = new Repositorio<Usuarios>(new Contexto());
            UsuariosComboBox.DataSource = usuarios.GetList(c => true);
            UsuariosComboBox.ValueMember = "UsuarioId";
            UsuariosComboBox.DisplayMember = "NombreUser";

            Repositorio<Productos> Entrada = new Repositorio<Productos>(new Contexto());
            ProductoComboBox.DataSource = Entrada.GetList(c => true);
            ProductoComboBox.ValueMember = "ProductoId";
            ProductoComboBox.DisplayMember = "Descripcion";
        }

        public void QuitarColumnas()
        {
            VentaDetalleDataGridView.Columns["Productos"].Visible = false;
            VentaDetalleDataGridView.Columns["VentaId"].Visible = false;
            VentaDetalleDataGridView.Columns["VDetalleId"].Visible = false;
        }

        private void IconCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ProductoComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            foreach (var item in ProductosBLL.GetList(x => x.Descripcion == ProductoComboBox.Text))
            {
                PrecioTextBox.Text = item.Precio.ToString();
            }
        }

        private void ButtonBuscar_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(VentaIdNumericUpDown.Value);
            Ventas venta = VentasBLL.Buscar(id);

            if (venta != null)
            {
                LlenarCampos(venta);
            }
            else
                MessageBox.Show("No se encontro!", "Fallo",
                   MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void ButtonAgregar_Click(object sender, EventArgs e)
        {
            List<VentasDetalle> detalle = new List<VentasDetalle>();

            if (VentaDetalleDataGridView.DataSource != null)
            {
                detalle = (List<VentasDetalle>)VentaDetalleDataGridView.DataSource;
            }

            Repositorio<Productos> repositorio = new Repositorio<Productos>(new Contexto());
            Productos producto = (Productos)ProductoComboBox.SelectedItem;

            if ((int)CantidadNumericUpDown.Value > producto.Inventario)
            {
                MessageBox.Show("no hay suficiente Productos para la venta!!", "Error!!",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                detalle.Add(
                    new VentasDetalle(vDetalleId: 0,
                    ventaId: (int)Convert.ToInt32(VentaIdNumericUpDown.Value),
                    productoId: (int)ProductoComboBox.SelectedValue,
                    producto: (string)ProductosBLL.RetornarDescripcion(ProductoComboBox.Text),
                    cantidad: Convert.ToInt32(CantidadNumericUpDown.Value),
                    precio: Convert.ToInt32(PrecioTextBox.Text),
                    importe: Convert.ToInt32(ImporteTextBox.Text)));

                VentaDetalleDataGridView.DataSource = null;
                VentaDetalleDataGridView.DataSource = detalle;

                QuitarColumnas();
            }

            if (CantidadNumericUpDown.Value == 0)
            {
                MessageBox.Show("Introduzca una cantidad!!", "Error!!",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            int x = Convert.ToInt32(CantidadNumericUpDown.Value);
            producto.Inventario -= x;

            decimal Total = 0;

            foreach (var item in detalle)
            {
                Total += item.Importe;
            }
          
            TotalTextBox.Text = Total.ToString();
        }

        private void ButtonRemover_Click(object sender, EventArgs e)
        {
            Ventas venta = new Ventas();
            if (VentaDetalleDataGridView.Rows.Count > 0 && VentaDetalleDataGridView.CurrentRow != null)
            {
                List<VentasDetalle> detalle = (List<VentasDetalle>)VentaDetalleDataGridView.DataSource;
                detalle.RemoveAt(VentaDetalleDataGridView.CurrentRow.Index);
                Productos producto = (Productos)ProductoComboBox.SelectedItem;

                int x = Convert.ToInt32(CantidadNumericUpDown.Value);
                producto.Inventario += x;

                decimal Total = 0;

                foreach (var item in detalle)
                {
                    Total -= item.Importe;
                }

                Total *= (-1);
                TotalTextBox.Text = Total.ToString();

                VentaDetalleDataGridView.DataSource = null;
                VentaDetalleDataGridView.DataSource = detalle;

                QuitarColumnas();
            }
        }

        private void ButtonNuevo_Click(object sender, EventArgs e)
        {
            LimpiarCampos();
        }

        private void ButtonGuardar_Click(object sender, EventArgs e)
        {
            if (Validar(2))
            {
                MessageBox.Show("Debe Ingresar Campos Obligatorios", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {
                Ventas venta = LlenaClase();
                bool Paso = false;

                if (VentaIdNumericUpDown.Value == 0)
                {
                    Paso = VentasBLL.Guardar(venta);
                }
                else
                {
                    Paso = VentasBLL.Modificar(venta);
                }

                if (Paso)
                {
                    LimpiarCampos();
                    MessageBox.Show("Guardado!!", "Exito",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                    MessageBox.Show("No se pudo guardar!!", "Fallo",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ButtonEliminar_Click(object sender, EventArgs e)
        {
            if (Validar(1))
            {
                MessageBox.Show("Favor Llenar Casilla!", "Exito",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                int id = Convert.ToInt32(VentaIdNumericUpDown.Value);
                if (VentasBLL.Eliminar(id))
                {
                    MessageBox.Show("Eliminado!!", "Exito",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LimpiarCampos();
                }
                else
                    MessageBox.Show("No se pudo eliminar!!", "Fallo",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

    

        private bool Validar(int error)
        {
            bool paso = false;

            if (error == 1 && VentaIdNumericUpDown.Value == 0)
            {
                GeneralErrorProvider.SetError(VentaIdNumericUpDown,
                  "Favor Introduzca Un Id");
                paso = true;
            }

            if (error == 2 && string.IsNullOrEmpty(DescripcionTextBox.Text))
            {
                GeneralErrorProvider.SetError(DescripcionTextBox,
                    "Es obligatorio Agregar una Descripcion");
                paso = true;
            }

            if (error == 2 && VentaDetalleDataGridView.RowCount == 0)
            {
                GeneralErrorProvider.SetError(VentaDetalleDataGridView,
                    "Es obligatorio Agregar un Producto");
                paso = true;
            }

            if (error == 3 && string.IsNullOrEmpty(ImporteTextBox.Text))
            {
                GeneralErrorProvider.SetError(ImporteTextBox,
                    "Es obligatorio Agregar un Producto");
                paso = true;
            }

            return paso;
        }

        private void PrecioTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void CantidadNumericUpDown_ValueChanged(object sender, EventArgs e)
        {
            LlenarImporte();
        }
    }
}
