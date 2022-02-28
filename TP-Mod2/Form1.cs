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
            // Mengambil teks yang telah diketik pada komponen TextBox
            string inputText = this.textBox_input.Text;

            // Melakukan set teks pada label output menjadi "Halo %teks_input%"
            this.label_output.Text = "Halo " + inputText;
        }

    }
}
