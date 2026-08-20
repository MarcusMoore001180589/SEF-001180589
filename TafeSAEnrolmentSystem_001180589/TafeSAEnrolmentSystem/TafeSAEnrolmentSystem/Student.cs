using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace TafeSAEnrolmentSystem
{
    class Student : Person
    {
        public const string DEFAULT_STUDENT_ID = "No studentID provided";
        public const string DEFAULT_PROGRAM = "No program provided";
        public static readonly DateTime DEFAULT_DATE_REGISTERED = new DateTime(1999, 01, 01);



        public string StudentId
        { get; set; }
        public string Program
        { get; set; }
        public DateTime DateRegistered
        { get; set; }



        /// no arg constructor for the Student class that initializes the 
        /// StudentId, Program, and DateRegistered properties to their default values.
        public Student() : this(DEFAULT_STUDENT_ID, DEFAULT_PROGRAM, DEFAULT_DATE_REGISTERED)
        { }

        /// all arg constructor for the Student class that takes in name, email, phone number, student ID, program, and registration date as parameters 
        /// and initializes the corresponding properties of the Student object. 
        /// It also calls the base constructor of the Person class to initialize the name, email, and phone number properties.
        public Student(string name, string email, string phoneNumber, string studentId, string program, DateTime dateRegistered) : base(name, email, phoneNumber)
        {
            this.StudentId = studentId;
            this.Program = program;
            this.DateRegistered = dateRegistered;


        }

        /// student constructor with student ID, program, and registration date provided
        public Student(string studentId, string program, DateTime dateRegistered)
        {
            this.StudentId = studentId;
            this.Program = program;
            this.DateRegistered = dateRegistered;

        }

        /// student constructor with only student ID provided
        public Student(string studentId)
        {
            this.StudentId = studentId;
        }

        /// override ToString method that returns a string representation of the Student object, 
        /// including the properties inherited from the Person class and the StudentId, Program, and DateRegistered properties.
        public override string ToString()
        {
            return base.ToString() + "StudentID: " + StudentId + "\nProgram: " + Program +
                "\nDate Registered: " + DateRegistered;
        }

        /// <summary>
        /// override the Equals method to compare two Student objects based on their StudentId property
        /// </summary>
        /// <param name="obj"></param>
        /// <returns></returns>
        public override bool Equals(object obj)
        {
            if (obj == null) // null check

                return false;

            if (ReferenceEquals(obj, this)) // reference check

                return true;

            if (obj.GetType() != this.GetType())// check different object types

                return false;

            Student student = (Student)obj;
            return student.StudentId == this.StudentId;
        }

        /// <summary>
        /// get hash code for the student object based on the StudentId property
        /// </summary>
        /// <returns></returns>
        public override int GetHashCode()
        {
            return this.StudentId.GetHashCode();
        }

        /// <summary>
        /// override the equality operator to compare two Student objects based on their StudentId property
        /// </summary>
        /// <param name="student1"></param>
        /// <param name="student2"></param>
        /// <returns>bool</returns>
        public static bool operator ==(Student student1, Student student2)
        {
            return object.Equals(student1, student2);
        }

        /// <summary>
        /// override the inequality operator to compare two Student objects based on their StudentId property
        /// </summary>
        /// <param name="student1"></param>
        /// <param name="student2"></param>
        /// <returns>bool</returns>
        public static bool operator !=(Student student1, Student student2)
        {
            return !object.Equals(student1, student2);
        }

        /// <summary>
        /// equals method to compare two objects for equality based on their StudentId property
        /// </summary>
        /// <param name="obj1"></param>
        /// <param name="obj2"></param>
        /// <returns>bool</returns>
        public static bool Equals(object obj1, object obj2)
        {
            if (obj1 == obj2)
                return true;
            if (obj1 == null || obj2 == null)
                return false;
            else
                return obj1.Equals(obj2);


        }

    }
}
