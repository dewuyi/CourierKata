using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourierKata
{
    public class ExtraLargeParcel:Parcel
    {
        public ExtraLargeParcel(bool speedyShipping, decimal weight)
        {
            SpeedyShipping = speedyShipping;
            Weight = weight;
        }
      
         
        public override decimal Charge
        {
            get
            {
                if (Weight > 10)
                {
                    return (Weight - 10) * 2;
                }
                return 0;
            }
        }

        public override decimal Cost
        {
            get
            {
                return 25;
            }
        }

        

    }
}
