using System;

namespace Template
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Person[] people = new Person[2] {
                                        new Person { Age = 24, Name = "Ronny" },
                                        new Person { Name = "Johanny", Age = 23 },
                                    };
            Console.WriteLine("Before Ordering");
            Display(people);

            Array.Sort(people);
            Console.WriteLine("After Ordering");
            Display(people);
        }

        static void Display(Person[] people)
        {
            foreach(Person person in people)
            {
                Console.WriteLine($"Name: {person.Name}, Age: {person.Age}");
            }
        }
    }

    class Person: IComparable
    {
        public int Age { get; set; }
        public string Name { get; set; }

        public int CompareTo(object obj)
        {
            Person person = (Person)obj;
            if (Age < person.Age)
                return -1;
            else if (Age == person.Age)
                return 0;
            else
                return 1;                
        }
    }
}
