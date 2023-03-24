using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PR1
{
    class Car
    {
        public int maxSpeed;
        public string Name;
        public Car(int maxSpeed,string Name)
        {
            this.Name = Name;
            this.maxSpeed = maxSpeed;
        }
        //Расчёт времени (мин)
        public double CalculateTime(double distance)
        {
            return (distance / maxSpeed)*100;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            int distance = 100;
            string win = "";
            //spid car random
            Random rndSpeed = new Random();
            int[] mXS = {
                rndSpeed.Next(100, 180),
                rndSpeed.Next(100, 180),
                rndSpeed.Next(100, 180),
                rndSpeed.Next(100, 180)
            };

            //name car
            Random rndNum = new Random();
            string[] num = {
                "Car - " +  rndNum.Next(0, 99),
                "Car - " + rndNum.Next(0, 99),
                "Car - " + rndNum.Next(0, 99),
                "Car - " + rndNum.Next(0, 99)
            };

            //Инициализация конструктором
            Car car1 = new Car(mXS[0], num[0]);
            Car car2 = new Car(mXS[1], num[1]);
            Car car3 = new Car(mXS[2], num[2]);
            Car car4 = new Car(mXS[3], num[3]);

            //Расчёт времени (мин)
            double[] timeC = {
                car1.CalculateTime(distance),
                car2.CalculateTime(distance),
                car3.CalculateTime(distance),
                car4.CalculateTime(distance)
            };    

            //Вычисления
            double winner = timeC.Min();
            if (winner == timeC[0])
                win = num[0];
            else if (winner == timeC[1])
                win = num[1];
            else if (winner == timeC[2])
                win = num[2];
            else if (winner == timeC[3])
                win = num[3];

            //Вывод
            Console.WriteLine($"Гонки рандома " +
                $"\nТрасса - 100Км " +
                $"\n\tПобеда достаётся: \"{win}\""+
                $"\n{car1.Name}, \tV = {car1.maxSpeed} Км/ч, t = {timeC[0]:f2} мин.;" +
                $"\n{car2.Name}, \tV = {car2.maxSpeed} Км/ч, t = {timeC[1]:f2} мин.;" +
                $"\n{car3.Name}, \tV = {car3.maxSpeed} Км/ч, t = {timeC[2]:f2} мин.;" +
                $"\n{car4.Name}, \tV = {car4.maxSpeed} Км/ч, t = {timeC[3]:f2} мин.;");
            Console.ReadKey(true);
            // v = максимальная скорость (км/ч) , t = время (мин).
        }
    }
}
