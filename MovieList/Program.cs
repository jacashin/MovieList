using System;
using System.Collections.Generic;

namespace MovieList
{
    class Program
    {
        static void Main(string[] args)
        {
                do

                {
                    Console.WriteLine("Welcome to the movie list, what category are you interested in (SciFi, Horror, Animated or Drama");

                    var userChoice = Console.ReadLine();

                    Console.WriteLine("              ");

                    ClassOfMovies classofMovies = new ClassOfMovies();

                    classofMovies.titleAndCat = new List<ClassThatContainsAllTheInfoForMovieList>();

                    classofMovies.titleAndCat.Add(new ClassThatContainsAllTheInfoForMovieList() { Title = "Down akaThe Shaft", Category = "Horror" });
                    classofMovies.titleAndCat.Add(new ClassThatContainsAllTheInfoForMovieList() { Title = "Dead and Deader", Category = "Horror" });
                    classofMovies.titleAndCat.Add(new ClassThatContainsAllTheInfoForMovieList() { Title = "Sleepaway Camp", Category = "Horror" });
                    classofMovies.titleAndCat.Add(new ClassThatContainsAllTheInfoForMovieList() { Title = "Alien: Covenent", Category = "SciFi" });
                    classofMovies.titleAndCat.Add(new ClassThatContainsAllTheInfoForMovieList() { Title = "Valerian", Category = "SciFi" });
                    classofMovies.titleAndCat.Add(new ClassThatContainsAllTheInfoForMovieList() { Title = "Transformers: Last Knight", Category = "SciFi" });
                    classofMovies.titleAndCat.Add(new ClassThatContainsAllTheInfoForMovieList() { Title = "Ghost in the Shell", Category = "SciFi" });
                    classofMovies.titleAndCat.Add(new ClassThatContainsAllTheInfoForMovieList() { Title = "Mars Needs Moms", Category = "Animated" });
                    classofMovies.titleAndCat.Add(new ClassThatContainsAllTheInfoForMovieList() { Title = "Sir Billi", Category = "Animated" });
                    classofMovies.titleAndCat.Add(new ClassThatContainsAllTheInfoForMovieList() { Title = "The Room", Category = "Drama" });

                    if (!(userChoice.Equals("Horror", StringComparison.OrdinalIgnoreCase) || userChoice.Equals("SciFi", StringComparison.OrdinalIgnoreCase) || userChoice.Equals("Animated", StringComparison.OrdinalIgnoreCase) || userChoice.Equals("Drama", StringComparison.OrdinalIgnoreCase)))
                    {
                        Console.WriteLine("Sorry dude, that don't exist");
                    }
                    else
                    {
                        foreach (var item in classofMovies.titleAndCat)
                        {
                            if (userChoice.ToUpper() == item.Category.ToUpper())
                            {
                                Console.WriteLine(item.Title);
                            }
                        }
                    }
                Console.WriteLine("----------------------------------------------------------------------------");

                Console.WriteLine("Would you like to do this again? (y/n)");                   
                }
                while (Console.ReadLine().Equals("y", StringComparison.OrdinalIgnoreCase));
            }
        }
    }
