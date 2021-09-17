using System;

namespace operadores_aritmeticos_binarios_suma
{
    class Program
    {
        static void Main(string[] args)
        {

            //**dadada
            //*!ddadadadsdasdasd
            //*? awdadadawda
            //*^ dadadwad
            ////shdubiabd
            //opejspofpsfjpsf

            Console.WriteLine("\nOperacionesAritmeticas-Binaria-Suma");

            Console.Write("\nIntroduce tu primera cifra: ");
            string string_0 = Console.ReadLine();
            Console.Write("\nIntroduce tu primera cifra: ");
            string string_1 = Console.ReadLine();

            double suma_0 = Convert.ToDouble(string_0);
            double suma_1 = Convert.ToDouble(string_1);

            Console.WriteLine($"\nLa suma de {string_0} + {string_1} = {suma_0 + suma_1}");
            Console.WriteLine();
            

        }
    }
}