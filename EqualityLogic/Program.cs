using System;
using System.Collections.Generic;

namespace EqualityLogic
{
    public class StartUp    
    {
        static void Main()
        {
            HashSet<Person> personsSet = new HashSet<Person>();
            SortedSet<Person> personsSortedSet = new SortedSet<Person>();

            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                Person newPerson = new(Console.ReadLine());
                personsSet.Add(newPerson);
                personsSortedSet.Add(newPerson);
            }

            Console.WriteLine(personsSortedSet.Count);
            Console.WriteLine(personsSet.Count);
        }
    }
}