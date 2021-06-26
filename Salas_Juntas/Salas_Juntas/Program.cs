using System;

namespace Salas_Juntas
{
    class Program
    {
        static void Main(string[] args)
        {
            string seleccion;
            Salas_Reuniones objSala1 = new Salas_Reuniones();
            Salas_Reuniones objSala2 = new Salas_Reuniones();
            Salas_Reuniones objSala3 = new Salas_Reuniones();
            objSala1.Todos_Disponibles();
            objSala2.Todos_Disponibles();
            objSala3.Todos_Disponibles();
            do
            {
                Console.Clear();
                Console.WriteLine("AGENDA TU REUNION");
                Console.WriteLine("SELECCIONA LA SALA QUE DESEAS RENTAR");//>>Menu de opciones
                Console.WriteLine("1) -- SALA 1");
                Console.WriteLine("2) -- SALA 2");
                Console.WriteLine("3) -- SALA 3");
                Console.WriteLine("4) -- SALIR DE LA APLICACION");
                Console.WriteLine("______________________________");
                Console.Write(">>Seleccion: ");
                seleccion = Console.ReadLine().ToUpper();
                switch (seleccion)
                {
                    case "1": //Sala 1
                        {
                            do
                            {
                                Console.Clear();
                                Console.WriteLine("<<<SALA 1>>>");
                                Console.WriteLine("--SELECCIONA EL DIA DE LA SEMANA QUE DESAS RENTAR--");//Menu de los dias que se pueden elegir
                                Console.WriteLine("1) -- Lunes");
                                Console.WriteLine("2) -- Martes");
                                Console.WriteLine("3) -- Miercoles");
                                Console.WriteLine("4) -- Jueves");
                                Console.WriteLine("5) -- Viernes");
                                Console.WriteLine("6) -- Sabado");
                                Console.WriteLine("7) -- Domingo");
                                Console.Write(">>Dia seleccionado: ");
                                objSala1.DIA = Convert.ToInt32(Console.ReadLine());
                                if (objSala1.DIA == 7)//Condision de si escoge el domingo. 
                                { Console.WriteLine("---Este Dia no hay Servicio--"); Console.ReadKey();}//Mensaje de indicacion de que el domingo no hay servicio
                            } while (objSala1.DIA == 7);//Ciclo pra que cuando escoja el domingo le vuelva a mostrar el menu. 
                            do
                            {
                                Console.WriteLine("¿Ah que horas quieres agendar tu reunion? (Formato 24 hrs)");
                                Console.Write(">>HORA: ");
                                objSala1.HORA = Convert.ToInt32(Console.ReadLine());
                                if (objSala1.Agenda[objSala1.DIA - 1, objSala1.HORA - 9] == ">>La Sala se Encuentra Ocupada<<")
                                {
                                    Console.WriteLine(">>ESA HORA YA ESTA OCUPADA");
                                    Console.WriteLine();
                                }//Condision por si la sala ya esta ocupada a la hora que esta ingresando el usuario. 
                            } while (objSala1.Agenda[objSala1.DIA-1, objSala1.HORA - 9] == ">>La Sala se Encuentra Ocupada<<");
                            if (objSala1.Agenda[objSala1.DIA - 1, objSala1.HORA - 9] != "Disponible") { Console.WriteLine("La sala no esta Disponible"); Console.ReadKey(); ; break; }
                            objSala1.Hora_Reunion();
                            Console.WriteLine(">> ¿CUANTAS HORAS QUIERES RENTAR ESTA SALA?");
                            Console.WriteLine("----- 1 HORA ---- 2 HORAS ---- 3 HORAS ----");
                            Console.WriteLine("--> HORAS: ");
                            objSala1.HRS_REUNION = Convert.ToInt32(Console.ReadLine());
                            objSala1.Hrs_Reunion();
                        }
                        break;
                    case "2": //Sala 2
                        {
                            do
                            {
                                Console.Clear();
                                Console.WriteLine("<<<SALA 1>>>");
                                Console.WriteLine("--SELECCIONA EL DIA DE LA SEMANA QUE DESAS RENTAR--");
                                Console.WriteLine("1) -- Lunes");
                                Console.WriteLine("2) -- Martes");
                                Console.WriteLine("3) -- Miercoles");
                                Console.WriteLine("4) -- Jueves");
                                Console.WriteLine("5) -- Viernes");
                                Console.WriteLine("6) -- Sabado");
                                Console.WriteLine("7) -- Domingo");
                                Console.Write(">>Dia seleccionado: ");
                                objSala2.DIA = Convert.ToInt32(Console.ReadLine());
                                if (objSala2.DIA == 7)
                                { Console.WriteLine("---Este Dia no hay Servicio--"); Console.ReadKey(); }
                            } while (objSala2.DIA == 7);
                            do
                            {
                                Console.WriteLine("¿Ah que horas quieres agendar tu reunion? (Formato 24 hrs)");
                                Console.Write(">>HORA: ");
                                objSala2.HORA = Convert.ToInt32(Console.ReadLine());
                                if (objSala2.Agenda[objSala2.DIA-1, objSala2.HORA - 9] == ">>La Sala se Encuentra Ocupada<<")
                                {
                                    Console.WriteLine(">>ESA HORA YA ESTA OCUPADA");
                                    Console.WriteLine();
                                }
                            } while (objSala2.Agenda[objSala2.DIA-1, objSala2.HORA - 9] == ">>La Sala se Encuentra Ocupada<<");
                            if (objSala2.Agenda[objSala2.DIA - 1, objSala2.HORA - 9] != "Disponible") { Console.WriteLine("La sala no esta Disponible"); Console.ReadKey(); break; }
                            objSala2.Hora_Reunion();
                            Console.WriteLine(">> ¿CUANTAS HORAS QUIERES RENTAR ESTA SALA?");
                            Console.WriteLine("----- 1 HORA ---- 2 HORAS ---- 3 HORAS ----");
                            Console.Write("--> HORAS: ");
                            objSala2.HRS_REUNION = Convert.ToInt32(Console.ReadLine());
                            objSala2.Hrs_Reunion();
                        }
                        break;
                    case "3": //Sala 3
                        {
                            do
                            {
                                Console.Clear();
                                Console.WriteLine("<<<SALA 1>>>");
                                Console.WriteLine("--SELECCIONA EL DIA DE LA SEMANA QUE DESAS RENTAR--");
                                Console.WriteLine("1) -- Lunes");
                                Console.WriteLine("2) -- Martes");
                                Console.WriteLine("3) -- Miercoles");
                                Console.WriteLine("4) -- Jueves");
                                Console.WriteLine("5) -- Viernes");
                                Console.WriteLine("6) -- Sabado");
                                Console.WriteLine("7) -- Domingo");
                                Console.Write(">>Dia seleccionado: ");
                                objSala3.DIA = Convert.ToInt32(Console.ReadLine());
                                if (objSala3.DIA == 7)
                                { Console.WriteLine("---Este Dia no hay Servicio--"); Console.ReadKey(); }
                            } while (objSala3.DIA == 7);
                            do
                            {
                                Console.WriteLine("¿Ah que horas quieres agendar tu reunion? (Formato 24 hrs)");
                                Console.Write(">>HORA: ");
                                objSala3.HORA = Convert.ToInt32(Console.ReadLine());
                                if (objSala3.Agenda[objSala3.DIA-1, objSala3.HORA - 9] == ">>La Sala se Encuentra Ocupada<<")
                                {
                                    Console.WriteLine(">>ESA HORA YA ESTA OCUPADA");
                                    Console.WriteLine();
                                }
                            } while (objSala3.Agenda[objSala3.DIA-1, objSala3.HORA - 9] == ">>La Sala se Encuentra Ocupada<<");
                            if (objSala3.Agenda[objSala3.DIA-1, objSala3.HORA - 9] != "Disponible") { Console.WriteLine("La sala no esta disponible"); Console.ReadKey(); ; break; }
                            objSala3.Hora_Reunion();
                            Console.WriteLine(">> ¿CUANTAS HORAS QUIERES RENTAR ESTA SALA?");
                            Console.WriteLine("----- 1 HORA ---- 2 HORAS ---- 3 HORAS ----");
                            Console.Write("--> HORAS: ");
                            objSala3.HRS_REUNION = Convert.ToInt32(Console.ReadLine());
                            objSala3.Hrs_Reunion();
                        } break;
                    case "REPORTE":
                        {
                            string dia = "";
                            Console.Clear();
                            Console.WriteLine("---HORARIOS DE LAS 3 SALAS---");
                            for (int n = 1; n < 4; n++)//Ciclo para repetir 3 veces (en cada vuelta muestrara la respectiva sala 1, 2, 3)
                            {
                                Console.WriteLine("______________________________________________");
                                Console.WriteLine($"----------------Sala {n}---------------------");
                                Console.WriteLine("<><><><><><><><><><><><><><><><><><><><><><><>");
                                for (int x = 0; x < 6; x++)//Filas (dias)
                                {
                                    switch (x)
                                    {
                                        case 0: dia = "Lunes"; break;
                                        case 1: dia = "Martes"; break;
                                        case 2: dia = "Miercoles"; break;
                                        case 3: dia = "Jueves"; break;
                                        case 4: dia = "Viernes"; break;
                                        case 5: dia = "Sabado"; break;
                                    }//Indicación de dias de la semana para mostrarlos. 
                                    Console.WriteLine(dia);
                                    for (int i = 0; i < 12; i++)//Columnas (horas)
                                    {
                                        switch(n)
                                        {
                                            case 1: Console.WriteLine($"---{i + 9}:00 >> {objSala1.Agenda[x,i]}");break;
                                            case 2: Console.WriteLine($"---{i + 9}:00 >> {objSala2.Agenda[x,i]}");break;
                                            case 3: Console.WriteLine($"---{i + 9}:00 >> {objSala3.Agenda[x,i]}");break;
                                        }//Dependiendo en que vuelta (sala) vallamos. 
                                    }
                                }
                            }
                            Console.ReadKey();
                        } break;
                }
            } while (seleccion != "4");//Ciclo para repetir el programa hasta que el usuario desee salir. 
        }
    }
}
