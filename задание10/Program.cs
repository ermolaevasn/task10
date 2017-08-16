using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace задание10
{
    class Program
    {
        static void Main(string[] args)
        {
            int n,m,k;
            Console.WriteLine("Введите количество чисел n");
            n = Convert.ToInt32(Console.ReadLine());
            int[] mas = new int[n];
            for (int i = 0; i < n; i++)
            {
                Console.Write("Введите число "+(i+1)+": ");
                mas[i] = Convert.ToInt32(Console.ReadLine());
            }

            for (int i = 0; i < n; i++)
                Console.Write(mas[i]+"  ");

            k = n - 1;//если не упорядочен
            m = n - 1;
            for (int j = 0; j < n; j++)
            {
                m = mas[0];
                for (int i = 0; i < k; i++)
                {
                    mas[i] = mas[i + 1];  
                }
                mas[k] = m;
                  k--;
            }
            Console.WriteLine();
            for (int i = 0; i < n; i++)
                Console.Write(mas[i] + "  ");

            Console.ReadKey();

        }
    }
}
