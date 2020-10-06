using System;

namespace SchoolPractice
{
    class Program
    {
        public static void Main(string[] args)
        {
            // TODO: Instantiate your objects and test your exercise solutions with print statements here.
            Student abby = new Student("Abby", 123456, 1, 4.0);
            Console.WriteLine(abby.Name + " :" + " student number= " + abby.StudentId + ", Credits= " + abby.NumberOfCredits + ", GPA= " + abby.Gpa); 
            

        }
    }
}
