using Datos;
using Modelo;
using Sistema.Datos;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Controlador
{
    public class ControladorCliente
    {
        public static DataTable ListarClientesActivos()
        {
            DClientes datos = new DClientes();
            return datos.ListarClientesActivos();
        }

        public static string InsertarCliente(/*Persona:*/string pNombre, string pAPaterno, string pAMaterno,
            char pGenero, string pDireccion, string pTelefono, string pCorreo,
            /*Usuario: */ string nombreUsuario, string contrasenia)
        {
            DClientes datos = new DClientes();
            //Armamos persona
            Persona persona = new Persona();
            persona.Nombre = pNombre;
            persona.APaterno = pAPaterno;
            persona.AMaterno = pAMaterno;
            persona.Genero = pGenero;
            persona.Direcion = pDireccion;
            persona.Telefono = pTelefono;
            persona.Correo = pCorreo;

            //Armamos Cliente
            Cliente cliente = new Cliente();
            cliente.Estatus = 1;

            //Armamos usuario
            Usuario usuario = new Usuario();
            usuario.NombreUsuario = nombreUsuario;
            usuario.Contrasenia = contrasenia;

            return datos.InsertarCliente(cliente, persona, usuario);

        }

        public static string ActualizarCliente
            (/*Persona:*/string idPersona, string pNombre, string pAPaterno, string pAMaterno, char pGenero, string pDireccion, string pTelefono, string pCorreo,
            /*Cliente: */ string idCliente,
            /*Usuario: */ string idUsuario, string nombreUsuario, string contrasenia)
        {
            DClientes datos = new DClientes();
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

            //Armamos Cliente
            Cliente cliente = new Cliente();
            cliente.IdCliente = idCliente;
            cliente.Estatus = 1;

            //Armamos usuario
            Usuario usuario = new Usuario();
            usuario.IdUsuario = Convert.ToInt32(idUsuario);
            usuario.NombreUsuario = nombreUsuario;
            usuario.Contrasenia = contrasenia;

            return datos.ActualizarCliente(cliente, persona, usuario);

        }

        public static string DesactivarCliente(string idCliente)
        {
            DClientes datos = new DClientes();
            return datos.DesactivarCliente(idCliente);
        }

        public static DataTable Buscar(string valor)
        {
            DClientes datos = new DClientes();
            return datos.BuscarCliente(valor);
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
