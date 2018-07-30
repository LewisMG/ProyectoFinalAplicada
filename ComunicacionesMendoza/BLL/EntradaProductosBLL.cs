using ComunicacionesMendoza.DAL;
using ComunicacionesMendoza.Entidades;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace ComunicacionesMendoza.BLL
{
    public class EntradaProductosBLL
    {
        public static bool Guardar(EntradaProductos entradaProducto)
        {
            bool paso = false;
            Contexto contexto = new Contexto();

            try
            {
                if (contexto.EntradaProductos.Add(entradaProducto) != null)
                {
                    var producto = contexto.Productos.Find(entradaProducto.ProductoId);
                    //Incrementar la cantidad
                    producto.Inventario += entradaProducto.Cantidad;

                    contexto.SaveChanges();
                    paso = true;
                }
                contexto.Dispose();
            }
            catch (Exception) { throw; }

            return paso;
        }

        public static bool Eliminar(int id)
        {

            bool paso = false;
            Contexto contexto = new Contexto();

            try
            {
                EntradaProductos entradaProducto = contexto.EntradaProductos.Find(id);

                if (entradaProducto != null)
                {
                    var Producto = contexto.Productos.Find(entradaProducto.ProductoId);
                    //Reduce la cantidad
                    Producto.Inventario -= entradaProducto.Cantidad;

                    contexto.Entry(entradaProducto).State = EntityState.Deleted;
                }

                if (contexto.SaveChanges() > 0)
                {
                    paso = true;
                    contexto.Dispose();
                }

            }
            catch (Exception)
            {
                throw;
            }

            return paso;
        }

        public static bool Modificar(EntradaProductos entradaProducto)
        {

            bool paso = false;
            Contexto contexto = new Contexto();

            try
            {
                EntradaProductos EntradaAnterior = EntradaProductosBLL.Buscar(entradaProducto.EntradapId);

                int diferencia;
                diferencia = entradaProducto.Cantidad - EntradaAnterior.Cantidad;

                var Producto = contexto.Productos.Find(EntradaAnterior.ProductoId);

                Producto.Inventario += diferencia;

                contexto.Entry(entradaProducto).State = EntityState.Modified;

                if (contexto.SaveChanges() > 0)
                {
                    paso = true;
                }
                contexto.Dispose();

            }
            catch (Exception)
            {
                throw;
            }

            return paso;
        }

        public static EntradaProductos Buscar(int id)
        {

            EntradaProductos entradaProducto = new EntradaProductos();
            Contexto contexto = new Contexto();

            try
            {
                entradaProducto = contexto.EntradaProductos.Find(id);
                contexto.Dispose();
            }
            catch (Exception)
            {
                throw;
            }
            return entradaProducto;

        }

        public static List<EntradaProductos> GetList(Expression<Func<EntradaProductos, bool>> expression)
        {
            List<EntradaProductos> entradaProducto = new List<EntradaProductos>();
            Contexto contexto = new Contexto();

            try
            {
                entradaProducto = contexto.EntradaProductos.Where(expression).ToList();
                contexto.Dispose();

            }
            catch (Exception)
            {
                throw;
            }
            return entradaProducto;
        }
    }
}
