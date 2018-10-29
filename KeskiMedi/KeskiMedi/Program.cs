using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KeskiMedi
{
    class Program
    {
        static void Main(string[] args)
        {
            double[] luvut = new double[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15 };

            KeskiMedi keskimedi = new KeskiMedi(luvut);

            Console.WriteLine(keskimedi.Keskiarvo());
            Console.WriteLine(keskimedi.Mediaani());
        }
    }
}
