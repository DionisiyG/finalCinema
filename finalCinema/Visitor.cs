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
        private bool _sex; // if true = Male, false = Female
        private int _age;

        Visitor()
        {
            int names = RandomProvider.GetThreadRandom().Next(5);
            string[] name = new string[] { "Jack", "Asa", "Jayden", "Keiran", "Gans" };
            _name = name[names];

            int surnames = RandomProvider.GetThreadRandom().Next(6);
            string[] surname = new string[] { "Black", "Akira", "James", "Lee", "Split", "May" };
            _surname = surname[surnames];

            _age = RandomProvider.GetThreadRandom().Next(90);
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

        public bool Sex
        {

            get { return _sex; }
            set { _sex = value; }
        }
    }
}
