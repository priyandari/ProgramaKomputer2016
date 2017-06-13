using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ProgramaKomputer2016
{
    class prosedur
    {
        static void Main(string[] args)
        {
            //prosedur misal = new prosedur();
            //misal.HitungLuas();
            HitungLuas();
            Console.ReadKey();
        }

        static void HitungLuas()
        {
            int panjang; int lebar; double Luas;
            panjang = 9; lebar = 7;
            Luas = panjang * lebar;

            Console.WriteLine("Persegi dengan ");
            Console.WriteLine("panjang " + panjang);
            Console.WriteLine("lebar" + lebar);
            Console.WriteLine("Luas adalah " + Luas);



        }
    }
}
