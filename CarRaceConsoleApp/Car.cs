namespace CarRaceConsoleApp
{
    internal class Car
    {
        internal string Name { get; private set; }
        internal int Speed { get; private set; }
        internal int Position { get; private set; }
        Random random = new Random();

        public Car(string name)
        {
            Name = name;
            Speed = 0;
            Position = 0;
        }

        public string ShowInfo(int maxDistance)
        {
            if (Position > maxDistance) return $"{Name} has arrived and parked.";
            return $"{Name} - Speed: {Speed} m/s | Distance: {Position}m / {maxDistance}";
        }

        public void PrintResult(Car opponent, int maxDistance)
        {
            if (Position > maxDistance) Console.WriteLine($"{Name} Won the race!");
            else if (opponent.Position >= maxDistance) Console.WriteLine($"{opponent.Name} Won the race!");
            else if (Position >= maxDistance && opponent.Position >= maxDistance) Console.WriteLine("It's a draw!");
        }

        public void Drive()
        {
            Position += Speed;
        }

        internal void randomDrive()
        {
            Position += random.Next(60, 200);
        }

        internal void ChangeSpeed(int increase)
        {
            Speed += increase;
        }
    }
}
