using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sub3_2026
{
    internal class ColectivitateStatistica
    {
        private List<double> observatii;
        private List<double> ponderi;

        public event EventHandler colectivitateSchimbata;

        public void NotificaColectivitateSchimbata()
        {
            CalculPonderi();
            colectivitateSchimbata?.Invoke(this, EventArgs.Empty);
        }

        public ColectivitateStatistica()
        {
            this.observatii = new List<double>();
            this.ponderi = new List<double>();
        }

        public ColectivitateStatistica(List<double> observatii)
        {
            this.observatii = observatii;
            this.ponderi = new List<double>();
            CalculPonderi();
        }

        public List<double> Observatii { get => observatii; set => observatii = value; }
        public List<double> Ponderi { get => ponderi; set => ponderi = value; }

        public void CalculPonderi()
        {
            double suma = 0;
            foreach(var it in this.observatii)
            {
                suma += it;
            }

            if(suma == 0)
            {
                return;
            }

            this.ponderi.Clear();
            for(int i =0; i<this.observatii.Count; i++)
            {
                this.ponderi.Add(this.observatii[i]/suma);
            }
        }
    }
}
