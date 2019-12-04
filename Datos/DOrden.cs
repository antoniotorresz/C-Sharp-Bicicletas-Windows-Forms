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
    public class DOrden
    {

        public DataTable ListMaterialCompra(string id)
        {
            SqlDataReader resultado; // lee una secuencia de filas en la tabla
            DataTable tabla = new DataTable();

            SqlConnection sqlCon = new SqlConnection(); // Con este objeto hacemos al conexion a la base de datos
            try
            {
                sqlCon = Conexion.getInstancia().CrearConexion(); //Utilizamos la variable tipo sql connection que obtenemos desde la calse conexion
                SqlCommand comando = new SqlCommand("listaCompraMaterial", sqlCon); // este es el comando que se va a ejecutar el la base de datos
                comando.CommandType = CommandType.StoredProcedure;
                comando.Parameters.Add("@id", SqlDbType.Int).Value = Convert.ToInt32(id);
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
        public DataTable ListMateriales(string provedor)
        {
            SqlDataReader resultado; // lee una secuencia de filas en la tabla
            DataTable tabla = new DataTable();

            SqlConnection sqlCon = new SqlConnection(); // Con este objeto hacemos al conexion a la base de datos
            try
            {
                string sql = "select * from Materiales where idProvedor = '" + provedor + "'";
                sqlCon = Conexion.getInstancia().CrearConexion(); //Utilizamos la variable tipo sql connection que obtenemos desde la calse conexion
                SqlCommand comando = new SqlCommand(sql, sqlCon);
                comando.CommandTimeout = 15;
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

        public DataTable ComboProvedor()
        {
            SqlDataReader resultado; // lee una secuencia de filas en la tabla
            DataTable tabla = new DataTable();

            SqlConnection sqlCon = new SqlConnection(); // Con este objeto hacemos al conexion a la base de datos
            try
            {
                string sql = "select * from provedores";
                sqlCon = Conexion.getInstancia().CrearConexion(); //Utilizamos la variable tipo sql connection que obtenemos desde la calse conexion
                SqlCommand comando = new SqlCommand(sql, sqlCon);
                comando.CommandTimeout = 15;
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

        public string insertarOrden(DateTime fecha, string provedor)
        {
            string respuesta = "";
            SqlConnection sqlConnection = new SqlConnection();

            try
            {
                sqlConnection = Conexion.getInstancia().CrearConexion();
                SqlCommand command = new SqlCommand("insertOrdenCompra", sqlConnection);
                command.CommandType = CommandType.StoredProcedure;

                //Agregamos los parametros:
                command.Parameters.Add("@var_fecha", SqlDbType.DateTime).Value = fecha;
                command.Parameters.Add("@var_Provedor", SqlDbType.VarChar).Value = provedor;

                SqlParameter idParameter = new SqlParameter("@id_Orden", SqlDbType.Int);
                idParameter.Direction = ParameterDirection.Output;
                command.Parameters.Add(idParameter);

                SqlParameter idParameter2 = new SqlParameter("@var_numFactura", SqlDbType.VarChar, 50);
                idParameter2.Direction = ParameterDirection.Output;
                command.Parameters.Add(idParameter2);
                //Abrimos la conexion y guardamos el resultado en respuesta

                sqlConnection.Open();
                if (command.ExecuteNonQuery() == 1) // el 1 respresenta un resultado exitoso
                {
                    //Esto quiere decir que se ingresó el provedor correctamente
                    respuesta = command.Parameters["@id_Orden"].Value + "," + command.Parameters["@var_numFactura"].Value;
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

        public string ingresarCompraMaterial(string idCompra, string idMaterial, string cantidad)
        {
            string respuesta = "";
            SqlConnection sqlConnection = new SqlConnection();

            try
            {
                sqlConnection = Conexion.getInstancia().CrearConexion();
                SqlCommand command = new SqlCommand("insertCompraMateriales", sqlConnection);
                command.CommandType = CommandType.StoredProcedure;

                //Agregamos los parametros:
                command.Parameters.Add("@var_idCompra", SqlDbType.Int).Value = Convert.ToInt32(idCompra);
                command.Parameters.Add("@var_Material", SqlDbType.Int).Value = Convert.ToInt32(idMaterial);
                command.Parameters.Add("@cantidad", SqlDbType.Int).Value = Convert.ToInt32(cantidad);

                //Abrimos la conexion y guardamos el resultado en respuesta

                sqlConnection.Open();
                if (command.ExecuteNonQuery() == 1) // el 1 respresenta un resultado exitoso
                {
                    //Esto quiere decir que se ingresó el provedor correctamente
                    respuesta = "ok";
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

        public string ActualizarPagado(string idCompra, string precioPagar)
        {
            string respuesta = "";
            SqlConnection sqlConnection = new SqlConnection();

            try
            {
                sqlConnection = Conexion.getInstancia().CrearConexion();
                SqlCommand command = new SqlCommand("actualizarOrdenC_pagado", sqlConnection);
                command.CommandType = CommandType.StoredProcedure;

                //Agregamos los parametros:
                command.Parameters.Add("@idCompra", SqlDbType.Int).Value = Convert.ToInt32(idCompra);
                command.Parameters.Add("@precioPagar", SqlDbType.Int).Value = float.Parse(precioPagar);
                
                //Abrimos la conexion y guardamos el resultado en respuesta

                sqlConnection.Open();
                if (command.ExecuteNonQuery() == 1) // el 1 respresenta un resultado exitoso
                {
                    //Esto quiere decir que se ingresó el provedor correctamente
                    respuesta = "ok";
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

        public string CancelarOrden(string idCompra)
        {
            string respuesta = "";
            SqlConnection sqlConnection = new SqlConnection();

            try
            {
                sqlConnection = Conexion.getInstancia().CrearConexion();
                SqlCommand command = new SqlCommand("cancelarOrden", sqlConnection);
                command.CommandType = CommandType.StoredProcedure;

                //Agregamos los parametros:
                command.Parameters.Add("@idCompra", SqlDbType.Int).Value = Convert.ToInt32(idCompra);
                //Abrimos la conexion y guardamos el resultado en respuesta

                sqlConnection.Open();
                if (command.ExecuteNonQuery() == 1) // el 1 respresenta un resultado exitoso
                {
                    //Esto quiere decir que se ingresó el provedor correctamente
                    respuesta = "ok";
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
    }
}
