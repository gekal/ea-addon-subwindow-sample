using System;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace AddinMainWithWindow
{
    public partial class SampleWindow : UserControl
    {
        public SampleWindow()
        {
            InitializeComponent();
        }

        private void SayHello_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Hello world!");
        }

        public void test()
        {
            MessageBox.Show("Hello world!");
        }
    }
}
