using TafeSAEnrolmentSystem.Model;
using TafeSAEnrolmentSystem;

namespace NUnit_Test
{
    public class Tests
    {


        private Student[] studentsRandom;

        private Student[] studentsSorted;

        private string[] sortAcending;

        private string[] sortDesending;

        [SetUp]
        public void Setup()
        {
            studentsRandom = new Student[]
           {

               new Student("G7", "Cert 3", new DateTime(2026, 06, 17),
                    "Fiona", "fiona7@someemail.com", "+0707070707",
                    new Address(), new Enrollment()),

               new Student("A1", "Cert 3", new DateTime(2026, 06, 11),
                    "Marcus", "marcus1@someemail.com", "+0101010101",
                    new Address(), new Enrollment()),

               new Student("J10", "Cert 3", new DateTime(2026, 06, 20),
                    "Ivan", "ivan10@someemail.com", "+1010101010",
                    new Address(), new Enrollment()),

               new Student("D4", "Cert 3", new DateTime(2026, 06, 14),
                    "Charlie", "charlie4@someemail.com", "+0404040404",
                    new Address(), new Enrollment()),

               new Student("I9", "Cert 3", new DateTime(2026, 06, 19),
                    "Hannah", "hannah9@someemail.com", "+0909090909",
                    new Address(), new Enrollment()),

               new Student("C3", "Cert 3", new DateTime(2026, 06, 13),
                    "Bob", "bob3@someemail.com", "+0303030303",
                    new Address(), new Enrollment()),

               new Student("F6", "Cert 3", new DateTime(2026, 06, 16),
                    "Ethan", "ethan6@someemail.com", "+0606060606",
                    new Address(), new Enrollment()),

               new Student("H8", "Cert 3", new DateTime(2026, 06, 18),
                    "George", "george8@someemail.com", "+0808080808",
                    new Address(), new Enrollment()),

               new Student("B2", "Cert 3", new DateTime(2026, 06, 12),
                    "Alice", "alice2@someemail.com", "+0202020202",
                    new Address(), new Enrollment()),

               new Student("E5", "Cert 3", new DateTime(2026, 06, 15),
                    "Diana", "diana5@someemail.com", "+0505050505",
                    new Address(), new Enrollment())

    };

            studentsSorted = new Student[]
{
    new Student("A1", "Cert 3", new DateTime(2026, 06, 11),
        "Marcus", "marcus1@someemail.com", "+0101010101",
        new Address(), new Enrollment()),

    new Student("B2", "Cert 3", new DateTime(2026, 06, 12),
        "Alice", "alice2@someemail.com", "+0202020202",
        new Address(), new Enrollment()),

    new Student("C3", "Cert 3", new DateTime(2026, 06, 13),
        "Bob", "bob3@someemail.com", "+0303030303",
        new Address(), new Enrollment()),

    new Student("D4", "Cert 3", new DateTime(2026, 06, 14),
        "Charlie", "charlie4@someemail.com", "+0404040404",
        new Address(), new Enrollment()),

    new Student("E5", "Cert 3", new DateTime(2026, 06, 15),
        "Diana", "diana5@someemail.com", "+0505050505",
        new Address(), new Enrollment()),

    new Student("F6", "Cert 3", new DateTime(2026, 06, 16),
        "Ethan", "ethan6@someemail.com", "+0606060606",
        new Address(), new Enrollment()),

    new Student("G7", "Cert 3", new DateTime(2026, 06, 17),
        "Fiona", "fiona7@someemail.com", "+0707070707",
        new Address(), new Enrollment()),

    new Student("H8", "Cert 3", new DateTime(2026, 06, 18),
        "George", "george8@someemail.com", "+0808080808",
        new Address(), new Enrollment()),

    new Student("I9", "Cert 3", new DateTime(2026, 06, 19),
        "Hannah", "hannah9@someemail.com", "+0909090909",
        new Address(), new Enrollment()),

    new Student("J10", "Cert 3", new DateTime(2026, 06, 20),
        "Ivan", "ivan10@someemail.com", "+1010101010",
        new Address(), new Enrollment())
};



            sortAcending = new string[]
 {
    "A1","B2","C3","D4","E5","F6","G7","H8","I9","J10"
 };


            sortDesending = new string[]
   {
    "J10","I9","H8","G7","F6","E5","D4","C3","B2","A1"
   };


        }

        [Test]
        public void TestLinearSearchIsFound()
        {

            // Arrange
            Student targetFound = new Student("B2", "Cert 3", new DateTime(2026, 06, 12),
            "Alice", "alice2@someemail.com", "+0202020202",
            new Address(), new Enrollment());

            // Act
            int foundIndex = Utility.LinearSearch(studentsSorted, targetFound);

            // Assert
            Assert.That(foundIndex, Is.EqualTo(1));

        }

        [Test]
        public void TestLinearSearchIsNotFound()
        {
            Student targetNotFound = new Student(
               "99999999", "Cert 3", DateTime.Now,
               "Ghost", "ghost@none.com", "+0000000000",
               new Address(), new Enrollment()
           );

            int notFoundIndex = Utility.LinearSearch(studentsSorted, targetNotFound);

            Assert.That(notFoundIndex, Is.EqualTo(-1));

        }


        [Test]
        public void TestBinraySearchIsFound()
        {
            Student targetFound = new Student("I9", "Cert 3", new DateTime(2026, 06, 19),
        "Hannah", "hannah9@someemail.com", "+0909090909",
        new Address(), new Enrollment());

            // A student that is *not* in the array

            // Act
            int foundIndex = Utility.BinarySearch(studentsSorted, targetFound);


            // Assert
            Assert.That(foundIndex, Is.EqualTo(8));
        }

        [Test]
        public void TestBinarySearchIsNotFound()
        {
            Student targetNotFound = new Student(
               "88888888", "Cert 3", DateTime.Now,
               "Petter", "petter@none.com", "+0001112223",
               new Address(), new Enrollment()
           );

            int notFoundIndex = Utility.BinarySearch(studentsSorted, targetNotFound);

            Assert.That(notFoundIndex, Is.EqualTo(-1));

        }

        [Test]
        public void BubbileSortAcendingTest()
        {
            Utility.bubbleSortAcending(studentsRandom);

            for (int i = 0; i < sortAcending.Length; i++)
            {
                Assert.That(studentsRandom[i].StudentId, Is.EqualTo(sortAcending[i]));
            }

        }

        [Test]
        public void BubbileDecendinTest()
        {
            Utility.bubbleSortDecending(studentsRandom);

            for (int i = 0; i < sortDesending.Length; i++)
            {
                Assert.That(studentsRandom[i].StudentId, Is.EqualTo(sortDesending[i]));
            }

        }
    }
}