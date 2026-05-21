using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace thiskeyword.Properties
{

    class accessmodiefier
    {
        public string name = "Nikhil";
        public void newmethod()
        {
            Console.WriteLine("My name is " + name);
        }
       
    }
    class secondclass
    {
        public void secondmethod()
        {
            accessmodiefier obj = new accessmodiefier();
            Console.WriteLine("The name is " + obj.name);
        }
    }
    internal class accessmodiefers
    {
        static void Main(string[] args)
        {
            accessmodiefier obj = new accessmodiefier();
            obj.newmethod();

            secondclass ob = new secondclass();
            ob.secondmethod();
        }
    }
}
