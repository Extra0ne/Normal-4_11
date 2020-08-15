using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Normal_4_11
{
    class Program
    {
        static void Main(string[] args)
        {
            int size = 0;
            Console.Write("Введите размер массива-> ");
            size = Convert.ToInt32(Console.ReadLine());
            int[] number = new int[size];

            Random r = new Random();
            for (int i = 0; i < number.Length; i++)
            {
                number[i] = r.Next(-100, 100);
                Console.Write(number[i] + " ");
            }
            for (int i = 0; i < number.Length; i++)
            {
                if (number[i] % 2 == 0)
                {
                    Console.Write("\nЧетные числа :{0} ", number[i]);
                }
            }
            for (int i = 0; i < number.Length; i++)
            {
                if (number[i] % 2 != 0)
                {
                    Console.Write("\nНе четные числа: {0} ", number[i]);
                }
            }
            Console.ReadKey();
        }
    }
}
