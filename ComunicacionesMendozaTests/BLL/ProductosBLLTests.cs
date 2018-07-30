using Microsoft.VisualStudio.TestTools.UnitTesting;
using ComunicacionesMendoza.BLL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ComunicacionesMendoza.Entidades;

namespace ComunicacionesMendoza.BLL.Tests
{
    [TestClass()]
    public class ProductosBLLTests
    {
        [TestMethod()]
        public void GuardarTest()
        {
            bool paso;
            Productos productos = new Productos();
            productos.ProductoId = 0;
            productos.Descripcion = "Iphone 6";
            productos.Costo = 13000;
            productos.Ganancia = 2000;
            productos.Precio = 15000;
            productos.Inventario = 2;
            paso = ProductosBLL.Guardar(productos);
            Assert.AreEqual(paso, true);
        }

        [TestMethod()]
        public void ModificarTest()
        {
            bool paso;
            Productos productos = new Productos();
            productos.ProductoId = 1;
            productos.Descripcion = "Iphone 6s plus";
            productos.Costo = 15000;
            productos.Ganancia = 2000;
            productos.Precio = 17000;
            productos.Inventario = 3;
            paso = ProductosBLL.Modificar(productos);
            Assert.AreEqual(paso, true);
        }
                
        [TestMethod()]
        public void BuscarTest()
        {
            int id = 1;
            Productos productos = new Productos();
            productos = ProductosBLL.Buscar(id);
            Assert.IsNotNull(productos);
        }

        [TestMethod()]
        public void GetListTest()
        {
            var Listar = ProductosBLL.GetList(x => true);
            Assert.IsNotNull(Listar);
        }

        //[TestMethod()]
        //public void CalcularGananciaTest()
        //{
        //    Productos productos = new Productos();
        //    productos = ProductosBLL.CalcularGanancia(15820, 12000);
        //    Assert.IsNotNull(productos);
        //}

        //[TestMethod()]
        //public void RetornarDescripcionTest()
        //{
        //    string nombre = "Lewis";
        //    Productos productos = new Productos();
        //    productos = ProductosBLL.RetornarDescripcion(nombre);
        //    Assert.IsNotNull(productos);
        //}

        [TestMethod()]
        public void EliminarTest()
        {
            bool paso;
            int id = 1;
            paso = ProductosBLL.Eliminar(id);
            Assert.AreEqual(paso, true);
        }
    }
}