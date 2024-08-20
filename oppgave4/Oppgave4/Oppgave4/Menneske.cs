using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oppgave4
{
    internal class Menneske: Pattedyr
    {
        override public void LagLyd()
        {
            Console.WriteLine("Eh, hei, har du betalt skatten din enda?");
        }
    }
}
