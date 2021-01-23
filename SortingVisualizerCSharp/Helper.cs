using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SortingVisualizerCSharp
{
  class Helper
  {
    public static double[] GetRandomArray(int maxValue, int n)
    {
      Random randNum = new Random();

     return Enumerable
      .Repeat(0, n)
      .Select(i => randNum.NextDouble() * maxValue)
      .ToArray();
    }
  }
}
