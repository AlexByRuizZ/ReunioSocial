using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Media;

namespace Reunió_Social
{
    public class Posicio : UserControl
    {
        protected string nom;
        protected int fila;
        protected int columna;
        private Image imgIcona;
        private TextBlock tbNom;
        public Posicio(int fila, int columna) { }
        public Posicio(string nom, int fila, int columna) { }
        public Posicio(string nom) { }
        public Posicio() { }
        public string Nom { get; set; }
        public int Columna { get; set; }
        public int Fila { get; set; }
        public virtual bool EsBuida { get; }
        public ImageSource Icona { get; set; }
        public static double Distancia(Posicio pos1, Posicio pos2)
        {
            return 0;
        }
    }
}
