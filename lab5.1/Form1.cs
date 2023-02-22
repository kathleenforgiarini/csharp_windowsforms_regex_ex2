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
using System.Xml.Linq;

namespace lab5._1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void exit_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to exit?", "Exit", MessageBoxButtons.YesNo).ToString() == "Yes")
            {
                Close();
            }
        }
        private void email_Click(object sender, EventArgs e)
        {
            Regex myRegex = new Regex(@"^([\w]+)@([\w]+)\.([\w]+)$");

            if (myRegex.IsMatch(text.Text) == false)
            {
                MessageBox.Show("Format incorrect for e-mail. Must be 'xxx@xxx.xxx'", "E-mail incorrect", MessageBoxButtons.OK);
                text.Focus();
            } else
            {
                MessageBox.Show(string.Format("E-mail validated: {0}", text.Text));
            }
        }
        private void extraSpaces_Click(object sender, EventArgs e)
        {
            Regex myRegex = new Regex(@"\s+");
            MessageBox.Show(myRegex.Replace(text.Text, " "));

        }

        private void postalCode_Click(object sender, EventArgs e)
        {
            Regex myRegex = new Regex(@"^([A-Z]\d[A-Z]\d[A-Z]\d)$|^(\d{5})$|^([0-9]{5}[\-][0-9]{3})$");
            if (myRegex.IsMatch(text.Text) == false)
            {
                MessageBox.Show("Format incorrect for Postal Code. Must be 'X0X0X0' or '00000' or '00000-000'", "Postal Code incorrect", MessageBoxButtons.OK);
                text.Focus();
            } else
            {
                MessageBox.Show(string.Format("Postal Code validated: {0}", text.Text));
            }
        }

        private void deleteLetter_Click(object sender, EventArgs e)
        {
            Regex myRegex = new Regex(@"[a-d]");
            MessageBox.Show(myRegex.Replace(text.Text, ""));
        }

        private void array_Click(object sender, EventArgs e)
        {
            Regex myRegex = new Regex(@" ");
            Array array = myRegex.Split(text.Text);

            foreach (string match in array)
            {
                MessageBox.Show(string.Format("{0}", match));
            }
        }
    }
}
