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
    public class DMaterial
    {
        //Obtener todos los materiales con estatus 1
        public DataTable ListarMaterialesActivos() {
            SqlDataReader resultado; // lee una secuencia de filas en la tabla
            DataTable tabla = new DataTable();

            SqlConnection sqlCon = new SqlConnection(); // Con este objeto hacemos al conexion a la base de datos
            try
            {
                sqlCon = Conexion.getInstancia().CrearConexion(); //Utilizamos la variable tipo sql connection que obtenemos desde la calse conexion
                SqlCommand comando = new SqlCommand("materiales_listarActivos", sqlCon); // este es el comando que se va a ejecutar el la base de datos
                comando.CommandType = CommandType.StoredProcedure;
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

        public DataTable ListarMaterialesInactivos()
        {
            SqlDataReader resultado; // lee una secuencia de filas en la tabla
            DataTable tabla = new DataTable();

            SqlConnection sqlCon = new SqlConnection(); // Con este objeto hacemos al conexion a la base de datos
            try
            {
                sqlCon = Conexion.getInstancia().CrearConexion(); //Utilizamos la variable tipo sql connection que obtenemos desde la calse conexion
                SqlCommand comando = new SqlCommand("materiales_listarInactivos", sqlCon); // este es el comando que se va a ejecutar el la base de datos
                comando.CommandType = CommandType.StoredProcedure;
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

        //Buscar por cualquier campo de materiales
        public DataTable BuscarMaterial(string valor)
        {
            SqlDataReader resultado; // lee una secuencia de filas en la tabla
            DataTable tabla = new DataTable();

            SqlConnection sqlCon = new SqlConnection(); // Con este objeto hacemos al conexion a la base de datos
            try
            {
                sqlCon = Conexion.getInstancia().CrearConexion(); //Utilizamos la variable tipo sql connection que obtenemos desde la calse conexion
                SqlCommand comando = new SqlCommand("materiales_buscar", sqlCon); // este es el comando que se va a ejecutar el la base de datos
                comando.CommandType = CommandType.StoredProcedure;

                //Agregamos el parametro del procedure:
                comando.Parameters.Add("@value", SqlDbType.VarChar).Value = valor;
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

        public string InsertarMaterial(Material material)
        {
            string respuesta = "";
            SqlConnection sqlConnection = new SqlConnection();

            try
            {
                sqlConnection = Conexion.getInstancia().CrearConexion();
                SqlCommand command = new SqlCommand("materiales_insertar", sqlConnection);
                command.CommandType = CommandType.StoredProcedure;

                //Agregamos los parametros:
                command.Parameters.Add("@nombre", SqlDbType.VarChar).Value = material.Nombre;
                command.Parameters.Add("@descripcion", SqlDbType.VarChar).Value = material.Descripcion;
                command.Parameters.Add("@cantidad", SqlDbType.VarChar).Value = material.Cantidad;
                command.Parameters.Add("@precioCompra", SqlDbType.VarChar).Value = material.PrecioCompra;
                command.Parameters.Add("@idProvedor", SqlDbType.VarChar).Value = material.IdProvedor;


                //Abrimos la conexion y guardamos el resultado en respuesta

                sqlConnection.Open();

                if (command.ExecuteNonQuery() == 1) // el 1 respresenta un resultado exitoso
                {
                    //Esto quiere decir que se ingresó el provedor correctamente
                    respuesta = "OK";
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

        public string AcutalizarMaterial(Material material)
        {
            string respuesta = "";
            SqlConnection sqlConnection = new SqlConnection();

            try
            {
                sqlConnection = Conexion.getInstancia().CrearConexion();
                SqlCommand command = new SqlCommand("materiales_actualizar", sqlConnection);
                command.CommandType = CommandType.StoredProcedure;

                //Agregamos los parametros:
                command.Parameters.Add("@idMaterial", SqlDbType.Int).Value = material.IdMaterial;
                command.Parameters.Add("@nombreMaterial", SqlDbType.VarChar).Value = material.Nombre;
                command.Parameters.Add("@descripcion", SqlDbType.VarChar).Value = material.Descripcion;
                command.Parameters.Add("@cantidad", SqlDbType.Int).Value = material.Cantidad;
                command.Parameters.Add("@precioCompra", SqlDbType.Float).Value = material.PrecioCompra;
                command.Parameters.Add("@idProvedor", SqlDbType.VarChar).Value = material.IdProvedor;


                //Abrimos la conexion y guardamos el resultado en respuesta

                sqlConnection.Open();

                if (command.ExecuteNonQuery() == 1) // el 1 respresenta un resultado exitoso
                {
                    //Esto quiere decir que se ingresó el provedor correctamente
                    respuesta = "OK";
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

        public string ActivarMaterial(string idMaterial)
        {
            string respuesta = "";
            SqlConnection sqlConnection = new SqlConnection();

            try
            {
                sqlConnection = Conexion.getInstancia().CrearConexion();
                SqlCommand command = new SqlCommand("materiales_activar", sqlConnection);
                command.CommandType = CommandType.StoredProcedure;

                //Agregamos los parametros:
                command.Parameters.Add("@idMaterial", SqlDbType.Int).Value = Convert.ToInt32(idMaterial);


                //Abrimos la conexion y guardamos el resultado en respuesta

                sqlConnection.Open();

                if (command.ExecuteNonQuery() == 1) // el 1 respresenta un resultado exitoso
                {
                    //Esto quiere decir que se ingresó el provedor correctamente
                    respuesta = "OK";
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

        public string DesactivarMaterial(string idMaterial)
        {
            string respuesta = "";
            SqlConnection sqlConnection = new SqlConnection();

            try
            {
                sqlConnection = Conexion.getInstancia().CrearConexion();
                SqlCommand command = new SqlCommand("materiales_desactivar", sqlConnection);
                command.CommandType = CommandType.StoredProcedure;

                //Agregamos los parametros:
                command.Parameters.Add("@idMaterial", SqlDbType.Int).Value = Convert.ToInt32(idMaterial);


                //Abrimos la conexion y guardamos el resultado en respuesta

                sqlConnection.Open();

                if (command.ExecuteNonQuery() == 1) // el 1 respresenta un resultado exitoso
                {
                    //Esto quiere decir que se ingresó el provedor correctamente
                    respuesta = "OK";
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

        public DataTable LlenarComboNombre() {
            SqlDataReader resultado; // lee una secuencia de filas en la tabla
            DataTable tabla = new DataTable();

            SqlConnection sqlCon = new SqlConnection(); // Con este objeto hacemos al conexion a la base de datos
            try
            {
                sqlCon = Conexion.getInstancia().CrearConexion(); //Utilizamos la variable tipo sql connection que obtenemos desde la calse conexion
                SqlCommand comando = new SqlCommand("materiales_obtenerIdprovedores", sqlCon); // este es el comando que se va a ejecutar el la base de datos
                comando.CommandType = CommandType.StoredProcedure;
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


        public string ExisteMaterial(string valor)
        {
            string respuesta = "";
            SqlConnection sqlConnection = new SqlConnection();

            try
            {
                sqlConnection = Conexion.getInstancia().CrearConexion();
                SqlCommand command = new SqlCommand("material_existe", sqlConnection);
                command.CommandType = CommandType.StoredProcedure;

                //Agregamos los parametros:
                command.Parameters.Add("@valor", SqlDbType.VarChar).Value = valor;

                //Agregamos un parametro de salida
                SqlParameter parametroExiste = new SqlParameter();
                parametroExiste.ParameterName = "@existe";
                parametroExiste.SqlDbType = SqlDbType.Int;
                parametroExiste.Direction = ParameterDirection.Output;

                command.Parameters.Add(parametroExiste);
                //Abrimos la conexion y guardamos el resultado en respuesta
                sqlConnection.Open();

                command.ExecuteNonQuery();
                respuesta = Convert.ToString(parametroExiste.Value);

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
    }
}
