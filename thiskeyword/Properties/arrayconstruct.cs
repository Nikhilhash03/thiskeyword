//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Runtime.InteropServices;
//using System.Text;
//using System.Threading.Tasks;

//namespace thiskeyword.Properties
//{
//    class student
//    {
//        int studentid;
//        string studentname;
//        static string college;
//        public student(int studentid, string studentname)
//        {
//            this.studentid = studentid;
//            this.studentname = studentname;
//        }

//       public void display()
//        {
//            Console.WriteLine("Student id = " + studentid);
//            Console.WriteLine("Student name = " + studentname);
//        }

//    }
//    internal class arrayconstruct
//    {
//        static void Main(string[] args)
//        {
//            Console.WriteLine("Enter student count");
//            int count = int.Parse(Console.ReadLine());

           

//            student[] students = new student[count];

//            for (int i = 0; i < count; i++)
//            {
//                Console.WriteLine("Enter Student Details");
//                int x = int.Parse(Console.ReadLine());
//                string y = Console.ReadLine();

//                students[i] = new student(x, y);
//            }

//            for(int i=0; i<students.Length; i++)
//            {

//                students[i].display();
//            }   
            
//        }
//    }
//}
