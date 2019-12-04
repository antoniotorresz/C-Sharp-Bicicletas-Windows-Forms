using Datos;
using Modelo;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Controlador
{
    public class ControladorProducto
    {
        public static DataTable ListarProductosActivos()
        {
            DProducto datos = new DProducto();
            return datos.ListarProductosActivos();
        }
        public static DataTable ListarProductosInactivos()
        {
            DProducto datos = new DProducto();
            return datos.ListarProductosInactivos();
        }

        public static string InsertarProducto(string nombre, string descripcion, 
            string precioVenta, string cantidad, string rutafoto, string foto) {

            DProducto datos = new DProducto();
            string existe = datos.ExisteProducto(nombre);
            if (existe.Equals("1")) {
                return "El producto ya está registrado";
            }
            else
            {
                Producto producto = new Producto();

                producto.Nombre = nombre;
                producto.Descripcion = descripcion;
                producto.PrecioVenta = float.Parse(precioVenta);
                producto.Cantidad = Convert.ToInt32(cantidad);
                producto.RutaFoto = rutafoto;
                producto.Foto = foto;
                return datos.InsertarProducto(producto);
            }
        }

        public static string ActualizarProducto(string id, string nombre, string descripcion,
            string precioVenta, string cantidad, string rutafoto, string foto)
        {

            DProducto datos = new DProducto();
            string existe = datos.ExisteProducto(nombre);
            if (existe.Equals("1"))
            {
                return "El producto ya está registrado";
            }
            else
            {
                Producto producto = new Producto();

                producto.IdProducto = Convert.ToInt32(id);
                producto.Nombre = nombre;
                producto.Descripcion = descripcion;
                producto.PrecioVenta = float.Parse(precioVenta);
                producto.Cantidad = Convert.ToInt32(cantidad);
                producto.RutaFoto = rutafoto;
                producto.Foto = foto;
                return datos.ActualizarProducto(producto);
            }
        }

        public static string ActivarProducto(string idProducto) {
            DProducto datos = new DProducto();
            return datos.ActivarProducto(idProducto);
        }

        public static string DesactivarProducto(string idProducto)
        {
            DProducto datos = new DProducto();
            return datos.DesactivarProducto(idProducto);
        }

        public static DataTable Buscar(string valor)
        {
            DProducto datos = new DProducto();
            return datos.BuscarProducto(valor);
        }

        public static string CodificarB64(string filePath)
        {
            byte[] imageArray = System.IO.File.ReadAllBytes(filePath);
            return Convert.ToBase64String(imageArray);
        }


        //Este metodo nos regresará una lista de cadena de b64 con las útlimas 10 imagenes
        public static List<string> ObtenerImagenes()
        {
            DProducto datos = new DProducto();
            return datos.Get10Img();
        }
    }
}
