using System;
using BikeFactory.Products;

namespace BikeFactory.Manufacturers
{
    public abstract class Manufacturer : IManufacturer
    {
        public abstract Bike CreateBike();
    }
}
