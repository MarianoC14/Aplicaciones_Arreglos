using System;
using System.Collections.Generic;
using System.Text;

namespace Cadena_Caracteres
{
    class Palabra
    {
        //--------------Atributos---------------
        string palabra, palabra_Invertida, mayuscula;
        int tamaño;
        //-------------Propiedades--------------
        public string PALABRA
        {
            get { return this.palabra; }
            set { this.palabra = value;}
        }
        //---------------Métodos----------------
        //<><><><><><Invertir Palabra<><><><><><
        public string Invertir_Palabra(string palabra)
        {
            PALABRA = palabra; //------Asignacion de la variable
            tamaño = PALABRA.Length; //------Valor del tamaño de la palabra
            for (int x = tamaño - 1; x >= 0; x--)//---Ciclo que recorre la palabra
            {
                palabra_Invertida += PALABRA[x];//--Asignacion de Caracteres iniciando desde el ultimo
            }
            return palabra_Invertida;
        }
        //<><><><>Convertir en Mayuscula<><><><<
        public string Hacer_Mayuscula(string palabra)
        {
            PALABRA = palabra;
            mayuscula = PALABRA.ToUpper();//Hacer la palabra en Mayuscula
            return mayuscula;
        }
        //<><><><><>Convertir en Minuscula<><><><><><
        public string Hacer_Minuscula(string palabra)
        {
            string minuscula;
            PALABRA = palabra;
            minuscula = PALABRA.ToLower();//Hacer la palabra en Minuscula
            return minuscula;
        }
        //<><><><Hacer Modificaciones<><><><><><><><><
        public string Correccion_de_Caracteres(string palabra)
        {
            //-----------Atributos del metodo----------
            string palabra_Modificada = "";
            int i = 0;
            PALABRA = palabra;
            tamaño = PALABRA.Length;
            char[] letra = new char[tamaño];//Arreglo para cada letra
            foreach(var l in mayuscula)//Ciclo para agregar letra por letra al arreglo
            {
                letra[i] = (l);
                i++;
            }
            for(int x = 0; x < tamaño; x++)//Ciclo para recorrer todos los Arreglos
            { 
                switch(letra[x])//Condisiones de Cambios
                {
                    case 'A': letra[x] = '4'; break;
                    case 'I': letra[x] = '1'; break;
                    case 'S': letra[x] = '5'; break;
                    case 'B': letra[x] = '8'; break;
                    case 'E': letra[x] = '3'; break;
                    case 'T': letra[x] = '7'; break;
                }
            }
            for(int x = 0; x < tamaño; x++)
            {
                palabra_Modificada += letra[x];
            }
            return palabra_Modificada;
        }
    }
}
