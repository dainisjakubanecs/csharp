using System;
using System.Collections.Generic;
using System.Text;

namespace Homework
{
    class Calculator
    {
        double a;
        String op;
        double b;
        String c;
        String d;
        String e;


        public Calculator()
        {           
            //this.a = a;
            //this.op = op;
            //this.b = b;
        }
        /*public double typeNumber()
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
        */

        public double result()
        {
            Console.WriteLine("Ievadiet skaitli a");
            c = Console.ReadLine();
            a = Convert.ToDouble(c);

            Console.WriteLine("Ievadiet operatoru");
            op = Console.ReadLine();

            Console.WriteLine("Ievadiet skaitli b");
            d = Console.ReadLine();
            b = Convert.ToDouble(d);
            //e = Console.ReadLine();

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
            while (e != "exit")
            {               
                Console.WriteLine("Rezultāts ir " + result());                
                e = Console.ReadLine();
            }            
        }
    }
}

