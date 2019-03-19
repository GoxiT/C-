using Homework_Class08.Library.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_Class08.Library.Classes
{
    public class Song
    {
       public string Title { get; set; }
       public int Length { get; set; }
       public Genre Genre { get; set; }

        public Song(string title , int lenght , Genre genre)
        {
            Title = title;
            Length = lenght;
            Genre = genre;
            

        } 
        
    }
}
