using System;
using System.Collections.Generic;
using System.Text;

namespace Diez_Numeros
{
    class Numeros
    {
        //Atributos 
        double suma = 0, promedio, mayor = 0, menor;
        //Atributos
        public double SUMA
        {
            get { return this.suma; }
            set { this.suma = value; }
        }
        public double PROMEDIO
        {
            get { return this.promedio; }
            set { this.promedio = value; }
        }
        public double MENOR
        {
            get { return this.menor; }
            set { this.menor = value; }
        }
        public double MAYOR
        {
            get { return this.mayor; }
            set { this.mayor = value; }
        }
        //--------------Array-----------------------------
        public double[] arrayNumeros = new double[10];
        //-----------------Metodos-----------------------------
        public void Numero_menor()
        {
            for (int i = 0; i <= 9; i++)//Ciclo Número Menor
            {
                if (arrayNumeros[i] < MENOR) { MENOR = arrayNumeros[i]; }//Condision para definir que numero es menor
                else { MENOR = MENOR; }
            }
        }
        public void Promedio()
        {//-------------Obtencion del Promedio-----------------
            PROMEDIO = SUMA / 10;}
        public void Numero_Mayor()
        {
            Array.Sort(arrayNumeros);//Ordenar los números de Menor a mayor
            MAYOR = arrayNumeros[9];//El numero mayor sera el ultimo numero ordenado
        }
    }
}
