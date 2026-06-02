using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SubPersoana
{
    internal class Persoana
    {
        private string nume;
        private string prenume;
        private int varsta;

        public Persoana(string nume, string prenume, int varsta)
        {
            this.nume = nume;
            this.prenume = prenume;
            this.varsta = varsta;
        }

        public string Nume {
            get => nume;
            set 
            {
                if (value.Length>=3)
                    nume = value; 
            }
        }
        public string Prenume { 
            get => prenume;
            set
            {
                if(value.Length>=3)
                    prenume = value;
            }
        }
        public int Varsta {
            get => varsta;
            set
            {
                if(value>=0)
                    varsta = value;
            }
        }


        public override string ToString()
        {
            return "Nume: " + nume + " Prenume: " + prenume + " Varsta: " + varsta;
        }
    }
}
