using System;

namespace HomeTask5
{
    public class Boat : WaterVehicle
    {
        private bool _engine;

        public Boat(bool engine, bool cargo, int passengers)
        {
            _engine = engine;
            Staff = new People { Cargo = cargo, Passangers = passengers, Service = 2 };
        }

        public Boat(bool engine, bool cargo)
        {
            _engine = engine;
            Staff = new People { Cargo = cargo, Passangers = 0, Service = 4 };
        }

        public Boat()
        {
            _engine = false;
            Staff = new People { Cargo = false, Passangers = 2, Service = 2 };
        }

        public override void Start()
        {
            if (_engine)
            {
                Console.WriteLine("Двигатель заведён!");
            }
            else
            {
                Console.WriteLine("Гребцы сели за вёсла!");
            }
        }

        public override void Move()
        {
            if (_engine)
            {
                MaxSpeed = 20;
                Console.WriteLine($"Лодка набирает скорость\n Максимальная скорость: {MaxSpeed}км/ч");
            }
            else
            {
                MaxSpeed = 5;
                Console.WriteLine($"Лодка набирает скорость\n Максимальная скорость: {MaxSpeed}км/ч");
            }
        }

        public static Boat GetRandomBoat()
        {
            var random = new Random();
            bool engine;
            bool cargo;
            int passengers = random.Next(0, 5);

            switch (random.Next(0, 2))
            {
                case 0:
                    engine = true;
                    break;
                case 1:
                    engine = false;
                    break;
                default:
                    throw new ArgumentException("Random value is out of the range");
            }

            switch (random.Next(0, 2))
            {
                case 0:
                    cargo = true;
                    break;
                case 1:
                    cargo = false;
                    break;
                default:
                    throw new ArgumentException("Random value is out of the range");
            }

            return new Boat(engine, cargo, passengers);
        }
    }
}