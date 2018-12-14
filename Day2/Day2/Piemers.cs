using System;
using System.Collections.Generic;
using System.Text;

namespace Day2
{
    class Piemers
    {
        public Piemers()
        {

        }
        public void TestaIzvade()
        {
            Console.WriteLine("vii");
        }
        public void TestaIzvade2()
        {
            Console.WriteLine("vii2");
        }
        public void Cikli()
        {
            //while, do...while, for
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("vii3");
            }

            String izvele = "";

            while (izvele != "iziet")
            {
                Console.WriteLine("Vai gribat iziet?");
                izvele = Console.ReadLine();
            }
            Console.WriteLine("Jūs esat izgājuši");


        }

    }
}

