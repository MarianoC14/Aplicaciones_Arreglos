using System;
using System.Collections.Generic;
using System.Text;

namespace Veinte_Numeros
{
    class Numeros
    {
        //------------------Atributos-------------------
        double num;
        string ordenamiento;
        //-----------------Array--------------- 
        public double[] ArrayNumero = new double[20];//--20 números
        //---Metodo para Solicitar al usuario que ingrese un número---
        public void asignar_Numero()
        {
            for(int x = 0; x < 20; x++)
            {
                Console.Clear();//Limpiar consola para no mostrar 20 veces el mismo proceso en pantalla. 
                Console.WriteLine($"-----------NUMERO {x + 1}------------");
                Console.Write(">> Introduce un Número: ");
                num = Convert.ToDouble(Console.ReadLine());
                ArrayNumero[x] = num;
            }
        }
        //----Método para ordenar los Números Ingresados----
        public string ordenar_Numeros()
        {
            ConsoleKeyInfo Ordenar;//Instancia para mi variable que identificara la tecla presionada.
            do {
                Console.WriteLine("-----Presiona Enter para Ordenar tus números----");
                Ordenar = Console.ReadKey(true);
            } while (Ordenar.Key != ConsoleKey.Enter);//Bucle que me solicitara que presione enter hasta que lo haga. 
            Array.Sort(ArrayNumero);//Ordenar todos los números en el array de menor a mayor. 
            for(int i = 0; i < 20; i++)
            {
                ordenamiento += $"-- {ArrayNumero[i]} ";//Mostrar Todos los números ordenados. 
            }
            return ordenamiento;
        }
    }
}
