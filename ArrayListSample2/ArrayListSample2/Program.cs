using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace ArrayListSample2
{
    class Program
    {
        static ArrayList a = new ArrayList();
        static void Main(string[] args)
        {
            while(true)
            {
                Console.WriteLine("1. Add Student:");
                Console.WriteLine("2. Display Student by Roll no:");
                Console.WriteLine("3. Display Student by Grade:");
                Console.WriteLine("4. Remove Student by Roll no:");
                Console.WriteLine("5. Update Name:");
                Console.WriteLine("6. Display all Students:");
                Console.WriteLine("0. Exit:");
                Console.Write("Enter your Choice:");
                int ch = int.Parse(Console.ReadLine());
                switch(ch)
                {
                    case 1:
                        AddStudent();
                        break;
                    case 2:
                        DisplayByRoll();
                        break;
                    case 3:
                        DisplayByGrade();
                        break;
                    case 4:
                        RemoveByRoll();
                        break;
                    case 5:
                        UpdateName();
                        break;
                    case 6:
                        DisplayAll();
                        break;
                    case 0:
                        Environment.Exit(0);
                        break;
                    default:
                        Console.WriteLine("Wrong Input");
                        continue;
                }
            }
        }
        static void AddStudent()
        {
            Student s = new Student();
            s.GetData();
            a.Add(s);
            Console.WriteLine("Added Successfully");
        }
        static void DisplayAll()
        {
            foreach (Object o in a)
            {
                Student s = (Student)o;
                s.ShowData();
            }
        }
        static void DisplayByGrade()
        {
            Boolean flag = false;
            char grd;
            Console.WriteLine("Enter grade:");
            grd = char.Parse(Console.ReadLine());
            foreach (Object o in a)
            {
                Student s = (Student)o;
                if (s.GetGrade == grd)
                {
                    flag = true;
                    s.ShowData();
                }
            }
            if(flag==false)
                Console.WriteLine("No Information Matched");
        }
        static void DisplayByRoll()
        {
            Boolean flag = false;
            int rl;
            Console.WriteLine("Enter Roll No:");
            rl = int.Parse(Console.ReadLine());
            foreach (Object o in a)
            {
                Student s = (Student)o;
                if (s.GetRoll == rl)
                {
                    flag=true;
                    s.ShowData();
                }
            }
            if(flag==false)
                Console.WriteLine("No Information Matched");
        }
        static void RemoveByRoll()
        {
            Console.Write("Enter roll no to delete:");
            int r = int.Parse(Console.ReadLine());
            Boolean flag = false;
            foreach (Object o in a)
            {
                Student s = (Student)o;
                if(s.GetRoll==r)
                {
                    a.Remove(s);
                    flag = true;
                    break;
                }
            }
            if (flag == true)
                Console.WriteLine("Removed Successed");
            else
                Console.WriteLine("Not found");
        }
        static void UpdateName()
        {
            Console.Write("Enter roll no to update the name:");
            int r = int.Parse(Console.ReadLine());
            Boolean flag = false;
            foreach (Object o in a)
            {
                Student s = (Student)o;
                if (s.GetRoll == r)
                {
                    a.Remove(s);
                    flag = true;
                    break;
                }
            }
            if (flag == true)
                Console.WriteLine("Removed Successed");
            else
                Console.WriteLine("Not found");
        }
      
    }
}
