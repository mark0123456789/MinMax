using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MinMax
{
    internal class Program
    {
        public static void MinMax(int[] bekertszam, out int min, out int max)
        {
            min = bekertszam[0];
            max = bekertszam[0];
            for (int i = 0; i < bekertszam.Length; i++)
            {
                if (bekertszam[i] < min)
                {
                    min = bekertszam[i];
                }
                if (bekertszam[i] > max)
                {
                    max = bekertszam[i];
                }
            }
        }

        static void Main(string[] args)
        {
            var bekertszam = new int[] { 1, 2, 3, 4, 5, 6 };

            int min;
            int max;


            MinMax(bekertszam, out min, out max);
            Console.WriteLine("Minimum: {0}, Maximum:{1}", min, max);
            Console.ReadKey();


        }
    }
}