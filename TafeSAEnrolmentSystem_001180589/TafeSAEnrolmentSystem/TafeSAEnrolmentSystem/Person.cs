using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TafeSAEnrolmentSystem
{
    class Person
    {
        public const string DEFAULT_NAME = "No name provided";
        public const string DEFAULT_EMAIL = "No email provided";
        public const string DEFAULT_PHONE_NUMBER = "No phone number provided";

        private Address address;

        public string Name
        { get; set; }
        public string Email
        { get; set; }
        public string PhoneNumber
        { get; set; }
        public Address Address
        { get; set; }

   
        /// no arg constructor for the Person class that initializes the
        public Person() : this(DEFAULT_NAME, DEFAULT_EMAIL, DEFAULT_PHONE_NUMBER)
        {
        }

        /// constructor for the Person class that takes in name, email, and phone number as parameters and 
        /// using default address.
        public Person(string name, string email, string phoneNumber): this (name, email, phoneNumber , new Address())
        {
            
        }

        /// all arg constructor for the Person class that takes in name, email, phone number, and address as parameters
        public Person(string name, string email, string phoneNumber, Address address)
        {
            this.Name = name;
            this.Email = email;
            this.PhoneNumber = phoneNumber;
            this.Address = address;
        }

        /// override the ToString method to return a string representation of the Person object, including the 
        /// name, email, phone number, and address.
        public override string ToString()
        {
            return "Name: " + Name + "\nEmail: " + Email +
                "\nPhoneNumber: " + PhoneNumber + "\n" + Address;
        }
    }
}
