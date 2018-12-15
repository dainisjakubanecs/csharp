using System;

namespace Day2Homework
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ievadiet skaitli a");
            String a = Console.ReadLine();
            double x = Convert.ToDouble(a);

            Console.WriteLine("Ievadiet operatoru");
            String oper = Console.ReadLine();

            Console.WriteLine("Ievadiet skaitli b");
            String b = Console.ReadLine();
            double y = Convert.ToDouble(a);


            Calculator calculator = new Calculator(x, oper, y);

            //double skaitlis1 = calculator.typeNumber();
            //double skaitlis2 = calculator.typeNumber();

            Console.WriteLine("Rezultāts ir " + calculator.result());
            Console.ReadLine();
        }
    }
}
