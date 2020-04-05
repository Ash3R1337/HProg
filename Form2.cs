using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Security.Cryptography;

namespace ForLesson
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void inputOk_Click(object sender, EventArgs e)
        {
            ResultPass.Text = GetHashString(inputPass.Text);
            
            

            string GetHashString(string s)
            {
                 
                byte[] bytes = Encoding.Unicode.GetBytes(s);

                  
                MD5CryptoServiceProvider CSP =
                    new MD5CryptoServiceProvider();

                 
                byte[] byteHash = CSP.ComputeHash(bytes);

                string hash = string.Empty;

                 
                foreach (byte b in byteHash)
                    hash += string.Format("{0:x2}", b);

                return hash;
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
            this.Close();
        }

        private void inputPass_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                ResultPass.Text = GetHashString(inputPass.Text);



                string GetHashString(string s)
                {

                    byte[] bytes = Encoding.Unicode.GetBytes(s);


                    MD5CryptoServiceProvider CSP =
                        new MD5CryptoServiceProvider();


                    byte[] byteHash = CSP.ComputeHash(bytes);

                    string hash = string.Empty;


                    foreach (byte b in byteHash)
                        hash += string.Format("{0:x2}", b);

                    return hash;
                }
            }
        }
    }
}
