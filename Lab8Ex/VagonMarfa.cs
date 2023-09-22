using System;
using System.Collections.Generic;
using System.Text;

namespace Lab8Ex
{
    enum TipMarfa
    {
        Cereale,
        Carbuni,
        Otel,
        NoMarfa
    }
    class VagonMarfa:Vagon
    {
        public VagonMarfa(TipMarfa marfa,int capacitate, int anFabricatie):base(3000,anFabricatie)
        {
            Capacitate = capacitate;
            this.Marfa = marfa;
        }
        public TipMarfa Marfa { get; private set; }
        public int Capacitate { get; private set; }
    }
}
