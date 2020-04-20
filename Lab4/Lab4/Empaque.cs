using System;
using System.Collections.Generic;
using System.Text;

namespace Lab4
{
    class Empaque : Control
    {
        int RAM;
        public void Prender()
        {
            RAM = 0;
            Console.WriteLine("Empaque Encendido\n");
        }
        public void Apagar()
        {
            Console.WriteLine("Empaque Apagado\n");
        }
        public bool Operar()
        {
            RAM += 1;
            if (RAM > 3)
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
