using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lists
{
    class Program
    {
        static void Main(string[] args)
        {
            //Lists
            //List<datatype> variableName = new List<datatype>();
            //List<int> favNums = new List<int>();
            //favNums.Add(7);
            //favNums.Add(2);
            //favNums.Add(15);

            //foreach (int num in favNums)
            //{
            //    Console.WriteLine(num);
            //}
            //.Count for List size
            //Console.WriteLine(favNums.Count());
            //List<string> books = new List<string>() { "Cat in the hat", "Green eggs and ham", "Toad and frog" };
            //Console.WriteLine(books[0]);
            //Inserts a new element at selected index and moves all elements, thereafter, over one.
            //books.Insert(0, "Horton hears a hoot");
            //Console.WriteLine(books[0] + books[1]);

            //Create a List and add 5 animals using the .Add() method. Print List.

            //List<string> animals = new List<string>();
            //animals.Add("Squirrel");
            //animals.Add("Monkey");
            //animals.Add("Dog");
            //animals.Add("Ferret");
            //animals.Add("Cat");

            //foreach (string animal in animals)
            //{
            //    Console.WriteLine(animal);
            //}

            //A bool List {true, false, false, true, false}
            //If value is true print "Better bring an umbrella."
            //If the value is false print "No rain today enjoy the sun."
            //List<bool> rain = new List<bool> { true, false, false, true, false };
            //foreach (bool isRain in rain)
            //{
            //    if (isRain == true)
            //    {
            //        Console.WriteLine("Better bring an umbrella.");
            //    }
            //    else
            //    {
            //        Console.WriteLine("No rain today enjoy the sun.");
            //    }
            //}

            //List<string> favFoods = new List<string> { "Steak", "Fish", "Ice Cream", "Katudon", "Nachos" };
            //foreach (string food in favFoods)
            //{
            //    Console.WriteLine(food);
            //}
            //if (!favFoods.Contains("Pizza"))
            //{
            //    Console.WriteLine();
            //    favFoods.Add("Pizza");
            //    favFoods.Sort();
            //    foreach (string food in favFoods)
            //    {
            //        Console.WriteLine(food);
            //    }
            //}

            //Create a list with the following numbers: 1 23 9 77 922 6 32 63 14 5
            //List<int> numbers = new List<int> { 1, 23, 9, 77, 922, 6, 32, 63, 14, 5 };
            ////Use contains method with the following values: 23 77 15
            //Console.WriteLine(numbers.Contains(23));
            //Console.WriteLine(numbers.Contains(77));
            //Console.WriteLine(numbers.Contains(15));
            //numbers.Remove(23);
            //numbers.Remove(77);
            //numbers.Remove(32);
            //numbers.Remove(6);

            //if (numbers.Contains(23) || numbers.Contains(77) || numbers.Contains(15))
            //{
            //    Console.WriteLine("23 is at the index of: {0}\n77 is at the index of: {1}\n15 is at the index of: {2}",
            //        numbers.IndexOf(23), numbers.IndexOf(77), numbers.IndexOf(15));
            //}
            //else
            //{
            //    Console.WriteLine("These numbers are not in this List");
            //}
            ////Remove these elements: 23 77 32 and 6
            //if (numbers.IndexOf(23) >= 0)
            //{
            //    numbers.Remove(23);
            //}
            //if (numbers.IndexOf(77) >= 0)
            //{
            //    numbers.Remove(77);
            //}
            //if (numbers.IndexOf(15) >= 0)
            //{
            //    numbers.Remove(15);
            //}
            //if (numbers.Contains(23) || numbers.Contains(77) || numbers.Contains(15))
            //{
            //    Console.WriteLine("23 is at the index of: {0}\n77 is at the index of: {1}\n15 is at the index of: {2}",
            //        numbers.IndexOf(23), numbers.IndexOf(77), numbers.IndexOf(15));
            //}
            //else
            //{
            //    Console.WriteLine();
            //    Console.WriteLine("These numbers are not in this List");
            //}
            //Use a contains method on the following values: 23 77 15

            //Movie Ordering Service
            //List of Movies
            //Ask user for movie to play
            //if in the list inform the user
            //else inform the user it will be ordered
            //continue as long as the user wants to continue
            //if user says quit end program

            List<string> movies = new List<string> { "terminator", "spiderman", "the incredible hulk" };
            Console.WriteLine("Welcome to Myflix\n");
            string cont;
            do
            {
                //Intro
                Console.WriteLine("Please enter a movie you'd like to watch:");
                //User Input
                string movie = Console.ReadLine().ToLower();
                //If input == quit show list and end program
                if (movie == "quit")
                {
                    movies.Sort();
                    foreach (string movieInList in movies)
                    {
                        Console.WriteLine(movieInList);
                    }
                    Environment.Exit(0);
                }
                //Checking if we have the movie in the list
                if (movies.Contains(movie))
                {
                    Console.WriteLine("We have that movie!");
                    Console.WriteLine("Would you like to continue searching? Yes/No");
                    //Ask user if he wants to continue
                    cont = Console.ReadLine().ToLower();
                    //If input == quit show list and end program
                    if (cont == "quit")
                    {
                        movies.Sort();
                        //Display movie list and end program
                        foreach (string movieInList in movies)
                        {
                            Console.WriteLine(movieInList);
                            Environment.Exit(0);
                        }
                    }
                }
                else
                {
                    Console.WriteLine("We apologize, that movie is not in our inventory. It will be available soon!");
                    Console.WriteLine("Would you like to continue searching? Yes/No");
                    cont = Console.ReadLine().ToLower();
                    movies.Add(movie);
                    if (cont == "quit")
                    {
                        movies.Sort();
                        foreach (string movieInList in movies)
                        {
                            Console.WriteLine(movieInList);
                            
                        }
                        Console.WriteLine("\tWill be added soon.");
                        Environment.Exit(0);
                    }

                }
            }
            while (cont == "yes");
        }
    }
}
