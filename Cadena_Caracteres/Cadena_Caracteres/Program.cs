using System;

namespace Cadena_Caracteres
{
    class Program
    {
        static void Main(string[] args)
        {
            //---------Instancia de la clase----------
            Palabra objPalabra = new Palabra();
            Console.Write(">>PALABRA: ");
            objPalabra.PALABRA = Console.ReadLine();
            Console.WriteLine("_______________________________");
            Console.WriteLine("-------------------------------");
            Console.Write(">>PALABRA INVERTIDA: ");
            Console.WriteLine(objPalabra.Invertir_Palabra(objPalabra.PALABRA));
            Console.WriteLine("_______________________________");
            Console.WriteLine("-------------------------------");
            Console.Write(">>MAYUSCULAS: ");
            Console.WriteLine(objPalabra.Hacer_Mayuscula(objPalabra.PALABRA));
            Console.WriteLine("_______________________________");
            Console.WriteLine("-------------------------------");
            Console.Write(">>MINUSCULAS: ");
            Console.WriteLine(objPalabra.Hacer_Minuscula(objPalabra.PALABRA));
            Console.WriteLine("_______________________________");
            Console.WriteLine("-------------------------------");
            Console.Write(">>PALABRA MODIFICADA: ");
            Console.WriteLine(objPalabra.Correccion_de_Caracteres(objPalabra.PALABRA));
            Console.WriteLine("_______________________________");
            Console.WriteLine("-------------------------------");
            Console.ReadKey();
        }
    }
}
