using System;

namespace Methods_Advanced_Container
{
    class Student
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public string Subject { get; set; }
    }

    class StudentOperations
    {

        /// <summary>
        ///  Returns a single student as a class model.
        /// </summary>
        /// <returns>Studnet Model</returns>
        public static Student GetStudent()
        {
            //Student student = new Student();
            //student.Name = "Peter";
            //student.Age = 19;
            //student.Subject = "JavaScript";

            return new Student()
            {
                Name = "Peter",
                Age = 21,
                Subject = "JavaScript"
            };
        }


        /// <summary>
        /// Returns a list of students as class models.
        /// </summary>
        /// <returns>Students array</returns>
        public static Student[] GetStudents()
        {
            return new Student[]
            {
                 new Student { Name = "Peter", Age = 21, Subject = "JavaScript" },
                 new Student { Name = "Mohan", Age = 20, Subject = "TypeScript" },
                 new Student  { Name = "Chandra", Age = 19, Subject = "HTML" }
            };
        }


        /// <summary>
        ///  Takes a student as input and returns the same student with updated details.
        /// </summary>
        /// <param name="student">Type is Studnet</param>
        /// <returns>Student</returns>
        public static Student UpdateStudent(Student student)
        {
            student.Subject = student.Subject + " - Advanced Level";
            return student;
        }


        /// <summary>
        ///  Takes a list of students as input and returns the updated list of students.
        /// </summary>
        /// <param name="students">stuenetdnts type</param>
        /// <returns>stuendts</returns>

        public static Student[] UpdateStudents(Student[] students)
        {
            foreach (Student student in students)
            {
                student.Subject = student.Subject + " - Advanced";
            }
            return students;
        }

    }

    class Program
    {
        static void Main()
        {
            // Method 1: Return a single class model
            var singleStudent = StudentOperations.GetStudent();
            Console.WriteLine($"Single Student: {singleStudent.Name}, {singleStudent.Age}, {singleStudent.Subject}");


            // Method 2: Return a list of class models
            Student[] studnetsList = StudentOperations.GetStudents();
            // var studnetsList = StudentOperations.GetStudents();
            Console.WriteLine("List of Students:");
            foreach (var student in studnetsList)
            {
                Console.WriteLine($"Single Student: {student.Name}, {student.Age}, {student.Subject}");
            }


            // Method 3: Take a class model as input and return an updated class model
            Student updatedStudent = StudentOperations.UpdateStudent(singleStudent);

            // Method 4: Take a list of class models as input and return an updated list of class models
            var updatedStudetns = StudentOperations.UpdateStudents(studnetsList);
            Console.WriteLine("List of Students:");
            foreach (var student in updatedStudetns)
            {
                Console.WriteLine($"Single Student: {student.Name}, {student.Age}, {student.Subject}");
            }


        }
    }
}



//GetStudent . name , age , subject
//GetStudentsList -- each student name , age , subject


//Update subject  - which student you have to update?????(input parameter)
//update subject for the studnents.