using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WebApplication1.Models
{
    public class Clientes
    {
        [Key]
        public int idCliente { get; set; }

        [Display(Name ="Nombre")]
        public string nombre { get; set; }

        [Display(Name = "Apellido")]
        public string apellido { get; set; }

        [Display(Name = "Correo")]
        public string correo { get; set; }

    }
}