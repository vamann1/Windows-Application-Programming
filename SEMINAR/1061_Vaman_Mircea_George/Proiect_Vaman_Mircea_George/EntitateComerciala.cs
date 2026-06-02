using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proiect_Vaman_Mircea_George
{
    [Serializable]
    public abstract class EntitateComerciala
    {
        protected int id;
        protected string nume;

        public EntitateComerciala()
        {
            id = 0;
            nume = string.Empty;
        }

        public EntitateComerciala(int id, string nume)
        {
            this.id = id;
            this.nume = nume;
        }

        public int Id { get => id; set => id = value; }
        public string Nume { get => nume; set => nume = value; }

        // fiecare clasa derivata trebuie sa implementeze asta
        public abstract string Descriere();
    }
}
