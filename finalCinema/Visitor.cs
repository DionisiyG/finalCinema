using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace finalCinema
{
   public  class Visitor
    {
        private string _name;
        private string _surname;
        private int _sex; 
        private int _age;
        private string[] name = new string[] { "Jack", "Asa", "Jayden", "Keiran", "Gans" };
        private string[] surname = new string[] { "Black", "Akira", "James", "Lee", "Split", "May" };

       public Visitor()
        {
            int names = RandomProvider.GetThreadRandom().Next(5);           
            _name = name[names];

            int surnames = RandomProvider.GetThreadRandom().Next(6);           
            _surname = surname[surnames];

            _age = RandomProvider.GetThreadRandom().Next(90);

            _sex = RandomProvider.GetThreadRandom().Next(2);
            if (_sex == 0)
            {
                Console.Write (" ");
            }
            else
                Console.Write(" ");
        }

        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        public string Surname
        {
            get { return _surname; }
            set { _surname = value; }
        }

        public int Age
        {
            get { return _age; }
            set { _age = value; }
        }

        public int Sex
        {

            get { return _sex; }
            set { _sex = value; }
        }

        
    }
}
