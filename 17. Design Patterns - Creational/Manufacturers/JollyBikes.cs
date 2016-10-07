using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BikeFactory.Products;

namespace BikeFactory.Manufacturers
{
    public class JollyBikes : Manufacturer
    {
        public override Bike CreateBike()
        {
            var childBike = new ChildBike { MaxSpeed = 15, Weight = 3 };
            return childBike;
        }
    }
}
