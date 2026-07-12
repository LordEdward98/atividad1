using System;
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("ingrese su nombre");
        string nombre = Console.ReadLine()!;
        Console.WriteLine("ingrese su apellido");
        string apellido = Console.ReadLine()!;
        Console.WriteLine("ingrese su edad");
        int edad = Convert.ToInt32(Console.ReadLine()!);
        Console.WriteLine("ingrese su carrera");
        string carrera = Console.ReadLine()!;
        Console.WriteLine("ingrese su universidad");
        string universidad = Console.ReadLine()!;
        Console.WriteLine("ingrese su promedio");
        double promedio = double.Parse(Console.ReadLine()!);
        Console.WriteLine("Los datos ingresados son:");
        Console.WriteLine("Nombre: " + nombre);
        Console.WriteLine("Apellido: " + apellido);
        Console.WriteLine("Edad: " + edad);
        Console.WriteLine("Carrera: " + carrera);
        Console.WriteLine("Universidad: " + universidad);
        Console.WriteLine("Promedio: " + promedio);
    }
}