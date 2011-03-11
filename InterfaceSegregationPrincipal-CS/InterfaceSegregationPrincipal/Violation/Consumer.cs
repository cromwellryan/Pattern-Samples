using System.Diagnostics;
using NUnit.Framework;

namespace InterfaceSegregationPrincipal.Violation
{
  [TestFixture]
  class Consumer
  {
    [Test]
    public void RecallingASundayDrive()
    {
      var car = new CarFactory().CreateHonda();

      var story = @"One Sunday afternoon, a {0} {1} with {2} doors drove by our home.";

      Debug.WriteLine(story, car.Color, car.Model, car.Doors);
    }

    [Test]
    public void TakingASundayDrive()
    {
      var car = new CarFactory().CreateHonda();

      Debug.WriteLine(@"Follow my directions: ");

      car.DriveStraight();
      car.TurnLeft();
      car.TurnLeft();
      car.TurnRight();
      car.DriveStraight();
      car.Stop();
    }
  }
}
