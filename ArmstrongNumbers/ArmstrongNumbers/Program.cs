using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArmstrongNumbers
{
    //Armstrong Numbers with basic approach
    class Program
    {
        static void Main(string[] args)
        {
            int checkNumber,lastNumber;
            double sum = 0; //Variables
            Console.WriteLine("Enter a Number: "); //Take input from user
            checkNumber = int.Parse(Console.ReadLine()); //Read the number
            Console.WriteLine("Enter another  Number: "); //Take input from user
            lastNumber = int.Parse(Console.ReadLine()); //Read the number

            for (int checkNumber1 = checkNumber; checkNumber1 <= lastNumber; checkNumber1++)
            {
                sum = 0;
                int devisor = checkNumber1;

                while (devisor != 0)
                {
                    int reminder = devisor % 10;
                    devisor = devisor / 10;
                    sum = sum + Math.Pow(reminder, 3);

                }
                if (checkNumber1 == sum)
                {
                    Console.WriteLine(sum);
                }
            }
            Console.Read();
        }
    }
}
