using System;
using System.Collections.Generic;
using System.Text;

namespace Lab4
{
    class Recepcion: Control
    {
        int RAM;
        public void Prender()
        {
            RAM = 0;
            Console.WriteLine("Recepcion Encendido\n");  
        }
        public void Apagar()
        {
            Console.WriteLine("Recepcion Apagado\n");
        }
        public bool Operar()
        {
            RAM += 1;
            if (RAM > 4)
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
