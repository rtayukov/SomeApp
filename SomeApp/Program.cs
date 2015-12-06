using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace SomeApp
{
    public struct Person:IBuilding
    {
        public string Name;
        public int Age;
        public Person(string name, int age)
        {
            Name = name;
            Age = age;
        }

    }

    class Program
    {
        static void Main()
        {
            

            Building House = new Building();
            int areaPP;
            Building Office = new Building();

            House.Area = 2500;
            House.Occupants = 4;
            House.Floors = 2;

            areaPP = House.Area / House.Occupants;

            Person person1 = new Person("Koly", 12);
            Person person2 = person1;
            //person2.Name = "Nadya";
            //person2.Age = 30;

            Console.WriteLine("Person1\n Name: {0}\n Age: {1}", person1.Name, person1.Age);
            Console.WriteLine("Person2\n Name: {0}\n Age: {1}", person2.Name, person2.Age);

            Console.WriteLine("\n{0} and {1} is Equals? {2}", person1.Name, person2.Name, person1.Equals(person2));

            Console.WriteLine("\n{0} and {1} is Equals? {2}", "House", "Office", House.Equals(Office));

            //Console.WriteLine("Дом имеет:\n "+
            //                  House.Floors + " этажа\n "+
            //                  House.Occupants + " жильца\n "+
            //                  House.Area + " кв. футов общей площади\n "+
            //                  areaPP + " кв. футов площади приходится на человека. ");
        }
    }
}
