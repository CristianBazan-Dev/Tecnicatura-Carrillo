﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad
{
    public class Empleados
    {

        public int IdEmpleado {  get; set; }

        public string Nombre { get; set; }

        public string Apellido { get; set; }

        public string Telefono { get; set; }

        public string Direccion { get; set; }

        public string Localidad {  get; set; }

        public string Provincia {  get; set; }

        public int Activo { get; set; }
    }
}
