using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SubAngajat
{
    
    internal class Angajat: ITtotalSalariu
    {
        private string nume;
        private int oreLucrate;
        private float salariuOrar;
        private float salariuLunar;

        private const string membruConstant = "A";
        public static int nrAngajati = 0;
        private string matricol = "A1";


        public void calculeazaSalariuTotal()
        {
           salariuLunar = oreLucrate * salariuOrar;  // formula din enunț
        }
        public Angajat(string nume, int oreLucrate, float salariuOrar)
        {
            this.nume = nume;
            this.oreLucrate = oreLucrate;
            this.salariuOrar = salariuOrar;
            nrAngajati++;
        }

        public string Nume { get => nume; set => nume = value; }
        public int OreLucrate { get => oreLucrate; set => oreLucrate = value; }
        public float SalariuOrar { get => salariuOrar; set => salariuOrar = value; }
        public float SalariuLunar { get => salariuLunar; set => salariuLunar = value; }
        public static string MembruConstant => membruConstant;
        public string Matricol { get => matricol; set => matricol = value; }

        public override string ToString()
        {
            return "Angajatul " + nume + " a lucrat " + oreLucrate + " ore " + "cu un salariu orar de " + salariuOrar;
        }
    }
}

