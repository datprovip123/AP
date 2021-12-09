using System;
using System.Collections.Generic;
using System.Text;

namespace ASM1
{
    public class Student:Person
    {
        public string Batch { set; get; }
        public string Id { set; get; }

        public Student(string id, string name, DateTime dob, string email, string address, string batch)
        {
            Id = id;
            Name = name;
            Dob = dob;
            Email = email;
            Address = address;
            Batch = batch;
        }

        public override string ToString() 
        {
            return "Id: " + Id + "\n" + "Name: " + Name + "\n" + "Dob: " + Dob + "\n" + "Email: " + Email + "\n" + "Address: " + Address + "\n" + "Batch: " + Batch;
        }
    }
}
