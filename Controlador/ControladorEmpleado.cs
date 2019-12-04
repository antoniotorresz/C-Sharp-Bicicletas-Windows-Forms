using Datos;
using Modelo;
using System;
using System.Data;

namespace Controlador
{
    public class ControladorEmpleado
    {
        public static DataTable ListarEmpleadosAct()
        {
            DEmpleado datos = new DEmpleado();
            return datos.ListarEmpleadosActivos();
        }

        public static string InsertarEmpleado(/*Empleado*/ int puesto,
            /*Persona:*/string pNombre, string pAPaterno, string pAMaterno,
                        char pGenero, string pDireccion, string pTelefono, string pCorreo,
            /*Usuario: */ string nombreUsuario, string contrasenia)
        {
            DEmpleado datos = new DEmpleado();
            //Armamos persona
            Persona persona = new Persona();
            persona.Nombre = pNombre;
            persona.APaterno = pAPaterno;
            persona.AMaterno = pAMaterno;
            persona.Genero = pGenero;
            persona.Direcion = pDireccion;
            persona.Telefono = pTelefono;
            persona.Correo = pCorreo;

            //Armamos Empleado
            Empleado empleado = new Empleado();
            empleado.Puesto = puesto;
            empleado.Estatus = 1;

            //Armamos usuario
            Usuario usuario = new Usuario();
            usuario.NombreUsuario = nombreUsuario;
            usuario.Contrasenia = contrasenia;

            return datos.InsertarEmpleado(empleado, persona, usuario);

        }

        public static string ActualizarEmpleado(/*Empleado*/ string idEmpleado ,int puesto,
    /*Persona:*/string idPersona, string pNombre, string pAPaterno, string pAMaterno,
                char pGenero, string pDireccion, string pTelefono, string pCorreo,
    /*Usuario: */ string idUsuario,string nombreUsuario, string contrasenia)
        {
            DEmpleado datos = new DEmpleado();
            //Armamos persona
            Persona persona = new Persona();
            persona.IdPersona = Convert.ToInt32(idPersona);
            persona.Nombre = pNombre;
            persona.APaterno = pAPaterno;
            persona.AMaterno = pAMaterno;
            persona.Genero = pGenero;
            persona.Direcion = pDireccion;
            persona.Telefono = pTelefono;
            persona.Correo = pCorreo;

            //Armamos Empleado
            Empleado empleado = new Empleado();
            empleado.IdEmpleado = idEmpleado;
            empleado.Puesto = puesto;
            empleado.Estatus = 1;

            //Armamos usuario
            Usuario usuario = new Usuario();
            usuario.IdUsuario = Convert.ToInt32(idUsuario);
            usuario.NombreUsuario = nombreUsuario;
            usuario.Contrasenia = contrasenia;

            return datos.ActualizarEmpleado(empleado, persona, usuario);

        }

        public static string DesactivarEmpleado (string idEmpleado)
        {
            DEmpleado datos = new DEmpleado();
            return datos.DesactivarEmpleado(idEmpleado);
        }

        public static DataTable Buscar(string valor)
        {
            DEmpleado datos = new DEmpleado();
            return datos.BuscarEmpleado(valor);
        }

        public static int ObtenerPuesto(string text)
        {
            int puesto = 3;
            if (text.Equals("Administrador")) {
                puesto = 1;
            }
            if (text.Equals("Vendedor"))
            {
                puesto = 2;
            }
            if (text.Equals("Almacenista"))
            {
                puesto = 3;
            }
            return puesto;
        }

        public static char ObtenerGenero(string combo)
        {
            char genero = 'H';
            if (!string.IsNullOrEmpty(combo))
            {
                if (combo.Equals("Masculino"))
                {
                    genero = 'H';
                }
                if (combo.Equals("Femenino"))
                {
                    genero = 'M';
                }
                if (combo.Equals("Otro"))
                {
                    genero = 'O';
                }
            }
            else
            {
                genero = 'H';
            }
            return genero;
        }
    }
}
