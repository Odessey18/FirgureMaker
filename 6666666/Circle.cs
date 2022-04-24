using System;
using System.Windows.Forms;
using System.Drawing;
class Circle
{
	private int X, Y, W;
	public Circle(int x , int y, int w)
	{
		X = x;
		Y = y;
		W = w;
	}
	public int GetArea()
	{
		return (int)(Math.PI*(W*W));	
	}
	public int GetPerimetr()
	{
		return (int)(2*Math.PI*W);
	}
	public void Draw(Graphics canvas, SolidBrush brush)
	{
		canvas.FillEllipse(brush,X,Y,W,W);
	}
}