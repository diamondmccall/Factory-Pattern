using System;
namespace FactoryPattern
{
	public static class VehicleFactory
	{
		public static IVehicle GetVehicle(int wheelCount)
		{
			if (wheelCount == 4)
			{
				return new Car();

			}
			else if (wheelCount == 2)
			{
				return new Motorcycle();
			}
			else if (wheelCount == 3)
			{
				return new Motorcycle();
			}
			else
				{
				return new Car();
				}
			
		}

        
    }
}

