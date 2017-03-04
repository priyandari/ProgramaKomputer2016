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
            //deklarasi variabel
            int suhuC; 
            int suhuK;
            string nama;

            //Input Data
            //suhuC = 100;
            Console.Write("Inputkan nama Anda : ");
            nama = Console.ReadLine();

            Console.Write("Inputkan suhu C : ");
            suhuC = Convert.ToInt32(Console.ReadLine());
            //Proses
            suhuK = 273 + suhuC;

            //Output
            //Console.Write("Suhu hasil konversi dalam Kelvin = ");
            //Console.WriteLine(suhuK);

            //Console.Write("Suhu hasil konversi dalam Kelvin = {0}", suhuK);

            //Console.Write("{0} Celcius = {1} Kelvin", suhuC, suhuK);


            Console.WriteLine("Suhu hasil konversi dalam Kelvin = " + suhuK);

            Console.WriteLine("Terima kasih {0} atas perhatiannya", nama);
            //bagian untuk menghentikan program sampai ditekannya sebuah tombol
            Console.ReadKey();




        }
    }
}
