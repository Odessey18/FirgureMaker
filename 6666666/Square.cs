using System;
using System.Windows.Forms;
using System.Drawing;
class Square
{
	private int X, Y, W;
	public Square(int x , int y, int w)
	{
		X = x;
		Y = y;
		W = w;
	}
	public int GetArea()
	{
		return W*W;	
	}
	public int GetPerimetr()
	{
		return W*4;
	}
	public void Draw(Graphics canvas, SolidBrush brush)
	{
		canvas.FillRectangle(brush,X,Y,W,W);
	}
}