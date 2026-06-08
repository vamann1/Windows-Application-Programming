using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Sub1_2026
{
    internal class ColectivitateStatistica
    {
        private string nume;
        private List<double> observatii;
        private List<double> indici;

        public event EventHandler DateModificate;

        public void NotificaSchimbare()
        {
            calculIndici();
            DateModificate?.Invoke(this, EventArgs.Empty);
        }

        public ColectivitateStatistica()
        {
        }

        public ColectivitateStatistica(string nume, List<double> observatii)
        {
            this.nume = nume;
            this.observatii = observatii;
            calculIndici();
        }

        public void calculIndici()
        {
            this.indici = new List<double>();
            for (int i = 0; i < this.observatii.Count; i++)
            {
                double indice = this.observatii[i]/this.observatii[0];
                this.indici.Add(indice);
            }
        }

        public List<double> Observatii { get => observatii; set => observatii = value; }
        public string Nume { get => nume; set => nume = value; }
        public List<double> Indici { get => indici; }
    }
}
