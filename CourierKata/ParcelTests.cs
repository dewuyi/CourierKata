using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace CourierKata
{
    public class ParcelTests
    {
        [Theory]
        [InlineData(5,true, 5, 14)]
        [InlineData(40, true, 5, 20)]
        [InlineData(45, false, 5, 12)]
        [InlineData(50, true, 6, 30)]
        [InlineData(200, false, 11, 27)]
        public void CreateParcelsCorrectly(int dimensions, bool speedyShipping, decimal weight, decimal orderCost)
        {
            IParcelFactory parcelFactory = new ParcelFactory();
            IParcel parcel = parcelFactory.CreateParcel(dimensions, speedyShipping, weight);
            Assert.Equal(parcel.OrderCost, orderCost);
        }
    }
}
