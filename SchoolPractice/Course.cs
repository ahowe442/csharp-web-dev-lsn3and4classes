using System;
using System.Collections.Generic;

namespace SchoolPractice
{
    public class Course
    {
        public string Name { get; set; }
        public int CourseId { get; set; }
        public string Instructor { get; set; }
        public Dictionary<string, double> Students = new Dictionary<string, double>();
        
        public Course(string name, int courseId, string instructor, string students )
        {
            Name = name;
            CourseId = courseId;
            Instructor = instructor;

        }
    }
}
