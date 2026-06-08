using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sub4_2026
{
    public class ColectivitateStatistica
    {
        private List<double> observatii;
        private List<int> frecvente;
        private double medie;

        public event EventHandler ColectivitateModificata;

        public void OnColectivitateModificata()
        {
            calculMedie();
            ColectivitateModificata?.Invoke(this, EventArgs.Empty);
        }

        public ColectivitateStatistica()
        {
            observatii = new List<double>();
            frecvente = new List<int>();

        }

        public ColectivitateStatistica(List<double> observatii, List<int> frecvente)
        {
            this.observatii = observatii;
            this.frecvente = frecvente;
        }

        public List<double> Observatii { get => observatii; set => observatii = value; }
        public List<int> Frecvente { get => frecvente; set => frecvente = value; }
        public double Medie { get => medie; }

        public void calculMedie()
        {
            int sum = 0;
            this.medie = 0;
            for (int i = 0; i < this.observatii.Count; i++)
            {
                sum += frecvente[i];
                this.medie += this.observatii[i] * this.frecvente[i];
            }
            this.medie = this.medie / sum;
        }


    }
}
