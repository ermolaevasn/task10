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
            int n,m,k,max=1;
            Console.WriteLine("Введите количество чисел n"); //ввод количества чисел последовательности
            n = Convert.ToInt32(Console.ReadLine());
            Proverka("длина последовательности",ref n);// проверка ввода длины
            int[] mas = new int[n];

            for (int i = 0; i < n; i++)//ввод чисел с проверкой
            {               
                Vvod("число "+(i+1),out mas[i]);

            }
           
            for (int i = 0; i < n-1; i++)//проверка на монотонность
            {
                if (mas[i+1]>=mas[i]) max++;
            }

            if (max == n)//вывод последовательности, если упорядочена
            {
                Console.WriteLine("Последовательность упорядочена по неубыванию");
                for (int i = 0; i < n; i++)
                    Console.Write(mas[i] + "  ");
            }
            else
            {
                k = n - 1;//вывод, если не упорядочена 
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
                Console.WriteLine("Последовательность не упорядочена");
                for (int i = 0; i < n; i++)
                    Console.Write(mas[i] + "  ");
            }
            Console.ReadKey();
        }
        static void Proverka(string s, ref int a)//функция, для проверки ввода длины послдед-ти
        {
            bool ok = false;
            string buf;
            do
            {
                if (a > 0) ok = true;
                else
                {
                    if (!ok) Console.WriteLine("\aВведите " + s + " заново");
                    Console.Write(s + " = ");
                    buf = Console.ReadLine();
                    ok = Int32.TryParse(buf, out a);
                    ok = false;
                }
            } while (!ok);
        }
        static double Vvod(string s, out int l)//функция, для проверки чисел последовательности
        {
            bool ok;
            string buf;
            do
            {
                Console.Write(s + " = ");
                buf = Console.ReadLine();
                ok = Int32.TryParse(buf, out l);
                if (!ok) Console.WriteLine("Введите " + s + " заново");
            } while (!ok);
            return l;
        }
    }
}
