using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BikeFactory.Products
{
    public class ChildBike : Bike
    {
        public ChildBike()
        {
            this.Model = "Dolly";
        }
        public override void Ride()
        {
            Console.WriteLine("Riding the small Dolly bike is so fun!");
            Console.WriteLine("Weeee!");
        }
    }
}
