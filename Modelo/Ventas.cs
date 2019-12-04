using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo
{
    public class Ventas
    {
        public int idVenta { get; set; }
        public DateTime FechaVenta { get; set; }
        public string idEmpleado { get; set; }
        public float precioTotal { get; set; }
        public int estatus { get; set; }
    }
}
