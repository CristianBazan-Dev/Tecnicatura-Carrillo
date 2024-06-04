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
                    string query = "SELECT IdEmpleado, Nombre, Apellido, Dni, Telefono, Horario FROM EMPLEADOS";
                    SqlCommand cmd = new SqlCommand(query, conexion);

                    cmd.CommandType = CommandType.Text;

                    conexion.Open();

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            lista.Add(new Empleados()
                            {
                                IdEmpleado = Convert.ToInt32(reader["IdEmpleado"]),
                                Nombre = reader["Nombre"].ToString(),
                                Apellido = reader["Apellido"].ToString(),
                                Dni = reader["Dni"].ToString(),
                                Telefono = reader["Telefono"].ToString(),
                                Horario = reader["Horario"].ToString(),
                            });
                        }
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error al obtener la lista de empleados desde la capa de datos: " + (ex.Message).ToString());
                    lista = new List<Empleados>();
                }
                finally
                {
                    conexion.Close();
                }
            }
            return lista; 
        }
        public void CrearEmpleado(Empleados Empleado)
        {
            using (SqlConnection conexion = new SqlConnection(Conexion.cadena))
            {
                try
                {
                    string query = "INSERT INTO EMPLEADOS(Apellido, Nombre, Dni, Telefono, Horario) VALUES (@Apellido, @Nombre, @Dni, @Telefono, @Horario)";
                    SqlCommand command = new SqlCommand(query, conexion);

                    command.Parameters.AddWithValue("@Apellido", Empleado.Apellido);
                    command.Parameters.AddWithValue("@Nombre", Empleado.Nombre);
                    command.Parameters.AddWithValue("@Dni", Empleado.Dni);
                    command.Parameters.AddWithValue("@Telefono", Empleado.Telefono);
                    command.Parameters.AddWithValue("@Horario", Empleado.Horario);

                    conexion.Open();
                    command.ExecuteNonQuery(); 
                    
                } catch (Exception ex)
                {
                    Console.WriteLine("Error al crear empleado desde la capa de datos: " + (ex.Message).ToString());
                }
                finally
                {
                    conexion.Close();
                }
            }
        }
    }
}
