using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EventExample2
{
    /// <summary>
    /// 一颗星难度的事件
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            Form form = new Form();
            Controller controller = new Controller(form);
            form.ShowDialog();
        }
    }
    class Controller
    {
        private Form form;
        public Controller(Form form)
        {
            if(form != null)
            {
                this.form = form;
                form.Click += this.FormClicked;
            }
        }

        internal void FormClicked(object sender, EventArgs e)
        {
            this.form.Text = DateTime.Now.ToString();
        }
    }
}
