using System;
using System.Collections.Generic;
using System.Text;

namespace Lab8Ex
{
   
    class Vagon
    {
        public Vagon(int masa,int anFabricatie)
        {
            Masa = masa;
            AnFabricatie = anFabricatie;
        }
        public int Masa { get; private set; }

        public int AnFabricatie { get;  private set; }
    }
}
