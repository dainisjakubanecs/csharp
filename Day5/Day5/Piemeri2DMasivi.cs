using System;
using System.Collections.Generic;
using System.Text;

namespace Day5
{
    class Piemeri2DMasivi
    {
        public void PirmaisDivDMasivs()
        {
            int[,] a = new int[3,3];

            for(int i = 0; i < 3; i++)        // definīcija
            {
                for (int j = 0; j < 3; j++)
                {
                    a[i, j] = 1;                   
                }                
            }

            for(int i = 0; i < 3; i++)   // izvade
            {
                for (int j = 0; j < 3; j++)
                {
                    Console.Write(a[i, j] + " ");
                }
                Console.WriteLine();
            }
        }
    }
}
