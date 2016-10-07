using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BikeFactory.Products;

namespace BikeFactory.Manufacturers
{
    public class RamBikes : Manufacturer
    {
        public override Bike CreateBike()
        {
            var adultBike = new AdultBike { MaxSpeed = 40, Weight = 5 };
            return adultBike;
        }
    }
}
