using System;

namespace Veinte_Numeros
{
    class Program
    {
        static void Main(string[] args)
        {
            Numeros objNumeros = new Numeros();
            ConsoleKeyInfo repetir_programa;
            do
            {
                Console.WriteLine("-------------20 NUMEROS---------------");
                Console.ReadKey();
                objNumeros.asignar_Numero();
                Console.WriteLine(objNumeros.ordenar_Numeros());
                Console.ReadKey();
                Console.WriteLine("____________________________________________");
                Console.WriteLine("<<PRESIONA [R] SI DESEAS REPETIR EL PROGRAMA>>");
                repetir_programa = Console.ReadKey();
            } while(repetir_programa.Key == ConsoleKey.R);
                Console.WriteLine(">>>>>>GRACIAS POR UTILIZAR EL PROGRAMA<<<<<<");
        }
    }
}
