
namespace SortingVisualizerCSharp
{
  partial class Form1
  {
    /// <summary>
    ///  Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    ///  Clean up any resources being used.
    /// </summary>
    /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    protected override void Dispose(bool disposing)
    {
      if (disposing && (components != null))
      {
        components.Dispose();
      }
      base.Dispose(disposing);
    }

    #region Windows Form Designer generated code

    /// <summary>
    ///  Required method for Designer support - do not modify
    ///  the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
      this.buttonSortStart = new System.Windows.Forms.Button();
      this.SuspendLayout();
      // 
      // buttonSortStart
      // 
      this.buttonSortStart.Location = new System.Drawing.Point(13, 703);
      this.buttonSortStart.Name = "buttonSortStart";
      this.buttonSortStart.Size = new System.Drawing.Size(94, 29);
      this.buttonSortStart.TabIndex = 1;
      this.buttonSortStart.Text = "Sort";
      this.buttonSortStart.UseVisualStyleBackColor = true;
      this.buttonSortStart.Click += new System.EventHandler(this.buttonSortStart_Click);
      // 
      // Form1
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(969, 748);
      this.Controls.Add(this.buttonSortStart);
      this.DoubleBuffered = true;
      this.Name = "Form1";
      this.Text = "Form1";
      this.Load += new System.EventHandler(this.Form1_Load);
      this.Shown += new System.EventHandler(this.Form1_Shown);
      this.Paint += new System.Windows.Forms.PaintEventHandler(this.Form1_Paint_1);
      this.ResumeLayout(false);

    }

    #endregion
    private System.Windows.Forms.Button buttonSortStart;
  }
}

