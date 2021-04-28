using System;

namespace HomeTask5
{
    public class Train : GroundVehicle
    {
        private bool _electrical;

        public Train(bool electrical, bool cargo, int passangers)
        {
            _electrical = electrical;
            Staff = new People { Cargo = cargo, Passangers = passangers, Service = 40 };
        }

        public Train(bool electrical, bool cargo)
        {
            _electrical = electrical;
            Staff = new People { Cargo = cargo, Passangers = 0, Service = 40 };
        }

        public Train()
        {
            _electrical = false;
            Staff = new People { Cargo = true, Passangers = 0, Service = 40 };
        }

        public override void Start()
        {
            Console.WriteLine("Вагоны проверены!\nДвигатель заведён!");
        }

        public override void Move()
        {
            if (_electrical)
            {
                MaxSpeed = 70;
                Console.WriteLine($"Электровоз тронулся!\n Максимальная скорость: {MaxSpeed}км/ч");
            }
            else
            {
                MaxSpeed = 130;
                Console.WriteLine($"Тягач тронулся!\n Максимальная скорость: {MaxSpeed}км/ч");
            }
        }

        public static Train GetRandomTrain()
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

            return new Train(electrical, cargo, passengers);
        }
    }
}