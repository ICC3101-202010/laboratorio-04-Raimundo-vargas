using System;
using System.Collections.Generic;
using System.Text;

namespace Lab4
{
    class ensamblaje:Control
    {
        int RAM;
        public void Prender()
        {
            RAM = 0;
            Console.WriteLine("Ensamblaje Encendido\n");
        }
        public void Apagar()
        {
            Console.WriteLine("Ensamblaje Apagado\n");
        }
        public bool Operar()
        {
            RAM += 1;
            if (RAM > 2)
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
