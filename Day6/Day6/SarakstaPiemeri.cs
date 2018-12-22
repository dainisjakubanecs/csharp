using System;
using System.Collections.Generic;
using System.Text;

namespace Day6
{
    class SarakstaPiemeri
    {
        public void SarakstaPiemers()
        {
            List<int> pirmaisSaraksts = new List<int>();

            pirmaisSaraksts.Add(1234);
            pirmaisSaraksts.Add(6);

            for(int i = 0; i < pirmaisSaraksts.Count; i++)
            {
                Console.WriteLine(pirmaisSaraksts[i]);
            }

            int reizuSkaits = 4;

            for(int i = 0; i < reizuSkaits; i++)
            {
                pirmaisSaraksts.Add(1);    // iekavās norādam vērtību, ko gribam pievienot
                pirmaisSaraksts.Remove(1); // norādam indeksu, nevis vērtību
            }
        }
    }
}
