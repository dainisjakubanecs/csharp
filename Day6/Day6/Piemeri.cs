using System;
using System.Collections.Generic;
using System.Text;

namespace Day6
{
    class Piemeri
    {
        public void Koordinatas()
        {
            //String tipa 2d masivs
            /*
             1 1 1
             2 2 2
             3 3 3
             */

            String[,] masivs = new String[3, 3];

            for(int i = 0; i < 3; i++)
            {
                for(int j = 0; j < 3; j++)
                {
                    masivs[i, j] = Convert.ToString(i + 1);                
                    Console.Write(masivs[i,j] + " ");
                }
                Console.WriteLine();
            }
            Console.WriteLine();

            int[] summa = new int[3];
            for(int i = 0; i < 3; i++)
            {
                for(int j = 0; j < 3; j++)
                {
                    summa[i] += Convert.ToInt16(masivs[i, j]);                     
                }
                Console.Write(summa[i] + " ");
            }               
        }

        public void SkaitluMasivs()
        {
            //int tipa 2d masivs
            // cilvēkam skaitli ir jāievada
            // pēc tam masīvu izvadam
            // ievadiet masiva vērtību (i,j)
            // skaitlis ir lielāks par 5 
            //ja rindā ir 2 vienādi skaitļi, tad aizstājam to skaitli ar nulli

            int[,] masivs = new int[3, 3];

            for (int i = 0; i < masivs.GetLength(0); i++)
            {
                for (int j = 0; j < masivs.GetLength(1); j++)
                {
                    Console.WriteLine("Ievadiet vērtību (" + i + ", " + j + ")");
                    masivs[i, j] = Convert.ToInt16(Console.ReadLine());                   
                }
            }
            Console.WriteLine();

            for (int i = 0; i < masivs.GetLength(0); i++)
            {
                for (int j = 0; j < masivs.GetLength(1); j++)
                {
                    Console.Write(masivs[i, j] + " ");
                }
                Console.WriteLine();
            }


            for (int i = 0; i < masivs.GetLength(0); i++)
            {
                for (int j = 0; j < masivs.GetLength(1); j++)
                {                   
                    for(int k = i + 1; k < masivs.GetLength(0); k++)
                    {
                        if (masivs[i, j] == masivs[k, j] && !(masivs[i, j] == 0))
                        {                            
                            masivs[i, j] = 0;                            
                            break;
                        }                       
                    }                                    
                }               
            }

            Console.WriteLine();

            for (int i = 0; i < masivs.GetLength(0); i++)
            {
                for (int j = 0; j < masivs.GetLength(1); j++)
                {
                    Console.Write(masivs[i, j] + " ");
                }
                Console.WriteLine();
            }

        }
    }
}
