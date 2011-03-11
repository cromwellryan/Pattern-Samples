namespace InterfaceSegregationPrincipal.Violation
{
  public interface ICar
  {
    void DriveStraight();
    void Stop();
    void TurnLeft();
    void TurnRight();

    string Color { get; }
    string Model { get; }
    int Doors { get; }
  }
}