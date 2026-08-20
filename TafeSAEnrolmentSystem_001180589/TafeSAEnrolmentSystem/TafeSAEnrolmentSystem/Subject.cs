using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TafeSAEnrolmentSystem
{
    class Subject
    {
        public const string DEFAULT_SUBJECT_CODE = "No subject code provided";
        public const string DEFAULT_SUBJECT_NAME = "No subject name provided";
        public const float DEFAULT_COST = -1;

        public string SubjectCode
        { get; set; }

        public string SubjectName
        { get; set; }

        public float Cost
        { get; set; }


        /// no arg constructor for the Subject class that initializes the
        public Subject() : this(DEFAULT_SUBJECT_CODE, DEFAULT_SUBJECT_NAME, DEFAULT_COST)
        { }


        /// all arg constructor for the Subject class that takes in subject code, subject name, and cost as parameters
        public Subject(string subjectCode, string subjectName, float cost)
        {
            this.SubjectCode = subjectCode;
            this.SubjectName = subjectName;
            this.Cost = cost;
        }

        /// override the ToString method to return a string representation of the Subject object, including the
        /// subject code, subject name, and cost.
        public override string ToString()
        {
            return "Subject Code: " + SubjectCode + "\nSubject Name: " + SubjectName + "\nCost : $" + Cost;
        }
    }
}
