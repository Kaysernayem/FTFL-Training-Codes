using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace numberOfSpace
{
    class Program
    {
        static void Main(string[] args)
        {
            string s;
            Console.Write("Enter Text");
            s = Console.ReadLine();
            int sp = 0, nsp = 0;
            for(int i=0;i<s.Length;i++)
            {
                if(s[i]==' ')
                    sp++;
                else
                    nsp++;
            }
            Console.WriteLine("Number of spaces are:"+sp);
            Console.WriteLine("Number of nonspaces characters are:"+nsp);

            int counter = 1;
            for(int i=0;i<=s.Length;i++)
            {
                Boolean flag=false;
                for(int j=0;j<=i-1;j++)
                {
                    if(s[i]==s[j])
                    {
                        flag = true;
                        break;
                    }
                }
                if(flag==false)
                {
                    for(int k=i+1;k<s.Length;k++)
                    {
                        if (s[i] == s[k])
                            counter++;
                    }
                    Console.WriteLine(s[i] + " " + counter);
                    counter = 1;
                }
            }
            Console.Read();
        }
    }
}
