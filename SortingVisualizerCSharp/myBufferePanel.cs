using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

namespace SortingVisualizerCSharp
{
  class myBufferePanel : Panel
  {
    public myBufferePanel()
    {
      this.DoubleBuffered = true;
      this.SetStyle(ControlStyles.UserPaint |
                    ControlStyles.AllPaintingInWmPaint |
                    ControlStyles.ResizeRedraw |
                    ControlStyles.ContainerControl |
                    ControlStyles.OptimizedDoubleBuffer |
                    ControlStyles.SupportsTransparentBackColor
                    , true);
    }
  }
}
