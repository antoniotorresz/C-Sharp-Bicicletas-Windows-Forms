using System;
using Modelo;
using System.Data.SqlClient;
using Sistema.Datos;
using System.Data;

namespace Datos
{
    public class DVentas
    {
        public DataTable ListarVentas()
        {
            SqlDataReader resultado; // lee una secuencia de filas en la tabla
            DataTable tabla = new DataTable();

            SqlConnection sqlCon = new SqlConnection(); // Con este objeto hacemos al conexion a la base de datos
            try
            {
                sqlCon = Conexion.getInstancia().CrearConexion(); //Utilizamos la variable tipo sql connection que obtenemos desde la calse conexion
                SqlCommand comando = new SqlCommand();
                comando.CommandText = "SELECT * FROM Ventas";
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

        public string deleteProductoventa(string idVenta,string idProducto,string cant)
        {
            string respuesta = "";
            SqlConnection sqlConnection = new SqlConnection();

            try
            {
                sqlConnection = Conexion.getInstancia().CrearConexion();
                SqlCommand command = new SqlCommand("DeleteProductosVentas", sqlConnection);
                command.CommandType = CommandType.StoredProcedure;

                //Agregamos los parametros:
                command.Parameters.Add("@var_idVenta", SqlDbType.Int).Value = Convert.ToInt32(idVenta);
                command.Parameters.Add("@var_idProducto", SqlDbType.Int).Value = Convert.ToInt32(idProducto);
                command.Parameters.Add("@var_cantidad", SqlDbType.Int).Value = Convert.ToInt32(cant);

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

        public DataTable ListarVentasProductos(string id)
        {
            SqlDataReader resultado; // lee una secuencia de filas en la tabla
            DataTable tabla = new DataTable();

            SqlConnection sqlCon = new SqlConnection(); // Con este objeto hacemos al conexion a la base de datos
            try
            {
                sqlCon = Conexion.getInstancia().CrearConexion(); //Utilizamos la variable tipo sql connection que obtenemos desde la calse conexion
                SqlCommand comando = new SqlCommand("productosVentaVista", sqlCon); // este es el comando que se va a ejecutar el la base de datos
                comando.CommandType = CommandType.StoredProcedure;
                comando.Parameters.Add("@var_id", SqlDbType.Int).Value = Convert.ToInt32(id);
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

        public string actualizarVenta(string id,string total)
        {
            string respuesta = "";
            SqlConnection sqlConnection = new SqlConnection();

            try
            {
                sqlConnection = Conexion.getInstancia().CrearConexion();
                SqlCommand command = new SqlCommand("updateVenta", sqlConnection);
                command.CommandType = CommandType.StoredProcedure;

                //Agregamos los parametros:
                command.Parameters.Add("@var_id", SqlDbType.Int).Value =Convert.ToInt32(id) ;
                command.Parameters.Add("@var_total", SqlDbType.Float).Value = float.Parse(total);
                

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
        public string insertarVenta(Ventas ventas)
        {
            string respuesta = "";
            SqlConnection sqlConnection = new SqlConnection();

            try
            {
                sqlConnection = Conexion.getInstancia().CrearConexion();
                SqlCommand command = new SqlCommand("insertVenta", sqlConnection);
                command.CommandType = CommandType.StoredProcedure;

                //Agregamos los parametros:
                command.Parameters.Add("@var_fecha", SqlDbType.DateTime).Value = ventas.FechaVenta;
                command.Parameters.Add("@var_idEmpleado", SqlDbType.VarChar).Value = ventas.idEmpleado;
                
                SqlParameter idParameter = new SqlParameter("@var_idVenta", SqlDbType.Int);
                idParameter.Direction = ParameterDirection.Output;
                command.Parameters.Add(idParameter);

                //Abrimos la conexion y guardamos el resultado en respuesta

                sqlConnection.Open();

                if (command.ExecuteNonQuery() == 1) // el 1 respresenta un resultado exitoso
                {
                    //Esto quiere decir que se ingresó el provedor correctamente
                    respuesta = ""+ command.Parameters["@var_idVenta"].Value;
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
        public string ingresarVentaProducto(string id, string idProducto,string cantidad)
        {
            string respuesta = "";
            SqlConnection sqlConnection = new SqlConnection();

            try
            {
                sqlConnection = Conexion.getInstancia().CrearConexion();
                SqlCommand command = new SqlCommand("insertProductosVentas", sqlConnection);
                command.CommandType = CommandType.StoredProcedure;

                //Agregamos los parametros:
                command.Parameters.Add("@var_idVenta", SqlDbType.Int).Value = Convert.ToInt32(id);
                command.Parameters.Add("@var_idProducto", SqlDbType.Int).Value = Convert.ToInt32(idProducto);
                command.Parameters.Add("@var_cantidad", SqlDbType.Int).Value = Convert.ToInt32(cantidad);

                SqlParameter idParameter = new SqlParameter("@res", SqlDbType.Int);
                idParameter.Direction = ParameterDirection.Output;
                command.Parameters.Add(idParameter);    

                //Abrimos la conexion y guardamos el resultado en respuesta

                sqlConnection.Open();
                if (command.ExecuteNonQuery() == 1) // el 1 respresenta un resultado exitoso
                {
                    //Esto quiere decir que se ingresó el provedor correctamente
                    respuesta = "" + command.Parameters["@res"].Value;
                }
                else
                {
                    respuesta = "" + command.Parameters["@res"].Value;
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


        public DataTable BusquedaEmpleado(string valor)
        {
            SqlDataReader resultado; // lee una secuencia de filas en la tabla
            DataTable tabla = new DataTable();

            SqlConnection sqlCon = new SqlConnection(); // Con este objeto hacemos al conexion a la base de datos
            try
            {
                sqlCon = Conexion.getInstancia().CrearConexion(); //Utilizamos la variable tipo sql connection que obtenemos desde la calse conexion
                SqlCommand comando = new SqlCommand("buscarEmpleadoNumero", sqlCon); // este es el comando que se va a ejecutar el la base de datos
                comando.CommandType = CommandType.StoredProcedure;
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

        public DataTable LlenarCombo()
        {
            SqlDataReader resultado; // lee una secuencia de filas en la tabla
            DataTable tabla = new DataTable();

            SqlConnection sqlCon = new SqlConnection(); // Con este objeto hacemos al conexion a la base de datos
            try
            {
                sqlCon = Conexion.getInstancia().CrearConexion(); //Utilizamos la variable tipo sql connection que obtenemos desde la calse conexion
                SqlCommand comando = new SqlCommand("select * from comboIdEmp", sqlCon); // este es el comando que se va a ejecutar el la base de datos
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
    }
}
