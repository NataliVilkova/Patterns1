using Patterns.Strategy;
using System;
using System.Windows.Forms;

namespace Patterns
{
    public partial class StrategyForm : Form
    {
        private SortingContext sortingContext;
        private ISorting sorting;

        public StrategyForm()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            sorting = new BubbleSort();
            sortingContext = new SortingContext(sorting);
            textBox2.Text = sortingContext.SortArray(SetupArray());
        }
        private void button2_Click(object sender, EventArgs e)
        {
            sorting = new SelectionSort();
            sortingContext = new SortingContext(sorting);
            textBox2.Text = sortingContext.SortArray(SetupArray());
        }
        private void button3_Click(object sender, EventArgs e)
        {
            sorting = new InsertionSort();
            sortingContext = new SortingContext(sorting);
            textBox2.Text = sortingContext.SortArray(SetupArray());
        }
        private void button4_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
        }
        private int[] SetupArray()
        {
            int stringToArrayofInt = Convert.ToInt32(textBox1.Text);
            int[] array = new int[textBox1.Text.Length];
            for (int i = 0; i < textBox1.Text.Length; i++)
            {
                array[i] = stringToArrayofInt % 10;

                stringToArrayofInt /= 10;
            }
            return array;
        }
    }
}
