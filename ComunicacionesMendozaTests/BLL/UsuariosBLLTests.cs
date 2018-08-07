using Microsoft.VisualStudio.TestTools.UnitTesting;
using BLL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Entidades;

namespace BLL.Tests
{
    [TestClass()]
    public class UsuariosBLLTests
    {
        [TestMethod()]
        public void GuardarTest()
        {
            bool paso;
            Usuarios usuarios = new Usuarios();
            usuarios.UsuarioId = 1;
            usuarios.Nombre = "Lewis Mendoza";
            usuarios.NombreUser = "LewMen";
            usuarios.Clave = "061098";
            usuarios.Fecha = DateTime.Now;
            usuarios.TotalVendido = 0;
            paso = UsuariosBLL.Guardar(usuarios);
            Assert.AreEqual(paso,true);
        }

        [TestMethod()]
        public void ModificarTest()
        {
            bool paso;
            Usuarios usuarios = new Usuarios();
            usuarios.UsuarioId = 1;
            usuarios.Nombre = "Lewis Mendoza";
            usuarios.NombreUser = "LewMen";
            usuarios.Clave = "061098";
            usuarios.Fecha = DateTime.Now;
            usuarios.TotalVendido = 16500;
            paso = UsuariosBLL.Modificar(usuarios);
            Assert.AreEqual(paso, true);
        }
               
        [TestMethod()]
        public void BuscarTest()
        {
            int id = 1;
            Usuarios usuarios = new Usuarios();
            usuarios = UsuariosBLL.Buscar(id);
            Assert.IsNotNull(usuarios);
        }

        [TestMethod()]
        public void GetListTest()
        {
            var Listar = UsuariosBLL.GetList(x => true);
            Assert.IsNotNull(Listar);
        }

        //[TestMethod()]
        //public void EliminarTest()
        //{
        //    bool paso;
        //    int id = 1;
        //    paso = UsuariosBLL.Eliminar(id);
        //    Assert.AreEqual(paso, true);
        //}
    }
}