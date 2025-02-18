﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    public class Profesor : Persona
    {
        public int AñosExperiencia = 0;

        public string NombreCompleto
        {
            get
            {
                return ($"{Nombre} {Apellido}");
            }
            set
            {

            }
        }


        public Profesor(long dni, string nombre, string apellido, DateOnly fechaNacimiento, int añosExperiencia)
            : base(dni, nombre, apellido, fechaNacimiento)
        {
            añosExperiencia = AñosExperiencia;
        }

        public virtual string DevolverNombreCompleto()
        {
            return ($"{Nombre} {Apellido}");
        }
    }
}
