using System;

namespace DecoratorPattern
{
    public class SpellChecker : ISpellChecker
    {
        public bool Check(string word)
        {
            if (word.Contains("cei"))
                return true;

            if (word.Contains("ie"))
                return true;

            return false;
        }
    }
}