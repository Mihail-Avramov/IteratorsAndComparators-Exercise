
using System;

namespace EqualityLogic
{
    public class Person :IComparable<Person>
    {
        public Person(string info)
        {
            string[] personInfo = info.Split(" ", StringSplitOptions.RemoveEmptyEntries);

            this.Name = personInfo[0];
            this.Age = int.Parse(personInfo[1]);
        }

        public string Name { get; set; }
        public int Age { get; set; }


        public int CompareTo(Person other)
        {
            if (this.Name.CompareTo(other.Name) == 0)
            {
                return this.Age.CompareTo(other.Age);
            }

            return this.Name.CompareTo(other.Name);
        }

        public override string ToString()
        {
            return $"{this.Name} => {this.Age}";
        }

        public override bool Equals(object obj)
        {
            Person other = obj as Person;

            if (other == null)
            {
                return false;
            }

            return Name == other.Name && Age == other.Age;
        }

        public override int GetHashCode()
        {
            int hashCode = Name.GetHashCode() + Age.GetHashCode();
            return hashCode;
        }
    }
}
