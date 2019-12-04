using Datos;
using Modelo;
using System;
using System.Collections.Generic;
using System.Data;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Controlador
{
    public class ControladorMaterial
    {
        public static DataTable ListarActivos()
        {
            DMaterial datos = new DMaterial();
            return datos.ListarMaterialesActivos();
        }

        public static DataTable ListarInactivos()
        {
            DMaterial datos = new DMaterial();
            return datos.ListarMaterialesInactivos();
        }

        public static DataTable ListarNombreProvedor()
        {
            DMaterial datos = new DMaterial();
            return datos.LlenarComboNombre();
        }

        public static string InsertarMaterial(string nombre, string descripcion,
                                              string cantidad, string precioCompra, string idProvedor)
        {
            DMaterial datos = new DMaterial();
            string existe = datos.ExisteMaterial(nombre);
            if (existe.Equals("1"))
            {
                return "Ya está registrado este material";
            }
            else
            {
                Material material = new Material();
                material.Nombre = nombre;
                material.Descripcion = descripcion;
                material.Cantidad = Convert.ToInt32(cantidad);
                material.PrecioCompra = float.Parse(precioCompra);
                material.IdProvedor = idProvedor;

                return datos.InsertarMaterial(material);

            }
        }

        public static string ActualizarMaterial(string idMaterial, string nombre, string descripcion,
                                              string cantidad, string precioCompra, string idProvedor)
        {
            DMaterial datos = new DMaterial();

            Material material = new Material();
            material.IdMaterial = Convert.ToInt32(idMaterial);
            material.Nombre = nombre;
            material.Descripcion = descripcion;
            material.Cantidad = Convert.ToInt32(cantidad);
            material.PrecioCompra = float.Parse(precioCompra);
            material.IdProvedor = idProvedor;

            return datos.AcutalizarMaterial(material);

        }

        public static string DesactivarMaterial(string idMaterial)
        {
            DMaterial datos = new DMaterial();
            return datos.DesactivarMaterial(idMaterial);
        }

        public static string ActivarMaterial(string idMaterial)
        {
            DMaterial datos = new DMaterial();
            return datos.ActivarMaterial(idMaterial);
        }

        public static DataTable BuscarMaterial(string valor)
        {
            DMaterial datos = new DMaterial();
            return datos.BuscarMaterial(valor);
        }

    }
}