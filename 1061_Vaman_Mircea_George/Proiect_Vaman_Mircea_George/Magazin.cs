using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proiect_Vaman_Mircea_George
{
    [Serializable]
    public class Magazin : EntitateComerciala, ICloneable, IComparable
    {
        private string oras;
        private string adresa;
        private List<Raion> raioane;

        public Magazin() : base()
        {
            oras = string.Empty;
            adresa = string.Empty;
            raioane = new List<Raion>();
        }

        public Magazin(int id, string nume, string oras, string adresa) : base(id, nume)
        {
            this.oras = oras;
            this.adresa = adresa;
            raioane = new List<Raion>();
        }

        public string Oras { get => oras; set => oras = value; }
        public string Adresa { get => adresa; set => adresa = value; }
        public List<Raion> Raioane { get => raioane; set => raioane = value; }

        public override string Descriere()
        {
            return $"Magazinul {nume} din {oras} are {raioane.Count} raioane";
        }

        public override string ToString()
        {
            return $"{id} | {nume} | {oras} | {adresa}";
        }

        // indexer pentru acces direct la raioane
        public Raion this[int index]
        {
            get { return raioane[index]; }
            set { raioane[index] = value; }
        }

        public object Clone()
        {
            return new Magazin(id, nume, oras, adresa);
        }

        // compara dupa nume
        public int CompareTo(object obj)
        {
            if (obj is Magazin m)
                return nume.CompareTo(m.nume);
            return -2;
        }

        // adauga un raion in magazin
        public static Magazin operator +(Magazin m, Raion r)
        {
            m.raioane.Add(r);
            return m;
        }

        // sterge un raion din magazin
        public static Magazin operator -(Magazin m, Raion r)
        {
            m.raioane.Remove(r);
            return m;
        }
    }
}
