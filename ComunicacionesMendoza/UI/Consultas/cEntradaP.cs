using BLL;
using Entidades;
using ComunicacionesMendoza.UI.Ventana_Reportes;
using System;
using System.Linq;
using System.Linq.Expressions;
using System.Windows.Forms;

namespace ComunicacionesMendoza.UI.Consultas
{
    public partial class cEntradaP : Form
    {
        public cEntradaP()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {

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

            return paso;
        }

        Expression<Func<EntradaProductos, bool>> filtro = x => true;
        
        private void ButtonBuscar_Click(object sender, EventArgs e)
        {             
            switch (FiltroComboBox.SelectedIndex)
            {
                case 0://EntradaId
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
                            filtro = x => x.EntradapId == id &&
                            (x.Fecha >= DesdeDateTimePicker.Value.Date &&
                            x.Fecha <= HastaDateTimePicker.Value.Date);
                        }
                        else
                        {
                            filtro = x => x.EntradapId == id;
                        }

                        if (EntradaProductosBLL.GetList(filtro).Count() == 0)
                        {
                            MessageBox.Show("No Hay Existencia", "Aviso",
                                MessageBoxButtons.OK, MessageBoxIcon.Information);
                            return;
                        }
                    }
                    break;
                case 1://ProductoId

                    if (Validar(1))
                    {
                        MessageBox.Show("Llenar Casilla ", "Fallido",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    if (Validar(2))
                    {
                        MessageBox.Show("Ingrese un Numero!",
                            "Fallido", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    else
                    {
                        int productoId = Convert.ToInt32(CriterioTextBox.Text);
                        if (FechaCheckBox.Checked == true)
                        {
                            filtro = x => x.ProductoId ==  productoId &&
                            (x.Fecha >= DesdeDateTimePicker.Value.Date &&
                            x.Fecha <= HastaDateTimePicker.Value.Date);
                        }
                        else
                        {
                            filtro = x => x.ProductoId == productoId;
                        }

                        if (EntradaProductosBLL.GetList(filtro).Count() == 0)
                        {
                            MessageBox.Show("No Hay Existencia", "Aviso",
                                MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                    break;

                case 2://Cantidad

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
                        int cantidad = Convert.ToInt32(CriterioTextBox.Text);
                        if (FechaCheckBox.Checked == true)
                        {
                            filtro = x => x.Cantidad == cantidad &&
                            (x.Fecha >= DesdeDateTimePicker.Value.Date &&
                            x.Fecha <= HastaDateTimePicker.Value.Date);
                        }
                        else
                        {
                            filtro = x => x.Cantidad == cantidad;
                        }

                        if (EntradaProductosBLL.GetList(filtro).Count() == 0)
                        {
                            MessageBox.Show("No Hay Existencia", "Aviso",
                                MessageBoxButtons.OK, MessageBoxIcon.Information);

                        }
                    }
                    break;
                case 3://Todos
                    filtro = x => true;
                    break;
            }
            EntradaProductosDataGridView.DataSource = EntradaProductosBLL.GetList(filtro);

            CriterioTextBox.Clear();
            GeneralErrorProvider.Clear();
        }

        private void ButtonNuevo_Click(object sender, EventArgs e)
        {
            vEntradaProducto ver = new vEntradaProducto(EntradaProductosBLL.GetList(filtro));
            ver.Show();
        }
    }
}
