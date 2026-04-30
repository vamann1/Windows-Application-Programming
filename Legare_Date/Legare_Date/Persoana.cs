using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Legare_Date
{
    public class Persoana
    {
        public Persoana() { }
        public Persoana(int marca, string nume)
        {
            this.marca = marca;
            this.nume = nume;
        }

        public int marca { get; set; }
        public string nume { get; set; }

    }
}
