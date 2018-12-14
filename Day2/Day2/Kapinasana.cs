using System;
using System.Collections.Generic;
using System.Text;

namespace Day2
{
    class Kapinasana
    {
        public Kapinasana()
        {

        }

        public int rezultats(int x, int y)
        {
            int temp = 1;
            for (int i = 0; i < y; i++)
            {
               
                temp = x * temp;
            }
               
            return temp;

        }
    }
}
