using System;
using System.Collections.Generic;
using System.Linq;

namespace Collection
{
    public class StartUp
    {
        static void Main()
        {
            List<string> items = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Skip(1).ToList();

            ListyIterator<string> listyIterator = new ListyIterator<string>(items);

            string command;

            while ((command = Console.ReadLine()) != "END")
            {
                if (command == "Print")
                {
                    try
                    {
                        listyIterator.Print();
                    }
                    catch (InvalidOperationException exception)
                    {
                        Console.WriteLine(exception.Message);
                    }
                }
                else if (command == "Move")
                {
                    Console.WriteLine(listyIterator.Move());
                }
                else if (command == "HasNext")
                {
                    Console.WriteLine(listyIterator.HasNext());
                }
                else if (command == "PrintAll")
                {
                    Console.WriteLine(string.Join(" ", listyIterator));
                }
            }
        }
    }
}