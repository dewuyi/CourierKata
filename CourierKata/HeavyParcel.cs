using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourierKata
{
    public class HeavyParcel:Parcel
    {
        public HeavyParcel(bool speedyShipping, decimal weight)
        {
            SpeedyShipping = speedyShipping;
            Weight = weight;
        }


        public override decimal Charge
        {
            get
            {
                if (Weight > 50)
                {
                    return Weight - 50;
                }
                return 0;
            }
        }
        public override decimal Cost
        {
            get
            {
                return 50;
            }
        }
    }
}
