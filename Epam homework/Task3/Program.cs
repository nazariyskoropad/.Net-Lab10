using System;
using System.Collections.Generic;
//using System.Linq;

namespace Task3
{
    class Program
    {
        public static List<string> ListOfStrings = new List<string>();
        static void Main(string[] args)
        {
            Console.WriteLine("Task 3.1\n");
            var persons = new List<Person>();

            var tom = new Person
            {
                Name = "Tom",
                Age = 18,
                PhoneNumbers = new[] { "+380000000000", "+3800000000001", "+3800000000002" }
            };
            persons.Add(tom);

            var bob = new Person
            {
                Name = "Bob",
                Age = 19,
                PhoneNumbers = new[] { "+380000000003", "+3800000000004", "+3800000000005", "+3800000000006" }
            };
            persons.Add(bob);

            var jack = new Person
            {
                Name = "Jack",
                Age = 20,
                PhoneNumbers = new[] { "+380000000007", "+3800000000008", "+3800000000009" }
            };
            persons.Add(jack);

            var richard = new Person
            {
                Name = "Richard",
                Age = 21,
                PhoneNumbers = new[] { "+380000000010", "+3800000000011", "+3800000000012" }
            };
            persons.Add(richard);

            var jeremy = new Person
            {
                Name = "Jeremy",
                Age = 22,
                PhoneNumbers = new[] { "+380000000013", "+3800000000014", "+3800000000015" }
            };
            persons.Add(jeremy);

            var james = new Person
            {
                Name = "James",
                Age = 23,
                PhoneNumbers = new[] { "+380000000016", "+3800000000017", "+3800000000018" }
            };
            persons.Add(james);

            foreach (var person in persons)
            {
                Console.WriteLine($"{person.Name}: age = {person.Age}");
            }

            Console.WriteLine("\n______________________________\nTask 3.2\n");
            IEnumerable<Person> TwoMorePersons = new[]
            {
                new Person()
                {
                     Name = "Stig",
                     Age = 24,
                     PhoneNumbers = new[] { "+380000000019", "+3800000000020", "+3800000000021" }
                },

                new Person()
                {
                     Name = "Leo",
                     Age = 25,
                    PhoneNumbers = new[] { "+380000000022", "+3800000000023", "+3800000000024", "+3800000000025 " }
                }
            };

            persons.AddRange(TwoMorePersons);

            int indexOfPerson = 1;
            foreach (var person in persons)
            {
                Console.WriteLine($"{indexOfPerson}. phone numbers:");
                indexOfPerson++;
                foreach (var number in person.PhoneNumbers)
                {
                    Console.Write(number + " ");
                }
                Console.WriteLine();
                Console.WriteLine();
            }

//---------------------------------------------------------------------------------------------
            Console.WriteLine("______________________________\nTask 3.3\n");

            // initializing
            var AllChars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";           
            var temp = new char[4];            
            var random = new Random();
              for (int i = 0; i < 110; i++)
              {
                  for (int j = 0; j < 4; j++)
                      temp[j] = AllChars[random.Next(AllChars.Length)];
                  ListOfStrings.Add(new String(temp));
              }

            Console.Write("Number of elements before transformations = " + ListOfStrings.Count + "\n");

            //remove elements which start with z
            int l = ListOfStrings.Count;
            for (int i = 0; i < l; i++)
            {
                if (ListOfStrings[i].StartsWith('Z'))
                {
                    ListOfStrings.Remove(ListOfStrings[i]);
                    i--;
                    l--;
                }
            }

            //remove repeatable
            var ListOfRepeatableStrings = new List<string>();
            for (int i =0; i<ListOfStrings.Count; i++)
                for (int j=i+1; j<ListOfStrings.Count; j++)
                {
                    if (ListOfStrings[i] == ListOfStrings[j] && !ListOfRepeatableStrings.Contains(ListOfStrings[i]))
                        ListOfRepeatableStrings.Add(ListOfStrings[i]);
                }
            for (int i = 0; i < ListOfRepeatableStrings.Count; i++)
                ListOfStrings.RemoveAll(x => x == ListOfRepeatableStrings[i]);

            ListOfStrings.Sort();
            ListOfStrings.Reverse();

            Console.Write("Number of elements after transformations = " + ListOfStrings.Count + "\n");

            try
            {                          
                Console.WriteLine("\nEnter a number of page or any other character to quit: ");
                int pageNumber = int.Parse(Console.ReadLine());
                DisplayPage(pageNumber);
                
            }
            catch (Exception)
            {
                Console.WriteLine("Exiting...");
            }

        }

        public static void DisplayPage(int pageNumber)
        {
            int numberOfPages = 0;
            if (ListOfStrings.Count % 5 == 0)
                numberOfPages = ListOfStrings.Count / 5;
            else
                numberOfPages = ListOfStrings.Count / 5 + 1;
            
            if (pageNumber > numberOfPages)
                Console.WriteLine("Sorry, we don't have so much pages");
            else if (pageNumber == numberOfPages)
                for (int i = pageNumber * 5 - 5; i < ListOfStrings.Count; i++)
                    Console.WriteLine(i + 1 + ". " + ListOfStrings[i]);
            else
                for (int i = pageNumber * 5 - 5; i < pageNumber * 5; i++)
                    Console.WriteLine(i + 1 + ". " + ListOfStrings[i]);
        }
    }
}
//правильно запушити


