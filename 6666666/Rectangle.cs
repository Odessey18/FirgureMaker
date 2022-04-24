using System;
using System.Windows.Forms;
using System.Drawing;
class Rectangle
{
	private int X, Y, W, H;
	public Rectangle(int x , int y, int w,int h)
	{
		X = x;
		Y = y;
		W = w;
		H = h;
	}
	public int GetArea()
	{
		return W*H;	
	}
	public int GetPerimetr()
	{
		return 2*(W+H);
	}
	public void Draw(Graphics canvas, SolidBrush brush)
	{
		canvas.FillRectangle(brush,X,Y,W,H);
	}
}