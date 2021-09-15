using System;

namespace tipo_datos_nonumericos
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\n======Tipos de datos No numericos======\n");
            Console.WriteLine("\n================BOLEANO================\n");
            
            Console.WriteLine("Pasare el examen?\n");

            bool agreditarExamen = true;//se puede usar este metodo para asignar valor ya sea TRUE o FALSE.

            Console.WriteLine($"{agreditarExamen},Si estudias.");

            Console.WriteLine("\nSi no quiero estudiar?\n");

            agreditarExamen = Convert.ToBoolean(0);//Este otro metodo es convertir a valor tipo int ya sea 1 o 0.

            Console.WriteLine($"{agreditarExamen},Si no estudias.");

            Console.WriteLine("\n=================CHAR==================\n");
        
            char valorCeroBasico = '0';// Caracter que determines (solamente uno).
            char valorCeroUniCode = '\u0030';// Este valor se saca de la colexion unicode que termina un solo codigo que es un caracter.
            char valorCeroDecimal = Convert.ToChar(48);// Tambien hay forma de hacerlo con un valor decimal.

            Console.WriteLine($"Basico: {valorCeroBasico}\n");

            Console.WriteLine($"UniCode: {valorCeroUniCode}\n");
                                    
            Console.WriteLine($"Decimal: {valorCeroDecimal}\n");
            
        }
    } 
}
