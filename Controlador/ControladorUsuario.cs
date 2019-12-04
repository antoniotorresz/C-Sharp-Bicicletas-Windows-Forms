using Datos;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Controlador
{
    public class ControladorUsuario
    {
        public static DataTable IngresarSistema(string usuario, string contrasenia)
        {
            DUsuario datos = new DUsuario();
            return datos.Ingresar(usuario, contrasenia);
        }

        public static int validarPuesto(int idUsuario)
        {
            DUsuario datos = new DUsuario();
            return datos.validarPuesto(idUsuario);
        }


    }
}
