using System;
using InterfaceSegregationPrincipal.HappyPath;

namespace InterfaceSegregationPrincipal.HappyPath
{
  internal class CarFactory
  {
    public ICar CreateHonda()
    {
      return new FordFiesta();
    }
  }
}