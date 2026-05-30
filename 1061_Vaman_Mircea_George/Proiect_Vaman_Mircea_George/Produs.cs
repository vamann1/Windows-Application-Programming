using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proiect_Vaman_Mircea_George
{
    [Serializable]
    public class Produs
    {
        private int id;
        private string nume;
        private string categorie;
        private double pret;
        private int stoc;

        public Produs()
        {
            id = 0;
            nume = string.Empty;
            categorie = string.Empty;
            pret = 0;
            stoc = 0;
        }

        public Produs(int id, string nume, string categorie, double pret, int stoc)
        {
            this.id = id;
            this.nume = nume;
            this.categorie = categorie;
            this.pret = pret;
            this.stoc = stoc;
        }

        public int Id { get => id; set => id = value; }
        public string Nume { get => nume; set => nume = value; }
        public string Categorie { get => categorie; set => categorie = value; }
        public double Pret { get => pret; set => pret = value; }
        public int Stoc { get => stoc; set => stoc = value; }

        public override string ToString()
        {
            return $"{id} | {nume} | {categorie} | {pret} RON | stoc: {stoc}";
        }

        // creste stocul cu 1
        public static Produs operator ++(Produs p)
        {
            p.stoc++;
            return p;
        }

        // scade stocul cu 1
        public static Produs operator --(Produs p)
        {
            p.stoc--;
            return p;
        }

        // cast explicit - returneaza valoarea totala a stocului
        public static explicit operator decimal(Produs p)
        {
            return (decimal)(p.pret * p.stoc);
        }

        // true daca stocul e 0
        public static bool operator !(Produs p)
        {
            return p.stoc == 0;
        }
    }
}
