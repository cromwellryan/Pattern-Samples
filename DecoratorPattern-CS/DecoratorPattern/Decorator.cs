using System;

namespace DecoratorPattern
{
    public class Decorator : ISpellChecker
    {
        private ISpellChecker _spellChecker;

        public virtual bool Check(string word)
        {
            return _spellChecker.Check(word);
        }

        public void SetComponent(ISpellChecker spellChecker )
        {
            _spellChecker = spellChecker;
        }
    }



    public class ConsoleOutputDecorator : Decorator
    {
        public override bool Check(string word)
        {
            AddBehavior(word);
            return base.Check(word);
        }

        private static void AddBehavior(string word)
        {
            Console.WriteLine("Checking word {0}", word);
        }
    }
}