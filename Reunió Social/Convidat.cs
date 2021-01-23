using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reunió_Social
{
    public abstract class Convidat : Persona
    {
        protected SortedDictionary<String, Int32> simpaties;
        protected int plusSexe;
        public Convidat(String nom, SortedDictionary<String, Int32> simpaties, int plusSexe)
        {

        }
        public Convidat(String nom, int plusSexe) { }
        public SortedDictionary<String, Int32> Simpaties { get; };
        public int PlusSexe;
        //public abstract bool EsHome;
        //public override bool EsConvidat;
    }
}
