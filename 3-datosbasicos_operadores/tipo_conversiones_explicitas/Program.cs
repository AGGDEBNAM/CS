using System;

namespace tipo_conversiones_explicitas
{
    class Program
    {
        //double -> float -> long -> int -> char
        static void Main(string[] args)
        {

            Console.WriteLine("\n========Conversiones-Explicitas========\n");
            //Esta es una buena forma de hacer convesiones explicitas de forma que tus varibles ya estan asignadas a un valor inicial asignado.
            Console.WriteLine("\nForma numero uno con varias varibles\n");

            Double myDouble_0 = 69.69d;
            float myFloat = (float) myDouble_0;
            long myLong = (long) myFloat;
            int myInt = (int) myLong;
            char myChar = (char) myInt;
            //es importante saber que puedes hacer saltos de tipos de varibles ejemplo de double a int pero nunca alreves como se muestra.

            Console.WriteLine($"Mi double es {myDouble_0}");
            Console.WriteLine($"Mi double a float es {myFloat}");
            Console.WriteLine($"Mi float a long es {myLong}");
            Console.WriteLine($"Mi long es int es {myInt}");
            Console.WriteLine($"Mi int a char es {myChar}");
            //hay dos formas de convertir que es declarando una variable con uno o varios textos a leer como en el ejemplo de abajo.
            //la otra forma es con varias variables ya convertidas con uno o varios textos o uno a leer.
            Console.WriteLine("\nForma numero dos con una varible\n");

            Double myDouble_1 = 69.69d;

            Console.WriteLine($"Mi valor double es de: {myDouble_1}");
            Console.WriteLine($"Mi valor double a Float es de: {(float) myDouble_1}");
            Console.WriteLine($"Mi valor double a Long es de: {(long) myDouble_1}");
            Console.WriteLine($"Mi valor double a Int es de: {(int) myDouble_1}");
            Console.WriteLine($"Mi valor double a Char es de: {(char) myDouble_1}");
            
        }
    }
}