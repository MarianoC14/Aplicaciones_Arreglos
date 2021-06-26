using System;

namespace Taller
{
    class Program
    {
        static void Main(string[] args)
        {
            ConsoleKeyInfo Opcion = new ConsoleKeyInfo();
            Taller_autos objTaller = new Taller_autos();
            double Cobro;
            objTaller.CAPACIDAD = 0;
            do
            {
                Console.Clear();
                Console.WriteLine("Escoge una opción: ");
                Console.WriteLine("a) Registrar Auto");
                Console.WriteLine("b) Quitar Auto");
                Console.WriteLine("c) Mostrar Lista de Autos");
                Console.WriteLine("d) Salir");
                Opcion = Console.ReadKey(true);
                switch (Opcion.Key)
                {
                    case ConsoleKey.A:
                        {
                            Console.Clear();
                            if (objTaller.CAPACIDAD > 4) 
                            {
                                Console.WriteLine("---El taller esta lleno---");
                                Console.ReadKey(); break;
                            }//Condición para que no sean mas de 5 autos en el taller
                            Console.WriteLine("REGISTRO");
                            Console.Write("--PROPIETARIO: ");
                            objTaller.Propietarios.Enqueue(Console.ReadLine());//--Agregar a la Queue 
                            Console.Write("--PLACAS: ");
                            objTaller.Autos.Enqueue(Console.ReadLine());//--Agregar a la Queue de Autos
                            objTaller.CAPACIDAD++;
                            objTaller.AUTOS_ATENDIDOS++;
                        }
                        break;
                    case ConsoleKey.B:
                        {
                            Console.Clear();
                            if (objTaller.CAPACIDAD == 0)
                            {
                                Console.WriteLine(">>NO HAY AUTOS EN EL TALLER");
                                Console.ReadKey(); break;
                            }
                            Console.Write(">>COBRO: ");
                            Cobro = Convert.ToDouble(Console.ReadLine());
                            objTaller.COBRO = objTaller.COBRO + Cobro;
                            objTaller.Lista_Cobros.Add(Cobro);//Agregar a la lista de los cobros aplicados
                            objTaller.Lista_Autos.Add(objTaller.Autos.Dequeue());//Agregar a la lista de autos y quitar del taller. 
                            objTaller.Lista_Propietarios.Add(objTaller.Propietarios.Dequeue());//Agregar a la lista propietarios
                            objTaller.CAPACIDAD--;
                        }
                        break;
                    case ConsoleKey.C:
                        {
                            Console.Clear();
                            Console.WriteLine($"AUTOS ATENDIDOS: {objTaller.AUTOS_ATENDIDOS}");
                            for(int i = 0; i < objTaller.AUTOS_ATENDIDOS; i++)
                            {
                                Console.WriteLine("------------------------------------");
                                Console.WriteLine("------------------------------------");
                                Console.WriteLine($"--Placas del Auto: {objTaller.Lista_Autos[i]}");
                                Console.WriteLine($"--Propietario: {objTaller.Lista_Propietarios[i]}");
                                Console.WriteLine($"--Cobro: {objTaller.Lista_Cobros[i]}");
                                Console.WriteLine();
                            }
                            Console.WriteLine("_________________________________________");
                            Console.WriteLine($"COBRO TOTAL EN EL DIA: $ {objTaller.COBRO}");
                            Console.ReadKey();
                        }
                        break;
                }
            } while (Opcion.Key != ConsoleKey.D);
            
        }
    }
}
