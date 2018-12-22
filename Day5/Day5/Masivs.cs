using System;
using System.Collections.Generic;
using System.Text;

namespace Day5
{
    class Masivs
    {
        public void MasivaVertibasPozitivasVaiNegativas()
        {
            Console.WriteLine("Ievadiet masīva garumu:");
            int masivaGarums = Convert.ToInt16(Console.ReadLine());

            int[] arr = new int[masivaGarums];

            for(int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine("Ievadiet masīva " + i + ". elementu");
                arr[i] = Convert.ToInt16(Console.ReadLine());
            }

            for(int i = 0; i < arr.Length; i++)
            {
                if(arr[i] > 0)
                {
                    arr[i] = 1;
                }
                else if (arr[i] < 0)
                {
                    arr[i] = 2;
                }
                else
                {
                    arr[i] = 0;
                }
                Console.Write(arr[i] + " ");
            }
        }

        public void MasivaElementi()
        {
            Console.WriteLine("Ievadiet masīva garumu:");
            int x = Convert.ToInt16(Console.ReadLine());

            int[] arr = new int[x];

            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine("Ievadiet masīva " + i + ". elementu");
                arr[i] = Convert.ToInt16(Console.ReadLine());
            }

            int skaits = 0;
            for(int i = 0; i < arr.Length; i++)
            {             
                if(arr[i] > 0 && arr[i] < 10)
                {                   
                    skaits ++; 
                }               
            }
            Console.WriteLine("Elementu skaits, kas ir lielāki par 0 un mazāki par 10, ir: " + skaits);
        }

        public void VaiIrAugosaSeciba()
        {
            Console.WriteLine("Ievadiet masīva garumu:");
            int x = Convert.ToInt16(Console.ReadLine());

            int[] arr = new int[x];

            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine("Ievadiet masīva " + i + ". elementu");
                arr[i] = Convert.ToInt16(Console.ReadLine());
            }

            bool navAugosa = false;
            for(int i = 0; i < arr.Length-1; i++)
            {
                if (arr[i] > arr[i + 1])
                {
                    navAugosa = true;                  
                    break;
                }                                
            }
            if(!navAugosa)
            {
                Console.WriteLine("Skaitļi ir augošā secībā");
            } else
            {
                Console.WriteLine("Skaitļi nav augošā secībā");
            }       
        }
    }
}
