using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace thiskeyword.Properties
{
    class employe
    {
        int id;
        string name;
        double salary;
        public employe(int id, string name, double salary)
        {
            this.id = id;
            this.name = name;
            this.salary = salary;
        }
        public void display()
        {
            Console.WriteLine("Employee id = " + id);
            Console.WriteLine("Employee name = " + name);
            Console.WriteLine("Employee salary = "+salary);
        }
    }
    internal class employee
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter no of employees");
            int n = int.Parse(Console.ReadLine());





            employe[] employeee = new employe[n];

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("Enter employe id");
                int x = int.Parse(Console.ReadLine());

                Console.WriteLine("Enter employe name");
                string y = Console.ReadLine();

                Console.WriteLine("Enter employe salary");
                double z = double.Parse(Console.ReadLine());

                employeee[i] = new employe(x, y, z);
            }

            for(int i = 0; i < n;i++)
            {
                employeee[i].display();
            }
        }
    }

}
