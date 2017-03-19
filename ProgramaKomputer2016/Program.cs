using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ProgramaKomputer2016
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Struktur program, Tipe data, variabel
                //Bagian Inisialisasi
                int suhuC;
                int suhuK;
                string nama;

                //Bagian Input Data 
                suhuC = 100;
                Console.Write("Inputkan nama Anda : ");
                nama = Console.ReadLine();

                Console.Write("Inputkan suhu C : ");
                suhuC = Convert.ToInt32(Console.ReadLine());
            
                //Bagian Proses
                suhuK = 273 + suhuC;

                //Bagian Output
                Console.Write("Suhu hasil konversi dalam Kelvin = ");
                Console.WriteLine(suhuK);

                Console.Write("Suhu hasil konversi dalam Kelvin = {0}", suhuK);

                Console.Write("{0} Celcius = {1} Kelvin", suhuC, suhuK);


                Console.WriteLine("Suhu hasil konversi dalam Kelvin = " + suhuK);

                Console.WriteLine("Terima kasih {0} atas perhatiannya", nama);

            #endregion

            #region Operator dan mengenal sedikit OOP
                //kotak kotakbaru = new kotak(); //deklarasi object
                //kotakbaru.setAtribut();
                //Console.WriteLine("Luas kotak adalah {0}", kotakbaru.Luas().ToString());

                //Operator CO = new Operator();
                //Console.WriteLine("Luas Segitiga adalah {0}", CO.LuasSegitiga().ToString());

                //Console.WriteLine("Nilai sisa Tinggi dibagi alas adalah {0}", CO.NilaiSisa().ToString());
            #endregion

            #region Percabangan 170317
                Percabangan genap = new Percabangan();
                genap.inputData();
                genap.checkBilangan();

                Percabangan nilaiProkom = new Percabangan();
                nilaiProkom.inputData();
                nilaiProkom.nilaiAkhir();
            #endregion
            
            //BAGIAN ini jangan dihilangkan
            Console.ReadKey(); //untuk menunda program ditutup, sampai ditekannya sebuah tombol
        }
    }

    class kotak
    {
        double panjang, lebar, luaskotak;

        public void setAtribut()
        {
            panjang = 10.9;
            lebar = 8.1;
        }

        public double Luas()
        {
            luaskotak = panjang * lebar;
            return luaskotak;
        }
    }
}
