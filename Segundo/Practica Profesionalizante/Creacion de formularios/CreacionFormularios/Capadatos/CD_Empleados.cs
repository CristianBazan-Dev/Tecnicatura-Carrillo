using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaEntidad;
using System.Data.SqlClient;
using System.Data;

namespace CapaDatos
{
    public class CD_Empleados
    {
        public List<Empleados> Listar()
        {
            List<Empleados> lista = new List<Empleados>();

            using (SqlConnection conexion = new SqlConnection(Conexion.cadena))
            {
                try
                {
                    string query = "SELECT Id_empleado, Nombre, Apellido, Direccion, Localidad, Provincia, FechaIngresoSistema, Activo FROM EMPLEADOS";
                    SqlCommand cmd = new SqlCommand(query, conexion);

                    cmd.CommandType = CommandType.Text;

                    conexion.Open();


                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {

                        while (reader.Read())
                        {
                            lista.Add(new Empleados()
                            {
                                IdEmpleado = Convert.ToInt32(reader["Id_empleado"]),
                                Nombre = reader["Nombre"].ToString(),
                                Apellido = reader["Apellido"].ToString(),
                                Direccion = reader["Direccion"].ToString(),
                                Localidad = reader["Localidad"].ToString(),
                                Provincia = reader["Provincia"].ToString(),
                                Activo = Convert.ToInt32(reader["Activo"])
                            });
                        }
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error al obtener la lista de empleados desde la capa de datos: " + ex.Message);
                    lista = new List<Empleados>();
                }
                finally
                {
                    conexion.Close();
                }
            }
            return lista; 
        }

    }
}
