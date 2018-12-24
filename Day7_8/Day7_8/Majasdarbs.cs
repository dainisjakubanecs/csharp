using System;
using System.Collections.Generic;
using System.Text;

namespace Day7_8
{
    class Majasdarbs
    {
        public void DzejolisNolasit()
        {
            String[] lines = System.IO.File.ReadAllLines(@"C:\Users\Dainis\Desktop\dzejolis.txt");

            for(int i = 0; i < lines.Length; i++)
            {              
                Console.WriteLine(lines[i]);
            }

            Console.WriteLine();

            String[] reverseLines = new String[lines.Length];

            for (int i = 0; i < lines.Length; i++)
            {
                reverseLines[i] = lines[lines.Length - 1 - i];
                Console.WriteLine(reverseLines[i]);
            }

            Console.WriteLine();

            using (System.IO.StreamWriter file =
            new System.IO.StreamWriter(@"C:\Users\Dainis\Desktop\dzejolis2.txt"))
            {
                for (int i = 0; i < lines.Length; i++)
                {
                    file.WriteLine(reverseLines[i]);
                }
            }
        }
        
    }
}
