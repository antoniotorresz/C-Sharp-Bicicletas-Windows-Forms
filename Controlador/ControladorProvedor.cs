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
    public class ControladorProvedor
    {
        //Sirve para comunicarnos con la clase datos

        public static DataTable Listar()
        {
            DProvedor datos = new DProvedor();
            return datos.ListarProvedores();
        }

        public static DataTable Buscar(string valor) {
            DProvedor datos = new DProvedor();
            return datos.BuscarProvedores(valor);
        }

        public static string Insertar(string nombre, string direccion, string telefono, string correo) {
            DProvedor datos = new DProvedor();

            string existe = datos.ExisteProvedor(nombre);

            if (existe.Equals("1"))
            {
                return "Ya está registrado este proveedor";
            }
            else
            {
                Proveedor proveedor = new Proveedor();
                proveedor.NombreProvedor = nombre;
                proveedor.Direccion = direccion;
                proveedor.Telefono = telefono;
                proveedor.Correo = correo;
                return datos.InsertarProvedor(proveedor);
            }


        }

        public static string Actualizar(string id, string nombre, string direccion, string telefono, string correo)
        {
            DProvedor datos = new DProvedor();

            string existe = datos.ExisteProvedor(nombre);

            if (existe.Equals("1"))
            {
                return "Ya está registrado este proveedor";
            }
            else {

                Proveedor proveedor = new Proveedor();

                proveedor.IdProvedor = id;
                proveedor.NombreProvedor = nombre;
                proveedor.Direccion = direccion;
                proveedor.Telefono = telefono;
                proveedor.Correo = correo;

                return datos.AcutalizarProveedor(proveedor);
            }
        }

        public static string Eliminar(string id) {
            DProvedor datos = new DProvedor();
            return datos.EliminarProvedor(id);
        }
    }
}
