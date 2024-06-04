using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaNegocio;
using CapaEntidad; 

namespace CreacionFormularios.Forms.Creacion
{
    public partial class FrmEmpleados : Form
    {
        public FrmEmpleados()
        {
            InitializeComponent();
        }

        private void CrearEmpleadoBtn_Click(object sender, EventArgs e)
        {
            string apellido = TxtApellido.Text;
            string nombre = TxtNombre.Text;
            string dni = TxtDni.Text;
            string telefono = TxtTelefono.Text;
            string horario = TxtHorario.Text;

            Empleados empleado = new Empleados()
            {
                Apellido = apellido,
                Nombre = nombre,
                Dni = dni,
                Telefono = telefono,
                Horario = horario
            };

            CN_Empleados cnEmpleados = new CN_Empleados();

            Console.WriteLine(empleado);
            cnEmpleados.CrearEmpleado(empleado);
            this.Close();
        }
    }
}
