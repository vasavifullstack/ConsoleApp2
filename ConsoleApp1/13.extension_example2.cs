using Methods_Advanced_Container;
using MyExtensions;
using System;
using System.Collections.Generic;
using System.ComponentModel;
namespace MyExtensions

{
    // Extension Method-add new method without modifity the existing class.
    //Existing Class(We cannot change this)
    //don't change the original class
    //don't create a derived class
    //add a method as if it belongs to that class
    public class Student
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
    }

    //Rules - Must be inside a static class
    //Method must be static
    //First parameter must have the keyword this
    //First parameter tells which class it extends


    //Extension Method Class
    public static class StudentExtensions
    {
        // Extension method to get full name of student
        public static string GetFullName(this Student student)
        {
            return student.FirstName + " " + student.LastName;
        }
    }



    class Program
    {
        static void Main()
        {
            Student s = new Student()
            {
                FirstName = "Vasavi Reddy",
                LastName = "Yarramachu"
            };

            string fullName = s.GetFullName();  // Calling extension method

            Console.WriteLine(fullName);
        }
    }
}
