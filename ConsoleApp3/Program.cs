﻿// See https://aka.ms/new-console-template for more information
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


////Variables: act 3
//int varnum = 11;

//switch (varnum)
//{
//    case <= 3:
//        Console.WriteLine("La variable pertenece al Grupo 1");
//        break;

//    case <= 6:
//        Console.WriteLine("La variable pertenece al Grupo 2");
//        break;

//    case <= 10:
//        Console.WriteLine("La variable pertenece al Grupo 3");
//        break;

//    default:
//        Console.WriteLine("ingrese una variable correcta");
//        break;
//}

////Variables: act 4
//int n = 1;
//while (n <= 10)
//{
//    Console.WriteLine($"{n} elefantes se balanceaban sobre la tela de una araña. Llamas otro elefante...");
//    n++;
//}
//Console.WriteLine("La telaraña se rompió");


////Variables: act 5
//int[] myArray = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
//Console.WriteLine($"El primer número del array es: {myArray[0]}");
//int total = 1;

//foreach (int i in myArray)
//{
//    Console.WriteLine($"El siguiente número del array es: {myArray[i]}");
//    int num2 = myArray[i];
//    int antTotal = total;
//    total = total * num2;
//    Console.WriteLine($"{antTotal} por {num2} es: {total}");
//    //Console.WriteLine(i);
//    if (i == myArray.Length - 1)
//    {
//        Console.WriteLine("No hay mas numeros que multiplicar, empecemos a sumar");
//        break;
//    }
//}


//int[] otroArray = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10,11};
//Console.WriteLine($"El primer numero del array es {otroArray[0]}");
//int nuevoResultado = otroArray[0];

//foreach (int i in otroArray)
//{
//    Console.WriteLine($"El siguiente numero del array es {otroArray[i]}");
//    //int primerNum = otroArray[i];  --> se puede sacar el num2 del ejercicio anterior y poner directamente el numero del array
//    int antRes = nuevoResultado;
//    nuevoResultado = otroArray[i] + antRes;
//    Console.WriteLine($"{antRes} más {otroArray[i]} es: {nuevoResultado}");
//    if (i == otroArray.Length-1)
//    {
//        Console.WriteLine("No hay mas numeros que sumar, gracias x su atención");
//        break;
//    }
//}






//POO Ejercicio 2
//--> Falta programar que te pida los datos del profesor y que te pida la cant maxima de alumnos
//______ Intento Fallido _______

//Profesor profesor1 = new(23452345, "Juan", "Perez", new DateOnly(1980, 5, 1), 25);
//Curso curso1 = new Curso("Aprendiendo .NET", 3, profesor1);

////No me agarra el método. Vamos a instanciarlo manualmente
//curso1.Nombre = "Aprendiendo .NET";
//Console.WriteLine($"1{curso1.Nombre}");

//Console.Write("Cantidad de cursos: ");
//long cantCursos = long.Parse(Console.ReadLine());


//for (int h = 0; h < cantCursos; h++)
//{
//    Console.Write($"Introduce el nombre del curso numero {h+1}: ");
//    string nombreCurso = Console.ReadLine();
//    Curso cursoBucle = new Curso($"{nombreCurso}", 1, profesor1);

//    for (int i = 0; i < cursoBucle.CantidadMaximaAlumnos; i++)
//    {
//        Console.WriteLine($"Ingrese el alumno numero {i}");
//        Console.Write("DNI: ");
//        long dni = long.Parse(Console.ReadLine());
//        Console.Write("Nombre: ");
//        string nombre = Console.ReadLine();
//        Console.Write("Apellido: ");
//        string apellido = Console.ReadLine();

//        Console.Write("Fecha de Nacimiento (dd/mm/aaaa): "); // --> "23/11/1981"
//        string fecha = Console.ReadLine();
//        DateOnly fechaNacimiento = new DateOnly(int.Parse(fecha.Substring(6, 4)), int.Parse(fecha.Substring(3, 2)), int.Parse(fecha.Substring(0, 2)));

//        Console.Write("Trabaja? (SI/NO): ");
//        bool trabaja = Console.ReadLine() == "SI";

//        Console.WriteLine($"2{curso1.Nombre}");

//        cursoBucle.Alumnos[i] = new(dni, nombre, apellido, fechaNacimiento, trabaja);

//        Console.WriteLine($"3{curso1.Nombre}");

//        //Alumno alumno = new Alumno(dni, nombre, apellido, fechaNacimiento, trabaja);
//        //curso1.Alumnos.Add(alumno);
//    }
//    Console.WriteLine($"4{curso1.Nombre}");
//    curso1 = cursoBucle;
//    Console.WriteLine($"5{curso1.Nombre}");
//}

//Console.WriteLine($"Los alumnos del curso {curso1.Nombre} son:");
//for (int i = 0; i < curso1.CantidadMaximaAlumnos; i++)
//{
//    Console.WriteLine($"Alumno {i + 1}: {curso1.Alumnos[i].Nombre} {curso1.Alumnos[i].Apellido}");
//}



//_______ New Try _______
List<Profesor> profesores = new List<Profesor>();
List<Curso> cursos = new List<Curso>();

while (true)
{
    Console.Write("Ingresar DNI del profesor (0 para finalizar): ");
    long dni = long.Parse(Console.ReadLine());

    if (dni == 0) { break; }

    Console.Write("Ingrese el nombre del profesor: ");
    string nombre = Console.ReadLine();

    Console.Write("Ingrese el apellido del profesor: ");
    string apellido = Console.ReadLine();

    Console.Write("Fecha de nacimiento (dd/mm/aaaa): ");
    string fecha = Console.ReadLine();
    DateOnly fechaNac = new DateOnly(int.Parse(fecha.Substring(6, 4)), int.Parse(fecha.Substring(3, 2)), int.Parse(fecha.Substring(0, 2)));

    Console.Write("Años de experiencia: ");
    int añosExp = int.Parse(Console.ReadLine());

    Console.WriteLine("*");

    Profesor profesor = new Profesor(dni, nombre, apellido, fechaNac, añosExp);
    profesores.Add(profesor);
}

while (true)
{
    Console.Write("Ingrese el nombre del curso (deje vacío para finalizar): ");
    string nombreCurso = Console.ReadLine();

    if (string.IsNullOrEmpty(nombreCurso)) { break; }

    Console.Write("Ingrese la cantidad maxima de alumnos: ");
    int cantMaxAlu = int.Parse(Console.ReadLine());

    Random ran = new Random();
    Profesor profeAsignado = profesores[ran.Next(profesores.Count)];

    Curso curso = new Curso(nombreCurso, cantMaxAlu, profeAsignado);

    Console.Write("Ingrese la cantidad de alumnos que desea ingresar: ");
    int cantAlu = int.Parse(Console.ReadLine());

    if (cantAlu > cantMaxAlu)
    {
        Console.WriteLine($"Error: Nose pueden agregar mas de {cantMaxAlu} alumnos. Podemos agregar solo el maximo permitido" );
        cantAlu = cantMaxAlu;
    }

    for(int i = 0; i < cantAlu; i++)
    {
        Console.WriteLine($"Ingrese el alumno {i + 1}");
        Console.Write("DNI: ");
        long dni = long.Parse(Console.ReadLine());
        Console.Write("Nombre: ");
        string nombre = Console.ReadLine();
        Console.Write("Apellido: ");
        string apellido = Console.ReadLine();

        Console.Write("Fecha de nacimiento(dd/mm/aaaa): ");
        string fecha = Console.ReadLine();
        DateOnly fechaNac = new DateOnly(int.Parse(fecha.Substring(6, 4)), int.Parse(fecha.Substring(3, 2)), int.Parse(fecha.Substring(0, 2)));

        Console.Write("Trabaja? (SI/NO): ");
        bool trabaja = Console.ReadLine() == "SI";

        Alumno alumno = new Alumno(dni, nombre, apellido, fechaNac, trabaja);
        curso.Alumnos.Add(alumno);

        Console.WriteLine("*");
    }

    Console.WriteLine("*");

    cursos.Add (curso);
}

Console.WriteLine("*");

Console.WriteLine("Cursos Ingresados: ");
foreach(var curso in cursos)
{
    Console.WriteLine($"Curso: {curso.Nombre}");
    Console.WriteLine($"Profesor {curso.Profesor.DevolverNombreCompleto()}");
    Console.WriteLine($"Curso: {curso.Nombre}, Profesor {curso.Profesor.DevolverNombreCompleto()}");
    Console.WriteLine("Alumnos: ");
    foreach(var alumno in curso.Alumnos)
    {
        Console.WriteLine(alumno.DevolverNombreCompleto());
    }
    Console.WriteLine("*");
}