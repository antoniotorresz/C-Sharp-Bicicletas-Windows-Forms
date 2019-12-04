using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo
{
    public  class Producto
    {
        public int IdProducto { get; set; }
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
        public float PrecioVenta { get; set; }
        public int Cantidad { get; set; }
        public string RutaFoto { get; set; }
        public string Foto { get; set; }
        public int Estatus { get; set; }
    }
}
