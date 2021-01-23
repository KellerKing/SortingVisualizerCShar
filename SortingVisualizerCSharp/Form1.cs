using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SortingVisualizerCSharp
{
  public partial class Form1 : Form
  {
    public Form1()
    {
      InitializeComponent();

      //BubbleSort.Sort(test2, test2.Length).ToList().ForEach(x => Debug.Print(x.ToString()));

    }


    public void PaintInitArray(double[] arr, Action<double, Graphics, int, int, int> GetLine)
    {
      for (int i = 0; i < arr.Length; i++)
      {
        GetLine(arr[i], this.CreateGraphics(), i * (Width / arr.Length), Height, Width / arr.Length);
      }

      //CreateGraphics().FillRectangle(new SolidBrush(Color.Black), 100, 100, 100, 100);
    }

    private void Form1_Shown(object sender, EventArgs e)
    {
      Random randNum = new Random();
      double[] test2 = Enumerable
    .Repeat(0, 100)
    .Select(i => randNum.NextDouble() * 50)
    .ToArray();

      test2.ToList().ForEach(x => Debug.Print(x.ToString()));

      PaintInitArray(test2, Painter.PaintLine);
    }
  }
}
