using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TafeSAEnrolmentSystem
{
    class Enrollment
    {
        public static readonly DateTime DEFAULT_DATE_ENROLLED = new DateTime(1999, 01, 01);
        public const string DEFAULT_GRADE_ID = "No grade provided";
        public const string DEFAULT_SEMESTER = "No semester provided";

        private Subject subject;

        // get and set for date enrolled
        public DateTime DateEnrolled
        { get; set; }

        public string Grade
        { get; set; }

        public string Semester
        { get; set; }

        public Subject Subject
        { get; set; }


        /// no arg constructor for the Enrollment class that initializes the

        public Enrollment() : this(DEFAULT_DATE_ENROLLED, DEFAULT_GRADE_ID, DEFAULT_SEMESTER)
        {

        }


        /// constructor for the Enrollment class that takes in date enrolled, grade, and semester as parameters and
        /// uses default subject.
        public Enrollment(DateTime dateEnrolled, string grade, string semester) : this(dateEnrolled, grade, semester, new Subject())
        {


        }

        /// all arg constructor for the Enrollment class that takes in date enrolled, grade, semester, and subject as parameters
        public Enrollment(DateTime dateEnrolled, string grade, string semester, Subject subject)
        {
            this.DateEnrolled = dateEnrolled;
            this.Grade = grade;
            this.Semester = semester;
            this.Subject = subject;

        }


        /// override the ToString method to return a string representation of the Enrollment object, including the
        public override string ToString()
        {
            return "DateEnrolled: " + DateEnrolled + "\nGrade : " + Grade +
                "\nSemester: " + Semester + "\n" + Subject;
        }
    }
}
