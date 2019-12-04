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
    public class DUsuario
    {
        public DataTable Ingresar(string usuario, string contrasenia)
        {
            SqlDataReader resultado;
            DataTable tabla = new DataTable();
            SqlConnection sqlConnection = new SqlConnection();

            try
            {
                sqlConnection = Conexion.getInstancia().CrearConexion();
                SqlCommand comando = new SqlCommand("usuario_login", sqlConnection);
                comando.CommandType = CommandType.StoredProcedure;
                comando.Parameters.Add("@username", SqlDbType.VarChar).Value = usuario;
                comando.Parameters.Add("@password", SqlDbType.VarChar).Value = contrasenia;

                sqlConnection.Open();
                resultado = comando.ExecuteReader();
                tabla.Load(resultado);
                return tabla;
            }
            catch (Exception ex)
            {
                return null;
                throw ex;
            }
            finally
            {
                if (sqlConnection.State == ConnectionState.Open) sqlConnection.Close();
            }
        }

        public int validarPuesto(int idusuario)
        {
            SqlDataReader resultado; // lee una secuencia de filas en la tabla
            int tabla;

            SqlConnection sqlCon = new SqlConnection(); // Con este objeto hacemos al conexion a la base de datos
            try
            {
                sqlCon = Conexion.getInstancia().CrearConexion(); //Utilizamos la variable tipo sql connection que obtenemos desde la calse conexion
                SqlCommand comando = new SqlCommand("empleado_puesto", sqlCon); // este es el comando que se va a ejecutar el la base de datos
                comando.CommandType = CommandType.StoredProcedure;

                //Agregamos el parametro del procedure:
                comando.Parameters.Add("@idUsuario", SqlDbType.Int).Value = idusuario;

                //salida
                SqlParameter puesto = new SqlParameter(
                    "@var_puesto",
                     SqlDbType.Int
                    );
                
                puesto.Direction = ParameterDirection.Output;
                comando.Parameters.Add(puesto);
                sqlCon.Open();

                //Se ejecuta el comando
                resultado = comando.ExecuteReader();
                //se carga en el objeto tabla
                tabla = Convert.ToInt32(comando.Parameters["@var_puesto"].Value);
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
