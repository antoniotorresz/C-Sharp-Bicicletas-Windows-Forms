using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo
{
    public class Proveedor
    {
        [StringLength(50, ErrorMessage = "IDprovedor Tamaño excede")]
        public string IdProvedor { get; set; }

        [StringLength(50, ErrorMessage = "nombreprovedor Tamaño excede")]
        public string NombreProvedor { get; set; }

        [StringLength(200, ErrorMessage = "Direccion Tamaño excede")]
        public string Direccion { get; set; }

        [StringLength(15, ErrorMessage = "Telefono Tamaño excede")]
        public string Telefono { get; set; }

        [StringLength(50, ErrorMessage = "Correo Tamaño excede")]
        public string Correo { get; set; }

    }
}
