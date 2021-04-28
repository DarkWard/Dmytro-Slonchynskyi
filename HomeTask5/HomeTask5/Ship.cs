using System;

namespace HomeTask5
{
    public class Ship : WaterVehicle
    {
        public Ship(bool military, bool cargo, int passengers)
        {
            Military = military;
            Staff = new People { Cargo = cargo, Passangers = passengers, Service = 70 };
        }

        public Ship(bool military, bool cargo)
        {
            Military = military;
            Staff = new People { Cargo = cargo, Passangers = 10, Service = 70 };
        }

        public Ship()
        {
            MaxSpeed = 20;
            Military = false;
            Staff = new People { Cargo = true, Passangers = 10, Service = 70 };
        }

        public override void Start()
        {
            Console.WriteLine("Двигатель запущен!\nШампанское разбито!");
        }

        public override void Move()
        {
            Console.WriteLine("Отшвартовываемся, полный вперёд!\nКурс зюйд-зюйд-вест!");

            if (Staff.Cargo)
            {
                MaxSpeed = 20;
                Console.WriteLine($"Максимальная скорость: {MaxSpeed}км/ч");
            }
            else
            {
                MaxSpeed = 40;
                Console.WriteLine($"Максимальная скорость: {MaxSpeed}км/ч");
            }
        }

        public static Ship GetRandomShip()
        {
            var random = new Random();
            bool military;
            bool cargo;
            int passengers = random.Next(0, 5);

            switch (random.Next(0, 2))
            {
                case 0:
                    military = true;
                    break;
                case 1:
                    military = false;
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

            return new Ship(military, cargo, passengers);
        }
    }
}