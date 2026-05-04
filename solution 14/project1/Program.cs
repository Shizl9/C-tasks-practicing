using System;
using System.Collections.Generic;

namespace project1
{
    class Movie
    {
        public string Title { get; set; }
        public string Genre { get; set; }
        public int Year { get; set; }
        public int Rating { get; set; } 

       public Movie (string title, string genre, int year, int rating )
        {
            Title= title;
            Genre= genre;
            Year= year;
            Rating= rating;
        }
    }

    class User
    {
        public string Name { get; set; }
        public int Age { get; set; }
       public User(string name , int age )
        {
            Name= name;
            Age= age;
            Console.WriteLine($"Welcome {Name} , you are {Age} years old");
        }
    }

    class Review
    {
        public string UserName { get; set; }
        public string MovieTitle { get; set; }
        public string Comment { get; set; }
        public int Rate { get; set; }
        public Review(string userName,string movieTitle, string comment, int rate)
        {
            UserName = userName;
            MovieTitle = movieTitle;
            Comment = comment;
            Rate = rate;
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
           //============create movies:========
           Movie m1=new Movie("Inception", "Sci-Fi", 2010, 9);
           Movie m2 = new Movie("Titanic", "Romance", 1997, 8);
           Movie m3 = new Movie("The Dark Knight", "Action", 2008, 9);

            //============create users:========
            User u1 = new User("Sheika", 25);

            //============create reviews:========
            Review r1 = new Review("sheika", "Inception", "Great movie!", 10);

            //============display movies:========
            Console.WriteLine("\nMovies:");
            Console.WriteLine($"{m1.Title} - {m1.Rating}");
            Console.WriteLine($"{m2.Title} - {m2.Rating}");
            Console.WriteLine($"{m3.Title} - {m3.Rating}");


            //============display reviews:========
            Console.WriteLine("\nReviews:");
            Console.WriteLine($"{r1.UserName} rated {r1.MovieTitle}: {r1.Rate} - {r1.Comment}");
        
    }
    }
}
