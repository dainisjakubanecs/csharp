using System;

namespace Day7_8
{
    class Program
    {
        static void Main(string[] args)
        {
            SarakstaUzdevumi sarakstaUzdevumi = new SarakstaUzdevumi();

            
            sarakstaUzdevumi.Interfeiss();
            //sarakstaUzdevumi.PievienotNumuru();
            //sarakstaUzdevumi.PievienotSarakstam();
            sarakstaUzdevumi.Search();

            Console.ReadLine();
        }
    }
}
