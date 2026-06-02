using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proiect_Vaman_Mircea_George
{
    [Serializable]
    public class Raion : EntitateComerciala, ICloneable, IComparable
    {
        private string categorie;
        private List<Produs> produse;

        public Raion() : base()
        {
            categorie = string.Empty;
            produse = new List<Produs>();
        }

        public Raion(int id, string nume, string categorie) : base(id, nume)
        {
            this.categorie = categorie;
            produse = new List<Produs>();
        }

        public string Categorie { get => categorie; set => categorie = value; }
        public List<Produs> Produse { get => produse; set => produse = value; }

        public void AdaugaProdus(Produs p)
        {
            produse.Add(p);
        }

        public override string Descriere()
        {
            return $"Raion {nume} - categoria {categorie} ({produse.Count} produse)";
        }

        public override string ToString()
        {
            return $"{id} | {nume} | {categorie}";
        }

        public object Clone()
        {
            return new Raion(id, nume, categorie);
        }

        // compara dupa nr de produse din raion
        public int CompareTo(object obj)
        {
            if (obj is Raion r)
                return produse.Count.CompareTo(r.produse.Count);
            return -2;
        }
    }
}
