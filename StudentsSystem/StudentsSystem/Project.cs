using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentsSystem
{
    public class Project
    {
        public static void Main(string[] args) 
        {
            Student s1 = new Student("Raz", 1, 16);
            Student s2 = new Student("Yoav", 54, 13);
            CollegeStudent cs1 = new CollegeStudent("Shaked", 40, 20, "Math", 90);
            CollegeStudent cs2 = new CollegeStudent("Yahav", 20, 21, "Computer Science", 95);
            s1.SetStudentID(50);
            s2.SetAge(14);
            cs2.SetStudentName("Ori");
            s1.DisplayInformation();
            Console.WriteLine();
            s2.DisplayInformation();
            Console.WriteLine();
            cs1.DisplayInformation();
            Console.WriteLine();
            cs2.DisplayInformation();
        }
    }
}
