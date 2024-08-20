using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oppgave4
{
    internal class Edderkopp: Insekt
    {
        override public void LagLyd()
        {
            Console.WriteLine("Jeg er faktisk ikke et insekt");
        }
    }
}
