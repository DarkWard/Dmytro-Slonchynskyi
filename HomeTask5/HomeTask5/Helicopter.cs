using System;

namespace HomeTask5
{
    public class Helicopter : AirVehicle
    {
        public Helicopter(bool military, bool cargo, int passengers)
        {
            Military = military;
            Staff = new People { Cargo = cargo, Passangers = passengers, Service = 20 };
        }

        public Helicopter(bool military, bool cargo)
        {
            Military = military;
            Staff = new People { Cargo = cargo, Passangers = 6, Service = 20 };
        }

        public Helicopter()
        {
            MaxSpeed = 80;
            Military = false;
            Staff = new People { Cargo = true, Passangers = 2, Service = 20 };
        }

        public override void Start()
        {
            Console.WriteLine("Двигатель запущен! Лопости набирают обороты!");
        }

        public override void Move()
        {
            Console.WriteLine("Взлёт разрешён!\nВертолёт набирает скорость!");

            if (Staff.Cargo)
            {
                MaxSpeed = 80;
                Console.WriteLine($"Максимальная скорость: {MaxSpeed}км/ч");
            }
            else
            {
                MaxSpeed = 150;
                Console.WriteLine($"Максимальная скорость: {MaxSpeed}км/ч");
            }
        }

        public static Helicopter GetRandomHelicopter()
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

            return new Helicopter(military, cargo, passengers);
        }
    }
}