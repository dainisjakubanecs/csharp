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
        private bool atrasts;
        private int x;

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

        private void IevadietID()
        {
            Console.WriteLine("Ievadiet ID");
            int id = Convert.ToInt16(Console.ReadLine());

            atrasts = false;
            x = 0;
            for (int i = 0; i < lietotajuNumuri.Count; i++)
            {
                if (id == lietotajuNumuri[i])
                {
                    x = i;
                    atrasts = true;
                    break;
                }
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

            IevadietID();

            if (!atrasts)
            {
                Console.WriteLine("ID netika atrasts!");
            }
            else
            {
                Console.WriteLine("Meklētais lietotājs ir " + lietotaji[x]);
            }           
        }

        public void Izdzest()
        {
            IevadietID();

            Console.WriteLine("Dzēstais lietotājs ir " + lietotaji[x]);
            lietotaji.RemoveAt(x);
            lietotajuNumuri.RemoveAt(x);
            Console.WriteLine("Ieraksts dzēsts!");
        

            if (!atrasts)
            {
                Console.WriteLine("ID netika atrasts!");
            }
                           
        }

        public void Interfeiss() { 
            while (ievade != "0")
            {
                Console.WriteLine("1, lai pievienotu, 2, lai izvadītu sarakstu, 0, lai izietu," +
                    " 3, lai atrastu ID, 4, lai izdzēstu ID");
                ievade = Console.ReadLine();
                switch (ievade)
                {
                    case "1":                       
                        PievienotSarakstam();
                        break;                        
                    case "2":
                        IzvaditLietotajaSaraksts();
                        break;
                    case "3":
                        Search();
                        break;
                    case "4":
                        Izdzest();
                        break;
                    case "5":
                        FailaRakstisanasPiemers fails = new FailaRakstisanasPiemers();
                        fails.Rakstit(lietotaji);
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
