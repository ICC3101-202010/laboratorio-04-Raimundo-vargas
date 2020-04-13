using System;
using System.Threading;

namespace Lab4
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Inicio de la jornada...\n");
            Recepcion R = new Recepcion();
            Almacenamiento A = new Almacenamiento();
            ensamblaje E = new ensamblaje();
            verificación V = new verificación();
            Empaque EM = new Empaque();
            Computador inicioR = new Computador(R);
            Computador inicioA = new Computador(A);
            Computador inicioE = new Computador(E);
            Computador inicioV = new Computador(V);
            Computador inicioEM = new Computador(EM);
            inicioR.Prender();
            int RamR = 0;
            inicioA.Prender();
            int RamA = 0;
            inicioE.Prender();
            int RamE = 0;
            inicioV.Prender();
            int RamV = 0;
            inicioEM.Prender();
            int RamEM = 0;
            int Hora = 0;
            while (Hora<3600)
            {
                RamR += 1;
                if (RamR > 1000)
                {
                    while (RamR > 1000)
                    {
                        {
                            Console.WriteLine("#############################################################");
                            Console.WriteLine("La Maquina de Recepcion colapso a las: "+Hora+", Reiniciar para liberar RAM\n");
                            Console.WriteLine("Presione 2 para reiniciar");
                            string respuesta = Console.ReadLine();
                            if (respuesta=="2")
                            {
                                inicioR.Reiniciar();
                                RamR = 0;
                            }                           
                            Console.WriteLine("#############################################################");                            
                            Thread.Sleep(1000);
                        }
                    }
                }                                   
                RamA += 1;
                if (RamA > 500)
                {
                    while (RamA > 500)
                    {
                        {
                            Console.WriteLine("#############################################################");
                            Console.WriteLine("La Maquina de Almacenamiento colapso a las: " + Hora + ", Reiniciar para liberar RAM\n");
                            Console.WriteLine("Presione 2 para reiniciar");
                            string respuesta = Console.ReadLine();
                            if (respuesta == "2")
                            {
                                inicioA.Reiniciar();
                                RamA = 0;
                            }
                            Console.WriteLine("#############################################################");
                            Thread.Sleep(1000);
                        }
                    }
                }                             
                RamE += 1;
                if (RamE > 1500)
                {
                    while (RamE > 1500)
                    {
                        {
                            Console.WriteLine("#############################################################");
                            Console.WriteLine("La Maquina de Ensamblaje colapso a las: " + Hora + ", Reiniciar para liberar RAM\n");
                            Console.WriteLine("Presione 2 para reiniciar");
                            string respuesta = Console.ReadLine();
                            if (respuesta == "2")
                            {
                                inicioE.Reiniciar();
                                RamE = 0;
                            }
                            Console.WriteLine("#############################################################");
                            Thread.Sleep(1000);
                        }
                    }
                }          
                RamV += 1;
                if (RamV > 800)
                {
                    while (RamV > 800)
                    {
                        {
                            Console.WriteLine("#############################################################");
                            Console.WriteLine("La Maquina de Verificacion colapso a las: " + Hora + ", Reiniciar para liberar RAM\n");
                            Console.WriteLine("Presione 2 para reiniciar");
                            string respuesta = Console.ReadLine();
                            if (respuesta == "2")
                            {
                                inicioV.Reiniciar();
                                RamV = 0;
                            }
                            Console.WriteLine("#############################################################");
                            Thread.Sleep(1000);
                        }
                    }
                }            
                RamEM += 1;
                if (RamEM > 1200)
                {
                    while (RamEM > 1200)
                    {
                        {
                            Console.WriteLine("#############################################################");
                            Console.WriteLine("La Maquina de Empaque colapso a las: " + Hora + ", Reiniciar para liberar RAM\n");
                            Console.WriteLine("Presione 2 para reiniciar");
                            string respuesta = Console.ReadLine();
                            if (respuesta == "2")
                            {
                                inicioEM.Reiniciar();
                                RamEM = 0;
                            }
                            Console.WriteLine("#############################################################");
                            Thread.Sleep(1000);
                        }
                    }
                }
                Hora += 1;                            
            }
            Console.WriteLine("Fin de la Jornada...\n");
            inicioR.Apagar();
            inicioA.Apagar();
            inicioE.Apagar();
            inicioV.Apagar();
            inicioEM.Apagar();
        }
    }
}
