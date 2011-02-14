using System;
using DecoratorPattern.Tests;

namespace DecoratorPattern
{
    class SpellCheckerStatisticsDecorator : ISpellChecker 
    {
        private readonly MockSpellChecker _spellChecker;

        public SpellCheckerStatisticsDecorator(MockSpellChecker spellChecker)
        {
            _spellChecker = spellChecker;
        }

        public int CheckWasCalled { get; private set; }

        public bool Check(string word)
        {
            CheckWasCalled++;

            return _spellChecker.Check(word);
        }
    }
}
