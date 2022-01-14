// See https://aka.ms/new-console-template for more information

using OOPdemo02;

using static System.Console;  //Allows you to access the static methods in Console class directly

Course cpsc1517Course = new Course("CPSC1517", "intro");

WriteLine($"CourseNo: {cpsc1517Course.CourseNo}");
WriteLine($"CourseName: {cpsc1517Course.CourseName}");

//Add some students to the course
cpsc1517Course.AddStudent("Aaron Fong");
cpsc1517Course.AddStudent("David L. McKinley");
cpsc1517Course.AddStudent("Hamza Said");
cpsc1517Course.LoadFromFile(@"D;\NAIT\cpsc\1212\Students.txt");

//Display all the students in a course
foreach (string currentStudent in cpsc1517Course.Students)
{
    WriteLine(currentStudent);
}

//Remove 2 students from the course
cpsc1517Course.RemoveStudent("Hamza Said");
cpsc1517Course.RemoveStudent("Haseeb Memon");

cpsc1517Course.SaveToFile("cpsc1517.csv");
//Display the number of students
WriteLine($"There are now {cpsc1517Course.StudentCount} students.");
