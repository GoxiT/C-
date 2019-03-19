using Homework_Class08.Library.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_Class08.Library.Classes
{
    public class Person
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
        public Genre FavouriteMusicType { get; set; }
        public List<Song> FavouriteSong { get; set; }

        public Person(string firstName , string lastName , int age , Genre genre)
        {
            FirstName = firstName;
            LastName = lastName;
            Age = age;
            FavouriteMusicType = genre;

        }

        public void GetFavSongs()
        {
            if(FavouriteSong.Count == 0)
            {
                Console.WriteLine("This person hates music");
            }
            else
            {
                foreach  (Song song in FavouriteSong)
                {
                    Console.WriteLine(song.Title);
                }
            }
        
        }

    }
}
