using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourierKata
{
    public interface IParcelFactory
    {
        IParcel CreateParcel(int dimensions, bool speedyShipping, decimal weight);
    }
}
