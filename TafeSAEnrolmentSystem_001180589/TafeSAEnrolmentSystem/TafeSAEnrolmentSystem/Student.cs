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

       
    }
}
