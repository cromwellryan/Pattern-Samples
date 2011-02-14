using NUnit.Framework;
using Should.Fluent;

namespace DecoratorPattern.Tests
{
    [TestFixture]
    public class SpellCheckerTests
    {
        [Test]
        public void ShouldFailSpellingCheck_WhenWordIncludesEBeforeIButNotAfterC()
        {
            new SpellChecker().Check("Cheif").Should().Be.False();
        }

        [TestCase("Receive")]
        [TestCase("Deceive")]
        public void ShouldPassSpellingCheck_WhenWordIncludesEBeforeIButAfterC(string word)
        {
            new SpellChecker().Check(word).Should().Be.True();
        }

        [Test]
        public void ShouldPassSpellingCheck_WhenWordIncludesIBeforeE()
        {
            new SpellChecker().Check("Chief").Should().Be.True();
        }
    }
}
