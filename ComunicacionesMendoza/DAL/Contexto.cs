using ComunicacionesMendoza.Entidades;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;

namespace ComunicacionesMendoza.DAL
{
    public class Contexto : DbContext
    {
        public DbSet<Productos> Productos { get; set; }
        public DbSet<EntradaProductos> EntradaProductos { get; set; }
        public DbSet<Ventas> Venta { get; set; }
        public DbSet<VentasDetalle> Ventas  { get; set; }
        public DbSet<Usuarios> Usuarios { get; set; }

        public Contexto() : base("ConStr") { }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
    }
}
