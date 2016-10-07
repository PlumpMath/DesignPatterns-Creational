using BikeFactory.Manufacturers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BikeFactory
{
    class Program
    {
        static void Main(string[] args)
        {
            TestManufacturersProduct(new RamBikes());
            Console.WriteLine(new string('-', 60));

            TestManufacturersProduct(new JollyBikes());
            Console.WriteLine(new string('-', 60));
        }

        static void TestManufacturersProduct(Manufacturer manufacturer)
        {
            var bike = manufacturer.CreateBike();
            Console.WriteLine(bike.ToString());
            bike.Ride();
        }
    }
}
