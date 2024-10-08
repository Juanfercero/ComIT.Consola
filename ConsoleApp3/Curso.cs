using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    public class Curso
    {
        public string Nombre = "";
        public int CantidadMaximaAlumnos = 1;
        public Profesor Profesor;
        public Alumno[] Alumnos;

        public Curso(string nombreCurso, int cantidadMaximaAlumnos, Profesor profesor)
        {
            //nombreCurso = Nombre;
            //cantidadMaximaAlumnos = CantidadMaximaAlumnos;
            //profesor = Profesor;
            //Alumnos = new Alumno[CantidadMaximaAlumnos];
        }
    }
}
