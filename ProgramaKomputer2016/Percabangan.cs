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
    }
}
