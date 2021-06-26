using System;
using System.Collections.Generic;
using System.Text;

namespace Salas_Juntas
{
    class Salas_Reuniones
    {
        //-----Arreglos
        public string[,] Agenda = new string[6,12];
        //-----Atributos
        int dia;
        int hora, hrs_reunion;
        //----Propiedades
        public int DIA
        {
            get { return this.dia;}
            set { this.dia = value; }
        }
        public int HORA
        {
            get { return this.hora; }
            set { this.hora = value; }
        }
        public int HRS_REUNION
        {
            get { return this.hrs_reunion; }
            set { this.hrs_reunion = value; }
        }
        //------Métodos
        public void Hora_Reunion()
        {
            if (Agenda[DIA - 1, HORA - 9] == "Disponible")//condision de si la sala esta disponible ahora ocuparla. 
            {
                Agenda[DIA - 1, HORA - 9] = ">>La Sala se Encuentra Ocupada<<";
            }
            else
            {
                Console.WriteLine(">>La sala se Encuentra Ocupada<<");//mensaje indicando que esta ocupada. 
            }
        }
        public void Hrs_Reunion()
        {
            int[] Confirmacion = { 1, 1, 1,};
            for (int i = 1; i <= HRS_REUNION; i++)
            {
                if (Agenda[DIA - 1, HORA - 9 + i] == "Disponible")//Condision de si la sala a la hora que esta indicando esta disponible me indique que si se puede asignar. 
                {
                    Confirmacion[i - 1] = 1;
                }
                else { Confirmacion[i - 1] = 0;}//Indicacion de que en el rango de horas hay una sala ocupada. 
            }
            if (Confirmacion[0] == 1 && Confirmacion[1] == 1 && Confirmacion[2] == 1)
            {
                for (int i = 1; i <= HRS_REUNION; i++)
                {
                    if (Agenda[DIA - 1, HORA - 9 + i] == "Disponible")//Asignar La sala como ocupada
                    {
                        Agenda[DIA - 1, HORA - 9 + i] = ">>La sala se Encuentra Ocupada<<";
                    }
                }
            }
            else//Si almenos en una de las horas hay una sala ocupada no hara nada.  
            {
                Console.WriteLine("En ese Rango de Horas hay Salas ocupadas");
            }
        }
        public void Todos_Disponibles()
        {
            for(int x = 0; x < 6;x++)//Columnas (Dias)
            {
                for(int i = 0; i < 12;i++)//Filas (Horas) 
                {
                    Agenda[x, i] = "Disponible";
                }
            }
        }//Este metodo definira que todas las salas estan disponibles al inicial el programa. 
    }
}
