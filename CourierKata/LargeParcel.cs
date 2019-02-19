using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourierKata
{
    public class LargeParcel:Parcel
    {
        public LargeParcel(bool speedyShipping, decimal weight)
        {
            SpeedyShipping = speedyShipping;
            Weight = weight;
        }
        
        public override decimal Charge
        {
            get
            {
                if (Weight > 6)
                {
                    return (Weight - 6) * 2;
                }
                return 0;
            }
        }
        public override decimal Cost
        {
            get
            {
                return 15;
            }
        }

        
    }
}
