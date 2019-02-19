using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourierKata
{
    public interface IParcel
    {
        decimal Cost { get;}
        decimal OrderCost { get; }
        decimal Charge { get;}
        bool SpeedyShipping { get; }
        decimal Weight { get;}
    }
}
