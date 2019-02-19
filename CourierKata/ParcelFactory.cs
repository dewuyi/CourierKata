using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourierKata
{
    public class ParcelFactory: IParcelFactory
    {
        public IParcel CreateParcel(int dimensions, bool speedyShipping, decimal weight)
        {
            if(dimensions < 10)
            {
                return new SmallParcel(speedyShipping, weight);
            }

            else if(dimensions < 50)
            {
                return new MediumParcel(speedyShipping, weight);
            }

            else if(dimensions < 100)
            {
                return new LargeParcel(speedyShipping, weight);
            }
            else
            {
                return new ExtraLargeParcel(speedyShipping, weight);
            }
        }
    }
}
