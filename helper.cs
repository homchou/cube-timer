using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;

using System.Text;
using System.Windows.Forms;

namespace Simple_Cute_Timer
{
    public partial class helper : Form
    {
        public helper()
        {
            InitializeComponent();
        }

        private void helper_Load(object sender, EventArgs e)
        {
            textBox1.Select(0, 0);
            textBox1.Select(textBox1.Text.Length, 0);
            textBox1.Focus();
        }
    }
}
