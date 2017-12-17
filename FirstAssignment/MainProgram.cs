using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstAssignment
{
    class MainProgram
    {
        static void Main()
        {
            Address placeOfLiving1 = new Address { street = "Maria Luiza 52 ", city = "Busmantsi", country = " Ukraine" };
            Address placeOfLiving2 = new Address { street = "Oborishte 13 ", city = "Varna", country = "Russia" };
            Address placeOfLiving3 = new Address { street = "Krakra 56", city = "Dryanovo", country = " Bulgaria" };
            Address placeOfLiving4 = new Address { street = "Kozlodui 14 ", city = "Turkincha", country = " Russia" };
            Address placeOfLiving5 = new Address { street = "Ruse 23", city = "Veliko Turnovo", country = " Bulgaria" };

            Student[] people = new Student[]
                {

                new Student("1714015",placeOfLiving1, "Kiril","Kalchev", 19),
                new Student("1714014",placeOfLiving2,"Pesho", "Kolev", 21),
                new Student("1714013",placeOfLiving3,"Radoslava", "Stoyanova", 18),
                new Student("1714012",placeOfLiving4,"Milena", "Kalestrova", 19),
                new Student("1714011",placeOfLiving5,"Teodor", "Kabakchiev", 19)

            };

            people[0].grades = new List<int> { 5, 6, 2, 3 };
            people[1].grades = new List<int> { 4, 5, 2, 3 };
            people[2].grades = new List<int> { 5, 6, 5, 3 };
            people[3].grades = new List<int> { 4, 4, 3, 3 };
            people[4].grades = new List<int> { 5, 4, 6, 3 };

            Console.WriteLine("Facluty numbers of people in the class : ");

            foreach (Student p in people)
            {
                Console.WriteLine("{0}", p.studentNumber);
            }

            Dictionary<string, Student> link = new Dictionary<string, Student>();


            link["1714015"] = people[0];
            link["1714014"] = people[1];
            link["1714013"] = people[2];
            link["1714012"] = people[3];
            link["1714011"] = people[4];


            Console.WriteLine("Choose a faculty number :  ");
            string studentNumber = Console.ReadLine();

            if (link.ContainsKey(studentNumber))
            {
                Console.WriteLine("The average score of {0} is : {1}", link[studentNumber].FullName, link[studentNumber].grades.Average());
            }
            else
            {
                Console.WriteLine("Student {0} does not exist.", link[studentNumber].FullName);
            }

            Console.WriteLine("Student {0} is living in {1}. ", link[studentNumber].FullName, placeOfLiving2.city);
            Console.WriteLine("Student {0} full address is {1}.", link[studentNumber].FullName, placeOfLiving1.street + "street, " + placeOfLiving2.city + "," + placeOfLiving5.country);

        }
    }
}

