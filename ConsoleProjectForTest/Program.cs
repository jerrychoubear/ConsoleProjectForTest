using Car;
using System;

namespace ConsoleProjectForTest
{
    class Program
    {
        static void Main(string[] args)
        {
            BaseCarRender(Type.GetType("Car.BaseCar, Car"));
            BaseCarRender(Type.GetType("Car.Sedan, Car"));
            BaseCarRender(Type.GetType("Car.Wagon, Car"));

            //SedanRender(Type.GetType("Car.BaseCar, Car"));
            SedanRender(Type.GetType("Car.Sedan, Car"));
            //SedanRender(Type.GetType("Car.Wagon, Car"));

            //WagonRender(Type.GetType("Car.BaseCar, Car"));
            //WagonRender(Type.GetType("Car.Sedan, Car"));
            WagonRender(Type.GetType("Car.Wagon, Car"));
        }

        static void BaseCarRender(Type type)
        {
            BaseCar car = Activator.CreateInstance(type) as BaseCar;
            car.RenderSpec();
        }

        static void SedanRender(Type type)
        {
            BaseCar car = Activator.CreateInstance(type) as Sedan;
            car.RenderSpec();
        }

        static void WagonRender(Type type)
        {
            BaseCar car = Activator.CreateInstance(type) as Wagon;
            car.RenderSpec();
        }
    }
}
