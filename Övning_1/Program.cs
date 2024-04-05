using System;

namespace Övning_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Car myCar = new Car();
            myCar.Brand = "Subaru";
            myCar.Model = "Impreza";
            myCar.Year = 2004;
            myCar.Color = "Blå";
            myCar.Price = 150000;

            Console.WriteLine($"Min bil är en {myCar.Color} {myCar.Year} {myCar.Brand} {myCar.Model} som kostar {myCar.Price}kr");
        }
    }
}
