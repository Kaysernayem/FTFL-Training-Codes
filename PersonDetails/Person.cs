using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonDetails
{
    class Person
    {
        string name, address, contact;
        int age;

        public Person(string Name,string Address,int Age,string Contact)
        {
            this.name = Name;
            this.address = Address;
            this.age = Age;
            this.contact = Contact;
        }

        public void ShowPersonDetails()
        {
            Console.WriteLine("Person's Name=" + name + "\nPerson's Address=" + address + "\nPerson's Age=" + age + "\nPerson's Cell No=" + contact);
        }

        public string getName
        {
            get { return name;}
            set { name = value; }
        }
        public string getAddress
        {
            get { return address;}
            set { address = value; }
        }
        public int getAge
        {
            get { return age;}
            set { age = value; }
        }
        public string getContact
        {
            get { return contact;}
            set { contact = value; }
        }
    }
}
