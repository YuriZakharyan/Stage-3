﻿using System;
using System.Collections.Generic;

namespace Yield_example
{
    class Program
    {
        public static void ProcessPeople()
        {
            var people = GetPeople(1_000_000);
            foreach (var person in people)
            {
                if (person.Id < 1000)
                    Console.WriteLine($"Id: {person.Id}, Name: {person.Name}");
                else
                    break;
            }

        }
        static IEnumerable<Person> GetPeople(int count)
        {
            for (int i = 0; i < count; i++)
            {
                yield return new Person()
                {
                    Id = i,
                    Name = $"Name {i}"
                };
            }
        }
        public static void Main(string[] args)
        {
            ProcessPeople();
        }
    }
}
