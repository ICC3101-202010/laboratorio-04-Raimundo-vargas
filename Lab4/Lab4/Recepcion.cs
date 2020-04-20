using System;
using System.Collections.Generic;
using System.Text;

namespace Lab4
{
    class Recepcion: Control
    {     
        public void Prender()
        {         
            Console.WriteLine("Recepcion Encendido\n");  
        }
        public void Apagar()
        {
            Console.WriteLine("Recepcion Apagado\n");
        }
    }
}
