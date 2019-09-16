using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataTypes
{
    class Program
    {
        static void Main(string[] args)
        {
            Person roman = new Person();
            roman.Name = "Roman";
            roman.LastName = "Nowak";
            roman.BirthDate = 2000;
            Console.WriteLine(roman.GetAge());
            Console.ReadLine();
        }
    }
}
