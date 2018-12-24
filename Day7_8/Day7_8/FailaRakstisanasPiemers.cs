using System;
using System.Collections.Generic;
using System.Text;

namespace Day7_8
{
    class FailaRakstisanasPiemers
    {
        public void Rakstit(List<String> lines)
        {
            using (System.IO.StreamWriter file =
            new System.IO.StreamWriter(@"C:\Users\Dainis\Desktop\WriteLines2.txt"))
            {
                foreach (string line in lines)
                {
                    // If the line doesn't contain the word 'Second', write the line to the file.
                    if (!line.Contains("Second"))
                    {
                        file.WriteLine(line);
                    }
                }
            }
        }

        public void LasitSaskaitit()
        {
            // ielasam rindas no faila masiva
            // tas būs string tipa masīvs, konvertējam uz int
            // saskaitam a + b

            // Read each line of the file into a string array. Each element
            // of the array is one line of the file.
            String[] lines = System.IO.File.ReadAllLines(@"C:\Users\Dainis\Desktop\WriteLines2.txt");

            // Display the file contents by using a foreach loop.
            Console.WriteLine("Contents of WriteLines2.txt = ");
            foreach (string line in lines)
            {
                // Use a tab to indent each line of the file.
                Console.WriteLine(line);
            }

            Console.WriteLine();

            
            int summa = 0;
            for(int i = 0; i < lines.Length; i++)
            {                
                summa += Convert.ToInt16(lines[i]);               
            }
            Console.WriteLine("Summa ir " + summa);


        }
    }
}
