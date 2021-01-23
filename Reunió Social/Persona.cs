using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reunió_Social
{
    class Persona
    {
        protected bool tractat;
        public Persona(String nom, int fil, int col) { }
        public Persona(String nom) { }
        public Persona(){ }
        public bool Tractat { get; set; }
        //public override bool EsBuida { get; }
        //private double Atraccio(int fil, int col, Escenari esc) { }
        //public Direccio OnVaig(Escenari esc) { }
        //public abstract int Interes(Posicio pos) { }
        //public abstract bool EsConvidat;
    }
}
