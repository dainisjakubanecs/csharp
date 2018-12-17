using System;
using System.Collections.Generic;
using System.Text;

namespace Homework
{
    class Calculator
    {
        double a;
        String operators;
        double b;              

        public Calculator()
        {           
            
        }

        public void ievade()
        {
            Console.WriteLine("Ievadiet skaitli a");
            a = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Ievadiet operatoru");
            operators = Console.ReadLine();

            Console.WriteLine("Ievadiet skaitli b");
            b = Convert.ToDouble(Console.ReadLine());

        }

        public double result()
        {           
            switch (operators)
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
                case "^":
                    {
                        double temp = 1;
                        for (double i = 0; i < b; i++)
                        {
                            temp = a * temp;
                        }
                        return temp;
                    }
            }
            return -9999;
        }

        public void result2()
        {           
            do
            {
                ievade();
                if(result() != 0 && result() != -9999)
                {
                    Console.WriteLine(a + operators + b + " = " + result());
                }
                else if (result() == -9999)
                {
                    Console.WriteLine("Ir izvēlēts nepareizs operators!");
                }
                else
                {
                    Console.WriteLine("Nedrīkst dalīt ar nulli!");
                }                            
            }
            while (!(Console.ReadLine().Equals("exit"))) ;
        }
    }
}

