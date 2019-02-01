using System;
using System.Windows.Forms;

namespace RichTextBox_textTransfer
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            richTextBox1.Text = Form1.MainMessage;
        }
    }
}
