using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SubiectBiciclete
{
    [Serializable]
    public class Bicicleta
    {
        private readonly int codB;
        private string denumireStatieParcare;
        private static int contor = 0;
        private int kmParcursi;

        public int CodB => codB;

        public string DenumireStatieParcare { get => denumireStatieParcare; set => denumireStatieParcare = value; }
        public int KmParcursi { get => kmParcursi; set => kmParcursi = value; }

        public Bicicleta(string denumireStatieParcare, int kmParcursi)
        {
            this.denumireStatieParcare = denumireStatieParcare;
            this.kmParcursi = kmParcursi;
            codB = ++contor;
        }

        public Bicicleta()
        {
        }

        public override string ToString()
        {
            return this.denumireStatieParcare;
        }
    }
}
