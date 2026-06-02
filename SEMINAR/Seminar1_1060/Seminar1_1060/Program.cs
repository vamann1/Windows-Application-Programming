using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Seminar1_1060
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello world");

            Console.WriteLine("Numar argumente: " + args.Length);

            for (int i = 0; i < args.Length; i++)
            {
                Console.WriteLine(args[i]);
            }

            //Console.WriteLine("Introduceti nume: ");
            //string nume = Console.ReadLine();
            //Console.WriteLine("Introduceti varsta: ");
            //int varsta = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("Persoana " + nume + " are varsta " + varsta);
            //Console.WriteLine("Persoana {0} are varsta {1}", nume, varsta);
            //Console.WriteLine($"Persoana {nume} are varsta {varsta}");

            //int[] v1 = new int[3];
            //int[] v1 = { 1, 2, 3, 4 };
            int[] v1 = new int[3] {1, 2, 3};

            for(int i = 0; i < v1.Length;i++)
            {
                Console.Write(v1[i]);
            }

            //shallow copy
            //int[] v2 = v1;
            int[] v2 = (int[])v1.Clone();

            //foreach(int v in v2)
            foreach(var v in v2)
            {
                Console.Write("{0} ", v);
            }

            //deep copy
            int[] v3 = new int[v1.Length];
            for(int i = 0;i < v1.Length;i++)
            {
                v3[i] = v1[i];
            }

            Console.WriteLine();
            int[,] m1 = new int[3, 3] { { 1, 2, 3 }, { 4, 5, 6 }, { 7, 8, 9 } };
            for(int i = 0; i<m1.GetLength(0);i++)
            {
                for(int j = 0; j < m1.GetLength(1);j++)
                {
                    Console.Write("{0} ", m1[i, j]);
                }
                Console.WriteLine();
            }

            int[][] m2 = new int[2][];
            m2[0] = new int[2] { 1, 2 };
            m2[1] = new int[3] { 1, 2, 3 };
            for (int i = 0; i < m2.Length; i++)
            {
                for (int j = 0; j < m2[i].Length; j++)
                {
                    Console.Write("{0} ", m2[i][j]);
                }
                Console.WriteLine();
            }
        }
    }
}
