using System;
using System.Collections.Generic;
using System.Text;

namespace Day9_10
{
    class Piemeri
    {
        // 1.izvadīt visus
        // 2.izvadīt to, kuru gribam(cilvēks ievada numuru, mēs izvadam rindiņas joku)
        // 3.Pievienot --> streamwriter pārraksta
        // B izvadam random joku
        // 0. iziet
        
        
        
        private List<String> saraksts = new List<String>();       

        public void Joke()
        {
            String ievade = "";

            while (!ievade.Equals("0"))
            {
                Console.WriteLine("Nospiediet 1, lai izvadītu visus jokus");
                Console.WriteLine("Nospiediet 2 , lai izvadītu to kuru gribam");
                Console.WriteLine("Nospiediet 3 , lai pievienotu jaunu");
                Console.WriteLine("Nospiediet 4 , lai random");
                Console.WriteLine("Nospiediet 5 , lai izdzēstu visu sarakstu");
                Console.WriteLine("Nospiediet 0 , lai izietu");
                ievade = Console.ReadLine();
                Console.WriteLine();
                
                switch (ievade)
                {
                    case "1":
                        IzvaditVisus();
                        break;
                    case "2":
                        IzvaditKuruGribam();
                        break;
                    case "3":
                        PievienotJaunu();
                        break;
                    case "4":
                        GetRandomNumber();
                        break;
                    case "5":
                        ClearLines();
                        break;
                    case "0":
                        break;
                    default:
                        Console.WriteLine("Nepareiza ievade!");
                        break;
                }
            }


        }

        private void IzvaditVisus()
        {            
            RefreshSaraksts();
            
            foreach(String line in saraksts)
            {
                Console.WriteLine(line);
            }                                                                
            Console.WriteLine();
        }

        private void IzvaditKuruGribam()
        {
            RefreshSaraksts();
            Console.WriteLine("Nospiediet numuru, kuru joku gribat izvadīt");
            int ievade2 = Convert.ToInt16(Console.ReadLine());
            
            if(ievade2 > 0 && ievade2 <= saraksts.Count)
            {
                Console.WriteLine(saraksts[ievade2 - 1]);
            }
            else
            {
                Console.WriteLine("Nepareiza ievade!");
            }                               
        }

        private void RefreshSaraksts()
        {
            saraksts.Clear();
            String[] lines = System.IO.File.ReadAllLines(@"C:\Users\Dainis\Desktop\joki.txt");
            for (int i = 0; i < lines.Length; i++)
            {
                if (!lines[i].Equals(""))
                {
                    saraksts.Add(lines[i]);
                }                               
            }           
        }

        private void PievienotJaunu()
        {
            RefreshSaraksts();
            Console.WriteLine("Ievadiet jaunu joku");           
            String ievadit = Console.ReadLine();
            
            if (!ievadit.Equals(""))
            {
                saraksts.Add(ievadit);
            }
            else
            {
                Console.WriteLine("Nav nekas ievadīts");
                return;
            }

            using (System.IO.StreamWriter file =
            new System.IO.StreamWriter(@"C:\Users\Dainis\Desktop\joki.txt"))
            {
                foreach (string jaunsSaraksts in saraksts)
                {
                    file.WriteLine(jaunsSaraksts);
                }
            }
        }

        private void GetRandomNumber()
        {
            Random rnd = new Random();
            RefreshSaraksts();            
            int randomSkaitlis = rnd.Next(saraksts.Count);
            Console.WriteLine(saraksts[randomSkaitlis]);
        }

        private void ClearLines()
        {            
            saraksts.Clear();

            using (System.IO.StreamWriter file =
            new System.IO.StreamWriter(@"C:\Users\Dainis\Desktop\joki.txt"))
            {              
                file.Write("");                
            }
        }
    }
}

