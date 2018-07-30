using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;

namespace ComunicacionesMendoza.Entidades
{
    public class Usuarios
    {
        [Key]
        public int UsuarioId { get; set; }
        public string Nombre { get; set; }
        public string NombreUser { get; set; }
        public string Clave { get; set; }
        public DateTime Fecha { get; set; }
        public decimal TotalVendido { get; set; }

        public Usuarios()
        {

        }
    }
}
