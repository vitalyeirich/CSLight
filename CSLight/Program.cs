using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSLight
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("### Анкета ###\n");

            Console.Write("Как вас зовут?\n");
            string name = Console.ReadLine();

            Console.Write("\nСколько Вам лет?\n");
            int age = Convert.ToInt32(Console.ReadLine());

            Console.Write("\nКто вы по профессии?\n");
            string profession = Console.ReadLine();

            Console.WriteLine();
            Console.WriteLine("### Информация о Вас ###");
            Console.WriteLine("Вас зовут " + name + ", вам: " + age + " года/лет, вы " + profession + ".");

            Console.ReadLine();
        }
    }
}