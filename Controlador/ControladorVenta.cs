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
    public class ControladorVenta
    {
        public static DataTable ListarProductosActivos()
        {
            DVentas datos = new DVentas();
            return datos.ListarVentas();
        }

        public static DataTable LlenarComboEmpleado()
        {
            DVentas datos = new DVentas();
            return datos.LlenarCombo();
        }

        public static DataTable ListarVentaProducto(string id)
        {
            DVentas datos = new DVentas();
            return datos.ListarVentasProductos(id);
        }

        public static string updateVenta(string id,string total)
        {
            DVentas datos = new DVentas();
            return datos.actualizarVenta(id,total);
        }

        public static string EliminarVentaProducto(string idV, string idP,string cant)
        {
            DVentas datos = new DVentas();
            return datos.deleteProductoventa(idV,idP,cant);
        }

        public static string InsertarVentaProducto(string id, string idp,string cant)
        {
            DVentas datos = new DVentas();
            return datos.ingresarVentaProducto(id,idp,cant);
        }



        public static string InsertarVenta(DateTime fechaVenta, string idEmpleado)
        {

            DVentas datos = new DVentas();

                Ventas ventas = new Ventas();

                ventas.FechaVenta= fechaVenta;
                ventas.idEmpleado = idEmpleado;
                return datos.insertarVenta(ventas);
        }
    }
}
