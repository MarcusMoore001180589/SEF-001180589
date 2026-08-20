using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TafeSAEnrolmentSystem
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Testing the Address Class 
            Console.WriteLine("Testing the Address Class \n");
            Address address1 = new Address();
            Console.WriteLine("Testing No arg \n" + address1);
            address1.StreetNum = "11";
            address1.StreetName = "Perry Street";
            address1.Suburb = "Catalogue";
            address1.Postcode = "3343";
            address1.State = "SA";
            Console.WriteLine("\nTesting the getter and setters \n" + address1);

            Address address2 = new Address("16", "Valuables Cove", "Attened", "5757", "WA");

            Console.WriteLine("\nTesting All arg \n" + address2);


            //Testing the Subject Class 

            Console.WriteLine("\nTesting the Subject Class \n");
            Subject subject1 = new Subject();
            Console.WriteLine("Testing No arg \n" + subject1);
        
            subject1.SubjectCode = "WEB4040";
            subject1.SubjectName = "Making A Website";
            subject1.Cost = 10.20f;
            Console.WriteLine("\nTesting the getter and setters \n" + subject1);
            Subject subject2 = new Subject("PROG5190", "Making a Game", 199.99f);

            Console.WriteLine("\nTesting All arg \n" + subject2);


            //Testing the Enrollment Class
            Console.WriteLine("\nTesting the Enrollment Class \n");
            Enrollment enrollment1 = new Enrollment();
            Console.WriteLine("Testing No arg \n" + enrollment1);

            enrollment1.DateEnrolled = new DateTime(2026, 11, 11);
            enrollment1.Grade = "B";
            enrollment1.Semester = "2";
            Console.WriteLine("\nTesting the getter and setters \n" + enrollment1);
            Enrollment enrollment2 = new Enrollment(new DateTime(2025, 01, 01), "Making a Game", "4", subject2);
            Console.WriteLine("\nTesting All arg \n" + enrollment2);

            //Testing the Person Class
            Console.WriteLine("\nTesting the Person Class \n");
            Person person1 = new Person();
            Console.WriteLine("Testing No arg \n" + person1);

            person1.Name = "Ben";
            person1.Email = "Ben@10.com";
            person1.PhoneNumber = "0909090909";
            Console.WriteLine("\nTesting the getter and setters \n" + person1);
            Person person2 = new Person("Sid", "Sid@Sloth.com", "9988999", address2);
            Console.WriteLine("\nTesting All arg \n" + person2);


            //Testing the student class
            Console.WriteLine("\nTesting the Student Class");
            Student student1 = new Student();
            Console.WriteLine("Testing No arg \n" + student1);

            student1.StudentId = "00112233";
            student1.Program = "Vert 4";
            student1.DateRegistered = new DateTime(1999, 11, 11);


            Console.WriteLine("\nTesting the getter and setters \n" + student1);

            Student student2 = new Student();
            student2.StudentId = "99887766"; 
            Console.WriteLine("\nTesting 1 arg\n" + student2);

            Student student3 = new Student("Marcus", "sloth@someemail.com", "+0101010101", "00112233", "Cert 3", new DateTime(2026, 06, 11));


            Console.WriteLine("\nTesting the all arg \n" + student3);

            Console.WriteLine("\nTesting Equals with hash codes\n");
            Console.WriteLine("student3 ID and hash code= (" + student3.StudentId + " " + student3.GetHashCode() + ").Equals(student2 id and hash code)  = (" + student2.StudentId + " " + student2.GetHashCode() + ") " + student3.Equals(student2));
            Console.WriteLine("student3 ID and hash code= (" + student3.StudentId + " " + student3.GetHashCode() + ").Equals(student1 id and hash code) = (" + student1.StudentId + " " + student1.GetHashCode() + ") " + student3.Equals(student1));




        }
    }
}
