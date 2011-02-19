using System.Diagnostics;

namespace OpenClosedPrincipal.Outputs
{
    internal class DebugOutput : IOutput
    {
        public void Write(string message)
        {
            Debug.WriteLine(message);
        }
    }
}