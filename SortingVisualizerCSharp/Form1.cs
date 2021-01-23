using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SortingVisualizerCSharp
{
  public partial class Form1 : Form
  {

    private double[] arr;

    public Form1()
    {
      InitializeComponent();
      //BubbleSort.Sort(test2, test2.Length).ToList().ForEach(x => Debug.Print(x.ToString()));
    }


    public new void Paint(double[] arr)
    {
      panel1.Refresh();
      PaintArray(arr, Painter.PaintLine);
      Thread.Sleep(1);
    }


    public void PaintArray(double[] arr, Action<double, Graphics, int, int, int> GetLine)
    {
      for (int i = 0; i < arr.Length; i++)
      {
        GetLine(arr[i], panel1.CreateGraphics(), i * (Width / arr.Length), Height, Width / arr.Length);
      }

      //CreateGraphics().FillRectangle(new SolidBrush(Color.Black), 100, 100, 100, 100);
    }

    private void Form1_Shown(object sender, EventArgs e)
    {
      Random randNum = new Random();
      arr = Enumerable
    .Repeat(0, 100)
    .Select(i => randNum.NextDouble() * this.Height)
    .ToArray();

      //arr.ToList().ForEach(x => Debug.Print(x.ToString()));

      Paint(arr);
    }

    private async void buttonSortStart_Click(object sender, EventArgs e)
    {
     await BubbleSort.SortAync(arr,arr.Length, Paint);
    }
  }
}
