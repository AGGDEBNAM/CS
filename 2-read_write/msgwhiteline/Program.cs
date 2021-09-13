using System;

namespace msgwhiteline
{
    class Program
    {
        static void Main(string[] args)
        {
            
            string empresa = "AGG";
            string elaboracion = "DESING";
            string servicio = "WEB"; 

            Console.WriteLine("\n   Empieza tu nueva WEB");
            Console.WriteLine("\n   Con " + empresa + " " + elaboracion + " la carga no sera todo tuya. ");
            Console.WriteLine("\n   Interpolacion de Strings ");//la interpolacion es la interjeccion de strings en texto por medio de "{}" y "$".
            Console.WriteLine($"\n   Ahora {empresa} {elaboracion} {servicio} sabes lo que te brinda\n");

        }
    }
}
