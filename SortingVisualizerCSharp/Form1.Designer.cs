﻿
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
      this.panel1 = new myBufferePanel();
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
      // panel1
      // 
      this.panel1.Location = new System.Drawing.Point(13, 13);
      this.panel1.Name = "panel1";
      this.panel1.Size = new System.Drawing.Size(944, 684);
      this.panel1.TabIndex = 2;
      // 
      // Form1
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(969, 748);
      this.Controls.Add(this.panel1);
      this.Controls.Add(this.buttonSortStart);
      this.DoubleBuffered = true;
      this.Name = "Form1";
      this.Text = "Form1";
      this.Shown += new System.EventHandler(this.Form1_Shown);
      this.ResumeLayout(false);

    }

    #endregion
    private System.Windows.Forms.Button buttonSortStart;
    private System.Windows.Forms.Panel panel1;
  }
}

