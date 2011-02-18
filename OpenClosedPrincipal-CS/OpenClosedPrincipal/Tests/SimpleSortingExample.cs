using System.Linq;
using NUnit.Framework;

namespace OpenClosedPrincipal.Tests
{
    [TestFixture]
    class SimpleSortingExample
    {
        [Test]
        public void SortingByAge()
        {
            var people = new[]
                             {
                                 new {Name = "Ryan", Age = 32},
                                 new {Name = "John", Age = 29},
                                 new {Name = "Dan", Age = 32},
                                 new {Name = "Dave", Age = 30}
                             };

            var expected = new[] {"John", "Dave", "Dan","Ryan"};


            var sortedByAge = people.OrderBy(x => x.Age)
                                    .Select(x => x.Name);

            CollectionAssert.AreEquivalent(expected, sortedByAge);
        }

    }


}
