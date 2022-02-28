using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TP_Mod2
{
    public partial class HelloWorldApp : Form
    {
        public HelloWorldApp()
        {
            InitializeComponent();
        }

        private void button_submit_Click(object sender, EventArgs e)
        {
            string inputText = this.textBox_input.Text;

            this.label_output.Text = "Halo " + inputText;
        }

    }
}
