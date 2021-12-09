using System;
using System.Collections.Generic;
using System.Text;

namespace ASM1
{
    public class Lecturer:Person
    {
        public string Id { set; get; }
        public string Department { set; get; }

        public Lecturer(string id, string name, DateTime dob, string email, string address, string department)
        {
            Id = id;
            Name = name;
            Dob = dob;
            Email = email;
            Address = address;
            Department = department;
        }

        public override string ToString() 
        {
            return "Id: " + Id + "\n" + "Name: " + Name + "\n" + "Dob: " + Dob + "\n" + "Email: " + Email + "\n" + "Address: " + Address + "\n" + "Department: " + Department;
        }
    }
}
