using System;

namespace practica_msg
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\n====DATOS PARA ENCUESTADO====\n");
            Console.WriteLine(" Cual es tu Nombre:\n");
            string nombre = Console.ReadLine();
            Console.WriteLine("\n Apellidos:\n");
            string apellidos = Console.ReadLine();
            Console.WriteLine("\n Cual es tu Edad:\n");
            string edad = Console.ReadLine();
            Console.WriteLine("\n Que es lo que te Apaciona:\n");
            string pasion = Console.ReadLine();
            Console.WriteLine("====RESULTADOS DEL ENCUESTADO====\n");
            Console.WriteLine($"Se llama: \n{nombre} {apellidos}");
            Console.WriteLine($"\nSu edad es: \n{edad} años");
            Console.WriteLine($"\nSu pasion es: \n{pasion}\n");

        }
    }
}
