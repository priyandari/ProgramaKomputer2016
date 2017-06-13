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

            #region Matriks
            //Pengisian data matrik
            //Console.WriteLine("Inputkan jumlah baris Matrik A :");
            //int BarisA = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("Inputkan jumlah kolom Matrik A :");
            //int KolomA = Convert.ToInt32(Console.ReadLine());

            //Console.WriteLine("Inputkan jumlah baris Matrik B :");
            //int BarisB = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("Inputkan jumlah kolom Matrik B :");
            //int KolomB = Convert.ToInt32(Console.ReadLine());

            //double[,] matrikA = new double[BarisA, KolomA];
            //double[,] matrikB = new double[BarisB, KolomB];
            //double[,] matrikC = new double[BarisA, KolomB];

            double[,] matrikA = new double[2, 3];
            double[,] matrikB = new double[3, 2];
            double[,] matrikC = new double[2, 2];

            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Console.Write("Inputkan data matrik A" + i + "," + j + " : ");
                    matrikA[i, j] = Convert.ToDouble(Console.ReadLine());
                }
            }
            
            //Menampilkan data matrik
            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Console.Write(matrikA[i, j] +"\t");
                }
                Console.WriteLine();
            }
            Console.WriteLine();

            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 2; j++)
                {
                    Console.Write("Inputkan data matrik B" + i + "," + j + " : ");
                    matrikB[i, j] = Convert.ToDouble(Console.ReadLine());
                }
            }

            //Menampilkan data matrik
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 2; j++)
                {
                    Console.Write(matrikB[i, j] + "\t");
                }
                Console.WriteLine();
            }

            //PERKALIAN MATRIK

            double data = 0;

            for (int i = 0; i < 2; i++)
            {
                for (int l = 0; l < 2; l++)
                {
                    data = 0;
                    for (int j = 0; j < 3; j++)
                    {

                       data = data + matrikA[i, j] * matrikB[j, l];
                    }
                    matrikC[i, l] = data;

                }
            }

            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < 2; j++)
                {
                    Console.Write(matrikC[i, j] + "\t");
                }
                Console.WriteLine();
            }
            #endregion

            Console.ReadKey();
        }
    }
}