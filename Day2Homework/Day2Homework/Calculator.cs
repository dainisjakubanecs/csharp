using System;
using System.Collections.Generic;
using System.Text;

namespace Day2Homework
{
    class Calculator
    {
        double a;
        String op;
        double b;


        public Calculator(double a, String op, double b)
        {
            this.a = a;
            this.op = op;
            this.b = b;
        }
        public double typeNumber()
        {
            Console.WriteLine("Ievadiet skaitli a");
            String a = Console.ReadLine();


            return Convert.ToDouble(a);
        }

        public double typeNumber1()
        {
            Console.WriteLine("Ievadiet skaitli b");
            String b = Console.ReadLine();

            return Convert.ToDouble(b);
        }

        public String operators()
        {
            Console.WriteLine("Ievadiet operatoru");
            String a = Console.ReadLine();

            return a;
        }

        public double result()
        {
            switch (op)
            {
                case "+":
                    {
                        return a + b;
                    }
                case "-":
                    {
                        return a - b;
                    }
                case "/":
                    {
                        if (b == 0)
                        {
                            Console.WriteLine("Nevar dalīt ar nulli!");
                            return 0;
                        }
                        else
                        {
                            return a / b;
                        }

                    }
                case "*":
                    {
                        return a * b;
                    }
            }
            return -9999;
        }

    }
}
