using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Runtime.InteropServices;
namespace LogOffSystem
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        [DllImport("user32.dll")]
        public static extern int ExitWindowsEx(int operationFlag, int operationReason);
        private void btnLogOff_Click(object sender, EventArgs e)
        {
            ExitWindowsEx(4, 0);
        }
    }
}
