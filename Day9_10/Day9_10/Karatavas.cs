using System;
using System.Collections.Generic;
using System.Text;

namespace Day9_10
{
    class Karatavas
    {
        // 1. vārds (1 rindiņa)
        // file ---> programma
        // cilvēks raksta pa vienam burtam iekšā
        // pirmais, ko redz ir ____
        // piecas reizes nepareizi ievadam, tad spēle beidzās

        //private String[] vards; // = System.IO.File.ReadAllLines(@"E:\csharp projekti\csharp\Day9_10\vards.txt");
        private String darbiba = "";
        private char ievaditBurtu;
        private char[] vardaBurts;
        private char[] mainamaisBurts;
        private bool atminetsBurts;        
        private bool jauIrBurts;
        private int x;
        



        public void SpelesMenu()
        {                                   
            while (!darbiba.Equals("0") && !ievaditBurtu.Equals('0'))
            {
                if (!ievaditBurtu.Equals('1'))
                {
                    SpelesMenuIzvele();
                    darbiba = Console.ReadLine();

                    switch (darbiba)
                    {
                        case "1":
                            Console.Clear();
                            SpelesMenuIzvele();                           
                            Spele();                      
                            break;
                        case "0":
                            break;
                        default:
                            Console.WriteLine("Nepareiza ievade");
                            break;
                    }
                }
                else
                {
                    Console.Clear();
                    SpelesMenuIzvele();
                    Spele();
                }
                
            }
        }

        private void SpelesMenuIzvele()
        {
            Console.WriteLine("Spēle - Karātavas");
            Console.WriteLine("Nospiediet 1, lai sāktu jaunu spēli");            
            Console.WriteLine("Nospiediet 0, lai izietu");
            Console.WriteLine();
        }

        public void Spele()
        {
            x = 0;
            Console.WriteLine("Atminiet vārdu");
            Console.WriteLine();
            SakumaVards();
            Console.WriteLine();
            
            while (mainamaisBurts != vardaBurts)
            {               
                if (AtminetsVards())
                {
                    if (x < 3)
                    {
                        Console.WriteLine();
                        Console.Write("Ievadiet burtu: ");
                        ievaditBurtu = Convert.ToChar(Console.ReadLine());
                        Console.WriteLine();
                        atminetsBurts = false;
                        jauIrBurts = false;

                        for (int i = 1; i < vardaBurts.Length; i++)
                        {
                            if (ievaditBurtu == mainamaisBurts[i])
                            {
                                jauIrBurts = true;
                            }                                                        
                            if (ievaditBurtu == vardaBurts[i])
                            {
                                mainamaisBurts[i] = vardaBurts[i];
                                atminetsBurts = true;
                            }                                                          
                        }
                        if (atminetsBurts && !jauIrBurts)
                        {
                            for (int i = 0; i < vardaBurts.Length; i++)
                            {
                                Console.Write(mainamaisBurts[i] + " ");
                                x = 0;
                            }
                            Console.WriteLine();
                        }
                        else if (jauIrBurts)
                        {
                            Console.WriteLine("Tāds burts jau ir ievadīts!");
                            x++;
                        }
                        else if (ievaditBurtu.Equals('0'))
                        {                           
                            break;
                        }
                        else if (ievaditBurtu.Equals('1'))
                        {                       
                            break;
                        }
                        else
                        {
                            Console.WriteLine("Nav tāda burta!");
                            x++; 
                        }
                    }
                    else
                    {
                        Console.WriteLine("Jūs ievadījāt nepareizu vai tādu pašu burtu " + x + " reizes pēc kārtas!");
                        Console.WriteLine("Spēle beigusies!");
                        Console.WriteLine();
                        break;
                    }                                        
                }
                else
                {
                    Console.WriteLine();
                    Console.WriteLine("Apsveicam, Jūs atminējāt vārdu!");
                    Console.WriteLine("Spēle beigusies!");
                    Console.WriteLine();
                    break;
                }                
            }            
        }

        private void SakumaVards()
        {
            String[] vards = System.IO.File.ReadAllLines(@"E:\csharp projekti\csharp\Day9_10\vards.txt");
            Random rnd = new Random();           
            int randomSkaitlis = rnd.Next(vards.Length);           
            vardaBurts = vards[randomSkaitlis].ToCharArray();
            mainamaisBurts = new char[vardaBurts.Length];
            int randomSkaitlis2 = rnd.Next(vardaBurts.Length);

            for (int i = 0; i < vardaBurts.Length; i++)
            {
                mainamaisBurts[i] = '_';
                mainamaisBurts[0] = vardaBurts[0];
                mainamaisBurts[randomSkaitlis2] = vardaBurts[randomSkaitlis2];

                for(int j = 1; j < vardaBurts.Length; j++)
                {                   
                    if (vardaBurts[i] == mainamaisBurts[j])
                    {
                        mainamaisBurts[i] = mainamaisBurts[j];                       
                    }
                }               
                Console.Write(mainamaisBurts[i] + " ");                
            }           
            Console.WriteLine();
        }

        private bool AtminetsVards()
        {
           for(int i = 0; i < vardaBurts.Length; i++)
            {
                if(mainamaisBurts[i].Equals('_') )
                {
                    return true;                   
                }               
            }
            return false;            
        }       
    }
}
