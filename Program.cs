using System;
class Program
{
    static void Main(string[] args)
    {
        const int materiaMaxima = 6;

        Console.WriteLine("ingrese sus nombres");
        string nombre = Console.ReadLine()!;
        Console.WriteLine("ingrese sus apellidos");
        string apellido = Console.ReadLine()!;
        Console.WriteLine("ingrese su edad");
        int edad = Convert.ToInt32(Console.ReadLine()!);
        Console.WriteLine("ingrese su carrera");
        string carrera = Console.ReadLine()!;
        Console.WriteLine("ingrese su carnet");
        string carnet = Console.ReadLine()!;
        Console.WriteLine("ingrese su correo electronico");
        string correo = Console.ReadLine()!;
        Console.WriteLine("ingrese su telefono");
        string telefono = Console.ReadLine()!;
        Console.WriteLine("ingrese su promedio");
        double promedio = double.Parse(Console.ReadLine()!);
        Console.WriteLine("ingrese la cantidad de materias inscritas");
        int cantidadMaterias = Convert.ToInt32(Console.ReadLine()!);

        Console.WriteLine("================================");
        Console.WriteLine("Bienvenido al sistema de registro de estudiantes");
        Console.WriteLine("================================");
        Console.WriteLine("Bienvenido/a " + nombre + " " + apellido);
        Console.WriteLine("");
        Console.WriteLine("Nombre: " + nombre);
        Console.WriteLine("Apellido: " + apellido);
        Console.WriteLine("Edad: " + edad);
        Console.WriteLine("edad dentro de 5 años: " + (edad + 5));
        Console.WriteLine("");
        Console.WriteLine("Carrera: " + carrera);
        Console.WriteLine("Carnet: " + carnet);
        Console.WriteLine("Correo electrónico: " + correo);
        Console.WriteLine("Teléfono: " + telefono);
        Console.WriteLine("Promedio: " + promedio);
        Console.WriteLine("");
        Console.WriteLine("Materias inscritas: " + cantidadMaterias);
        Console.WriteLine("Materia máxima permitida: " + materiaMaxima);
        Console.WriteLine("");
        if (cantidadMaterias < materiaMaxima)
        {
            Console.WriteLine("puede inscribir mas materias: si");
        }
        else if (cantidadMaterias == materiaMaxima)
        {
            Console.WriteLine("puede inscribir mas materias: no");
        }
        else
        {
            Console.WriteLine("no puede inscribir mas de 6 materias");
        }
        Console.WriteLine("");
        Console.WriteLine("================================");
        Console.WriteLine("gracias por utulizar el sistema");
        Console.WriteLine("================================");
    }
}