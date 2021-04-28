using System;

namespace HomeTask5
{
    public class Vehicle : IMachine
    {
        protected int MaxSpeed { get; set; }
        protected People Staff { get; set; }

        public virtual void Start()
        {
            Console.WriteLine("Процесс запущен!");
        }

        public virtual void Move()
        {
            Console.WriteLine("Транспорт начал движение!");
        }

        public static void BuildPark()
        {
            var air = AirVehicle.GetRandomVehicles();
            var ground = GroundVehicle.GetRandomVehicles();
            var water = WaterVehicle.GetRandomVehicles();

            var staff = 0;
            var passengers = 0;
            var cargo = 0;

            Vehicle[] vehicles = new Vehicle[air.Length + ground.Length + water.Length];
            var counter = 0;

            Console.WriteLine($"В вашем парке {vehicles.Length} транспортных средств!");
            Console.WriteLine($"Из них {air.Length} воздушных!\nИз них {ground.Length} наземных!\nИз них {water.Length} водных!");

            for (int i = 0; i < air.Length; i++)
            {
                vehicles[counter] = air[i];
                counter++;

                if (air[i].Staff.Cargo)
                {
                    cargo++;
                }

                staff += air[i].Staff.Service;
                passengers += air[i].Staff.Passangers;
            }

            Console.WriteLine($"У вас {cargo} грузовых водных единиц и {air.Length - cargo} пассажрских еднц, для обслужвания которых необходимо {staff} человек персонала и на которых вы можете перевезт {passengers} пассажиров!");
            staff = 0;
            passengers = 0;
            cargo = 0;

            for (int i = 0; i < ground.Length; i++)
            {
                vehicles[counter] = ground[i];
                counter++;

                if (ground[i].Staff.Cargo)
                {
                    cargo++;
                }

                staff += ground[i].Staff.Service;
                passengers += ground[i].Staff.Passangers;
            }

            Console.WriteLine($"У вас {cargo} грузовых наземных единиц и {ground.Length - cargo} пассажрских еднц, для обслужвания которых необходимо {staff} человек персонала и на которых вы можете перевезт {passengers} пассажиров!");
            staff = 0;
            passengers = 0;
            cargo = 0;

            for (int i = 0; i < water.Length; i++)
            {
                vehicles[counter] = water[i];
                counter++;

                if (water[i].Staff.Cargo)
                {
                    cargo++;
                }

                staff += water[i].Staff.Service;
                passengers += water[i].Staff.Passangers;
            }

            Console.WriteLine($"У вас {cargo} грузовых воздушных единиц и {water.Length - cargo} пассажрских еднц, для обслужвания которых необходимо {staff} человек персонала и на которых вы можете перевезт {passengers} пассажиров!");
        }
    }
}