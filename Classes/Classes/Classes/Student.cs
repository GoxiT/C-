using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes.Classes
{
    public class Student
    {
        public string Name { get; set; }
        public string Academy { get; set; }
        public int Group { get; set; }

        public Student(string name , string academy , int group)
        {
            Name = name;
            Academy = academy;
            Group = group;
        }
    }

}
