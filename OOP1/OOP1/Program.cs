using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the number of Student");
            int n = int.Parse(Console.ReadLine());
            Student [] stu = new Student[n];
            for (int i = 0; i < n; i++)
            {
                stu[i] = new Student();
                stu[i].GetData();
                Console.Write("Enter 1 to continue or 0 to stop!!");
                int nos = int.Parse(Console.ReadLine());
                if (nos == 1)
                    continue;
                else
                    break;
            }
            for (int i = 0; i < n; i++)
            {
                stu[i].ShowData();
            }
            Console.Read();
        }
    }
}
