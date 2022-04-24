using System;
using System.Windows.Forms;
using System.Drawing;


public class MainForm : Form
{
	private TextBox xText;
	private TextBox yText;
	private TextBox wText;
	private TextBox hText;

	private Button squareButton;
	private Button circleButton;
	private Button rectangleButton;

	private Label result;

	private Graphics canvas;
	private SolidBrush brush;

	public MainForm ()
	{
		Width = 800;
		Height = 600;

		xText = new TextBox();
		yText = new TextBox();
		yText.Left = 100;
		wText = new TextBox();
		wText.Left = 200;
		hText = new TextBox();
		hText.Left = 300;
		squareButton = new Button();
		squareButton.Left = 400;
		squareButton.Text = "Квадрат";
		squareButton.Click += SquareButton_Click;

		circleButton = new Button();
		circleButton.Left = 475;
		circleButton.Text = "Круг";
		circleButton.Click += CircleButton_Click;

		rectangleButton = new Button();
		rectangleButton.Left = 550;
		rectangleButton.Width = 120;
		rectangleButton.Text = "Прямоугольник";
		rectangleButton.Click += RectangleButton_Click;

		canvas = CreateGraphics();
		brush = new SolidBrush(Color.DarkOrange);

		result = new Label();
		result.Left = 670;
		result.Top = 5;
		result.Text = "S:_____, P:_____";

		Controls.Add(xText);
		Controls.Add(yText);
		Controls.Add(wText);
		Controls.Add(hText);
		Controls.Add(squareButton);
		Controls.Add(circleButton);
		Controls.Add(rectangleButton);
		Controls.Add(result);

		canvas.Clear(Color.White);

	}
	void SquareButton_Click (object sender, EventArgs e)
	{
		canvas.Clear(Color.White);

		Square square = new Square(int.Parse(xText.Text), int.Parse(yText.Text), int.Parse(wText.Text));
		result.Text = "S: " + square.GetArea().ToString() + ", P: " + square.GetPerimetr().ToString();
		square.Draw(canvas, brush);
	}

	void CircleButton_Click (object sender, EventArgs e)
	{
		canvas.Clear(Color.White);

		Circle circle = new Circle(int.Parse(xText.Text), int.Parse(yText.Text), int.Parse(wText.Text));
		result.Text = "S: " + circle.GetArea().ToString() + ", P: " + circle.GetPerimetr().ToString();
		circle.Draw(canvas, brush);

	}

	void RectangleButton_Click (object sender, EventArgs e)
	{
		canvas.Clear(Color.White);

		Rectangle rectangle = new Rectangle(int.Parse(xText.Text), int.Parse(yText.Text), int.Parse(wText.Text), int.Parse(hText.Text));
		result.Text = "S: " + rectangle.GetArea().ToString() + ", P: " + rectangle.GetPerimetr().ToString();
		rectangle.Draw(canvas, brush);

	}
}


