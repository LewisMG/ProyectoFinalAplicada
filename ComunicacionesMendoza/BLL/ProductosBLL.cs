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
    public class ProductosBLL
    {
        public static bool Guardar(Productos producto)
        {
            bool paso = false;
            Contexto contexto = new Contexto();

            try
            {
                if (contexto.Productos.Add(producto) != null)
                {
                    contexto.SaveChanges();
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

        public static bool Modificar(Productos producto)
        {

            bool paso = false;
            Contexto contexto = new Contexto();

            try
            {
                contexto.Entry(producto).State = EntityState.Modified;

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

        public static bool Eliminar(int id)
        {

            bool paso = false;
            Contexto contexto = new Contexto();

            try
            {
                Productos producto = contexto.Productos.Find(id);

                if (producto != null)
                {
                    contexto.Entry(producto).State = EntityState.Deleted;
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

        public static Productos Buscar(int id)
        {
            Productos producto = new Productos();
            Contexto contexto = new Contexto();

            try
            {
                producto = contexto.Productos.Find(id);
                contexto.Dispose();
            }
            catch (Exception)
            {
                throw;
            }
            return producto;
        }

        public static List<Productos> GetList(Expression<Func<Productos, bool>> expression)
        {
            List<Productos> producto = new List<Productos>();
            Contexto contexto = new Contexto();

            try
            {
                producto = contexto.Productos.Where(expression).ToList();
                contexto.Dispose();
            }
            catch (Exception)
            {
                throw;
            }
            return producto;
        }

        public static decimal CalcularGanancia(decimal precioventa, decimal preciocompra)
        {
            return precioventa - preciocompra ;
        }

        public static string RetornarDescripcion(string nombre)
        {
            string descripcion = string.Empty;
            var lista = GetList(x => x.Descripcion.Equals(nombre));
            foreach (var item in lista)
            {
                descripcion = item.Descripcion;
            }

            return descripcion;
        }
    }
}
