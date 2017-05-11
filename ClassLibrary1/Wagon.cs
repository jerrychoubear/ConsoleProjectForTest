using System;

namespace Car
{
    public class Wagon : BaseCar
    {
        /// <summary>
        /// With C# 4.0 optional parameters.
        /// </summary>
        /// <param name="seating"></param>
        public Wagon(int seating = 2) : base(TransmissionEnum.Manual)
        {
            Console.WriteLine("Wagon's ctor called.");
            Seating = seating;
        }

        /// <summary>
        /// in C# 3.5 or before to simulate optional parameters.
        /// </summary>
        public Wagon() : this(3)
        {
            Wheels = 6;
        }
    }
}
