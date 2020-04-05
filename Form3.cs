using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using System.Diagnostics;
using System.Runtime.InteropServices;

namespace ForLesson
{
    public partial class Form3 : Form
    {

        

        public Form3()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ProcessLabel.Visible = true;
            progressBar1.Minimum = 0;
            progressBar1.Maximum = 100;
            progressBar1.Step = 1;
            for (int i = 0; i <= progressBar1.Maximum; i++) {
                progressBar1.PerformStep();
            }
            
            if (progressBar1.Value == progressBar1.Maximum) { 
                System.Diagnostics.Process.Start(@"C:\Users\rocks\source\repos\ForLesson\TextFile1.bat");
            }
          
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
            this.Close();
        }
    }
}
