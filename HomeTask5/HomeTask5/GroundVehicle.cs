using System;

namespace HomeTask5
{
    public class GroundVehicle : Vehicle
    {
        public static Vehicle[] GetRandomVehicles()
        {
            var random = new Random();
            Vehicle[] vehicles = new Vehicle[random.Next(5, 11)];

            for (int i = 0; i < vehicles.Length; i++)
            {
                if (i % 2 == 0)
                {
                    vehicles[i] = Car.GetRandomCar();
                }
                else
                {
                    vehicles[i] = Train.GetRandomTrain();
                }
            }

            return vehicles;
        }
    }
}