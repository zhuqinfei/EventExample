using System;
using System.Windows.Forms;

namespace EventExample4
{
    /// <summary>
    /// 三星难度事件：对于有按钮和文本框类的时候，怎么去订阅事件。
    /// 这是用一个类包住他们两个，对这个类进行订阅即可
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            Myform form = new Myform();
            form.ShowDialog();

        }
    }
    class Myform:Form
    {
        private TextBox textBox;
        private Button button;
        public Myform()
        {
            this.textBox = new TextBox();
            this.button = new Button();
            this.Controls.Add(this.button);
            this.Controls.Add(this.textBox);
            this.button.Click += this.ButtonClicked;
        }

        private void ButtonClicked(object sender, EventArgs e)
        {
            this.textBox.Text = "Hello, World!!!!!!!!!!!!!";
        }
    }
}
