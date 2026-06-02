using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proiect_Vaman_Mircea_George
{
    [Serializable]
    public class Vanzare : IFacturabil
    {
        private int id;
        private string numeProdus;
        private int cantitate;
        private double pretUnitar;
        private DateTime data;

        public Vanzare()
        {
            id = 0;
            numeProdus = string.Empty;
            cantitate = 0;
            pretUnitar = 0;
            data = DateTime.Now;
        }

        public Vanzare(int id, string numeProdus, int cantitate, double pretUnitar, DateTime data)
        {
            this.id = id;
            this.numeProdus = numeProdus;
            this.cantitate = cantitate;
            this.pretUnitar = pretUnitar;
            this.data = data;
        }

        public int Id { get => id; set => id = value; }
        public string NumeProdus { get => numeProdus; set => numeProdus = value; }
        public int Cantitate { get => cantitate; set => cantitate = value; }
        public double PretUnitar { get => pretUnitar; set => pretUnitar = value; }
        public DateTime Data { get => data; set => data = value; }

        // proprietati calculate, folosite in FormDetaliiVanzare prin data binding
        public double ValoareTotala => cantitate * pretUnitar * 1.19;
        public double TVACalculat => cantitate * pretUnitar * 0.19;

        public double CalculeazaTVA()
        {
            return cantitate * pretUnitar * 0.19;
        }

        public double ValoareFinala()
        {
            return cantitate * pretUnitar * 1.19;
        }

        public override string ToString()
        {
            return $"{id} | {data:dd-MM-yyyy} | {numeProdus} x {cantitate} | {pretUnitar} RON";
        }
    }
}
