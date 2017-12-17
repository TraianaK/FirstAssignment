using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace FirstAssignment
{
    class Student : Person
    {
        public string studentNumber;
        Address address;
        public List<int> grades;

        public Student(string studentNumber, Address address, string firstName, string lastName, int age) : base(firstName, lastName, age)
        {
            this.studentNumber = studentNumber;
            this.address = address;
            
        }
    }
}