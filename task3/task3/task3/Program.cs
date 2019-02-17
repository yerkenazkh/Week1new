using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task3
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());//кол-во элементов в массиве
            int[] a = new int[n];//создаем массив
            for (int i = 0; i < n; i++)//заполняем массив
            {
                int b = Convert.ToInt32(Console.ReadLine());
                a[i] = b;
            }
            for (int i = 0; i < n; i++)//заполняем массив повторяя его элементы
                Console.Write(a[i] + " " + a[i] + " ");
        }
    }
}
