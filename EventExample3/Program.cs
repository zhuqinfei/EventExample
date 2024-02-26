using System;
using System.Windows.Forms;

namespace EventExample3
{
    /// <summary>
    /// 这是二星难度：事件拥有者和响应者都是同一个
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            MyForm form = new MyForm();
            form.Click += form.FormClicked;
            form.ShowDialog();
        }
    }
    class MyForm : Form
    {
        internal void FormClicked(object sender, EventArgs e)
        {
            this.Text = DateTime.Now.ToString();
        }
    }
}
