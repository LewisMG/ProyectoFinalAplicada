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
    public class UsuariosBLL
    {
        public static bool Guardar(Usuarios usuario)
        {
            bool paso = false;
            Contexto contexto = new Contexto();

            try
            {
                if (contexto.Usuarios.Add(usuario) != null)
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

        public static bool Modificar(Usuarios usuario)
        {

            bool paso = false;
            Contexto contexto = new Contexto();

            try
            {
                contexto.Entry(usuario).State = EntityState.Modified;

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
                Usuarios usuario = contexto.Usuarios.Find(id);

                if (usuario != null)
                {
                    contexto.Entry(usuario).State = EntityState.Deleted;
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

        public static Usuarios Buscar(int id)
        {
            Usuarios usuario = new Usuarios();
            Contexto contexto = new Contexto();

            try
            {
                usuario = contexto.Usuarios.Find(id);
                contexto.Dispose();
            }
            catch (Exception)
            {
                throw;
            }
            return usuario;
        }

        public static List<Usuarios> GetList(Expression<Func<Usuarios, bool>> expression)
        {
            List<Usuarios> usuario = new List<Usuarios>();
            Contexto contexto = new Contexto();

            try
            {
                usuario = contexto.Usuarios.Where(expression).ToList();
                contexto.Dispose();
            }
            catch (Exception)
            {
                throw;
            }
            return usuario;
        }
    }
}
