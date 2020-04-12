using System;
using System.Threading;

namespace Lab4
{
    class Program
    {
        static void Main()
        {
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


            while (true)
            {
                RamR += 1;
                if (RamR == 10)
                {
                    Console.WriteLine("#############################################################");
                    Console.WriteLine("La Maquina de Recepcion colapso, Reiniciar para liberar RAM\n");
                    inicioR.Reiniciar();
                    Console.WriteLine("#############################################################");
                    RamR = 0;
                    Thread.Sleep(1000);
                }
                RamA += 1;
                if (RamA == 5)
                {
                    Console.WriteLine("#############################################################");
                    Console.WriteLine("La Maquina de Almacenamiento colapso, Reiniciar para liberar RAM\n");
                    inicioA.Reiniciar();
                    Console.WriteLine("#############################################################");
                    RamA = 0;
                    Thread.Sleep(1000);
                }
                RamE += 1;
                if (RamE == 8)
                {
                    Console.WriteLine("#############################################################");
                    Console.WriteLine("La Maquina de Ensamblaje colapso, Reiniciar para liberar RAM\n");
                    inicioE.Reiniciar();
                    RamE = 0;
                    Console.WriteLine("#############################################################");
                    Thread.Sleep(1000);
                }
                RamV += 1;
                if (RamV == 20)
                {
                    Console.WriteLine("#############################################################");
                    Console.WriteLine("La Maquina de Verificacion colapso, Reiniciar para liberar RAM\n");
                    inicioV.Reiniciar();
                    Console.WriteLine("#############################################################");
                    RamV = 0;
                    Thread.Sleep(1000);
                }
                RamEM += 1;
                if (RamEM == 15)
                {
                    Console.WriteLine("#############################################################");
                    Console.WriteLine("La Maquina de Empaque colapso, Reiniciar para liberar RAM\n");
                    inicioEM.Reiniciar();
                    Console.WriteLine("#############################################################");
                    RamEM = 0;
                    Thread.Sleep(1000);
                }


            }


        }
    }
}
