using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MultimediaDatabaseLab6.Models
{
    public class Movie
    {
        //this is the movie ID
        public int MovieID { get; set; }

        //this is the bookID from the class book
        public int bookID { get; set; }

        //this is a foreign key for the book
        public Book Book { get; set; }

        //this is when the user who has watched the movie 
        public string watcherName { get; set; }

        //this is the name of the movie 
        public string movieName { get; set; }

        //this is when the movie was released in that year
        public int year { get; set; }

        //this is the age of the movie that relies on the year
        public int age { get; set; }

        //this is the person who directed the movie
        public string director { get; set; }

        //a short description of the movie 
        public string description { get; set; }

        //this is if the movie relates to the book or not
        public string basedOnBooks { get; set; }

        //this is the genre of the movie/book
        public string genre { get; set; }
    }
}
