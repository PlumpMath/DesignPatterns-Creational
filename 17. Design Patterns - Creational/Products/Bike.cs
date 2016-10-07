using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BikeFactory.Products
{
    public abstract class Bike : IBike
    {
        public string Model { get; set; }
        public int Weight { get; set; }
        public int MaxSpeed { get; set; }
        public abstract void Ride();

        public override string ToString()
        {
            var bikeAsString = new StringBuilder();
            bikeAsString.AppendFormat("Bike model: {0}", this.Model);
            bikeAsString.AppendLine();
            bikeAsString.AppendFormat("Max speed: {0}", this.MaxSpeed);
            bikeAsString.AppendLine();
            bikeAsString.AppendFormat("Weight: {0}", this.Weight);
            bikeAsString.AppendLine();
            return bikeAsString.ToString();
        }
    }
}
