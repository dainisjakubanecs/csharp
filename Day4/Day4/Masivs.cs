using System;
using System.Collections.Generic;
using System.Text;

namespace Day4
{
    class Masivs
    {

        public void PirmaisPiemers()
        {

            Console.WriteLine("Ievadiet masīva garumu");
            int a = Convert.ToInt16(Console.ReadLine());
            int[] arr = new int[a];

            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = i + 2;
                Console.WriteLine("Masīva " + i + ". elements ir " + arr[i]);
            }

            for (int i = arr.Length - 1; i >= 0; i--)
            {
                Console.WriteLine("Masīva " + i + ". elements ir " + arr[i]);
            }
        }

        public void OtraisPiemers()
        {
            Console.WriteLine("Ievadiet masīva garumu");
            int a = Convert.ToInt16(Console.ReadLine());
            int[] arr = new int[a];

            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine("Ievadiet masīva " + i + ". elementa vērtību");
                arr[i] = Convert.ToInt16(Console.ReadLine());

            }

            double sum = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                sum += arr[i];
            }
            Console.WriteLine("Masīva vidējā vērtība ir " + sum / arr.Length);
        }

        public void TresaisPiemers()
        {
            Console.WriteLine("Ievadiet masīva garumu");
            int a = Convert.ToInt16(Console.ReadLine());
            int[] arr = new int[a];

            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine("Ievadiet masīva " + i + ". elementa vērtību");
                arr[i] = Convert.ToInt16(Console.ReadLine());
            }

            Console.WriteLine("Ievadiet meklējamo masīva vērtību");
            int b = Convert.ToInt16(Console.ReadLine());
            bool skaitlisAtrasts = false;

            for (int i = 0; i < arr.Length; i++)
            {
                if (b == arr[i])
                {
                    Console.WriteLine("Vērtība " + b + " atrodas masīva " + i + "elementā");
                    skaitlisAtrasts = true;
                }
            }
            if (!skaitlisAtrasts)
            {
                Console.WriteLine("Skaitlis nav atrasts!");
            }

            int temp = arr[0];
            for (int i = 1; i < arr.Length; i++)
            {
                if (temp < arr[i])
                {
                    temp = arr[i];
                }
                Console.WriteLine("Masīva vērtības ir " + arr[i] + " elementā " + i);
            }
            Console.WriteLine("Lielākā masīva vērtība ir " + temp);
        }

        public void CeturtaisPiemers()
        {
            Console.WriteLine("Ievadiet masīva garumu");
            int a = Convert.ToInt16(Console.ReadLine());
            int[] arr = new int[a];

            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine("Ievadiet masīva " + i + ". elementa vērtību");
                arr[i] = Convert.ToInt16(Console.ReadLine());
            }

            
            for(int i = 0; i < arr.Length; i++)
            {
                for (int j = 0; j < arr.Length - 1; j++)
                {
                    if (arr[j] > arr[j + 1])
                    {
                        int temp = arr[j];
                        arr[j] = arr[j + 1];
                        arr[j + 1] = temp;
                    }
                }
            }

            for(int i = 0; i < arr.Length; i++)
            {
                Console.Write(arr[i] + ", ");
            }
            


        }
    }
}
