using System;

namespace Lab8Ex
{
    class Program
    {
        static void Main(string[] args)
        {
            Locomotiva locomotiva = new Locomotiva();
            VagonClasa1 vagon1 = new VagonClasa1(230,2015);
            VagonClasa1 vagon4 = new VagonClasa1(230, 2015);
            VagonClasa1 vagon5 = new VagonClasa1(230, 2015);
            VagonPerosane vagon2 = new VagonPerosane(150,2015);
            VagonMarfa vagon3 = new VagonMarfa(TipMarfa.Cereale,150, 2015);
            Tren Tren = new Tren("Galati-Constanta",locomotiva);

            Tren.AddVagon(vagon1);





            Tren.PleacaDinGara();
            Tren.OpresteInGara();
            Tren.NumarDeLocuri();
        }
    }
}
