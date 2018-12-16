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
              
        public double result()
        {
            Console.WriteLine("Ievadiet skaitli a");           
            a = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Ievadiet operatoru");
            operators = Console.ReadLine();

            Console.WriteLine("Ievadiet skaitli b");
            
            b = Convert.ToDouble(Console.ReadLine());
            

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
                            Console.WriteLine("Nedrīkst dalīt ar nulli!");
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
                Console.WriteLine("Rezultāts ir " + result());                                
            }
            while (!(Console.ReadLine().Equals("exit"))) ;
        }
    }
}

