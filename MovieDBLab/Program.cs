using System;
using System.Collections.Generic;
using System.Linq;

namespace MovieDBLab
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Movie> SearchMovie;
            string input = "";
            bool validInput = false;
            while (!validInput)
            {
                Console.WriteLine("Would you like to search using a movie: title or genre?");
                input = Validator.Validator.GetString();
                validInput = Validator.Validator.CompareToList(input, new List<string> { "title", "genre" });
            }
            if (input == "name")
            {
                SearchMovie = FindName();
            }
            else
            {
                SearchMovie = GetGenre(new List<string> { "horror", "animation", "action", "sci-fi", "drama" });
            }

            foreach (Movie m in SearchMovie)
            {
                Console.WriteLine($"Title: {m.Title} Genre: {m.Genre} Runtime: {m.Runtime} hours");
            }
        }

        public static List<Movie> FindName()
        {
            while (true)
            {
                Console.WriteLine("What Movie would you like to search?");
                string name = Validator.Validator.GetString();

                using (MovieDBContext movie = new MovieDBContext())
                {
                    List<Movie> movieName = movie.Movies.Where(m => m.Title.ToLower() == name).ToList();
                    if (movieName.Count > 0)
                    {
                        return movieName;
                    }
                }
            }
        }

        public static List<Movie> GetGenre(List<string> options)
        {
            while (true)
            {
                Console.WriteLine("What genre would you like to search?");
                string genre = Validator.Validator.GetString();
                bool ValidOption = Validator.Validator.CompareToList(genre, options);
                if (ValidOption)
                {
                    using (MovieDBContext movie = new MovieDBContext())
                    {

                        List<Movie> movieGenre = movie.Movies.Where(m => m.Genre.ToLower() == genre).ToList();
                        if (movieGenre.Count > 0)
                        {
                            return movieGenre;
                        }

                    }
                }
                else
                {
                    Console.WriteLine("Unfortunetly there are no options of the title that you looking for");
                }
            }
        }
    }
}

