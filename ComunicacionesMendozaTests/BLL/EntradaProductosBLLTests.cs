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
    public class EntradaProductosBLLTests
    {
        [TestMethod()]
        public void GuardarTest()
        {
            bool paso;
            EntradaProductos entradaProductos = new EntradaProductos();
            entradaProductos.EntradapId = 0;
            entradaProductos.Fecha = DateTime.Now;
            entradaProductos.ProductoId = 1;
            entradaProductos.Cantidad = 5;
            paso = EntradaProductosBLL.Guardar(entradaProductos);
            Assert.AreEqual(paso,true);
        }

        [TestMethod()]
        public void ModificarTest()
        {
            bool paso;
            EntradaProductos entradaProductos = new EntradaProductos();
            entradaProductos.EntradapId = 1;
            entradaProductos.Fecha = DateTime.Now;
            entradaProductos.ProductoId = 1;
            entradaProductos.Cantidad = 2;
            paso = EntradaProductosBLL.Modificar(entradaProductos);
            Assert.AreEqual(paso, true);
        }

        [TestMethod()]
        public void BuscarTest()
        {
            int id = 1;
            EntradaProductos entradaProductos = new EntradaProductos();
            entradaProductos = EntradaProductosBLL.Buscar(id);
            Assert.IsNotNull(entradaProductos);
        }

        [TestMethod()]
        public void GetListTest()
        {
            var Listar = EntradaProductosBLL.GetList(x => true);
            Assert.IsNotNull(Listar);
        }

        [TestMethod()]
        public void EliminarTest()
        {
            bool paso;
            int id = 1;
            paso = EntradaProductosBLL.Eliminar(id);
            Assert.AreEqual(paso, true);
        }
    }
}