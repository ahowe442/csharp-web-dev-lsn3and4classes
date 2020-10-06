using System;
namespace SchoolPractice
{
    public class Teacher
    {
        string FirstName { get; set; }
        string LastName { get; set; }
        string Subject { get; set; }
        int YearsTeaching { get; set; }
        public Teacher(string firstName, string lastName, string subject, int yearsTeaching)
        {
            FirstName = firstName;
            LastName = lastName;
            Subject = subject;
            YearsTeaching = yearsTeaching;
        }
    }
}
