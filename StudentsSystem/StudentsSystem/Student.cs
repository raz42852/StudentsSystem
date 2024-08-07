using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentsSystem
{
    public class Student : IPerson
    {
        protected string studentName;
        protected int studentID;
        protected int age;

        public Student(string studentName, int studentID, int age) 
        {
            this.studentName = studentName;
            this.studentID = studentID;
            this.age = age;
        }
        public string GetStudentName()
        {
            return this.studentName;
        }
        public int GetStudentID()
        {
            return this.studentID;
        }
        public int GetAge()
        {
            return this.age;
        }
        public void SetStudentName(string studentName)
        {
            this.studentName = studentName;
        }
        public void SetStudentID(int studentID)
        {
            this.studentID = studentID;
        }
        public void SetAge(int age)
        {
            this.age = age;
        }
        public virtual void DisplayInformation()
        {
            Console.WriteLine("Student ID : " + this.studentID);
            Console.WriteLine("Student Name: " + this.studentName);
            Console.WriteLine("Student Age : " + this.age);
        }
        public Tuple<string, int, int> GetStudentInfo()
        {
            return Tuple.Create(this.studentName, this.studentID, this.age);
        }
    }
}
