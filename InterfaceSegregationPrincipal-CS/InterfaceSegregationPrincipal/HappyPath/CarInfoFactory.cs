using System;

namespace InterfaceSegregationPrincipal.HappyPath
{
  internal class CarInfoFactory
  {
    public ICarInfo CreateHondaInfo()
    {
      return new FordFiesta();
    }
  }
}