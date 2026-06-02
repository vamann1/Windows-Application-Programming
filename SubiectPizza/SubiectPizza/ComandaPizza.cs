using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SubiectPizza
{
    [Serializable]
    public class ComandaPizza : ICustomizabil, ICloneable
    {
        private string nume;
        private string blat;
        private int durataRealizare;
        List<Topping> topping;
        private static readonly double costPizzaBaza = 40;

        public ComandaPizza(string nume, string blat, int durataRealizare, List<Topping> topping)
        {
            this.nume = nume;
            this.blat = blat;
            this.durataRealizare = durataRealizare;
            this.topping = topping;
        }

        public ComandaPizza()
        {
        }

        public string Nume { get => nume; set => nume = value; }
        public int DurataRealizare { get => durataRealizare; set => durataRealizare = value; }
        public string Blat { get => blat; set => blat = value; }
        public List<Topping> Topping { get => topping; set => topping = value; }

        public Topping this[int index]
        {
            get => topping[index];
        }

        public object Clone()
        {
            return nume.Clone();
        }

        public double CalculCostPizza()
        {
            double cost = costPizzaBaza;
            foreach (Topping iterator in topping) {
                cost += iterator.Cantitate * iterator.Pret;
            }

            return cost;
        }

        public static bool operator <(ComandaPizza cp1, ComandaPizza cp2)
        {
            if (cp1.CalculCostPizza() < cp2.CalculCostPizza())
                return true;
            else return false;
        }

        public static bool operator >(ComandaPizza cp1, ComandaPizza cp2)
        {
            if (cp1.CalculCostPizza() > cp2.CalculCostPizza())
                return true;
            return false;
        }


    }

}
