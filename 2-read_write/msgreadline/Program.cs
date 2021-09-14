using System;

namespace msgreadline
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("\nHola me gustaria saber tu nombre:\n");
            Console.WriteLine("\nEs un bonito nombre " + $"{Console.ReadLine()}\n");
            //Un readline solo se puede ejecutar dentro de la funcion writeline colocado de la forma que se ve.
            //string nombre = Console.ReadLine();
            //La unica forma alternativa es añadiendo de esta forma en el espacio solicitado.

        }
    }
}
