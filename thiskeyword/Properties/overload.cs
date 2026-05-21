using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Authentication.ExtendedProtection.Configuration;
using System.Text;
using System.Threading.Tasks;

namespace thiskeyword.Properties
{

    class student
    {
        int id;
        string name;
        string college;
        public student()
        {
            int id = 233212;
            string name = "Nikhil";
            string college = "VIT";

        }
        public student(int id, string name)
        {
            this.id = id;
            this.name = name;
        }
        public student(int id ,string name, string college)
        {
            this.id = id;
            this.name = name;
            this.college = college;
        }
        public void display()
        {
            Console.WriteLine("Student id = " + id);
            Console.WriteLine("Student name = " + name);
            Console.WriteLine("Student college = " + college);
        }
    }
    internal class overload
    {
        static void Main(string[] args)
        {
            student obj = new student(102, "Raghu", "Vit");
            obj.display();

            student stu = new student();
            stu.display();

            student stud  = new student(345,"Srinu");
            stud.display();
        }
    }
}
