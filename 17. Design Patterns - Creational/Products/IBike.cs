using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BikeFactory
{
    public interface IBike
    {
        string Model { get; set; }
        int Weight { get; set; }
        int MaxSpeed { get; set; }

        void Ride();
    }
}
