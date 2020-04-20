using System;
using System.Collections.Generic;
using System.Text;

namespace Lab4
{
    class Almacenamiento: Control
    {
        int RAM;
        public void Prender()
        {
            RAM = 0;
            Console.WriteLine("Almacenamiento Encendido\n");
        }
        public void Apagar()
        {
            Console.WriteLine("Almacenamiento Apagado\n");
        }
        public bool Operar()
        {
            RAM += 1;
            if (RAM > 2.5)
            {
                return false;
            }
            else
            {
                return true;
            }
        }
    }
}
