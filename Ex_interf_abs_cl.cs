using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex_interf_abs
{
    interface IFigura
    {
        int get_arie();
        int Perimetru {  get; }
    }

    abstract class Figura : IFigura
    {
        protected int lat;
        public Figura(int flat) { lat = flat; }
        protected abstract int calcul_perimetru();
        protected abstract int calcul_arie();
        public int Perimetru => calcul_perimetru();
        public int get_arie()   => calcul_arie(); 
        public override string ToString() => $"{Tip_FG} are Perimetru: {Perimetru} aria: {calcul_arie()}";     
        public string Tip_FG => this.GetType().Name;
    }

    class Patrat : Figura
    {
        public Patrat(int flat) : base(flat) { }
        protected override int calcul_arie() => lat * lat;
        protected override int calcul_perimetru() => 4 * lat;
        public static Patrat operator+(Patrat p1, Patrat p2) =>
            new Patrat(p1.lat + p2.lat);
    }

    class Dreptunghi : Figura
    {
        int lung;
        public Dreptunghi(int flat, int flung) : base(flat) { lung = flung; }
        protected override int calcul_arie() => lat * lung;
        protected override int calcul_perimetru() => 2 * lat + 2 * lung;
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Figura obp = new Patrat(10), obd = new Dreptunghi(4, 5);
            Console.WriteLine(obp + "\n" + obd);
            Patrat obp1 = new Patrat(3), prez;
            prez = (Patrat)obp + obp1;
            Console.WriteLine(prez);
        }
    }
}
