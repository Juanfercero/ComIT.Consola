using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    public class Persona
    {
        public long DNI = 0;
        public string Nombre = "";
        public string Apellido = "";
        public DateOnly FechaNacimiento = new();

        public Persona(long dNI, string nombre, string apellido, DateOnly fechaNacimiento)
        {
            DNI = dNI;
            Nombre = nombre;
            Apellido = apellido;
            FechaNacimiento = fechaNacimiento;
        }
    }
}
