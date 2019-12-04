using Modelo;
using Sistema.Datos;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos
{
    public class DClientes
    {
        public DataTable ListarClientesActivos()
        {
            SqlDataReader resultado; // lee una secuencia de filas en la tabla
            DataTable tabla = new DataTable();

            SqlConnection sqlCon = new SqlConnection(); // Con este objeto hacemos al conexion a la base de datos
            try
            {
                sqlCon = Conexion.getInstancia().CrearConexion(); //Utilizamos la variable tipo sql connection que obtenemos desde la calse conexion
                SqlCommand comando = new SqlCommand("select * from vistaClientes", sqlCon); // este es el comando que se va a ejecutar el la base de datos
                comando.CommandType = CommandType.Text;
                sqlCon.Open();
                //Se ejecuta el comando
                resultado = comando.ExecuteReader();
                //se carga en el objeto tabla
                tabla.Load(resultado);
                return tabla;
            }
            catch (Exception e)
            {
                throw e;
            }
            finally
            { // Este codigo se va a ejecutar aunque haya alguna excepcion. **SIEMPRE SE CERRARÁ LA CONEXIÓN**

                if (sqlCon.State == ConnectionState.Open) sqlCon.Close();
            }
        }

        public string InsertarCliente(Cliente cliente, Persona persona, Usuario usuario)
        {
            string respuesta = "";
            SqlConnection sqlConnection = new SqlConnection();

            try
            {
                sqlConnection = Conexion.getInstancia().CrearConexion();
                SqlCommand command = new SqlCommand("insertCliente", sqlConnection);
                command.CommandType = CommandType.StoredProcedure;

                //Agregamos los parametros:

                //TODO: Parametros de persona
                command.Parameters.Add("@var_nombre", SqlDbType.VarChar).Value = persona.Nombre;
                command.Parameters.Add("@var_aPaterno", SqlDbType.VarChar).Value = persona.APaterno;
                command.Parameters.Add("@var_aMaterno", SqlDbType.VarChar).Value = persona.AMaterno;
                command.Parameters.Add("@var_genero", SqlDbType.Char).Value = persona.Genero;
                command.Parameters.Add("@var_direccion", SqlDbType.VarChar).Value = persona.Direcion;
                command.Parameters.Add("@var_telefono", SqlDbType.VarChar).Value = persona.Telefono;
                command.Parameters.Add("@var_correo", SqlDbType.VarChar).Value = persona.Correo;

                //Parametros de Cliente:
                command.Parameters.Add("@var_estatus", SqlDbType.Int).Value = 1;

                //Parametros de Usuario
                command.Parameters.Add("@var_Usuario", SqlDbType.VarChar).Value = usuario.NombreUsuario;
                command.Parameters.Add("@var_contrasenia", SqlDbType.VarChar).Value = usuario.Contrasenia;


                //command.Parameters.Add("@var_idProducto", SqlDbType.Int).Value = producto.IdProducto;

                SqlParameter idPersonaParameter = new SqlParameter("@var_idPersona", SqlDbType.Int);
                idPersonaParameter.Direction = ParameterDirection.Output;
                command.Parameters.Add(idPersonaParameter);

                SqlParameter idUsuarioParameter = new SqlParameter("@var_idUsuario", SqlDbType.Int);
                idUsuarioParameter.Direction = ParameterDirection.Output;
                command.Parameters.Add(idUsuarioParameter);

                SqlParameter idClienteParameter = new SqlParameter("@var_idCliente", SqlDbType.VarChar, 50);
                idClienteParameter.Direction = ParameterDirection.Output;
                command.Parameters.Add(idClienteParameter);

                //Abrimos la conexion y guardamos el resultado en respuesta

                sqlConnection.Open();
                int rowsAffected = command.ExecuteNonQuery(); //Marca 0
                if (rowsAffected == 1) // el 1 respresenta un resultado exitoso
                {
                    //respuesta = "Cliente registrado.";
                }
                else
                {
                    //respuesta = "No se pudo completar la solicitud... " + rowsAffected;
                }
                
            }
            catch (Exception e)
            {
                respuesta = e.ToString();
            }
            finally
            {
                if (sqlConnection.State == ConnectionState.Open) sqlConnection.Close();
            }

            return respuesta;
        }

        public string ActualizarCliente(Cliente cliente, Persona persona, Usuario usuario)
        {
            string respuesta = "";
            SqlConnection sqlConnection = new SqlConnection();

            try
            {
                sqlConnection = Conexion.getInstancia().CrearConexion();
                SqlCommand command = new SqlCommand("updateClientes", sqlConnection);
                command.CommandType = CommandType.StoredProcedure;

                //Agregamos los parametros:

                //TODO: Parametros de persona
                command.Parameters.Add("@var_nombre", SqlDbType.VarChar).Value = persona.Nombre;
                command.Parameters.Add("@var_aPaterno", SqlDbType.VarChar).Value = persona.APaterno;
                command.Parameters.Add("@var_aMaterno", SqlDbType.VarChar).Value = persona.AMaterno;
                command.Parameters.Add("@var_genero", SqlDbType.Char).Value = persona.Genero;
                command.Parameters.Add("@var_direccion", SqlDbType.VarChar).Value = persona.Direcion;
                command.Parameters.Add("@var_telefono", SqlDbType.VarChar).Value = persona.Telefono;
                command.Parameters.Add("@var_correo", SqlDbType.VarChar).Value = persona.Correo;

                //Parametros de Cliente:
                command.Parameters.Add("@var_estatus", SqlDbType.Int).Value = 1;

                //Parametros de Usuario
                command.Parameters.Add("@var_Usuario", SqlDbType.VarChar).Value = usuario.NombreUsuario;
                command.Parameters.Add("@var_contrasenia", SqlDbType.VarChar).Value = usuario.Contrasenia;
                //IDs

                command.Parameters.Add("@var_idPersona", SqlDbType.Int).Value = persona.IdPersona;
                command.Parameters.Add("@var_idUsuario", SqlDbType.Int).Value = usuario.IdUsuario;
                command.Parameters.Add("@var_idCliente", SqlDbType.VarChar).Value = cliente.IdCliente;

                //Abrimos la conexion y guardamos el resultado en respuesta

                sqlConnection.Open();

                if (command.ExecuteNonQuery() == 1) // el 1 respresenta un resultado exitoso
                {
                    //Esto quiere decir que se ingresó el provedor correctamente
                    //respuesta = "Cliente actualizado: ";
                }
                else
                {
                    //respuesta = "No se pudo completar la solicitud...";
                }
                
            }
            catch (Exception e)
            {
                respuesta = e.ToString();
            }
            finally
            {
                if (sqlConnection.State == ConnectionState.Open) sqlConnection.Close();
            }

            return respuesta;
        }

        public string DesactivarCliente(string idCliente)
        {
            string respuesta = "";
            SqlConnection sqlConnection = new SqlConnection();

            try
            {
                sqlConnection = Conexion.getInstancia().CrearConexion();
                SqlCommand command = new SqlCommand("DeleteCliente", sqlConnection);
                command.CommandType = CommandType.StoredProcedure;

                //Agregamos los parametros:
                command.Parameters.Add("@var_estatus", SqlDbType.Int).Value = 0;
                command.Parameters.Add("@var_idCliente", SqlDbType.VarChar).Value = idCliente;


                //Abrimos la conexion y guardamos el resultado en respuesta

                sqlConnection.Open();

                if (command.ExecuteNonQuery() == 1) // el 1 respresenta un resultado exitoso
                {
                    //Esto quiere decir que se ingresó el provedor correctamente
                    respuesta = "Cliente eliminado: " + idCliente;
                }
                else
                {
                    respuesta = "No se pudo completar la solicitud...";
                }


            }
            catch (Exception e)
            {
                respuesta = e.ToString();
            }
            finally
            {
                if (sqlConnection.State == ConnectionState.Open) sqlConnection.Close();
            }

            return respuesta;
        }

        public DataTable BuscarCliente(string valor)
        {
            SqlDataReader resultado; // lee una secuencia de filas en la tabla
            DataTable tabla = new DataTable();

            SqlConnection sqlCon = new SqlConnection(); // Con este objeto hacemos al conexion a la base de datos
            try
            {
                sqlCon = Conexion.getInstancia().CrearConexion(); //Utilizamos la variable tipo sql connection que obtenemos desde la calse conexion
                SqlCommand comando = new SqlCommand("buscarCliente", sqlCon); // este es el comando que se va a ejecutar el la base de datos
                comando.CommandType = CommandType.StoredProcedure;

                //Agregamos el parametro del procedure:
                comando.Parameters.Add("@dato", SqlDbType.VarChar).Value = valor;
                sqlCon.Open();
                //Se ejecuta el comando
                resultado = comando.ExecuteReader();
                //se carga en el objeto tabla
                tabla.Load(resultado);
                return tabla;
            }
            catch (Exception e)
            {
                throw e;
            }
            finally
            { // Este codigo se va a ejecutar aunque haya alguna excepcion. **SIEMPRE SE CERRARÁ LA CONEXIÓN**

                if (sqlCon.State == ConnectionState.Open) sqlCon.Close();
            }
        }
    }
}
