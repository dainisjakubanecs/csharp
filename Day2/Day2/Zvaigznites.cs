using System;
using System.Collections.Generic;
using System.Text;

namespace Day2
{
    class Zvaigznites
    {
        public Zvaigznites()
        {

        }

        public static void ZvaignisuSkaits()
        {
            String zvaigznite = "";
            for (int i = 0; i < 4; i++)
            {
                zvaigznite += "*";
                Console.WriteLine(zvaigznite);
            }

        }
        public static void ZvaignisuSkaits2()  // šis variants ir labāks, jo nav jāsaglabā mainīgais
        {
            
            for (int i = 1; i < 5; i++)
            { 
                for(int j = 0; j < i; j++)
                {
                    Console.Write("*");

                }
                Console.WriteLine();    
               
            }

        }

    }
}
