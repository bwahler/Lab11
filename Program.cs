using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab11
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Movie List Application");

            while (true)
            {
                Console.WriteLine("Please enter a movie category (horror, independent, scifi, drama)");
                string movie = Console.ReadLine().ToLower();
                listMovie();
                foreach (Movie m in listMovies)
                {
                    if (m.MovieCategory == movie)
                    {
                        Console.WriteLine(m.MovieTitle);
                    }
                }

                Console.WriteLine("Would you like to keep going? (y/n)");
                string userContinue = Console.ReadLine().ToLower();
                if (userContinue == "y" || userContinue == "Y")
                {
                    continue;
                }
                else if (userContinue == "n" || userContinue == "N")
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Sorry, I did not understand that! Try again (y/n)");
                    userContinue = Console.ReadLine().ToLower();
                }

            }
            Console.ReadKey();
        }

        public static List<Movie> listMovies = new List<Movie>();
        public static void listMovie()
        {
            Movie halloween = new Movie("Halloween", "horror");
            Movie IT = new Movie("IT", "horror");
            Movie cube = new Movie("Cube", "scifi");
            Movie mazerunner = new Movie("Maze Runner", "scifi");
            Movie slacker = new Movie("Slacker", "independent");
            Movie beforesunrise = new Movie("Before Sunrise", "drama");


            listMovies.Add(halloween);
            listMovies.Add(IT);
            listMovies.Add(cube);
            listMovies.Add(mazerunner);
            listMovies.Add(slacker);
            listMovies.Add(beforesunrise);

        }
    }
}
