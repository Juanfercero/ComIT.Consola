// See https://aka.ms/new-console-template for more information
using System;
using System.Collections.Generic;
using ConsoleApp3;

//Console.WriteLine("Hello, World!");

////Variables: act 1
//int num = 0;
//Console.WriteLine(num);
//num = +5;
//Console.WriteLine($"Sumo {num}");

//string cadena1 = "una";
//string cadena2 = "cadena";
//Console.WriteLine($"Esto es {cadena1} {cadena2}");

////Variables: act 2
//int num1 = 2;
//int num2 = 2;
//if(num1 == num2)
//{
//    Console.WriteLine($"Ambos numeros son iguales");
//}
//else if(num1 > num2)
//{
//     Console.WriteLine($"{num1} es mayor que {num2}");
//}
//else
//{
//    Console.WriteLine($"{num2} es mayor que {num1}");
//}


//POO Ejercicio 2
Profesor profesor1 = new(23452345, "Juan", "Perez", new DateOnly(1980, 5, 1), 25);
Curso curso1 = new Curso("Aprendiendo .NET", 1, profesor1);

for (int i = 0; i < curso1.CantidadMaximaAlumnos; i++)
{
    Console.WriteLine($"Ingrese el alumno numero {i}");
    Console.Write("DNI: ");
    long dni = long.Parse(Console.ReadLine());
    Console.Write("Nombre: ");
    string nombre = Console.ReadLine();
    Console.Write("Apellido: ");
    string apellido = Console.ReadLine();

    Console.Write("Fecha de Nacimiento (dd/mm/aaaa): "); // --> "23/11/1981"
    string fecha = Console.ReadLine();
    DateOnly fechaNacimiento = new DateOnly(int.Parse(fecha.Substring(6,4)), int.Parse(fecha.Substring(3,2)), int.Parse(fecha.Substring(0,2)));

    Console.Write("Trabaja? (SI/NO): ");
    bool trabaja = Console.ReadLine() == "SI";

    curso1.Alumnos[i] = new(dni, nombre, apellido, fechaNacimiento, trabaja);
}

Console.WriteLine($"Los alumnos del curso {curso1.Nombre} son:");
for (int i = 0;i < curso1.CantidadMaximaAlumnos; i++)
{
    Console.WriteLine($"Alumno {i+1}: {curso1.Alumnos[i].Nombre} {curso1.Alumnos[i].Nombre}");
}


//act 1
int num = 0;
Console.WriteLine(num);
num = +5;
Console.WriteLine($"Sumo {num}");