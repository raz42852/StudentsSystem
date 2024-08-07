using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentsSystem
{
    public class CollegeStudent : Student
    {
        protected string profession;
        protected int avgGradeStu;

        public CollegeStudent(string studentName, int studentID, int age, string profession, int avgGradeStu) 
            : base(studentName, studentID, age)
        {
            this.profession = profession;
            this.avgGradeStu = avgGradeStu;
        }
        public override void DisplayInformation()
        {
            base.DisplayInformation();
            Console.WriteLine("Profession : " + this.profession);
            Console.WriteLine("Average : " + this.avgGradeStu);
        }

    }
}
