using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
namespace FrmBasicThread1
{
    public partial class Form1 : Form
    {
    static Thread ThreadA, ThreadB;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void run1_Click(object sender, EventArgs e)
        {
            bsThread.Text = "-Before starting thread-";
            Console.WriteLine(bsThread.Text);
            ThreadA = new Thread(MyThreadClass.Thread1);
            ThreadB = new Thread(MyThreadClass.Thread1);

            ThreadA.Start();
            ThreadB.Start();

            ThreadA.Join();
            ThreadB.Join();
            bsThread.Text = "-End of Thread-";
            Console.WriteLine(bsThread.Text);
        }
    }
}
