// See https://aka.ms/new-console-template for more information
using System;
using System.Collections.Generic;

//Actividad Método
//Suma

Console.Write($"Ingrese Numero 1: ");
int sumNum1 = int.Parse(Console.ReadLine());
Console.Write($"Ingrese Numero 2: ");
int sumNum2 = int.Parse(Console.ReadLine());

int Sumar()
{
    return sumNum1 + sumNum2;
}

Console.WriteLine($"El resultado de la suma es {Sumar()}");


//Concatenación

Console.Write($"Ingrese la primera frase a concatenar: ");
string cadena1 = Console.ReadLine();
Console.Write($"Ingrese la segunda frase a concatenar: ");
string cadena2 = Console.ReadLine();

void Concatenar()
{
    Console.WriteLine($"Concatenación: {cadena1} {cadena2}");
}

Concatenar();


//Descuento

Console.Write($"Ingrese el valor del item: ");
double valorItem = double.Parse(Console.ReadLine());
Console.Write($"Ingrese la cantidad a comprar: ");
double cantItem = double.Parse(Console.ReadLine());

double Descuento()
{
    if ( valorItem * cantItem >= 1000)
    {
        //double valorDescuento = valorItem * cantItem * 0.10;
        //return valorItem * cantItem - valorDescuento;
        return valorItem * cantItem * 0.90;
    }
    else
    {
        return valorItem * cantItem;
    }
}

Console.WriteLine($"El valor total a pagar es: {Descuento()}");


//Impresión de asteriscos

Console.Write($"Ingrese la cantidad de asteriscos que desea imprimir: ");
int cantAsteriscos = int.Parse(Console.ReadLine());

void Imprimir()
{
    for (int i = 0; i < cantAsteriscos; i++)
    {
        Console.WriteLine("*");
    }
}

Imprimir();
Console.WriteLine("Se han impreso todos los asteriscos");