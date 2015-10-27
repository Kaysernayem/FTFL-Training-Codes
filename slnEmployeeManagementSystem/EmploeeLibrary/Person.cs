using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EmploeeLibrary;

namespace EmploeeLibrary
{
    public abstract partial class Person
    {
        private string _name;

        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        private int _age;

        public int Age
        {
            get { return _age; }
            set { _age = value; }
        }

        private string _address;

        public string Address
        {
            get { return _address; }
            set { _address = value; }
        }

        private int _contactNo;

        public int ContactNo
        {
            get { return _contactNo; }
            set { _contactNo = value; }
        }

        public Person(string name, int age, string address, int contactNo)
        {
            Name = name;
            Age = age;
            Address = address;
            ContactNo = contactNo;
        }

        public override string ToString()
        {
            return "Name:" + Name + "\nAge:" + Age + "\nAddress:" + Address + "\nContact No:" + ContactNo;
        }

        public abstract void ShowDetails();
        //{
        //    Console.WriteLine("Name:"+Name+"\nAge:"+Age+"\nAddress:"+Address+"\nContact No:"+ContactNo);
        //}
    }
}
