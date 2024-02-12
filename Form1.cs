using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TimeManager
{
    public partial class Form1 : Form
    {
        
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Task.Run(() => DxAxelxD.Classes.AppCatcher.Start());
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblActiveApp.Text = DxAxelxD.Classes.AppCatcher.GetActualActiveApp();
        }
    }
}
