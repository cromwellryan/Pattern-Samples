using System;
using System.Collections.Generic;
using OpenClosedPrincipal.Outputs;
using OpenClosedPrincipal.Tests;

namespace OpenClosedPrincipal
{
    internal class PeoplePrinter
    {
        private readonly IOutput _output;

        public PeoplePrinter(IOutput output)
        {
            _output = output;
        }

        public void Print(IEnumerable<Person> people, Func<Person, string> selector)
        {
            foreach (var person in people)
                _output.Write(selector(person));
        }
    }
}