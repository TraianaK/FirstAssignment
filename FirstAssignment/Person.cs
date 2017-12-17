using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstAssignment
{
    public class Person
    {
        public string firstName;
        public string lastName;       
        public int age;

        public Person(string firstName, string lastName, int age)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.age = age;
        }



        public string FullName
        {
            get { return firstName + " " + lastName; }
        }
        public override string ToString()
        {
            return FullName.ToString();
        }

    }

}


