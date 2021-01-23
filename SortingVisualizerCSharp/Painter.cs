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
      g.FillRectangle(new SolidBrush(Color.Black), posX, 0, w, (int)value);
      //g.FillRectangle(new SolidBrush(Color.Black), 100, 400, 100, 100);
    }
  }
}