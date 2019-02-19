using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourierKata
{
    public abstract class Parcel:IParcel
    {
        public abstract decimal Cost { get; }
        
        public abstract decimal Charge { get; }
        public bool SpeedyShipping { get; set; }
        public decimal Weight { get; set; }

        public decimal OrderCost
        {
            get
            {
                if (SpeedyShipping)
                {
                    return (2 * Cost) + Charge;
                }

                return Cost + Charge;
            }
        }
    }
}
