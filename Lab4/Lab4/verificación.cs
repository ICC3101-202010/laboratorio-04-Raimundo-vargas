using System;
using System.Collections.Generic;
using System.Text;

namespace Lab4
{
    class verificación:Control
    {
        int RAM;
        public void Prender()
        {
            RAM = 0;
            Console.WriteLine("Verificacion Encendido\n");
        }
        public void Apagar()
        {
            Console.WriteLine("Verificacion Apagado\n");
        }
        public bool Operar()
        {
            RAM += 1;
            if (RAM > 1.5)
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
