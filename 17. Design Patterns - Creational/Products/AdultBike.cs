using System;

namespace BikeFactory.Products
{
    public class AdultBike : Bike
    {
        public AdultBike()
        {
            this.Model = "Dragster";
        }
        public override void Ride()
        {
            Console.WriteLine("Riding the big Dragster bike is cool");
            Console.WriteLine("I'm so serious");
        }
    }
}
