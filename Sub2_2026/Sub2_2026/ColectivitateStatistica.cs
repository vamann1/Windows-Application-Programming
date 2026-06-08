using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Sub2_2026
{
    internal class ColectivitateStatistica
    {
        private List<double> observatii;
        private List<double> ponderi;

        public delegate void DateModificate();
        public event DateModificate dateModif;

        public ColectivitateStatistica()
        {
            observatii = new List<double>();
            ponderi = new List<double>();
        }

        public ColectivitateStatistica(List<double> observatii)
        {
            this.observatii = new List<double>();
            this.ponderi = new List<double>();
            this.observatii = observatii;
            CalculIndici();
        }

        public void CalculIndici()
        {
            this.ponderi.Clear();
            ponderi.Add(0.0);
            for (int i = 1; i < observatii.Count; i++)
            {
                ponderi.Add(observatii[i] / observatii[i-1]);
            }

        }

        public void Adauga(double val)
        {
           observatii.Add(val);
            CalculIndici();
            dateModif?.Invoke();
        }

        public void Modifica(int index, double val)
        {
            if (index >= 0 && index < observatii.Count)
            {
                observatii[index] = val;
                CalculIndici();
                dateModif?.Invoke();
            }
        }

        public void Sterge(int index)
        {
            if (index >= 0 && index < observatii.Count)
            {
                observatii.RemoveAt(index);
                CalculIndici();
                dateModif?.Invoke();
            }
        }

        public List<double> Observatii { get => observatii; }
        public List<double> Ponderi { get => ponderi; }
    }
}
