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
    public class DEmpleado
    {
        public DataTable ListarEmpleadosActivos()
        {
            SqlDataReader resultado; // lee una secuencia de filas en la tabla
            DataTable tabla = new DataTable();

            SqlConnection sqlCon = new SqlConnection(); // Con este objeto hacemos al conexion a la base de datos
            try
            {
                sqlCon = Conexion.getInstancia().CrearConexion(); //Utilizamos la variable tipo sql connection que obtenemos desde la calse conexion
                SqlCommand comando = new SqlCommand("select * from vistaEmpleados", sqlCon); // este es el comando que se va a ejecutar el la base de datos
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

        public string InsertarEmpleado(Empleado empleado, Persona persona, Usuario usuario)
        {
            string respuesta = "";
            SqlConnection sqlConnection = new SqlConnection();

            try
            {
                sqlConnection = Conexion.getInstancia().CrearConexion();
                SqlCommand command = new SqlCommand("insertEmpleado", sqlConnection);
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

                //Parametros de Empleado:
                command.Parameters.Add("@var_puesto", SqlDbType.VarChar).Value = empleado.Puesto;
                command.Parameters.Add("@var_estatus", SqlDbType.Int).Value = 1;

                // 1 administrador o gerente, 2 ventas, 3 Almacenista
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

                SqlParameter idEmpleado = new SqlParameter("@var_idEmpleado", SqlDbType.VarChar, 50);
                idEmpleado.Direction = ParameterDirection.Output;
                command.Parameters.Add(idEmpleado);

                //Abrimos la conexion y guardamos el resultado en respuesta

                sqlConnection.Open();
                int rowsAffected = command.ExecuteNonQuery(); //Marca 0
                if (rowsAffected == 1) // el 1 respresenta un resultado exitoso
                {
                    respuesta = "Empleado registrado.";
                }
                else
                {
                    respuesta = "Empleado registrado.";
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

        public string ActualizarEmpleado(Empleado empleado, Persona persona, Usuario usuario)
        {
            string respuesta = "";
            SqlConnection sqlConnection = new SqlConnection();

            try
            {
                sqlConnection = Conexion.getInstancia().CrearConexion();
                SqlCommand command = new SqlCommand("updateEmpleado", sqlConnection);
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

                //Parametros de Empleado:
                command.Parameters.Add("@var_puesto", SqlDbType.VarChar).Value = empleado.Puesto;
                command.Parameters.Add("@var_estatus", SqlDbType.Int).Value = 1;

                // 1 administrador o gerente, 2 ventas, 3 Almacenista

                //Parametros de Usuario
                command.Parameters.Add("@var_Usuario", SqlDbType.VarChar).Value = usuario.NombreUsuario;
                command.Parameters.Add("@var_contrasenia", SqlDbType.VarChar).Value = usuario.Contrasenia;
                command.Parameters.Add("@var_rol", SqlDbType.VarChar).Value = "Empleado";


                //IDs
                command.Parameters.Add("@var_idPersona", SqlDbType.Int).Value = persona.IdPersona;
                command.Parameters.Add("@var_idUsuario", SqlDbType.Int).Value = usuario.IdUsuario;
                command.Parameters.Add("@var_idEmpleado", SqlDbType.VarChar).Value = empleado.IdEmpleado;


                //Abrimos la conexion y guardamos el resultado en respuesta

                sqlConnection.Open();
                
                if (command.ExecuteNonQuery() == 0) // el 1 respresenta un resultado exitoso
                {
                    respuesta = "Empleado actualizado: " + empleado.IdEmpleado;
                }
                else
                {
                    respuesta = "Empleado actualizado";
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

        public string DesactivarEmpleado(string idEmpleado)
        {
            string respuesta = "";
            SqlConnection sqlConnection = new SqlConnection();

            try
            {
                sqlConnection = Conexion.getInstancia().CrearConexion();
                SqlCommand command = new SqlCommand("DeleteEmpleado", sqlConnection);
                command.CommandType = CommandType.StoredProcedure;

                //Agregamos los parametros:
                command.Parameters.Add("@var_estatus", SqlDbType.Int).Value = 0;
                command.Parameters.Add("@var_idEmpleado", SqlDbType.VarChar).Value = idEmpleado;


                //Abrimos la conexion y guardamos el resultado en respuesta

                sqlConnection.Open();

                if (command.ExecuteNonQuery() == 1) // el 1 respresenta un resultado exitoso
                {
                    //Esto quiere decir que se ingresó el provedor correctamente
                    respuesta = "Empleado eliminado: " + idEmpleado;
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

        public DataTable BuscarEmpleado(string valor)
        {
            SqlDataReader resultado; // lee una secuencia de filas en la tabla
            DataTable tabla = new DataTable();

            SqlConnection sqlCon = new SqlConnection(); // Con este objeto hacemos al conexion a la base de datos
            try
            {
                sqlCon = Conexion.getInstancia().CrearConexion(); //Utilizamos la variable tipo sql connection que obtenemos desde la calse conexion
                SqlCommand comando = new SqlCommand("buscarEmpleado", sqlCon); // este es el comando que se va a ejecutar el la base de datos
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
