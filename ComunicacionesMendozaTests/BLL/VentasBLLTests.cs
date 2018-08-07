using Microsoft.VisualStudio.TestTools.UnitTesting;
using BLL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Entidades;
using System.Linq.Expressions;
using DAL;

namespace BLL.Tests
{
    [TestClass()]
    public class VentasBLLTests
    {
        [TestMethod()]
        public void GuardarTest()
        {
            bool paso;
            Ventas ventas = new Ventas();
            ventas.VentaId = 1;
            ventas.UsuarioId = 1;
            ventas.Fecha = DateTime.Now;
            ventas.Descripcion = "Venta de equipo";
            ventas.NombreCliente = "Marledy";
            ventas.TelefonoCliente = "809-361-1686";
            ventas.Itbis = 2700;
            ventas.SubTotal = 15000;
            ventas.Total = 17700;
            
            ventas.Detalle.Add(new VentasDetalle(1,1,1, "Iphone 6",1,15000,15000));
            paso = VentasBLL.Guardar(ventas);
            Assert.AreEqual(paso, true);
        }

        [TestMethod()]
        public void ModificarTest()
        {
            //int idVenta = VentasBLL.GetList(x => true)[0].VentaId;
            Ventas ventas = new Ventas();//VentasBLL.Buscar(idVenta);
            ventas.VentaId = 1;
            ventas.UsuarioId = 1;
            ventas.Fecha = DateTime.Now;
            ventas.Descripcion = "Venta de equipo";
            ventas.NombreCliente = "Maggy";
            ventas.TelefonoCliente = "829-899-6654";
            ventas.Itbis = 2700;
            ventas.SubTotal = 15000;
            ventas.Total = 17700;

            ventas.Detalle.Add(new VentasDetalle(1, 1, 1, "Iphone 6", 1, 15000, 15000));
            bool paso = VentasBLL.Modificar(ventas);
            Assert.AreEqual(paso, true);
        }

        [TestMethod()]
        public void BuscarTest()
        {
            int idVenta = VentasBLL.GetList(x => true)[0].VentaId;
            Ventas ventas = VentasBLL.Buscar(idVenta);
            bool paso = ventas.Detalle.Count > 0;
            Assert.AreEqual(true, paso);
        }

        [TestMethod()]
        public void GetListTest()
        {
            var Listar = VentasBLL.GetList(x => true);
            Assert.IsNotNull(Listar);
        }

        //[TestMethod()]
        //public void EliminarTest()
        //{
        //    bool paso;
        //    int id = 1;
        //    paso = VentasBLL.Eliminar(id);
        //    Assert.AreEqual(paso, true);
        //}

    }
}