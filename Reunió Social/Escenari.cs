using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace Reunió_Social
{
    class Escenari:Grid
    {
        public Escenari(int fles, int columnes) { }
        public Escenari(int files, int columnes, int nHOmes, int nDones, int nCambrers) { }
        public int Files;
        public int Columnes;
        public int Homes;
        public int Dones;
        public int Cambrers;

        private void Moure(int filOrig, int colOrig, int filDesti, int colDesti) { }

        //public Posicio this[int fila, int col] { }

        //public bool DestiValid(int fil, int col) { }

        public void Buida(int fil, int col) { }

        public void Posa(Persona pers) { }

        //private String ObteNom(String fitxer) { }

        private void ObteImatge(Persona p) { }

        public void Cicle() { }

    }
}
