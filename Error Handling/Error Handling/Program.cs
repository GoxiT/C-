using My_Library.Classes;
using My_Library.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Error_Handling
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Movie
            Movie movie1 = new Movie("Scary Movie", Genre.Comedy, 4, 2.5);
            Movie movie2 = new Movie("American Pie", Genre.Comedy, 4, 2.5);
            Movie movie3 = new Movie("Saw", Genre.Horror, 4, 2.5);
            Movie movie4 = new Movie("The Shining", Genre.Horror, 4, 2.5);
            Movie movie5 = new Movie("Rambo", Genre.Action, 4, 2.5);
            Movie movie6 = new Movie("The Terminator", Genre.Action, 4, 2.5);
            Movie movie7 = new Movie("Forrest Gump", Genre.Drama, 4, 2.5);
            Movie movie8 = new Movie("12 Angru Men", Genre.Drama, 4, 2.5);
            Movie movie9 = new Movie("Passengers", Genre.SciFi, 4, 2.5);
            Movie movie10 = new Movie("Interstellar", Genre.SciFi, 4, 2.5);
            List<Movie> MovieSet1 = new List<Movie>() { movie1, movie2, movie3, movie4, movie5, movie6, movie7, movie8, movie9, movie10 };
            Movie movie11 = new Movie("Airplane", Genre.Comedy, 4, 2.5);
            Movie movie12 = new Movie("Johnny English", Genre.Comedy, 4, 2.5);
            Movie movie13 = new Movie("The Ring", Genre.Horror, 4, 2.5);
            Movie movie14 = new Movie("Sinister", Genre.Horror, 4, 2.5);
            Movie movie15 = new Movie("RoboCop", Genre.Action, 4, 2.5);
            Movie movie16 = new Movie("Judge Dredd", Genre.Action, 4, 2.5);
            Movie movie17 = new Movie("The Social Network", Genre.Drama, 4, 2.5);
            Movie movie18 = new Movie("The Shawshank Redemption", Genre.Drama, 4, 2.5);
            Movie movie19 = new Movie("Inception", Genre.SciFi, 4, 2.5);
            Movie movie20 = new Movie("Avatar", Genre.SciFi, 4, 2.5);
            List<Movie> MovieSet2 = new List<Movie>() { movie11, movie12, movie13, movie14, movie15, movie16, movie17, movie18, movie19, movie20 };
            #endregion Movie
            #region Cinema

            Cinema cinema1 = new Cinema("Cineplex");
            cinema1.Halls = new List<int>() { 1, 2, 3, 4 };
            cinema1.ListOfMovies = MovieSet1;
            Cinema cinema2 = new Cinema("Milenium");
            cinema2.Halls = new List<int>() { 1, 2 };
            cinema2.ListOfMovies = MovieSet2;
            #endregion Cinema

            try
            {
                Console.WriteLine($"Choose cinema: \n1) {cinema1.Name} \n2) {cinema2.Name}");
                string inputChoice = Console.ReadLine();

                if (inputChoice == "1")
                {
                    CinemaMethod(cinema1);
                }
                else if (inputChoice == "2")
                {
                    CinemaMethod(cinema2);
                }
                else
                {
                    throw new Exception("Error");
                }


            }
            catch (Exception e)
            {

                Console.WriteLine(e.Message);
            }
            


            Console.ReadLine();
        }




        public static void CinemaMethod(Cinema cinema)
        {

            try
            {
                Console.WriteLine($"Choose 1. All Movies or by 2. Genre: \n");
                string inputMoviesOrGenre = Console.ReadLine();
                if (inputMoviesOrGenre == "1")
                {
                    foreach (var movie in cinema.ListOfMovies)
                    {
                        Console.WriteLine(movie.Title);
                    }


                }
                else if (inputMoviesOrGenre == "2")
                {
                    Console.WriteLine("Choose Genre: \n 1. Comedy \n 2. Horror \n 3. Action \n 4. Drama \n 5. SciFi");
                    string genre = Console.ReadLine();
                    try
                    {
                        if (genre == "1")
                        {
                            List<Movie> comedyMovies = cinema.ListOfMovies.Where(m => m.Genre == Genre.Comedy).ToList();
                            foreach (var movie in comedyMovies)
                            {
                                Console.WriteLine(movie.Title);

                            }
                        }
                        else if (genre == "2")
                        {
                            List<Movie> horrorMovies = cinema.ListOfMovies.Where(m => m.Genre == Genre.Horror).ToList();
                            foreach (var movie in horrorMovies)
                            {
                                Console.WriteLine(movie.Title);
                            }
                        }
                        else if (genre == "3")
                        {
                            List<Movie> actionMovies = cinema.ListOfMovies.Where(m => m.Genre == Genre.Action).ToList();
                            foreach (var movie in actionMovies)
                            {
                                Console.WriteLine(movie.Title);
                            }
                        }
                        else if (genre == "4")
                        {
                            List<Movie> dramaMovies = cinema.ListOfMovies.Where(m => m.Genre == Genre.Drama).ToList();
                            foreach (var movie in dramaMovies)
                            {
                                Console.WriteLine(movie.Title);
                            }

                        }
                        else if (genre == "5")
                        {
                            List<Movie> SciFiMovies = cinema.ListOfMovies.Where(m => m.Genre == Genre.SciFi).ToList();
                            foreach (var movie in SciFiMovies)
                            {
                                Console.WriteLine(movie.Title);
                            }

                        }
                        else
                        {
                            throw new Exception("You must enter 1 to 5");
                        }

                    }
                    catch (Exception e)
                    {

                        Console.WriteLine(e.Message);
                    }
                    

                }
                else
                {
                    throw new Exception("Enter 1 or 2");
                }

            }
            catch (Exception e)
            {

                Console.WriteLine(e.Message);
            }
            





        }

    }
}

