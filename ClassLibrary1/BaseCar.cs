using System;

namespace Car
{
    public class BaseCar
    {
        protected int Wheels { get; set; } = 4;

        protected TransmissionEnum Transmission { get; set; } = TransmissionEnum.Auto;

        protected int Seating { get; set; } = 2;

        public BaseCar()
        {
            Console.WriteLine("BaseCar's ctor called.");
        }

        public virtual void RenderSpec()
        {
            Console.WriteLine("========================");
            Console.WriteLine($"BaseCar has {Wheels} Wheels, {Transmission.ToString(), -6} Transmission, and {Seating} Seats.");
            Console.WriteLine("\n");
        }
    }   
}
