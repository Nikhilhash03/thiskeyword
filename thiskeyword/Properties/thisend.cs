using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace thiskeyword.Properties
{
    class user
    {
        int uid;
        string uname;
        public user(int id, string name)
        {
            uid = id;
            uname = name;
        }
        public void display()
        {
            Console.WriteLine("User id = " + uid);
            Console.WriteLine("user name = " + uname);
           
        }
    }
    internal class thisend
    {
        static void Main(string[] args)
        {
            int x = int.Parse(Console.ReadLine());
            string y = Console.ReadLine();
           
            user obje = new user(x, y);
            obje.display();
        }

        }
    }
