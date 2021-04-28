using System;

namespace HomeTask5
{
    public class WaterVehicle : Vehicle
    {
        protected bool Military { get; set; }

        public static Vehicle[] GetRandomVehicles()
        {
            var random = new Random();
            Vehicle[] vehicles = new Vehicle[random.Next(5, 11)];

            for (int i = 0; i < vehicles.Length; i++)
            {
                if (i % 2 == 0)
                {
                    vehicles[i] = Ship.GetRandomShip();
                }
                else
                {
                    vehicles[i] = Boat.GetRandomBoat();
                }
            }

            return vehicles;
        }
    }
}