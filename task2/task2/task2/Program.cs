using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TASK2
{
    class Info//create new class which have 3 variables
    {
        string name;
        string surname;
        public int age;
        public Info(string n, string s)//new function/method
        {
            name = n;//приравниваем значения переменных из класса Студент к значениям переменных функции
            surname = s;
        }
        public void data() // fill the information of student(новый метод/функция)
        {
            Console.WriteLine("Name: " + name + "\n" + "Surname: " + id);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Write name: ");//вводим данные студента
                string sName = Console.ReadLine();
            Console.WriteLine("Write Surname: ");
            string sSurname = Console.ReadLine();
            Console.WriteLine("Write age: ");
            int sYear;
            string num = Console.ReadLine();
            sYear = Convert.ToInt32(num);
            Student s = new Student(sName, sId);// конструктор с параметрами
            s.data();//через созданный метод выводим на консоль имя и айди студента
            Console.WriteLine("Next year of study:" + s.Nextyear(sYear));//выводим след год обучения
        }
    }
}
