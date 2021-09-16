using System;

namespace tipo_conversiones_clasesconvert
{
    //para saber mas detalles se ofrece la documentacion de onenote '3-datosbasicos_operadores' para saber todos los tipos de convert.
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("\n   ALGUNOS TIPOS DE TO.CONVERT   \n");

            int myInt = 98;
            double myDouble = 13.69;
            bool myBool = true;
            char myChar = '#';
            //sencillamente convierte valores de un tipo de variable a una en la que se pueda convertir pudiendo decir que es una forma automatica de detectar implicito y explicito.

            Console.WriteLine($"Mi int '98' a Char es: {Convert.ToChar(myInt)}");
            Console.WriteLine($"Mi double '13.69' a String es: {Convert.ToString(myDouble)}");
            Console.WriteLine($"Mi bool 'true' a Int es: {Convert.ToInt32(myBool)}"); 
            Console.WriteLine($"Mi char '#' a Byte es: {Convert.ToSByte(myChar)}");

            Console.WriteLine("\n   ALGUNOS TIPOS DE TO.CONVERT - SALIENDO DE CONVERSION EXPLICITA   \n");
            //Si combinamos ambas funciones podemos convertir un valor ya convertido.

            double myDouble_0 = 270.7;
            long myLong_0 = (long) myDouble_0;
            char myChar_0 = (char) myDouble_0;
            
            Console.WriteLine($"Mi double '270.7' a int es: {Convert.ToInt32(myDouble_0)}");
            Console.WriteLine($"Mi long '270' a bool es: {Convert.ToBoolean(myLong_0)}");
            Console.WriteLine($"Mi char 'D' a String es: {Convert.ToString(myChar_0)}");
            
            Console.WriteLine("\n   ALGUNOS TIPOS DE TO.CONVERT - SALIENDO DE CONVERSION IMPLICITA   \n");
            //Si combinamos ambas funciones podemos convertir un valor ya convertido.

            char myChar_1 = 'W';
            long myLong_1 = myChar_1;
            double myDouble_1 = myLong_1;

            Console.WriteLine($"Mi char 'W' a int es: {Convert.ToInt32(myChar_1)}");
            Console.WriteLine($"Mi long '87' a bool es: {Convert.ToBoolean(myLong_1)}");
            Console.WriteLine($"Mi Double '87' a String es: {Convert.ToString(myDouble_1)}");

            Console.WriteLine("\n   ALGUNOS TIPOS DE TO.CONVERT - SIN VALORES DECLARADOS   \n");
            //Esta funcion sin declarar variables se debe a que se declaran el en espacio donde deveria y la variable.

            Console.WriteLine($"Convert.ToInt32('#') = {Convert.ToInt32('#')}");
            Console.WriteLine($"Convert.ToString(true) = {Convert.ToString(true)}");
            Console.WriteLine($"Convert.ToChar('u0092') = {Convert.ToChar('\u0092')}");
            Console.WriteLine($"Convert.ToBoolean(0) = {Convert.ToBoolean(0)}");
            Console.WriteLine($"Convert.ToChar(34) = {Convert.ToChar(34)}");
            Console.WriteLine($"Convert.ToDouble(44.54) = {Convert.ToDouble(44.54)}");


        }
    }
}
