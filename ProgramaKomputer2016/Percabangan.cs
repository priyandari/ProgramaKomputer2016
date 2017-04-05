using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ProgramaKomputer2016
{
    class Percabangan
    {
        string sinput;
        int bill, sisa;
        double NA;

       
        public void inputData()
        {
            Console.Write("Inputkan sebuah bilangan : ");
            sinput = Console.ReadLine();
        }

        public void checkBilangan()
        {
            bill  = Convert.ToInt32(sinput);
            sisa = bill % 2;

            //Check Bilangan GENAP?

            if (sisa == 0)
            {
                Console.WriteLine("Bilangan GENAP");
            }
            else
            {
                Console.WriteLine("Bilangan GANJIL");
            }
        }

        public void nilaiAkhir()
        {
            NA = Convert.ToDouble(sinput);

            if (NA >= 85)
            {
                Console.WriteLine("A : 4"); 
            }
            else if (NA >= 80)
            {
                Console.WriteLine("A- : 3.7");
            }
            else
            {
                Console.WriteLine("E : 0");    
            }
        }


        public void contohIf()
        {
            int nilai1 = 1;
            int nilai2 = 2;

            if (nilai1 == 1)
            {
                Console.WriteLine("Nilai1 bernilai benar");
            }
            else if(nilai2 == 2)
            {
                Console.WriteLine("Nilai2 bernilai benar");
            }
            else
            {
                Console.WriteLine("Nilai1 dan Nilai 2 tidak ada yg benar");
            }

            contohSwith();

        }

        public void contohSwith()
        {
            int checkKondisi = 9;
            string menu = "Satu";

            Console.WriteLine("Pilih paket data yang akan dibeli :");
            Console.WriteLine("1. Paket Harian");
            Console.WriteLine("2. Paket Mingguan");
            Console.WriteLine("3. Paket Bulanan");
            Console.WriteLine("9. Kembali ke menu awal");

            //menu = menu.ToLower();
            Console.WriteLine(menu.ToLower());

            switch (checkKondisi)
            {
                //Satu               
                case 1:
                    Console.WriteLine("checkKondisi bernilai 1");
                    Console.WriteLine("Anda memilih menu 1");
                    //Proses-proses yang bisa dilakukan
                    break;
                case 2:
                    Console.WriteLine("checkKondisi bernilai 2");
                    Console.WriteLine("Anda memilih menu 2");
                    break;
                case 3:
                    Console.WriteLine("checkKondisi bernilai 3");
                    Console.WriteLine("Anda memilih menu 3");
                    break;
                case 9:
                    Console.WriteLine("checkKondisi bernilai 7");
                    Console.WriteLine("Anda kembali ke menu awal");
                    break;

                default:
                    Console.WriteLine("Tidak ada yang bernilai benar");
                    Console.WriteLine("Pilih menu yang ada saja");
                    break;
            }
        }
    }
}
