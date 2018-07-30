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
    public partial class cUsuarios : Form
    {
        Expression<Func<Usuarios, bool>> filtro = x => true;

        public cUsuarios()
        {
            InitializeComponent();
        }

        private void cUsuarios_Load(object sender, EventArgs e)
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
                case 0://UsuarioId
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
                            filtro = x => x.UsuarioId == id && 
                            (x.Fecha >= DesdeDateTimePicker.Value.Date && 
                            x.Fecha <= HastaDateTimePicker.Value.Date);
                        }
                        else
                        {
                            filtro = x => x.UsuarioId == id;
                        }

                        if (UsuariosBLL.GetList(filtro).Count() == 0)
                        {
                            MessageBox.Show("No Hay Existencia", "Aviso", 
                                MessageBoxButtons.OK, MessageBoxIcon.Information);
                            return;
                        }
                    }
                    break;
                case 1://Nombre

                    if (Validar(1))
                    {
                        MessageBox.Show("Llenar Casilla ", "Fallido", 
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    if (Validar(3))
                    {
                        MessageBox.Show("Ingrese un Nombre!", 
                            "Fallido", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    else
                    {
                        if (FechaCheckBox.Checked == true)
                        {
                            filtro = x => x.Nombre.Contains(CriterioTextBox.Text) && 
                            (x.Fecha >= DesdeDateTimePicker.Value.Date && 
                            x.Fecha <= HastaDateTimePicker.Value.Date);
                        }
                        else
                        {
                            filtro = x => x.Nombre.Contains(CriterioTextBox.Text);
                        }

                        if (UsuariosBLL.GetList(filtro).Count() == 0)
                        {
                            MessageBox.Show("No Hay Existencia", "Aviso", 
                                MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                    break;

                case 2://NombreUsuario

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
                            filtro = x => x.NombreUser.Contains(CriterioTextBox.Text) && 
                            (x.Fecha >= DesdeDateTimePicker.Value.Date && 
                            x.Fecha <= HastaDateTimePicker.Value.Date);
                        }
                        else
                        {
                            filtro = x => x.NombreUser.Contains(CriterioTextBox.Text);
                        }

                        if (UsuariosBLL.GetList(filtro).Count() == 0)
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

            UsuariosDataGridView.DataSource = UsuariosBLL.GetList(filtro);

            CriterioTextBox.Clear();
            GeneralErrorProvider.Clear();
        }

        private void ButtonImprimir_Click(object sender, EventArgs e)
        {
            vUsuarios ver = new vUsuarios(BLL.UsuariosBLL.GetList(filtro));
            ver.Show();
        }
    }
}
