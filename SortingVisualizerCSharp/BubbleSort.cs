using System;
using System.Collections.Generic;
using System.Text;

namespace SortingVisualizerCSharp
{
  class BubbleSort
  {
    private static double[] Swap(int index1, int index2, double[] arr) //TODO: Stimmt net
    {
      var newArr = arr; //1 = 5 | 2 = 10
      newArr[index1] = arr[index2];
      newArr[index2] = arr[index1];

      return newArr;
    }

    public static double[] Sort(double[] arr, int n)
    {

      if (n == 1) return arr;

      var newArr = arr;

      for (int i = 0; i < n-1; i++)
      {
        newArr = newArr[i] > newArr[i+1] ? Swap(i, i + 1, newArr) : newArr;
      }

      return Sort(newArr, n - 1);
    }
  }
}
