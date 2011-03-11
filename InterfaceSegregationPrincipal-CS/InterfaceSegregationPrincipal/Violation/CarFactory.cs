using System;

namespace InterfaceSegregationPrincipal.Violation
{
  internal class CarFactory
  {
    public ICar CreateHonda()
    {
      return new Honda();
    }
  }
}