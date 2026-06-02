using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SubAngajat
{
    internal class Firma
    {
        private string numeFirma;
        private List<Angajat> listaAngajati;

        public Firma(string numeFirma)
        {
            this.numeFirma = numeFirma;
            this.listaAngajati = new List<Angajat>();
        }

        public string NumeFirma { get => numeFirma; set => numeFirma = value; }
        internal List<Angajat> ListaAngajati { get => listaAngajati; set => listaAngajati = value; }

        public override string ToString()
        {
            string afisare = "Nume firma: " + numeFirma + "\nAngajati: ";

            for (int i = 0; i < listaAngajati.Count; i++)
            {
                afisare += "\n" + listaAngajati[i].Nume;
            }
            return afisare;
        }

        public static Firma operator +(Firma firma, Angajat ang)
        {
            if (firma == null) throw new ArgumentException(nameof(firma));
            if (firma.listaAngajati == null)
            {
                firma.listaAngajati = new List<Angajat>();
            }
            firma.listaAngajati.Add(ang);
            return firma;
        }

        public Angajat this[int index]
        {
            get
            {
                if (index < 0 || index >= listaAngajati.Count)
                {
                    MessageBox.Show("Index invalid!");
                    return null;
                }
                return listaAngajati[index];
            }
        }
    }
}
