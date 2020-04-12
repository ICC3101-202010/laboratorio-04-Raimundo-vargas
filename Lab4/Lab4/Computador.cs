using System;
using System.Collections.Generic;
using System.Threading;
using System.Text;


namespace Lab4
{
    class Computador
    {
        private Control control;
        public Computador(Control control1)
        {
            control = control1;
        }
        public void Prender()
        {
            Thread.Sleep(1000);
            control.Prender();
        }
        public void Apagar()
        {
            Thread.Sleep(1000);
            control.Apagar();
        }
        public void Reiniciar()
        {
            Thread.Sleep(1000);
            Console.WriteLine("Reiniciando...\n");
            Thread.Sleep(1000);
            control.Apagar();
            Thread.Sleep(1000);
            control.Prender();
        }
    }
}
