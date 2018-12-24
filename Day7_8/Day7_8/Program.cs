using System;

namespace Day7_8
{
    class Program
    {
        static void Main(string[] args)
        {
            SarakstaUzdevumi sarakstaUzdevumi = new SarakstaUzdevumi();
            FailaRakstisanasPiemers failaRakstisanasPiemers = new FailaRakstisanasPiemers();
            Majasdarbs majasdarbs = new Majasdarbs();

            //sarakstaUzdevumi.Interfeiss();
            //sarakstaUzdevumi.PievienotNumuru();
            //sarakstaUzdevumi.PievienotSarakstam();
            //sarakstaUzdevumi.Search();
            //sarakstaUzdevumi.Izdzest();

            //failaRakstisanasPiemers.LasitSaskaitit();
            majasdarbs.DzejolisNolasit();

            Console.ReadLine();
        }
    }
}
