using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonDetails
{
    class Program
    {
        static void Main(string[] args)
        {
            Person p = new Person("Kayser","Feni",24,"01710328545");
            p.ShowPersonDetails();
            Console.Read();
        }
    }
}
