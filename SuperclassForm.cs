using System;
using System.Drawing;
using System.Windows.Forms;
using Patterns.Superclass.Shapes;

namespace Patterns
{
    public partial class SuperclassForm : Form
    {
        private Graphics _formGraphics;
        public SuperclassForm()
        {
            InitializeComponent();
        }
        private void AbstractSuperclass_Load(object sender, EventArgs e)
        {
            _formGraphics = CreateGraphics();
        }
        private void _circleButton_Click(object sender, EventArgs e)
        {
            Circle circle = new Circle(Color.Black, _formGraphics, 200);
            circle.DrawShape();
        }
        private void _rectangleButton_Click(object sender, EventArgs e)
        {
            Superclass.Shapes.Rectangle rectangle =
                new Superclass.Shapes.Rectangle(Color.Black, _formGraphics, 235, 120);
            rectangle.DrawShape();
        }
        private void _ellipseButton_Click(object sender, EventArgs e)
        {
            Ellipse ellipse = new Ellipse(Color.Black, _formGraphics, 150, 200);
            ellipse.DrawShape();
        }
        private void _squareButton_Click(object sender, EventArgs e)
        {
            Square square = new Square(Color.Black, _formGraphics, 250);
            square.DrawShape();
        }
    }
}
