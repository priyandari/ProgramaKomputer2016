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

            //deklarasi variabel 12
            //int suhuC; 
            //int suhuK;
            //string nama;

            //Input Data 
            //suhuC = 100;
            //Console.Write("Inputkan nama Anda : ");
            //nama = Console.ReadLine();

            //Console.Write("Inputkan suhu C : ");
            //suhuC = Convert.ToInt32(Console.ReadLine());
            //Proses
            //suhuK = 273 + suhuC;

            //Output
            //Console.Write("Suhu hasil konversi dalam Kelvin = ");
            //Console.WriteLine(suhuK);

            //Console.Write("Suhu hasil konversi dalam Kelvin = {0}", suhuK);

            //Console.Write("{0} Celcius = {1} Kelvin", suhuC, suhuK);


            //Console.WriteLine("Suhu hasil konversi dalam Kelvin = " + suhuK);

            //Console.WriteLine("Terima kasih {0} atas perhatiannya", nama);
            //bagian untuk menghentikan program sampai ditekannya sebuah tombol

            //kotak kotakbaru = new kotak();
            //kotakbaru.setAtribut();
            //Console.WriteLine("Luas kotak adalah {0}", kotakbaru.Luas().ToString());

            contohOperator CO = new contohOperator();
            Console.WriteLine("Luas Segitiga adalah {0}", CO.LuasSegitiga().ToString());

            Console.ReadKey();




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
