using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO
{
    public class Libro
    {
        public string Titulo = "";
        public string Autor = "";
        public int CantCopias = 0;
        public int CantPrestamo = 0;

        public Libro(string titulo, string autor, int cantCopias, int cantPrestamo)
        {
            Titulo = titulo;
            Autor = autor;
            CantCopias = cantCopias;
            CantPrestamo = cantPrestamo;
        }

        public void Prestar()
        {
            if (CantCopias >= 1)
            {
                CantPrestamo++;
                CantCopias--;
                Console.WriteLine($"Se ha prestado una copia del libro {Titulo}");
            }
            else
            {
                Console.WriteLine($"El libro {Titulo} no tiene stock");
            }
        }

        public void Devolver()
        {
            if (CantPrestamo >= 1)
            {
                CantPrestamo--;
                CantCopias++;
                Console.WriteLine($"Se ha devuelto una copia del libro {Titulo}");
            }
            else
            {
                Console.WriteLine($"El libro {Titulo} no tiene copias que devolver");
            }
        }

        public void MostrarDatos()
        {
            Console.WriteLine($"*");
            Console.WriteLine($"Título: {Titulo}");
            Console.WriteLine($"Autor: {Autor}");
            Console.WriteLine($"Stock: {CantCopias}");
            Console.WriteLine($"Copias Prestadas: {CantPrestamo}");
            Console.WriteLine($"*");
        }
    }
}
