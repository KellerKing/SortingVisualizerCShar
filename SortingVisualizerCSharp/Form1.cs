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
    private Bitmap bm = new Bitmap(944, 684);
    private Graphics g;

    private double[] arr;

    public Form1()
    {
      InitializeComponent();
      arr = Helper.GetRandomArray(600, 50);
    }

    private void Form1_Load(object sender, EventArgs e)
    {
      g = Graphics.FromImage(bm);
    }


    public async void PaintOnScreen(double[] arr)
    {
      
      PaintArray(arr, Painter.PaintLine);
      Refresh();
      g.Clear(Color.White);
      Thread.Sleep(50);
    }


    public void PaintArray(double[] arr, Action<double, Graphics, int, int, int> GetLine)
    {
      for (int i = 0; i < arr.Length; i++)
      {
        GetLine(arr[i], g, i * (Width / arr.Length), Height, Width / arr.Length);
      }

      //CreateGraphics().FillRectangle(new SolidBrush(Color.Black), 100, 100, 100, 100);
    }

    private void Form1_Shown(object sender, EventArgs e)
    {
      PaintOnScreen(arr);
    }

    private async void buttonSortStart_Click(object sender, EventArgs e)
    {
     await BubbleSort.SortAync(arr,arr.Length, PaintOnScreen);
    }

    private void Form1_Paint_1(object sender, PaintEventArgs e)
    {
      e.Graphics.DrawImage(bm, 20, 0);
    }
  }
}
