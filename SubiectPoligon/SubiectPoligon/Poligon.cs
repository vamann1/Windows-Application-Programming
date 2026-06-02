using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SubiectPoligon
{
    [Serializable]
    public class Poligon
    {
        private List<Point> puncte;
        private string culoare;
        private int grosime_linie;
        private readonly int cod_figura;
        private static int contor;
        private string eticheta;

        public Poligon()
        {
            cod_figura = ++contor;
        }

        public Poligon(List<Point> puncte, string culoare, int grosime_linie, string eticheta)
        {
            this.puncte = puncte;
            this.culoare = culoare;
            this.grosime_linie = grosime_linie;
            this.eticheta = eticheta;
            cod_figura = ++contor;
        }

        public List<Point> Puncte { get => puncte; set => puncte = value; }
        public string Culoare { get => culoare; set => culoare = value; }
        public int Grosime_linie { get => grosime_linie; set => grosime_linie = value; }
        public string Eticheta { get => eticheta; set => eticheta = value; }
        public int Cod_figura => cod_figura;

        public double CalculPerimetru()
        {
            double perimetru = 0;
            if (puncte.Count > 1)
            {
                for(int i = 0; i < puncte.Count; i++)
                {
                    perimetru += Math.Sqrt((double)(Math.Pow((puncte[i].X - puncte[(i + 1)%puncte.Count].X), 2) 
                        +Math.Pow((puncte[i].Y - puncte[(i+1)%puncte.Count].Y), 2)));
                }
            }

            return perimetru;
        }

        public Point this[int index]
        {
            get => puncte[index];

            set => puncte[index] = value;
        }

    }
}
