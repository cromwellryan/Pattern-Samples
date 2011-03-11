using System;
using System.Diagnostics;

namespace InterfaceSegregationPrincipal.HappyPath
{
  internal class FordFiesta : ICar, ICarInfo
  {
    /* Implementation of ICar */
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


    /* Implementation of ICarInfo */
    public string Color { get { return "Green"; } }
    public string Model { get { return "Accord"; } }
    public int Doors { get { return 4; } }
  }

  internal interface ICarInfo
  {
    string Color { get; }
    string Model { get; }
    int Doors { get; }
  }
}