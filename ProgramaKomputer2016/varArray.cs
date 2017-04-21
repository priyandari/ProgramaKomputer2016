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
            #region Array 1 Dimensi            
            ////Inisiasi variabel array dan mendefinisikan panjang data
            //int[] bilangan = new int [9];
            //int variabelTunggal;

            //variabelTunggal = 900;

            ////assignment atau memberi nilai pada array
            //bilangan[0] = 100;
            //bilangan[1] = 200;
            //bilangan[5] = 500;

            ////memanggil data dari variabel array yang telah diberi nilai
            //Console.WriteLine("Bilangan ke-1 : " + bilangan[0]);
            //Console.WriteLine("Bilangan ke-2 : " + bilangan[1]);
            //Console.WriteLine("Bilangan ke-5 : " + bilangan[5]);

            //Console.WriteLine("Bilangan dengan indeks 2 : " + bilangan[2]);

            ////Inisiasi dan memberi langsung nilai array
            //string[] nama = {"Heru", "Budi", "Wati", "Ika"};

            //Console.WriteLine(nama[1] + " berada pada indeks ke-1 / urutan ke-2");
            //Console.WriteLine(nama[3] + " berada pada indeks ke-3 / urutan ke-4");
            /////Console.WriteLine(nama[4] + " berada pada indeks ke-4 / urutan ke-5"); //Tidak terdefinisikan atau out of range


            ////Menggunakan looping / pengulangan untuk memberi nilai pada sebuah variabel array
            //for (int i = 0; i < 9; i++)
            //{
            //    bilangan[i] = 100 + i;
            //}

            //for (int i = 0; i < bilangan.Length; i++)
            //{
            //    Console.WriteLine("Indeks ke-" + i + " adalah " + bilangan[i] );
            //}
            //Console.WriteLine();
            //foreach (int item in bilangan)
            //{
            //    Console.WriteLine("Bilangan : " + item);
            //}

            //Console.WriteLine();
            //int indek;
            //indek = 0;
            //foreach (var bill in bilangan)
            //{
            //    Console.WriteLine("Bill "+ indek +" : " + bill);
            //    indek++;
            //}

            //Console.WriteLine();
            //foreach (var item in nama)
            //{
            //    Console.WriteLine("Hallo : " + item);
            //}

            #endregion


            #region Array 2 Dimensi
            ////Inisiasi array berdimensi 2
            //int[,] matrik = new int[2,3];
            ////int[,,] Cube = new int[2, 3,4];

            ////Memberi nilai
            //matrik[0,0] = 100;
            //matrik[0, 1] = 101;
            //matrik[0, 2] = 102;
            //matrik[1, 0] = 200;
            //matrik[1, 1] = 201;
            //matrik[1, 2] = 202;


            //Console.WriteLine(matrik[1,2]);
            //Console.WriteLine(matrik[0, 1]);
            #endregion


            #region Array 1 Dimensi lanjutan
            //int[] varBilangan = new int[10];

            //for (int i = 0; i < varBilangan.Length; i++)
            //{
            //    varBilangan[i] = 500 + i;
            //}

            //for (int i = 0; i < varBilangan.Length; i++)
            //{
            //    //if (varBilangan[i] % 2 == 0)
            //    //{
            //    //    Console.WriteLine(varBilangan[i]);
            //    //}
            //    Console.WriteLine(varBilangan[i]);
            //    if (varBilangan[i] == 507)
            //    {                    
            //        break; 
            //    }
            //}
            
            #endregion


            Console.ReadKey();
        }
    }
}