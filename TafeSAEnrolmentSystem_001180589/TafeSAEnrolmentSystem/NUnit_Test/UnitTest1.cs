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
            // Unsorted array
            studentsRandom = new Student[]
            {
                new Student("G7"),
                new Student("A1"),
                new Student("J10"),
                new Student("D4"),
                new Student("I9"),
                new Student("C3"),
                new Student("F6"),
                new Student("H8"),
                new Student("B2"),
                new Student("E5")
            };

            // Sorted array (ascending)
            studentsSorted = new Student[]
            {
                new Student("A1"),
                new Student("B2"),
                new Student("C3"),
                new Student("D4"),
                new Student("E5"),
                new Student("F6"),
                new Student("G7"),
                new Student("H8"),
                new Student("I9"),
                new Student("J10")
            };

            // Expected sorted orders
            sortAcending = new string[]
            {
                "A1","B2","C3","D4","E5","F6","G7","H8","I9","J10"
            };

            sortDesending = new string[]
            {
                "J10","I9","H8","G7","F6","E5","D4","C3","B2","A1"
            };
        }


        // Linear Search Tests


        [Test]
        public void TestLinearSearchIsFound()
        {
            Student targetFound = new Student("B2");

            int foundIndex = Utility.LinearSearch(studentsSorted, targetFound);

            Assert.That(studentsSorted[foundIndex].StudentId, Is.EqualTo("B2"));
        }

        [Test]
        public void TestLinearSearchIsNotFound()
        {
            Student targetNotFound = new Student(
                "99999999");

            int notFoundIndex = Utility.LinearSearch(studentsSorted, targetNotFound);

            Assert.That(notFoundIndex, Is.EqualTo(-1));
        }

        // Binary Search Tests

        [Test]
        public void TestBinarySearchIsFound()
        {
            Student targetFound = new Student("I9");

            int foundIndex = Utility.BinarySearch(studentsSorted, targetFound);

            Assert.That(studentsSorted[foundIndex].StudentId, Is.EqualTo("I9"));
            ;
        }

        [Test]
        public void TestBinarySearchIsNotFound()
        {
            Student targetNotFound = new Student(
                "88888888");

            int notFoundIndex = Utility.BinarySearch(studentsSorted, targetNotFound);

            Assert.That(notFoundIndex, Is.EqualTo(-1));
        }


        // Bubble Sort Tests
      

        [Test]
        public void BubbleSortAcendingTest()
        {
            Utility.bubbleSortAcending(studentsRandom);

            for (int i = 0; i < sortAcending.Length; i++)
            {
                Assert.That(studentsRandom[i].StudentId, Is.EqualTo(sortAcending[i]));
            }
        }

        [Test]
        public void BubbleSortDecendingTest()
        {
            Utility.bubbleSortDecending(studentsRandom);

            for (int i = 0; i < sortDesending.Length; i++)
            {
                Assert.That(studentsRandom[i].StudentId, Is.EqualTo(sortDesending[i]));
            }
        }
        // Merge Sort test

        [Test]
        public void MergeSortAcendingTest()
        {
            Utility.mergeAcending(studentsRandom, 0, studentsRandom.Length -1);

            for (int i = 0; i < studentsRandom.Length; i++)
            {
                Assert.That(studentsRandom[i].StudentId, Is.EqualTo(sortAcending[i]));
            }
        }

        [Test]
        public void MergeSortDecendingTest()
        {
            Utility.mergeDecending(studentsRandom, 0, studentsRandom.Length - 1);

            for (int i = 0; i < studentsRandom.Length; i++)
            {
                Assert.That(studentsRandom[i].StudentId, Is.EqualTo(sortDesending[i]));
            }
        }

    }
}
