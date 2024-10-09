// See https://aka.ms/new-console-template for more information
using POO;

Libro libro1 = new Libro("Peter Punk", "J. Matthew del Barrio", 2, 0);
Libro libro2 = new Libro("Sherlock Home", "A. Conan Detective", 1, 1);
Libro libro3 = new Libro("La Madrina", "Mario Chuzo", 3, 0);

libro1.MostrarDatos();

libro1.Prestar();
libro1.Prestar();
libro1.Prestar();

libro1.MostrarDatos();

libro1.Devolver();
libro1.Devolver();
libro1.Devolver();

libro1.MostrarDatos();

libro2.MostrarDatos();

libro2.Prestar();
libro2.Prestar();

libro2.MostrarDatos();

libro2.Devolver();
libro2.Devolver();
libro2.Devolver();

libro2.MostrarDatos();