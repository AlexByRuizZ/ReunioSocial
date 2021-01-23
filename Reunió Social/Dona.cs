using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reunió_Social
{
    class Dona:Convidat
    {
        public Dona(String nom, SortedDictionary<String, Int32> simpaties, int sexe) { }
        public Dona(String nom, int sexe) { }
        //public override bool EsHome;
        //public override int Interes(Posicio pos) { }
    }
}
