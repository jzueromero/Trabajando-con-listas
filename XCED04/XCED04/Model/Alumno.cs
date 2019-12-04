using System;
using System.Collections.Generic;
using System.Text;

namespace XCED04.Model
{
    public class Alumno
    {
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public int Edad { get; set; }

        private string _Especialidad;

        public string Especialidad
        {
            get { return _Especialidad; }
            set { _Especialidad = value.ToUpper(); }
        }
    }
}
