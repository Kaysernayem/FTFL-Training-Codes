using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IStudentDAL
{
    public interface IStudentDataLayer
    {

         int StudentRollNo { get; set; }

         int StudentMarks { get; set; }

         string Name { get; set; }

         int Age { get; set; }

         string Address { get; set; }

         int ContactNo{get;set;}
    }
}
