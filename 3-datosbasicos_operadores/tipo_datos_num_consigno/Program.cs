using System;

namespace tipo_datos_num_consigno
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Tipos de datos numericos - Enteros - Consigno");

            sbyte sbyteValorValido = 127;
            short shortValorValido = 32767;
            int intValorValido = 2147483647;
            long longValorValido = 9223372036854775807;
            //Todos los datos son valores enteros con signos al igual que se ven
            //en la variable su valor negativo es el mismo -1.Ejemplo_127=-127-1=-128 
            Console.WriteLine(sbyteValorValido);
            Console.WriteLine(shortValorValido);
            Console.WriteLine(intValorValido);
            Console.WriteLine(longValorValido);

        }
    }
}
