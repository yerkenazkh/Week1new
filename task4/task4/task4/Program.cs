using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task4
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());//размр двумерного массива
            int[,] a = new int[n, n];// создаем двумерный массив
            for (int i = 0; i < n; i++)//через цикл заполняем массив
            {
                for(int j = 0; j <= i; j++)
                {
                    Console.Write("[*]");
                }
                Console.WriteLine();
            }
        }
    }
}
