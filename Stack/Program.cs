using System;
using System.Linq;

namespace Stack
{
    public class StartUp
    {
        static void Main()
        {
            CustomStack<int> customStack = new CustomStack<int>();

            string input= string.Empty;

            while ((input = Console.ReadLine()) != "END")
            {
                string[] inputArguments = input.Split(" ",2, StringSplitOptions.RemoveEmptyEntries);

                string command = inputArguments[0];

                if (command == "Push")
                {
                    if (inputArguments.Length > 1)
                    {
                        int[] itemsToPush = inputArguments[1].Split(", ").Select(int.Parse).ToArray();

                        foreach (var item in itemsToPush)
                        {
                            customStack.Push(item);
                        }
                    }
                    else
                    {
                        Console.WriteLine("Incorrect input!");
                    }
                    
                }
                else if (command == "Pop")
                {
                    try
                    {
                        customStack.Pop();
                    }
                    catch (Exception e)
                    {
                        Console.WriteLine(e.Message);
                    }
                }
            }

            foreach (var item in customStack)
            {
                Console.WriteLine(item);
            }

            foreach (var item in customStack)
            {
                Console.WriteLine(item);
            }
        }
    }
}