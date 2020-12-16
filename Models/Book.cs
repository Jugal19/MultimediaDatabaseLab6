using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MultimediaDatabaseLab6.Models
{
    public class Book
    {
        //bookID was used to create the number of times the user makes a new data
        public int bookID { get; set; }

        //readerName is used to see who made these comments
        public string readerName { get; set; }

        //bookName is the title of the book
        public string bookName { get; set; }

        //year is when the book was released
        public int year { get; set; }

        //age is used for the user/or the book depending on how old it is
        public int age { get; set; }

        //the person who made the book
        public string author { get; set; }

        //short description of the book 
        public string description { get; set; }

        //the genre of the book
        public string genre { get; set; }
    }
}
