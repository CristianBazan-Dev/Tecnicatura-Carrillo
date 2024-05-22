using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CreacionFormularios.Forms;


namespace CreacionFormularios
{
    
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void BtnLibrary_Click(object sender, EventArgs e)
        {
            Biblioteca LibraryForm = new Biblioteca();
            LibraryForm.Show();
        }

        private void BtnProfesors_Click(object sender, EventArgs e)
        {
            Profesores ProfesorsForm = new Profesores();
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
    }
}
