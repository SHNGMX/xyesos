using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace xyesos
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
            textBox1.MaxLength = 11;

        }

        private void button1_Click(object sender, EventArgs e)
        {
           
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        public Boolean Number()
        {
            try
            {
                string number = textBox1.Text;
                string prefix = "89";
                bool result = number.StartsWith(prefix);
                if (result)
                {
                    MessageBox.Show("Номер телефона введен верно");
                }
                else
                {
                    MessageBox.Show("Номер телефона введен неверно");
                }
                return true;
            }
            catch
            {
                return false;

            }
        }

        public Boolean Email()
        {
            try
            {
                string email = textBox2.Text;
                Regex regex = new Regex(@"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$");
                Match match = regex.Match(email);
                if (match.Success)
                    MessageBox.Show("Email введен верно");
                else
                    MessageBox.Show("Email введен не верно");
                return true;
            }
            catch
            {
                return false;
            }

        }
    }
}
