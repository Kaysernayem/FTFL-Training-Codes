using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVCTwo.Models
{
    public class StudentListModel
    {
        public List<StudentList> StudentListCollection { get; set; }
        public StudentList StudentListDetails { get; set; }
    }

    public class StudentList
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public string Section { get; set; }
        public int Marks { get; set; }
    }
}