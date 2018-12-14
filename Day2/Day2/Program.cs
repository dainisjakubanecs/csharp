using System;

namespace Day2
{
    class Program
    {
        static void Main(string[] args)
        {
            Piemers piemers = new Piemers();
            Kapinasana kapinasana = new Kapinasana();
            //piemers.TestaIzvade();
            //piemers.Cikli();
            //Zvaigznites.ZvaignisuSkaits();
            //Zvaigznites.ZvaignisuSkaits2();
            Console.WriteLine(kapinasana.rezultats(5, 3));

            Console.ReadLine();

            

        }
    }
}
