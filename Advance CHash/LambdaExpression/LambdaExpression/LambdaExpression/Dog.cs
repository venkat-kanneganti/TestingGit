using System;
using System.Collections.Generic;
using System.Linq;

namespace LambdaExpression
{
    class Dog
    {
        public string Name { get; set; }
        public int Age { get; set; }
    }

    class Demo
    {
        static void Main()
        {

            List<Dog> dogs = new List<Dog>()
            {
              new Dog {Name = "snoofy", Age = 5},
              new Dog {Name = "Morphyy", Age = 6},
              new Dog {Name = "Kichidi", Age = 7}
            };

            var names = dogs.Select(x => x.Name);
            foreach (var Name in names)
            {
                Console.WriteLine(Name);
            }

            Console.Read();
        }

    }
}
