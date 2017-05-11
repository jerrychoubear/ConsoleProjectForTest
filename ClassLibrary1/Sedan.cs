using System;

namespace Car
{
    public class Sedan : BaseCar
    {
        public Sedan()
        {
            Console.WriteLine("Sedan's ctor called.");
            Transmission = TransmissionEnum.Manual;
        }
    }
}
