using System;

namespace Cellphone {
    class Program {
        static void Main(string[] args) {

            var cp1 = new Cellphone {
                PhoneNumber = "513-555-1212",
                ServiceProvider = "Verizon",
                OperatingSystem = "iOS",
                Capacity = 128,
                Model = "iPhone X"
            };
            var cp2 = new Cellphone {
                PhoneNumber = "614-555-1212",
                ServiceProvider = "T-Mobile",
                OperatingSystem = "Android",
                Capacity = 64,
                Model = "Samsung"
            };
            var cp3 = new Cellphone {
                PhoneNumber = "216-555-1212",
                ServiceProvider = "T-Mobile",
                OperatingSystem = "Android",
                Capacity = 256,
                Model = "Samsung"
            };
            
            var cellphones = new Cellphone[] { cp1, cp2, cp3 };

            foreach(var cp in cellphones) {
                Console.WriteLine($"phone number is {cp.PhoneNumber}");
            }
        }
    }

}
