using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TafeSAEnrolmentSystem
{
    class Address
    {
        public const string DEFAULT_SREET_NUM = "No street number provided";
        public const string DEFAULT_STREET_NAME = "No street name provided";
        public const string DEFAULT_SUBURB = "No suburb provied";
        public const string DEFAULT_POSTCODE = "No postcode provided";
        public const string DEFAULT_STATE = "No state provided";

        public string StreetNum
        { get; set; }
        public string StreetName
        { get; set; }
        public string Suburb
        { get; set; }
        public string Postcode
        { get; set; }
        public string State
        { get; set; }

        /// no arg constructor for the Address class that initializes the 
        /// StreetNum, StreetName, Suburb, Postcode, and State properties to their default values.
        public Address() : this(DEFAULT_SREET_NUM, DEFAULT_STREET_NAME, DEFAULT_SUBURB,
           DEFAULT_POSTCODE, DEFAULT_STATE)
        { }

        /// all arg constructor for the Address class that takes in street number, street name, suburb, postcode, and state as parameters
        public Address(string streetNum, string streetName, string suburb,
            string postcode, string state)
        {
            this.StreetNum = streetNum;
            this.StreetName = streetName;
            this.Suburb = suburb;
            this.Postcode = postcode;
            this.State = state;
        }

        /// override the ToString method to return a string representation of the Address object, including the 
        /// street number, street name, suburb, postcode, and state.
        public override string ToString()
        {
            return "Street Number: " + StreetNum + "\nStreet Name: " + StreetName +
                "\nSuburb: " + Suburb + "\nPostcode: " + Postcode + "\nState : " + State + "\n";
        }
    }
}
