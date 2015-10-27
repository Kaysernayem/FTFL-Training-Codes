using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace CollectionPractice
{
    class Program
    {
        static void Main(string[] args)
        {
            ArrayList objArrayList = new ArrayList();
            objArrayList.Add(20);
            objArrayList.Add("ArrayList");
            objArrayList.Add(34.5);

            //int[] myInteger = new int[4];
            //myInteger[0] = 10;
            //myInteger[1] = 12;
            //myInteger[2] = 14;
            //myInteger[3] = 15;

            foreach (int i in objArrayList)
            {
                Console.WriteLine(i);
            }
            Console.Read();
        }
    }
}
