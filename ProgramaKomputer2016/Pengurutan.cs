using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ProgramaKomputer2016
{
    class Pengurutan
    {
        static void Main(string[] args)
        {
            string[] nim = new string[6];
            string[] nama = new string[6];
            string[] kelas = new string[6];
            string[,] mahasiswa = new string[3, 3]; //kolom 1 untuk nim, kolom untuk nama, kolom 3 kelas 
            string[,] copymahasiswa;
            double[,] copynilai;

            int[] nilaiuts = new int[6];
            int[] nilaiuas = new int[6];
            double[] nilaiakhir = new double[6];
            double[,] nilai = new double[3, 3]; //kolom 1 = uts, 2=uas, 3 =na 

            double a, b;
            int finalscore, nilaiuts1, nilaiuas1;

            string[] pemiliknilai = new string[6];
            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine("Identitas " + (i + 1));
                Console.WriteLine("====================");
                Console.Write("Masukan nim :");
                mahasiswa[i, 0] = Console.ReadLine();
                Console.Write("Masukan nama :");
                mahasiswa[i, 1] = Console.ReadLine();
                Console.Write("Masukan kelas :");
                mahasiswa[i, 2] = Console.ReadLine();
            }

        ulanginputnilai:
            Console.Write("Masukkan nim yang akan diinput nilai UTS : ");
            string nimcari = Console.ReadLine();
            for (int i = 0; i < 3; i++)
            {
                if (nimcari == mahasiswa[i, 0])
                {
                    Console.Write("Masukan nilai UTS mahasiswa " + mahasiswa[i, 1] + "  : ");
                    nilai[i, 0] = Convert.ToDouble(Console.ReadLine());
                    break;
                }
            }

            Console.Write("Akan input nilai UTS lagi ? (y/n)");
            string ulang = Console.ReadLine();
            if (ulang == "y")
            {
                goto ulanginputnilai;
            }


        ulanginputnilaiuas:
            Console.Write("Masukkan nim yang akan diinput nilai UAS : ");
            nimcari = Console.ReadLine();
            for (int i = 0; i < 3; i++)
            {
                if (nimcari == mahasiswa[i, 0])
                {
                    Console.Write("Masukan nilai UAS mahasiswa " + mahasiswa[i, 1] + "  : ");
                    nilai[i, 1] = Convert.ToDouble(Console.ReadLine());
                    break;
                }
            }

            Console.Write("Akan input nilai UAS lagi ? (y/n)");
            string ulanguas = Console.ReadLine();
            if (ulanguas == "y")
            {
                goto ulanginputnilaiuas;
            }

            for (int j = 0; j < 3; j++)
            {
                //Console.WriteLine("Data nilai" + (j + 1));
                //Console.WriteLine("====================");

                //Console.Write("Masukan nilai UTS :");
                //nilai[j,0] = Convert.ToDouble(Console.ReadLine());
                ////nilaiuts1 = nilaiuts[j];

                //Console.Write("Masukan nilai UAS :");
                //nilai[j, 1] = Convert.ToDouble(Console.ReadLine());
                ////nilaiuas1 = nilaiuas[j];

                ////a = 0.6 * nilaiuas1;
                ////b = 0.4 * nilaiuts1;

                nilai[j, 2] = nilai[j, 0] * 0.4 + nilai[j, 1] * 0.6;
                //nilaiakhir[j] = finalscore;
                //Console.WriteLine("Nilaiakhir adalah :" + finalscore);

                //Console.Write("Masukan NIM pemilik nilai : ");
                //pemiliknilai[j] = Console.ReadLine();

            }
            //double[] nilaisiswa = new double[6];

            //for (int i = 0; i < 6; i++)
            //{
            //    for (int j = 0; j < 6; j++)
            //    {
            //        if (nim[i] == pemiliknilai[j])
            //        {
            //            nilaisiswa[i] = nilaiakhir[j];
            //            break;
            //        }
            //    }
            //}
            Console.WriteLine("Tekan enter untuk melihat nilai");
            Console.ReadLine();
            TampilkanDaftar(mahasiswa, nilai);

            //Console.WriteLine("Data Nilai Mahasiswa");
            //Console.WriteLine("====================");
            //    Console.WriteLine("NIM || Nama || Kelas || UTS | UAS | Nilai Akhir");

            //    for (int i = 0; i < 3; i++) 
            //    {
            //        Console.WriteLine(mahasiswa[i,0] + "\t\t||" + mahasiswa[i, 1] + "\t\t||" + mahasiswa[i, 2] + "\t\t||"
            //       + nilai[i,0] + "\t\t||" + nilai[i, 1] + "\t\t||" + nilai[i, 2]);
            //    }

            Console.WriteLine("Tekan enter untuk mencari nilai mahasiswa");
            Console.ReadLine();
            Console.Write("Masukkan nim yang akan dicari nilainya : ");
            //string nimcari = Console.ReadLine();
            for (int i = 0; i < 3; i++)
            {
                if (nimcari == mahasiswa[i, 0])
                {
                    Console.WriteLine(mahasiswa[i, 0] + "\t\t||" + mahasiswa[i, 1] + "\t\t||" + mahasiswa[i, 2] + "\t\t||"
           + nilai[i, 0] + "\t\t||" + nilai[i, 1] + "\t\t||" + nilai[i, 2]);
                    break;
                }
            }


            copymahasiswa = mahasiswa;
            copynilai = nilai;

            //Mengurutkan Nilai Akhir dari Besar Ke Kecil
            //copynilai
            for (int j = 0; j <= 3 - 1; j++)
            {
                for (int k = 0; k <= 3 - 2; k++)
                {
                    if (copynilai[k, 2] < copynilai[k + 1, 2])
                    {
                        double tempnilaina = copynilai[k, 2];
                        double tempnilaiuas = copynilai[k, 1];
                        double tempnilaiuts = copynilai[k, 0];
                        copynilai[k, 2] = copynilai[k + 1, 2];
                        copynilai[k, 1] = copynilai[k + 1, 1];
                        copynilai[k, 0] = copynilai[k + 1, 0];

                        copynilai[k + 1, 2] = tempnilaina;
                        copynilai[k + 1, 1] = tempnilaiuas;
                        copynilai[k + 1, 0] = tempnilaiuts;


                        //lakukan pemindahan data copymahasiswa
                        string tempnim = copymahasiswa[k, 0];
                        string tempnama = copymahasiswa[k, 1];
                        string tempkelas = copymahasiswa[k, 2];
                        copymahasiswa[k, 2] = copymahasiswa[k + 1, 2];
                        copymahasiswa[k, 1] = copymahasiswa[k + 1, 1];
                        copymahasiswa[k, 0] = copymahasiswa[k + 1, 0];

                        copymahasiswa[k + 1, 2] = tempkelas;
                        copymahasiswa[k + 1, 1] = tempnama;
                        copymahasiswa[k + 1, 0] = tempnim;

                    }
                }
            }

            Console.WriteLine("Tekan enter untuk melihat nilai");
            Console.ReadLine();
            string dosen = "Agus";
            TampilkanDaftar(copymahasiswa, copynilai);
            Console.ReadKey();
        }

        static void TampilkanDaftar(string[,] mahasiswa, double[,] nilai)
        {
            Console.WriteLine("Tekan enter untuk melihat nilai");
            Console.ReadLine();
            Console.WriteLine("Data Nilai Mahasiswa");
            Console.WriteLine("====================");
            Console.WriteLine("NIM || Nama || Kelas || UTS | UAS | Nilai Akhir");

            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine(mahasiswa[i, 0] + "\t\t||" + mahasiswa[i, 1] + "\t\t||" + mahasiswa[i, 2] + "\t\t||"
               + nilai[i, 0] + "\t\t||" + nilai[i, 1] + "\t\t||" + nilai[i, 2]);
            }

        }
    }
}
