
using System;

namespace RS2.InterfaceEquitable
{
    public class Program
    {

        static void Main()
        {
            Car auto1 = new Car
            {
                Make = "Toyota",
                Model = "Corrola",
                Year = "2020"
            };
            Car auto2 = new Car
            {
                Make = "Toyota",
                Model = "Corrola",
                Year = "2019"
            };
            Car auto3 = new Car
            {
                Make = "Toyota",
                Model = "Corrola",
                Year = "2020"
            };
            if (auto1.Equals(auto2))
            {
                Console.WriteLine(nameof(auto1) + " i " + nameof(auto2)
                + " su isti.");
            }
            else
            {
                Console.WriteLine(nameof(auto1) + " i " + nameof(auto2)
                + " nisu isti.");
            }
            if (auto1.Equals(auto3))
            {
                Console.WriteLine(nameof(auto1) + " i " + nameof(auto3)
                + " su isti.");
            }
            else
            {
                Console.WriteLine(nameof(auto1) + " i " + nameof(auto3)
                + " nisu isti.");
            }

        }

    }
}

