using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeligateSample
{
    public delegate bool IsPromotable(Employee emp);
    public class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public int Salary { get; set; }
        public int YearsOfExp { get; set; }

        public static void PromotEmployee(List<Employee> listEmployee,IsPromotable delPromote)
        {
            foreach (Employee emp in listEmployee)
            {
                //if(emp.YearsOfExp>=7)
                if(delPromote(emp))
                {
                    Console.WriteLine("Congratulation !!! {0} you are Promoted!",emp.Name);
                }
            }
        }
    }
}
