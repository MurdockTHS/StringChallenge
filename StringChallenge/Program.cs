﻿using System;

namespace StringChallenge
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the string here: ");

            string input = Console.ReadLine();

            Console.Write("Enter a Character to search: ");

            char searchInput = Console.ReadLine()[0];

            int searchIndex = input.IndexOf(searchInput);
            Console.WriteLine("Index of character {0} in string is {1}", searchInput, searchIndex);

            Console.Write("Enter first name: ");
            string firstName = Console.ReadLine();
            Console.Write("Enter last name: ");
            string lastName = Console.ReadLine();

            string fullName = string.Concat(firstName, " ", lastName);
            Console.WriteLine("Your full name is {0}", fullName);
        }
    }
}
