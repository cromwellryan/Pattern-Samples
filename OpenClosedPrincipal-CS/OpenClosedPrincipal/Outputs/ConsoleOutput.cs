using System;

namespace OpenClosedPrincipal.Outputs
{
    internal class ConsoleOutput : IOutput
    {
        public void Write(string message)
        {
            Console.WriteLine(message);
        }
    }
}