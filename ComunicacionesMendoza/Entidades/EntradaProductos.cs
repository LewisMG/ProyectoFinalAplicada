using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;

namespace ComunicacionesMendoza.Entidades
{
    public class EntradaProductos
    {
        [Key]
        public int EntradapId { get; set; }
        public DateTime Fecha { get; set; }
        public int ProductoId { get; set; }
        public int Cantidad { get; set; }

        public EntradaProductos()
        {
            Fecha = DateTime.Now;
        }
    }
}
