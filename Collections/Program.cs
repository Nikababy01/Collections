using System;
using System.Collections.Generic;

namespace Collections
{
    class Program
    {
        static void Main(string[] args)
            
        {
            //List are general purpose colection that is pretty good at everything
            var instructors = new List<string>();
            var students = new List<string>();
            var evening11 = new List<string>();
            var numbers = new List<int>();
            
            // adds names to the list of names string
            instructors.Add("Jameka");
            instructors.Add("Nathan");
            instructors.Add("John");
           
            // adds numbers to the list of numbers string
            numbers.Add(1);
            numbers.Add(3);
            numbers.Add(5);

            // adds more than one thing at a time

           students.Add("Aaron");
           students.Add("John");
           students.Add("Monique");

            //add multiple at once from an existing list
            evening11.AddRange(instructors);
            evening11.AddRange(students);

            foreach (var person in evening11)
            {
                Console.WriteLine($"{person} is in evening cohort 11.");
            }

            var steveIsInE11 = evening11.Contains("Steve");

            // must put terinary inside parentheses
            Console.WriteLine($"Steve is {(steveIsInE11 ? "" : "not ")}in e11.");

            var matchingPerson = evening11.Find(person => person.StartsWith("J"));

            Console.WriteLine($"{matchingPerson} starts with 'J'");
            Console.WriteLine($"{students[1]} is the student at the index of 1?");

            //Dictionaries take in 2 types of arguements
            var words = new Dictionary<string, string>();
            words.Add("pedantic","Like a pedant");
            words.Add("congratulate", "to celebrate");
            words.Add("scrupulous", "diligent, thorough, extremely attentive to details");
            //keys must be unique, this won't work
            

            Console.WriteLine($"The fake definition of Congratulations is {(words["congratulate"])}.");

            foreach (var entry in words)
            {
                Console.WriteLine($"The fake definition of {entry.Key} is {entry.Value}");
            }
            var wordWithMultipleDefinitions = new Dictionary<string, List<string>>
            {
                {
                    "Scrupulous",
                new List<string> {"Diligent", "Thorough", "Extremely attentive to detail"}
                }
            };
            foreach (var(word, definitions) in wordWithMultipleDefinitions) 
            {
                Console.WriteLine($"{word} is defined as :");
                definitions.Add("poop");
                foreach (var definition in definitions)
                {
                    Console.WriteLine($"  {definition}");
                }
            }
        }
    }
}
