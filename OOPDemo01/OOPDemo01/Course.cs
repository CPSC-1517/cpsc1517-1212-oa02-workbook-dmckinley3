using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPDemo01
{
    public class Course
    {

        //fields//
        private string _CourseNo;
        private string _CourseName;
        private string[] students;

        //properties
        public string CourseNo { get; set; }
        public string CourseName { get; set; }

        //constructors

        public Course(string courseNo, string courseName)
        {
            CourseNo = courseNo;
            CourseName = courseName;

        }
        public Course()
        {

        }

        //methods
        public string AddStudent(string student)
        {
            return student;
        }
        public string DropStudent(string student)
        {
            return student;
        }
    }


}

