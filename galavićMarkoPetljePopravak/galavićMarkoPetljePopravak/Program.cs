using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace galavićMarkoPetljePopravak
{
    class Program
    {
        static void Main(string[] args)
        {


            int ocijena;

            Console.WriteLine("Unesi ocijenu");

            ocijena = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine(ocijena);

            for (int i = 0; i<6; i++)
            {
                if (ocijena > 0 || ocijena < 6) {
                    ocijena = Convert.ToInt32(Console.ReadLine());

                    Console.WriteLine(ocijena);
                }
                if (ocijena == 1)
                {
                    Console.WriteLine("Prosjek je 1");
                }
                
              
            }


            Console.ReadKey();











        }
    }
}
