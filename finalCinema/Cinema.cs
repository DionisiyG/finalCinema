using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace finalCinema
{
    class Cinema
    {
        int rnd;
        string isNull = null;
        public int summOfViewers = 0;
        public int numberOfMales = 0;
        public int numberOfFemales = 0;
        public double getAverageAge = 0;
        public double getAverageAgeMale = 0;
        public double getAverageAgeFemale = 0;
        Random random = new Random();

        public Cinema()
        {
            Visitor[,] visitors = new Visitor[4, 5];
            for (int i = 0; i < visitors.GetLength(0); i++)
            {
                for (int j = 0; j < visitors.GetLength(1); j++)
                {
                    rnd = random.Next(0, 2);
                    if (rnd == 0)
                    {
                        isNull = rnd.ToString();
                        Console.Write("*");
                    }
                    else
                    {
                        summOfViewers++;
                        Visitor newVisitor = new Visitor();
                        Console.Write(newVisitor.Name + " " + newVisitor.Surname + " (" + newVisitor.Age + ") ");

                        if (newVisitor.Age >= 0)
                        {
                            getAverageAge += newVisitor.Age;
                        }

                        if (newVisitor.Sex == 0)
                        {
                            numberOfMales++;
                            getAverageAgeMale += newVisitor.Age;
                        }
                        else
                        {
                            numberOfFemales++;
                            getAverageAgeFemale += newVisitor.Age;
                        }
                    }
                    Console.Write(visitors[i, j] + " ");
                }
                Console.WriteLine();
            }
        }
    }

}
