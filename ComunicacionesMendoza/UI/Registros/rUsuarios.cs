using BLL;
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
    public partial class rUsuarios : Form
    {
        public rUsuarios()
        {
            InitializeComponent();
        }

        private void IconCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public bool VerificarClave()
        {
            bool paso = false;
            string cadenaUno = ClaveTextBox.Text;
            string cadenaDos = VerificarClaveTextBox.Text;

            if (cadenaUno != cadenaDos)
            {
                MessageBox.Show("Contraseña y Verificación no son iguales", "Fallo",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                paso = true;
            }
            return paso;
        }

        private Usuarios Llenaclase()
        {
            TotalVendidoTextBox.Text = 0.ToString();
            Usuarios usuario = new Usuarios();

            usuario.UsuarioId = Convert.ToInt32(UsuarioIdNumericUpDown.Value);
            usuario.Nombre = NombresTextBox.Text;
            usuario.NombreUser = UsuarioTextBox.Text;
            usuario.Clave = ClaveTextBox.Text;
            usuario.Fecha = FechaDateTimePicker.Value;
            usuario.TotalVendido = Convert.ToDecimal(TotalVendidoTextBox.Text);

            return usuario;
        }

        private void LimpiarCampos()
        {
            UsuarioIdNumericUpDown.Value = 0;
            NombresTextBox.Clear();
            UsuarioTextBox.Clear(); 
            ClaveTextBox.Clear();
            VerificarClaveTextBox.Clear();
            FechaDateTimePicker.Value = DateTime.Now;
            TotalVendidoTextBox.Clear();

            GeneralErrorProvider.Clear();
        }

        private bool Validar(int error)
        {
            bool paso = false;

            if (error == 1 && UsuarioIdNumericUpDown.Value == 0)
            {
                GeneralErrorProvider.SetError(UsuarioIdNumericUpDown,
                    "Introduzca Id");
                paso = true;
            }

            if (error == 2 && string.IsNullOrEmpty(NombresTextBox.Text))
            {
                GeneralErrorProvider.SetError(NombresTextBox,
                    "Introduzca El Nombre");
                paso = true;
            }

            if (error == 2 && string.IsNullOrEmpty(UsuarioTextBox.Text))
            {
                GeneralErrorProvider.SetError(UsuarioTextBox,
                    "Introduzca Nombre De Usuario");
                paso = true;
            }

            if (error == 2 && string.IsNullOrEmpty(ClaveTextBox.Text))
            {
                GeneralErrorProvider.SetError(ClaveTextBox,
                    "Introduzca La Contraseña");
                paso = true;
            }

            if (error == 3 && ClaveTextBox.Text != VerificarClaveTextBox.Text)
            {
                GeneralErrorProvider.SetError(VerificarClaveTextBox,
                    "Confirme La Contraseña");
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
                int id = Convert.ToInt32(UsuarioIdNumericUpDown.Value);
                Usuarios usuario = UsuariosBLL.Buscar(id);

                if (usuario != null)
                {
                    UsuarioIdNumericUpDown.Value = usuario.UsuarioId;
                    NombresTextBox.Text = usuario.Nombre;
                    UsuarioTextBox.Text = usuario.NombreUser;
                    ClaveTextBox.Text = usuario.Clave;
                    FechaDateTimePicker.Value = usuario.Fecha;
                    TotalVendidoTextBox.Text = usuario.TotalVendido.ToString();
                }
                else
                {
                    MessageBox.Show("No Fue Encontrado!", "Fallido",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
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
            Usuarios usuario = Llenaclase();

            if (VerificarClave())
            {
                MessageBox.Show("La Contraseña No Es la Misma Verique!");
            }
            else if (Validar(2))
            {
                MessageBox.Show("Introduzca Las Casillas Correspondientes!");
            }           
            else
            {
                if (UsuarioIdNumericUpDown.Value == 0)
                {
                    paso = UsuariosBLL.Guardar(usuario);
                }
                else
                {
                    int id = Convert.ToInt32(UsuarioIdNumericUpDown.Value);
                    var usuarios = UsuariosBLL.Buscar(id);
                    if (usuarios != null)
                    {
                        paso = UsuariosBLL.Modificar(usuario);
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

        private void ButtonEliminar_Click(object sender, EventArgs e)
        {
            if (Validar(1))
            {
                MessageBox.Show("Introduzca Un Id");
            }
            else
            {
                int id = Convert.ToInt32(UsuarioIdNumericUpDown.Value);

                if (UsuariosBLL.Eliminar(id))
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
    }
}
