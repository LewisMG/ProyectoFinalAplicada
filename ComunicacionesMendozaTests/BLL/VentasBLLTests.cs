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
    public class VentasBLLTests
    {
        [TestMethod()]
        public void GuardarTest()
        {
            bool paso;
            Ventas ventas = new Ventas();
            ventas.VentaId = 0;
            ventas.UsuarioId = 1;
            ventas.Fecha = DateTime.Now;
            ventas.Descripcion = "Venta de equipo";
            ventas.NombreCliente = "Marledy";
            ventas.TelefonoCliente = "809-361-1686";
            ventas.Detalle.Add(new VentasDetalle(1,1,2, "Iphone 6",1,15000,15000));
            ventas.Total = 15000;
            paso = VentasBLL.Guardar(ventas);
            Assert.AreEqual(paso, true);
        }

        [TestMethod()]
        public void ModificarTest()
        {
            Assert.Fail();
        }

        [TestMethod()]
        public void EliminarTest()
        {
            Assert.Fail();
        }

        [TestMethod()]
        public void BuscarTest()
        {
            Assert.Fail();
        }

        [TestMethod()]
        public void GetListTest()
        {
            Assert.Fail();
        }

        [TestMethod()]
        public void GetListTest1()
        {
            Assert.Fail();
        }

        [TestMethod()]
        public void CalcularImporteTest()
        {
            Assert.Fail();
        }
    }
}