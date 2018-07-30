using ComunicacionesMendoza.BLL;
using ComunicacionesMendoza.Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Windows.Forms;

namespace ComunicacionesMendoza
{
    public partial class LOGIN : Form
    {
        public LOGIN()
        {
            InitializeComponent();
        }

        private void CleanProvider()
        {
            LogInErrorProvider.Clear();
        }

        private void ButtonLogin_Click(object sender, EventArgs e)
        {
            int paso = 0;
            Expression<Func<Usuarios, bool>> filtrar = x => true;
            List<Usuarios> user = new List<Usuarios>();
            
            CleanProvider();
            if (UsuariologtextBox.Text == string.Empty)
            {
                paso = 1;
                LogInErrorProvider.SetError(UsuariologtextBox, "Incorrecto");

            }
            if (ClavetextBox.Text == string.Empty)
            {
                paso = 1;
                LogInErrorProvider.SetError(ClavetextBox, "Incorrecto");

            }
            if (paso == 1)
            {
                MessageBox.Show("Campos Vacios!!");
                return;
            }
            if ((UsuariologtextBox.Text == "Admin") && (ClavetextBox.Text == "061098"))
            {
                MainForm ver = new MainForm();
                ver.Show();
            }
            else
            { 
                filtrar = t => t.NombreUser.Equals(UsuariologtextBox.Text);
                user = UsuariosBLL.GetList(filtrar);

                if (user.Exists(x => x.NombreUser == UsuariologtextBox.Text) && user.Exists(x => x.Clave == ClavetextBox.Text))
                {
                    MainForm ver = new MainForm();
                    ver.Show();
                }
                else
                {
                    MessageBox.Show("Nombre de usuario o contraseña incorrecta!!");
                    LogInErrorProvider.SetError(ClavetextBox, "Incorrecto");
                    LogInErrorProvider.SetError(UsuariologtextBox, "Incorrecto");
                }
            }
            ClavetextBox.MaxLength = 14;
        }

        private void IconCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void LOGIN_Load(object sender, EventArgs e)
        {

        }
    }
}
