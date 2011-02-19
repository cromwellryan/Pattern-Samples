using System.Linq;
using NUnit.Framework;
using OpenClosedPrincipal.Outputs;

namespace OpenClosedPrincipal.Tests
{
    [TestFixture]
    class Examples
    {
        private readonly Person[] _people = new[]
                                                {
                                                    new Person {Name = "Ryan", Age = 32},
                                                    new Person{Name = "John", Age = 29},
                                                    new Person{Name = "Dan", Age = 32},
                                                    new Person{Name = "Dave", Age = 30}
                                                };


        [Test]
        public void SortingByAge()
        {
            var expected = new[] { "John", "Dave", "Dan", "Ryan" };


            var sortedByAge = _people.OrderBy(person => person.Age) // Open to ordering by different selections of items, but closed to sorting algorithm
                                     .Select(person => person.Name);

            CollectionAssert.AreEquivalent(expected, sortedByAge);
        }

        [Test]
        public void CanPrintPeopleByName()
        {
            var peoplePrinter = new PeoplePrinter(new ConsoleOutput()); // Open to output to different IOutput implementations

            peoplePrinter.Print(_people, person => person.Name); // Open to printing different formats of Person, but closed to how people are iterated.
        }

        [Test]
        public void CanPrintPeopleByAge()
        {
            var peoplePrinter = new PeoplePrinter(new DebugOutput()); // Open to output to different IOutput implementations

            peoplePrinter.Print(_people, person => person.Age.ToString()); // Open to printing different formats of Person, but closed to how people are iterated.
        }

    }
}
