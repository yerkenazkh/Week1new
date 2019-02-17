using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task1
{
    class Program
    {
        static public bool Prime(int b) // function which determine prime number
        {
            if (b == 1) return false;
            for (int i = 2; i < b; i++)
            {
                if (b % i == 1) return false;//if the number will have reminder 0, when it devide to number between 2 and b, it will return false
            }
            return true;
        }
        static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());//insert string and convert to int
            int[] a = new int[n];//create new massive
            int cnt = 0;// counter is equal to zero
            for (int i = 0; i < n; i++)//by cycle fill the massive
            {
                int b = Convert.ToInt32(Console.ReadLine());
                a[i] = b;
            }
            for (int i = 0; i < n; i++)//if it is a prime numder, counter will increase to 1 and write those numbers
            {
                if (Prime(a[i]))
                    cnt++;//the number of prime numbers
            }
            Console.WriteLine(cnt);
            for (int i = 0; i < n; i++)
            {
                if (Prime(a[i]));
                Console.Write(a[i] + " ");//the prime numbers
            }
        }
    }
}
