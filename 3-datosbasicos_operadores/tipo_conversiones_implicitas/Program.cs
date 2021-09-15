using System;

namespace tipo_conversiones_basicas
{
    class Program
    {
        // char -> int -> long -> float -> double

        static void Main(string[] args)
        {

            Console.WriteLine("\n========Conversiones-Implicitas========\n");
            //Se pueden hacer saltos de tipo de varible pero sin hacerlo en sentido contrario.
            char myChar = '\u005E';
            int myInt = myChar;
            long myLong = myInt;
            float myFloat = myLong;
            Double myDouble = myFloat;
            //En la forma implicita podemos trabajar de esta forma la cual es asignar el 
            //valor de la variable en su tipologia ordenada como se muestra al inicio.

            Console.WriteLine("\n===============Los valores=============\n");
            Console.WriteLine($"Mi valor en la Char es de 'u005E' = {myChar}\n");
            Console.WriteLine($"Mi valor en Int es de '^' = {myInt}\n");
            Console.WriteLine($"Mi valor en Long es de '94' = {myLong}\n");
            Console.WriteLine($"Mi valor en Float es de '94' = {myFloat}\n");
            Console.WriteLine($"Mi valor en Double es de '94' = {myDouble}\n");
            
            
        }


    }
}
