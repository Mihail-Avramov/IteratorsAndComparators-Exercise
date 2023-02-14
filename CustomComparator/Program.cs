using System;
using System.Linq;

Func<int, int, int> customComparator = (num1, num2) =>
{
    if (num1 % 2 == 0 && num2 % 2 != 0)
    {
        return -1;
    }

    if (num1 % 2 != 0 && num2 % 2 == 0)
    {
        return 1;
    }

    return num1.CompareTo(num2);
};

int[] numbers = Console.ReadLine()
    .Split(" ", StringSplitOptions.RemoveEmptyEntries)
    .Select(int.Parse)
    .ToArray();



Array.Sort(numbers, (num1, num2) => customComparator(num1, num2));

Console.WriteLine(string.Join(" ", numbers));