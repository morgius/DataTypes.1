using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Objects
{
    class Program
    {
        static void Main(string[] args)
        {
            Animal animal = new Horse();
            animal.Sound();
            Console.WriteLine(animal.GetLegs());
            Console.WriteLine(animal.Name);
            Console.ReadLine();
        }
    }
}
