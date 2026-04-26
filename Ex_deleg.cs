using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex_Delegat
{
    internal class Program
    {
        //delegate int Delegat_opa(int a, int b); 
        static void Main(string[] args)
        {
            int aduna(int a, int b) => a + b;
            Func<int,int,int> ob_func = new Func<int, int, int>(aduna);
            ob_func += (x, y) => x - y;
            foreach(Func<int, int, int> f in ob_func.GetInvocationList())
                        Console.WriteLine(f(10, 7));

        }
    }
}
