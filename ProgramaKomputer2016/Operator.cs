using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ProgramaKomputer2016
{
    class Operator
    {
        double alas, tinggi, luas;
        
        public double LuasSegitiga()
        {
            Console.Write("Input alas : ");
            alas = Convert.ToDouble(Console.ReadLine());
            Console.Write("Input tinggi : ");
            tinggi = Convert.ToDouble(Console.ReadLine());

            luas = 0.5 * alas * tinggi;
            return luas;
        }

        public double NilaiSisa()
        {
            return tinggi % alas;
        }
    }
}
