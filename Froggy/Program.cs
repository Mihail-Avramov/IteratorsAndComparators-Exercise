using System;
using System.Linq;

namespace Froggy
{
    public class StartUp    
    {
        static void Main()
        {
            Lake stones = new Lake(Console.ReadLine().Split(", ").Select(int.Parse).ToList());

            Console.WriteLine(string.Join(", ", stones));
        }
    }
}