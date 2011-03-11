using System;
using System.Diagnostics;

namespace InterfaceSegregationPrincipal.Violation
{
  public class HondaAccord : ICar
  {
    public void DriveStraight()
    {
      Debug.WriteLine("Driving Straight");
    }

    public void Stop()
    {
      Debug.WriteLine("Stopping");
    }

    public void TurnLeft()
    {
      Debug.WriteLine("Turning Left");
    }

    public void TurnRight()
    {
      Debug.WriteLine("Turning Right");
    }

    public string Color { get { return "Green"; } }
    public string Model { get { return "Accord"; } }
    public int Doors { get { return 4; } }
  }
}
