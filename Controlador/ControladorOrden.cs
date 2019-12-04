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
    public class ControladorOrden
    {
        public static DataTable ComboProvedor()
        {
            DOrden datos = new DOrden();
            return datos.ComboProvedor();
        }

        public static DataTable listMaterialProvedor(string nombre)
        {
            DOrden datos = new DOrden();
            return datos.ListMateriales(nombre);
        }

        public static DataTable listMaterialComprados(string id)
        {
            DOrden datos = new DOrden();
            return datos.ListMaterialCompra(id);
        }

        public static string InsertarOrden(DateTime fecha, string idProvedor)
        {

            DOrden datos = new DOrden();
            return datos.insertarOrden(fecha, idProvedor);
        }

        public static string InsertarOrden(string idcompra, string idmaterial, string cantidad)
        {
            DOrden datos = new DOrden();
            return datos.ingresarCompraMaterial(idcompra, idmaterial, cantidad);
        }

        public static string ActualizarPagado(string idCompra, string precioPagado)
        {
            DOrden datos = new DOrden();
            return datos.ActualizarPagado(idCompra, precioPagado);
        }

        public static string CancelarOrden(string idCompra)
        {
            DOrden datos = new DOrden();
            return datos.CancelarOrden(idCompra);
        }

    }
}

