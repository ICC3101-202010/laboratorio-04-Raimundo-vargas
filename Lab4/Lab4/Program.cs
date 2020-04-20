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
            inicioA.Prender();
            inicioE.Prender();
            inicioV.Prender();
            inicioEM.Prender();
            string s;
            int Hora = 0;
            while (Hora<12)
            {
                s = "s";
                while (s == "s")
                {
                    if (R.Operar() == false)
                    {
                        Console.WriteLine("#############################################################");
                        Console.WriteLine("La Maquina de Recepcion colapso a las: " + Hora + ", Reiniciar para liberar RAM\n");
                        Console.WriteLine("Presione 2 para reiniciar");
                        string respuesta = Console.ReadLine();
                        if (respuesta == "2")
                        {
                            inicioR.Reiniciar();
                            s = "n";
                        }
                        else
                        {
                            Console.WriteLine("Boton Incorrecto...");
                        }
                        Console.WriteLine("#############################################################");
                        Thread.Sleep(1000);
                    }
                    else
                    {
                        s = "n";
                    }
                }
                s = "s";
                while (s == "s")
                {
                    if (A.Operar() == false)
                    {
                        Console.WriteLine("#############################################################");
                        Console.WriteLine("La Maquina de Almacenamiento colapso a las: " + Hora + ", Reiniciar para liberar RAM\n");
                        Console.WriteLine("Presione 2 para reiniciar");
                        string respuesta = Console.ReadLine();
                        if (respuesta == "2")
                        {
                            inicioA.Reiniciar();
                            s = "n";
                        }
                        else
                        {
                            Console.WriteLine("Boton Incorrecto...");
                        }
                        Console.WriteLine("#############################################################");
                        Thread.Sleep(1000);
                    }
                    else
                    {
                        s = "n";
                    }
                }
                s = "s";
                while (s == "s")
                {
                    if (E.Operar() == false)
                    {
                        Console.WriteLine("#############################################################");
                        Console.WriteLine("La Maquina de Ensamblaje colapso a las: " + Hora + ", Reiniciar para liberar RAM\n");
                        Console.WriteLine("Presione 2 para reiniciar");
                        string respuesta = Console.ReadLine();
                        if (respuesta == "2")
                        {
                            inicioE.Reiniciar();
                            s = "n";
                        }
                        else
                        {
                            Console.WriteLine("Boton Incorrecto...");
                        }
                        Console.WriteLine("#############################################################");
                        Thread.Sleep(1000);
                    }
                    else
                    {
                        s = "n";
                    }
                }
                s = "s";
                while (s == "s")
                {
                    if (V.Operar() == false)
                    {
                        Console.WriteLine("#############################################################");
                        Console.WriteLine("La Maquina de Verificacion colapso a las: " + Hora + ", Reiniciar para liberar RAM\n");
                        Console.WriteLine("Presione 2 para reiniciar");
                        string respuesta = Console.ReadLine();
                        if (respuesta == "2")
                        {
                            inicioV.Reiniciar();
                            s = "n";
                        }
                        else
                        {
                            Console.WriteLine("Boton Incorrecto...");
                        }
                        Console.WriteLine("#############################################################");
                        Thread.Sleep(1000);
                    }
                    else
                    {
                        s = "n";
                    }
                }
                s = "s";
                while (s=="s")
                {
                    if (EM.Operar() == false)
                    {
                        Console.WriteLine("#############################################################");
                        Console.WriteLine("La Maquina de Empaque colapso a las: " + Hora + ", Reiniciar para liberar RAM\n");
                        Console.WriteLine("Presione 2 para reiniciar");
                        string respuesta = Console.ReadLine();
                        if (respuesta == "2")
                        {
                            inicioEM.Reiniciar();
                            s = "n";
                        }
                        else
                        {
                            Console.WriteLine("Boton Incorrecto...");
                        }
                        Console.WriteLine("#############################################################");
                        Thread.Sleep(1000);
                    }
                    else
                    {
                        s = "n";
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
