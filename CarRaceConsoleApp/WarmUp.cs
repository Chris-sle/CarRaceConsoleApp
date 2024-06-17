namespace CarRaceConsoleApp
{
    internal class WarmUp
    {
        Car car1 = new Car("Toyota");

        public void TestDrive()
        {
            const int maxDistance = 1000;
            const int maxSpeedUpTo500m = 500;

            while (car1.Position < maxDistance)
            {
                if (car1.Position < maxSpeedUpTo500m)
                {
                    car1.ChangeSpeed(10);
                    car1.Drive();
                }
                else if (car1.Position >= maxSpeedUpTo500m && car1.Speed > 10)
                {
                    car1.ChangeSpeed(-10);
                    car1.Drive();
                }

                Console.WriteLine(car1.ShowInfo(maxDistance));
                Thread.Sleep(100);
            }

            Console.WriteLine($"{car1.Name} has arrived and parked.");
        }
    }
}
