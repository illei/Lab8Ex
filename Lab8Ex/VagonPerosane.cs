using System;
using System.Collections.Generic;
using System.Text;

namespace Lab8Ex
{
    class VagonPerosane : Vagon
    {
        protected int nrLocuri;

        public VagonPerosane(int NumarLocuri,int anFabricatie):base(2000,anFabricatie)
        {
            this.nrLocuri = NumarLocuri;
        }

        public void DeschideUsile()
        {
            Console.WriteLine("Usile sunt deschise");
        }

        public void InchideUsile()
        {
            Console.WriteLine("Usile s-au inchis");
        }
        public int LocuriVagon()
        {
            return this.nrLocuri;
        }
    }
}
