using System;
using System.Windows.Forms;
using Patterns.Delegate;

namespace Patterns
{
    public partial class Delegating : Form
    {
        private Procent _procent;

        public Delegating()
        {
            InitializeComponent();
        }
        private void Delegating_Load(object sender, EventArgs e)
        {
            _procent = new Procent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Text = _procent.CountSumTruncuated(GetSum(), 25).ToString();
        }
        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = _procent.CountSumTruncuated(GetSum(), 15).ToString();
        }
        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.Text = _procent.CountSumTruncuated(GetSum(), 1).ToString();
        }
        private double GetSum()
        {
            double.TryParse(textBox1.Text, out double result);
            return result;
        }
    }
}
