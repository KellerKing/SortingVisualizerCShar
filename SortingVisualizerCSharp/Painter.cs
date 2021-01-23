using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace SortingVisualizerCSharp
{
  class Painter
  {
    public static void PaintLine(double value, Graphics g, int posX, int posY, int w)
    {
      var rnd = new Random();
      g.FillRectangle(new SolidBrush(Color.FromArgb(rnd.Next(256), rnd.Next(256), rnd.Next(256))), posX, 0, w, (int)value*10);
      //g.FillRectangle(new SolidBrush(Color.Black), 100, 400, 100, 100);
    }
  }
}