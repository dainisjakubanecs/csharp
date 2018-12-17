using System;
using System.Collections.Generic;
using System.Text;

namespace Day3
{
    class Piemeri
    {
        public void MasivaPirmaisPiemers()
        {
            int skaitlis = 4;
            int[] masivs = new int[skaitlis];
            masivs[0] = 1;
            masivs[1] = 4;
            masivs[2] = 5;

            int garums = masivs.Length;

            for(int i = 0; i < masivs.Length; i++)
            {
                masivs[i] = 99;
            }
        }

        public void MasivaOtraisPiemers (int a)
        {
            String[] masivs = new String[a];
                       
            for (int i = 1; i < masivs.Length; i++)
            {
                if (i == 0)
                {
                    masivs[i] = "*";                   
                }
                else
                {
                    masivs[i] = masivs[i - 1] + "*";
                    Console.WriteLine(masivs[i]);
                }                                                              
            }
            for (int i = a - 2; i >= 0; i--)
            {               
                Console.WriteLine(masivs[i]);
            }

        }

        public void MasivaTresaisPiemers()
        {
            Console.WriteLine("Ievadiet masiva garumu!");
            int garums = Convert.ToInt16(Console.ReadLine());
            String[] masivs = new String[garums];
           

            for (int i = 0; i < masivs.Length; i++)
            {
                Console.WriteLine("Ievadiet masīva " + i + "." + " elementu!");
                masivs[i] = Console.ReadLine();
            }
            for(int i = 0; i < masivs.Length; i++)
            {
                Console.WriteLine("Masiva " + i + "." + " elements ir " + masivs[i]);
            }

        }
            
            
        }
    }

