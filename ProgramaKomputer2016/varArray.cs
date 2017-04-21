using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ProgramaKomputer2016
{
    class varArray
    {
        static void Main(string[] args)
        {
            //Inisiasi variabel array dan mendefinisikan panjang data
            int[] bilangan = new int [9];
            int variabelTunggal;

            variabelTunggal = 900;

            //assignment atau memberi nilai pada array
            bilangan[0] = 100;
            bilangan[1] = 200;
            bilangan[5] = 500;

            //memanggil data dari variabel array yang telah diberi nilai
            Console.WriteLine("Bilangan ke-1 : " + bilangan[0]);
            Console.WriteLine("Bilangan ke-2 : " + bilangan[1]);
            Console.WriteLine("Bilangan ke-5 : " + bilangan[5]);

            Console.WriteLine("Bilangan dengan indeks 2 : " + bilangan[2]);

            //Inisiasi dan memberi langsung nilai array
            string[] nama = {"Heru", "Budi", "Wati", "Ika"};

            Console.WriteLine(nama[1] + " berada pada indeks ke-1 / urutan ke-2");
            Console.WriteLine(nama[3] + " berada pada indeks ke-3 / urutan ke-4");
            ///Console.WriteLine(nama[4] + " berada pada indeks ke-4 / urutan ke-5"); //Tidak terdefinisikan atau out of range


            //Menggunakan looping / pengulangan untuk memberi nilai pada sebuah variabel array

            for (int i = 0; i < 9; i++)
            {
                bilangan[i] = 100 + i;
            }

            Console.ReadKey();
        }
    }
}