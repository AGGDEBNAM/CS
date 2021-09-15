using System;

namespace msgreadline
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("\nHola me gustaria saber tu nombre:\n");
            Console.WriteLine("\nEs un bonito nombre " + $"{Console.ReadLine()}\n");
            //Se puede poner un readline dentro del write line que va aadir un mensaje al texto entrante.
            //string 'nombre' = Console.ReadLine(); <--- La unica forma alternativa es añadiendo de esta forma en el espacio solicitado.


        }
    }
}
