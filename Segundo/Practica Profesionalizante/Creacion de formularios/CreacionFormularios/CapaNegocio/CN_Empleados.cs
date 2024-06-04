using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaEntidad;
using CapaDatos;
using System.Windows.Forms;

namespace CapaNegocio
{
    public class CN_Empleados
    {
        private CD_Empleados objcd_empleados = new CD_Empleados(); 

        public List<Empleados> Listar()
        {
            try
            {
               return objcd_empleados.Listar();
            } catch (Exception ex)
            {
                Console.WriteLine("Error al obtener la lista de empleados: " + ex.Message);
                MessageBox.Show("Error al obtener la lista de empleados: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return new List<Empleados>();

            }
        }
    }
}
