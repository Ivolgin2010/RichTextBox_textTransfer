using System;
using System.Windows.Forms;

namespace RichTextBox_textTransfer
{
    public partial class Form1 : Form
    {
        public static string MainMessage;

        public static string Message1;

        public Form1()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            MainMessage = "Вывод командной строки >> \n";
            Form2 f = new Form2();
            f.Show();
        }

        private void Button1_Click_1(object sender, EventArgs e)
        {
            Close();
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Выводим в окно значение параметра 1", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Message1 = "Расчетный параметр 1 равен:";
        }
    }
}
