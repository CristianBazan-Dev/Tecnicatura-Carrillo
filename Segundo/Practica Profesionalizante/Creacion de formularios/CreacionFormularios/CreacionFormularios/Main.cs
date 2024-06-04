using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CreacionFormularios.Forms;
using System.Configuration;
using CapaNegocio;
using CapaEntidad;
using System.Windows.Interop;
using CreacionFormularios.Forms.Creacion;

namespace CreacionFormularios
{
    
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }


        private void BtnProfesors_Click(object sender, EventArgs e)
        {
            ProfesoresForm ProfesorsForm = new ProfesoresForm();
            ProfesorsForm.Show();
        }

        private void BtnStudents_Click(object sender, EventArgs e)
        {
            Estudiantes StudentsForm = new Estudiantes();
            StudentsForm.Show();
        }

        private void BtnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Main_Load(object sender, EventArgs e)
        {
           CN_Empleados cnEmpleados = new CN_Empleados();

            List<Empleados> listaEmpleados = cnEmpleados.Listar();

            //foreach (Empleados empleado in listaEmpleados)
            //{
            //    MessageBox.Show($"Empleado: {empleado.Nombre}", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //    Console.WriteLine($"Empleado: {empleado.Nombre}");
            //}

        }

        private void BtnEmpleados_Click(object sender, EventArgs e)
        {
            FrmEmpleados FrmEmpleados = new FrmEmpleados();
            FrmEmpleados.Show();
        }
    }
}
