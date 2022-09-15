using System;
using System.Collections.Generic;
using System.Linq;

namespace Unit15Final

{
    class Program
    {
        static void Main(string[] args)
        {
            var classes = new[]
            {
               new Classroom { Students = {"Evgeniy", "Sergey", "Andrew"}, },
               new Classroom { Students = {"Anna", "Viktor", "Vladimir"}, },
               new Classroom { Students = {"Bulat", "Alex", "Galina"}, }
           };
            var allStudents = GetAllStudents(classes);

            Console.WriteLine("Имена всех студентов: \n{0}",string.Join("\n", allStudents));
        }

        static string[] GetAllStudents(Classroom[] classes)
        {
            var result= from students in classes
                        from student in students.Students
                        select student;
            return result.ToArray();
        }

        public class Classroom
        {
            public List<string> Students = new List<string>();
        }
    }
}