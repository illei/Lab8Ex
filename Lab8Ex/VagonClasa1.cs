using System;
using System.Collections.Generic;
using System.Text;

namespace Lab8Ex
{
    class VagonClasa1 : VagonPerosane
    {
        public VagonClasa1(int NrLocuri,int anFabricatie):base(anFabricatie,3500)
        {
            this.nrLocuri = NrLocuri;
        }

        public void PornesteAC()
        {
            Console.WriteLine("AC-ul este pornit");
        }

        public void OpresteAC()
        {
            Console.WriteLine("AC-ul este oprit");
        }
    }
}
