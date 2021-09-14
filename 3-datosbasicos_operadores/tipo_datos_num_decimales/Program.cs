using System;

namespace tipo_datos_num_decimales
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Tipos de datos numericos - Decimales");

            //Todos los valores tiene una cantidad grande de espacios enteros.
            //Todos tiene su depectiva letra para distinguirlos al final de valor asignado.
            float floatValorValido = 69.123456789f;//ocupa 4 espacios decimales y uno que se redondea.
            double doubleValorValido = 69.123456789123456789d;//Ocupa 14 espacios decimales.
            decimal decimalValorValido = 69.123456789123456789123456789123456789m;//Ocupa 27 espacios decimales. 

            Console.WriteLine(floatValorValido);
            Console.WriteLine(doubleValorValido);
            Console.WriteLine(decimalValorValido);
            
        }
    }
}
