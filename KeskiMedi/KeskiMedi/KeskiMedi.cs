using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KeskiMedi
{
    class KeskiMedi
    {
        //double[] luvut;
        double[] luvut;

        public double Keskiarvo()
        {
            return luvut.Average();
        }


        public double Mediaani()
        {
            int keskimmainen = luvut.Count() / 2;

            if (luvut.Count() % 2 == 0)
            {                
                return (luvut[keskimmainen] + luvut[keskimmainen - 1]) / 2;
            }

            return luvut[keskimmainen];
        }


        public void LisaaLuku(double lisattava)
        {

        }


        public KeskiMedi(double[] luvut)
        {
            this.luvut = luvut;
        }
    }
}
