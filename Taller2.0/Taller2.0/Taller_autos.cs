using System;
using System.Collections.Generic;
using System.Text;
using System.Collections;

namespace Taller
{
    class Taller_autos
    {
        ConsoleKeyInfo Opcion = new ConsoleKeyInfo();
        public Queue<string> Autos = new Queue<string>();
        public Queue<string> Propietarios = new Queue<string>();
        public ArrayList Lista_Propietarios = new ArrayList();
        public ArrayList Lista_Cobros = new ArrayList();
        public ArrayList Lista_Autos = new ArrayList();
        //------Arreglos
        //public string[] Arrayplacas = new string[5];
        //public string[] ArrayPropietario = new string[5];
        //-----Atributos
        int capacidad, autos_atendidos;
        double cobro = 0;
        //----Propiedades
        public int CAPACIDAD
        {
            get { return this.capacidad; }
            set { this.capacidad = value; }
        }
        public double COBRO
        {
            get { return this.cobro; }
            set { this.cobro = value; }
        }
        public int AUTOS_ATENDIDOS
        {
            get { return this.autos_atendidos; }
            set { this.autos_atendidos = value; }
        }
        public void Agregar_cobros(double pago)
        {
            Lista_Cobros.Add(pago);
        }//--Añadir a mi lista de cobros
        public void Agregar_Propietario(double persona)
        {
            Lista_Propietarios.Add(persona);
        }//--Añadir a mi lista de propietarios
        public void Agregar_Autos(double autos)
        {
            Lista_Autos.Add(autos);
        }
    }
}
