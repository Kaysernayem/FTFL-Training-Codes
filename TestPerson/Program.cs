using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestPerson
{
    class Program
    {
        class Person
        {
            private string _name, _address, _contactNumber;
            private int _age;

            //public Person()
            //{
                
            //}
           public Person(string name, int age, string address, string contactNumber)
            {
                this._name = name;
                this._address = address;
                this._contactNumber = contactNumber;
                this._age = age;

            }

            //public string SetName
            //{
            //    set { _name = value; }
            //    get
            //    {
            //        return _name;
            //    }

            //}

            //public int SetAge
            //{
            //    set { _age = value; }
            //    get
            //    {
            //        return _age;
            //    }

            //}

            //public string Address
            //{
            //    set { _address = value; }
            //    get
            //    {
            //        return _address;
            //    }

            //}
            //public string ContactNumber
            //{
            //    set { _contactNumber = value; }
            //    get
            //    {
            //        return _contactNumber;
            //    }

            //}

            public void Show()
            {
                Console.WriteLine("Name: "+ _name+  "   " + "Age" + _age + "  " + "Address: " + _address+ "  " + "Contact Number: " + _contactNumber);

            }

        }
        static void Main(string[] args)
        {
            Person p = new Person("NAZRUL ISLAM", 25, "Dhaka", "01920556654");
            p.Show();
            //Console.WriteLine("\nAfter calling property");
            //p.Address = "Ctg";
            //p.Show();
            //Console.WriteLine("\nDefault Constructor calling");
            //Person per1 = new Person();
            //per1.Show();
            //Console.WriteLine("\nSetting the value using property");
            //per1.SetName = "Kaiser";
            //per1.Address = "Feni";
            //per1.ContactNumber = "01710328545";
            //per1.SetAge = 24;
            //per1.Show();
            Console.Read();
        }
    }
}
