using System;
using System.Collections.Generic;

namespace ComparingObjects
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            List<Person> people = new List<Person>();

            string input = string.Empty;

            while ((input = Console.ReadLine()) != "END")
            {
                string[] personArguments = input.Split(" ", StringSplitOptions.RemoveEmptyEntries);
                string name = personArguments[0];
                int age = int.Parse(personArguments[1]);
                string town = personArguments[2];

                Person newPerson = new Person()
                {
                    Name = name,
                    Age = age,
                    Town = town
                };
               
                people.Add(newPerson);
            }

            int n = int.Parse(Console.ReadLine());
            Person personToCompare = people[n - 1];

            int equalCounter = 0;
            int differentCounter = 0;

            foreach (var person in people)
            {
                if (person.CompareTo(personToCompare) == 0)
                {
                    equalCounter ++;
                }
                else
                {
                    differentCounter ++;
                }
            }

            if (equalCounter == 1)
            {
                Console.WriteLine("No matches");
            }
            else
            {
                Console.WriteLine($"{equalCounter} {differentCounter} {people.Count}");
            }

        }
    }
}