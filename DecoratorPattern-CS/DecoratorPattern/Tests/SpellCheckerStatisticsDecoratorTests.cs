using System;
using NUnit.Framework;
using Should.Fluent;

namespace DecoratorPattern.Tests
{
    [TestFixture]
    public class SpellCheckerStatisticsDecoratorTests
    {
        [Test]
        public void ShouldRespondWithResultFromTargetOfDecoration()
        {
            new SpellCheckerStatisticsDecorator(new MockSpellChecker(true)).Check("something").Should().Be.True();
            new SpellCheckerStatisticsDecorator(new MockSpellChecker(false)).Check("something").Should().Be.False();
        }

        [Test]
        public void ShouldRecordNumberOfCallsToCheck()
        {
            var spellCheckerStatisticsDecorator = new SpellCheckerStatisticsDecorator(new MockSpellChecker(true));

            spellCheckerStatisticsDecorator.Check("something");
            spellCheckerStatisticsDecorator.Check("somethingelse");
            spellCheckerStatisticsDecorator.Check("somethingelse");

            spellCheckerStatisticsDecorator.CheckWasCalled.Should().Equal(3);
        }
    }

    public class MockSpellChecker : ISpellChecker 
    {
        private readonly bool _mockResult;

        public MockSpellChecker(bool mockResult)
        {
            _mockResult = mockResult;
        }

        public bool Check(string word)
        {
            return _mockResult;
        }
    }
}
