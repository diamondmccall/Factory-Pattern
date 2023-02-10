using System;
namespace FactoryPattern
{
	public class Motorcycle : IVehicle
	{
		public Motorcycle()
		{
		}

        public void Drive()
        {
            Console.WriteLine($"Your Bike is ready to ride!");
        }
    }
}

