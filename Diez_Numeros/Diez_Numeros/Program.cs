using System;

namespace Diez_Numeros
{
    class Program
    {
        static void Main(string[] args)
        {
            Numeros obj10Numeros = new Numeros();
            //--------------Array-----------------------------
            Console.WriteLine("<><><><><><DIEZ NUMEROS><><><><><><><>");
            for (int x = 0; x <= 9; x++)
            {
                Console.Write("Escribe un valor: ");
                obj10Numeros.arrayNumeros[x] = Convert.ToDouble(Console.ReadLine());
                obj10Numeros.SUMA = obj10Numeros.SUMA + obj10Numeros.arrayNumeros[x];//Cada numero que se ingrese se agregara 
                //--------Comparación del Número Mayor----------------            a la variable suma para de una sola accion ir sumando los numeros.
                if (obj10Numeros.MAYOR > obj10Numeros.arrayNumeros[x])
                { obj10Numeros.MAYOR = obj10Numeros.MAYOR; }
                else {obj10Numeros.MAYOR = obj10Numeros.arrayNumeros[x]; }
                //Console.WriteLine(arrayNumeros[x]);
            }
            obj10Numeros.MENOR = obj10Numeros.arrayNumeros[0];
            obj10Numeros.Numero_menor();
            //----------------------SALIDA----------------------------
            Console.WriteLine("____________________________________");
            Console.WriteLine($"---Numero Menor: {obj10Numeros.MENOR}");
            obj10Numeros.Promedio();
            Console.WriteLine("____________________________________");
            Console.WriteLine($"---Promedio: {obj10Numeros.PROMEDIO}");
            obj10Numeros.Numero_Mayor();
            Console.WriteLine("____________________________________");
            Console.WriteLine($"---Mayor: {obj10Numeros.MAYOR}");
            Console.WriteLine("____________________________________");
            Console.WriteLine($"---Suma: {obj10Numeros.SUMA}");
            Console.WriteLine("FIN");
        }
    }
}
