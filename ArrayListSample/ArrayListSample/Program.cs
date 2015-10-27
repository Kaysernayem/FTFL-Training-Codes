using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace ArrayListSample
{
    class Program
    {
        static void Main(string[] args)
        {
            ArrayList a = new ArrayList();
            a.Add(123);
            a.Add("BARD");
            a.Add(34.689);
            a.Insert(2, 'A');
            a.Remove(123);
            a.RemoveAt(2);
            foreach (Object o in a)
            {
                Console.WriteLine(o.ToString());
            }








            //Student s = new Student();
            //s.GetData();
            //a.Add(s);
            //foreach (Object o in a)
            //{
            //    if (o.GetType().ToString() == "ArrayListSample.Student")
            //    {
            //        Student s1 = (Student)o;
            //        s1.ShowData();
            //    }
            //}
            //Console.WriteLine("No of elements are:" +a.Count);


            Console.Read();
        }
    }
}
