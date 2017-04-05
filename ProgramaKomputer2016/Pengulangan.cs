using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ProgramaKomputer2016
{
    class Pengulangan
    {
        static void Main(string[] args)
        {
            #region FOR
            //for (int i = 0; i < 10; i++)
            //{
            //    Console.WriteLine("Urutan angka ke- " + i);
            //}

            #endregion

            #region WHILE
            //int j=1;
            //while (j <= 10)
            //{
            //    Console.WriteLine("Ini langkah ke-"+ j +" dari 1000 langkah");
            //    j++;
            //}
            #endregion

            #region DO
            int k = 101;
            do
            {
                Console.WriteLine("Ini langkah ke-" + k + " dari 1000 langkah");
                k++;
            } while (k <= 110);
            #endregion

            Console.WriteLine("Silahkan tekan tombol untuk selesai ...");
            Console.ReadKey();
        }
    }
}
