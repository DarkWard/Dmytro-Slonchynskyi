using System;

namespace HomeTask5
{
    public class Car : GroundVehicle
    {
        private bool _electrical;

        private string _color;

        public Car(bool electrical, bool cargo, int passengers, string color)
        {
            _electrical = electrical;
            _color = color;
            Staff = new People { Cargo = cargo, Passangers = passengers, Service = 8 };
        }

        public Car(bool electrical, bool cargo, int passengers)
        {
            _electrical = electrical;
            _color = "Чёрный";
            Staff = new People { Cargo = cargo, Passangers = passengers, Service = 8 };
        }

        public Car()
        {
            _electrical = false;
            _color = "Чёрный";
            Staff = new People { Cargo = false, Passangers = 4, Service = 8 };
        }

        public override void Start()
        {
            if (Staff.Cargo)
            {
                Console.WriteLine($"Двигатель заведён!\nБагаж загружен!");
            }
            else
            {
                Console.WriteLine($"Двигатель заведён!\nПассажры на местах");
            }
        }

        public override void Move()
        {
            if (Staff.Cargo)
            {
                MaxSpeed = 90;
                Console.WriteLine($"{_color} автомобиль набирает скорость\n Максимальная скорость: {MaxSpeed}км/ч");
            }
            else if (_electrical)
            {
                MaxSpeed = 110;
                Console.WriteLine($"{_color} автомобиль набирает скорость\n Максимальная скорость: {MaxSpeed}км/ч");
            }
            else
            {
                MaxSpeed = 150;
                Console.WriteLine($"{_color} автомобиль набирает скорость\n Максимальная скорость: {MaxSpeed}км/ч");
            }
        }

        public static Car GetRandomCar()
        {
            var random = new Random();
            bool electrical;
            bool cargo;
            int passengers = random.Next(0, 5);

            switch (random.Next(0, 2))
            {
                case 0:
                    electrical = true;
                    break;
                case 1:
                    electrical = false;
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

            return new Car(electrical, cargo, passengers);
        }
    }
}