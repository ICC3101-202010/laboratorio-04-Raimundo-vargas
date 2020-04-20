using System;
using System.Collections.Generic;
using System.Text;

namespace Lab4
{
    class Empaque: Control
    {
        public void Prender()
        {
            Console.WriteLine("Empaque Encendido\n");
        }
        public void Apagar()
        {
            Console.WriteLine("Empaque Apagado\n");
        }
    }   
}
