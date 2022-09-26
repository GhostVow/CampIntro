using System;

namespace ClassIntro
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Course[] courses =
            {
                new Course
                {
                    Id = 1,
                    CourseName = "Python",
                    EducatorName = "Berkay Bilgin"
                },
                new Course
                {
                    Id = 2,
                    CourseName = "Java",
                    EducatorName = "Engin Demiroğ"
                },
                new Course
                {
                    Id = 3,
                    CourseName = "Javascript",
                    EducatorName = "Mustafa Murat Coşkun"
                }

            };


            foreach (var course in courses)
            {
                string screenText = course.CourseName + " : " + course.EducatorName;
                Console.WriteLine(screenText);

            }


        }
    }

    class Course
    {
        public int Id { get; set; }
        public string CourseName { get; set; }
        public string EducatorName { get; set; }

    }

}
