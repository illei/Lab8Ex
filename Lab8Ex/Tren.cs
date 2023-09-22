using System;
using System.Collections.Generic;
using System.Text;

namespace Lab8Ex
{
    class Tren
    {
        public string Nume { get; set; }
        Locomotiva locomotiva;
        public int NumarLocuri { get; set; }
        public int NumarLocuriClasa1 { get; set; }
        List<Vagon> Vagoane = new List<Vagon>();
        

        public Tren(string nume, Locomotiva locomotiva)
        {
            this.Nume = nume;
            this.locomotiva = locomotiva;
        }

        public void AddVagon(Vagon vagon)
        {
            Vagoane.Add(vagon);
        }

        public void PleacaDinGara()
        {
            locomotiva.Porneste();
            foreach (Vagon vagon in Vagoane)
            {
                if (vagon is VagonClasa1)
                {
                    VagonClasa1 vagonPersoane = vagon as VagonClasa1;
                    vagonPersoane.InchideUsile();
                    vagonPersoane.PornesteAC();
                }
                else if (vagon is VagonPerosane)
                {
                    VagonPerosane vagonPerosane = vagon as VagonPerosane;
                    vagonPerosane.InchideUsile();
                }
            }
        }
        public void OpresteInGara()
        {
            locomotiva.Opreste();
            foreach (Vagon vagon in Vagoane)
            {
                if (vagon is VagonClasa1)
                {
                    VagonClasa1 vagonPersoane = vagon as VagonClasa1;

                }
                else if (vagon is VagonPerosane)
                {
                    VagonPerosane vagonPerosane = vagon as VagonPerosane;
                    vagonPerosane.DeschideUsile();
                }
            }
        }

        public void NumarDeLocuri()
        {
            foreach (Vagon vagon in Vagoane)
            {
                if (vagon is VagonClasa1)
                {
                    VagonClasa1 vagonPersoane = vagon as VagonClasa1;
                    NumarLocuriClasa1 += vagonPersoane.LocuriVagon();
                }
                else if (vagon is VagonPerosane)
                {
                    VagonPerosane vagonPerosane = vagon as VagonPerosane;
                    NumarLocuri += vagonPerosane.LocuriVagon();
                }
            }
            Console.WriteLine($"Trenul are {NumarLocuri} normale si {NumarLocuriClasa1} la clasa 1");
        }

        public void SumarMarfa()
        {

        }
    }
}
