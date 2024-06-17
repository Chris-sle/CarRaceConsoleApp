using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace CarRaceConsoleApp
{
    internal class Race
    {
        private List<Car> cars = new List<Car>()
        {
            new Car("BMW"),
            new Car("Volvo")
        };

        public void StartRace()
        {
            var finishLine = 10000;
            while (cars.All(car => car.Position < finishLine))
            {
                foreach (var car in cars) car.randomDrive();
                display(finishLine);
                Thread.Sleep(50);
            }
            cars[0].PrintResult(cars[1], finishLine);
        }

        public void display(int finishLine)
        {
            Console.Clear();
            foreach (var car in cars) Console.WriteLine(car.ShowInfo(finishLine));
        }
    }
}
