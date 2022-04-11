using System;
using System.Windows.Forms;

namespace Patterns
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Delegating delegateForm = new Delegating();

            delegateForm.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SuperclassForm superclassForm = new SuperclassForm();

            superclassForm.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            FactoryMethodForm factoryMethodForm = new FactoryMethodForm();

            factoryMethodForm.Show();
        }
    }
}
