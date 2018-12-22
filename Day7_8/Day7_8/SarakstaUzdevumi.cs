using System;
using System.Collections.Generic;
using System.Text;

namespace Day7_8
{
    class SarakstaUzdevumi
    {
        private List<String> lietotaji = new List<String>();
        private List<int> lietotajuNumuri = new List<int>();
        private String ievade;

        public void IzvaditLietotajaSaraksts()
        {
            //String list
            //prasam, lai cilvēks ievada vārdu, ko pievienot sarakstam
            //izvelnei (while{switch, case})
            // 1. pievienot jaunu lietotāju sarakstam
            // 2. izvadīt sarakstu
            // ja saraksts ir tukšs, tad pie izvades tas ir jāpasaka

            if (lietotaji.Count == 0)
            {
                Console.WriteLine("Lietotāju saraksts ir tukšs");
            }
            else
            {
                for (int i = 0; i < lietotaji.Count; i++)
                {
                    Console.WriteLine(lietotajuNumuri[i] + ". " + lietotaji[i]);
                    
                }
                Console.WriteLine();
            }
        }

        public void PievienotSarakstam()
        {
            Console.WriteLine("Ievadiet lietotāju");
            lietotaji.Add(Console.ReadLine());
           
            if (lietotajuNumuri.Count == 0)
            {
                lietotajuNumuri.Add(1);
            }
            else
            {
                lietotajuNumuri.Add(lietotajuNumuri[lietotajuNumuri.Count - 1] + 1);
            }
            
        }
      

        public void Search()
        {
            //piešķir otra saraksta katram lietotājam numuru
            //lietotājs ievada id, un tad pasakam, kurš vārds
            //sākam skaitīt no viens
            // ievada id - ar for ciklu ejam cauri id sarakstam
            // no tā varam dabūt indeksu. int atrastaisSkaitlis = i;
            //so indeksu varam izmantot, lai izvadītu Console.WriteLine(lietotaji[atrastaisSkaitlis]);

            Console.WriteLine("Ievadiet ID");
            int id = Convert.ToInt16(Console.ReadLine());

            bool atrasts = false;
            int x = 0;
            for (int i = 0; i < lietotajuNumuri.Count; i++)
            {
                if (id == lietotajuNumuri[i])
                {
                    x = i;
                    atrasts = true;                 
                    break;
                }                
            }
            if (!atrasts)
            {
                Console.WriteLine("Skaitlis netika atrasts!");
            }
            else
            {
                Console.WriteLine("Meklētais lietotājs ir " + lietotaji[x]);
            }           
        }

        public void Interfeiss() { 
            while (ievade != "0")
            {
                Console.WriteLine("+, lai pievienotu, 2, lai izvadītu sarakstu,0, lai izietu");
                ievade = Console.ReadLine();
                switch (ievade)
                {
                    case "+":                       
                        PievienotSarakstam();
                        break;                        
                    case "2":
                        IzvaditLietotajaSaraksts();
                        break;                       
                    case "0":
                        break;
                    default:                       
                        Console.WriteLine("Nepareiza ievade");
                        break;                       
                }
            }
        }       
    }
}
