using Classes.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{
    class Program
    {
        static void Main(string[] args)
        {
            //Exercise 3
            //Create a class Student that has properties: Name, Academy and Group
            //Create an array with 5 new Students(objects )
            //The user should enter a name and the user information should be displayed in the console if a user by that name exists
            //If there is no such user it should show an error message

            Student[] studentsArr = new Student[5];

            studentsArr[0] = new Student("Viktor", "SEDC", 2);
            studentsArr[1] = new Student("Pero", "SEDC", 2);
            studentsArr[2] = new Student("Dacka", "SEDC", 2);
            studentsArr[3] = new Student("Goran", "SEDC", 2);
            studentsArr[4] = new Student("Philip of Macedon", "SEDC", 2);

            Console.WriteLine("Please enter student name: ");
            string input = Console.ReadLine();
            Console.WriteLine(GetStudent(input, studentsArr));
            Console.ReadLine();

        }

        public static string GetStudent (string name,Student[] studentsArr )
        {
            foreach (var item in studentsArr)
            {
                if (name == item.Name)
                {
                    return $"{item.Name} {item.Academy} {item.Group}";
                    
                }

            }
            return "Student not found";

        }


}
}
