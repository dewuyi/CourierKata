using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourierKata
{
    public class MediumParcel:Parcel
    {
        public MediumParcel(bool speedyShipping, decimal weight)
        {
            SpeedyShipping = speedyShipping;
            Weight = weight;
        }
        
        public override decimal Charge
        {
            get
            {
                if (Weight > 3)
                {
                    return (Weight - 3) * 2;
                }
                return 0;
            }
        }
        public override decimal Cost
        {
            get
            {
                return 8;
            }
        }

       
    }
}
