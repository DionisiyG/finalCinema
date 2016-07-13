using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace finalCinema
{
    class Program
    {

        static void Main(string[] args)
        {
            Cinema cinema = new Cinema();
            Console.WriteLine();
            Console.WriteLine("Number of viewers:" + cinema.summOfViewers);
            Console.WriteLine("Average age of viewers:" + cinema.getAverageAge / cinema.summOfViewers);
            Console.WriteLine("Total number of Male is:" + cinema.numberOfMales);
            Console.WriteLine("Total number of Female is:" + cinema.numberOfFemales);
            Console.WriteLine("Average age of Males is:" + cinema.getAverageAgeMale / cinema.numberOfMales);
            Console.WriteLine("Average age of Females is:" + cinema.getAverageAgeFemale / cinema.numberOfFemales);
            Console.WriteLine();
           

            Console.ReadLine();

        }
    }
}
