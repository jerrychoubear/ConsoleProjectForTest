using System;

namespace Car
{
    public class Wagon : BaseCar
    {
        public Wagon()
        {
            Console.WriteLine("Wagon's ctor called.");
            Seating = 4;
        }
    }
}
