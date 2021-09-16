using System;

namespace tipo_conversiones_basicas
{
    class Program
    {
        // char -> int -> long -> float -> double

        static void Main(string[] args)
        {

            Console.WriteLine("\n========Conversiones-Implicitas========\n");
            //Se pueden hacer saltos de tipo de varible pero sin hacerlo en sentido contrario, ejemplo de char -> float.
            char myChar = '\u005E';//tambien se puede expresar en forma de caracter 'y' suponiendo que y es mi caracter.
            int myInt = myChar;
            long myLong = myInt;
            float myFloat = myLong;
            Double myDouble = myFloat;  
            //En la forma implicita podemos trabajar de esta forma la cual es asignar el 
            //valor de la variable en su tipologia ordenada como se muestra al inicio.

            Console.WriteLine("\n===============Los valores=============\n");
            Console.WriteLine($"Mi valor en la Char es de 'u005E' = {myChar}\n");
            Console.WriteLine($"           Mi valor en Int es de {myChar} = {myInt}\n");
            Console.WriteLine($"                      Mi valor en Long es de {myInt} = {myLong}\n");
            Console.WriteLine($"                                 Mi valor en Float es de {myLong} = {myFloat}\n");
            Console.WriteLine($"                                            Mi valor en Double es de {myFloat} = {myDouble}\n");
            
        }


    }
}
