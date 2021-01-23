using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace SortingVisualizerCSharp
{
  class BubbleSort
  {
    private static double[] Swap(int index1, int index2, double[] arr) //TODO: Stimmt net
    {
      double[] newArr = new double[arr.Length];

      Array.Copy(arr, newArr, arr.Length); 
      newArr[index1] = arr[index2];
      newArr[index2] = arr[index1];

      return newArr;
    }

    public static async Task<double[]> SortAync(double[] arr, int n, Action<double[]> paint)
    {

      if (n == 1) return arr;

      double[] newArr = new double[arr.Length];
      Array.Copy(arr, newArr, arr.Length);

      for (int i = 0; i < n-1; i++)
      {
        if (newArr[i] > newArr[i + 1])
        {
          newArr = Swap(i, i + 1, newArr);
          paint(newArr);
        }
       // paint(newArr);
      }
     

      return await SortAync(newArr, n - 1, paint);
    }
  }
}
