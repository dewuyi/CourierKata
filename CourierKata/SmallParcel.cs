using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourierKata
{
    public class SmallParcel:Parcel
    {
        public SmallParcel(bool speedyShipping, decimal weight)
        {
            SpeedyShipping = speedyShipping;
            Weight = weight;
        }
       

        public override decimal Charge
        {
            get
            {
                if (Weight > 1)
                {
                    return (Weight - 1) * 2;
                }
                return 0;
            }
        }
        public override decimal Cost
        {
            get
            {
                return 3;
            }
        }

       
    }
}
