using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//
using essentialcrypt;

namespace essentialcrypt_DEMOGUI
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(comboBox1.Text == "Atom128")
            {
                string input = textBox1.Text;
                string encoded = essentialcrypt.Atom128.Encode(input);
                textBox2.Text = encoded;
            }

            if (comboBox1.Text == "Reverse")
            {
                string input = textBox1.Text;
                string encoded = essentialcrypt.Reverse.Encode(input);
                textBox2.Text = encoded;
            }

            if (comboBox1.Text == "Base64")
            {
                string input = textBox1.Text;
                string encoded = essentialcrypt.Base64.Encode(input);
                textBox2.Text = encoded;
            }

            if (comboBox1.Text == "ROT13")
            {
                string input = textBox1.Text;
                string encoded = essentialcrypt.ROT13.Encode(input);
                textBox2.Text = encoded;
            }

            if (comboBox1.Text == "Lambda")
            {
                string input = textBox1.Text;
                string encoded = essentialcrypt.Lambda.Encode(input , Convert.ToInt32(textBox3.Text));
                textBox2.Text = encoded;
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (comboBox1.Text == "Atom128")
            {
                string input = textBox1.Text;
                string decoded = essentialcrypt.Atom128.Decode(input);
                textBox2.Text = decoded;
            }

            if (comboBox1.Text == "Reverse")
            {
                string input = textBox1.Text;
                string decoded = essentialcrypt.Reverse.Decode(input);
                textBox2.Text = decoded;
            }

            if (comboBox1.Text == "Base64")
            {
                string input = textBox1.Text;
                string decoded = essentialcrypt.Base64.Decode(input);
                textBox2.Text = decoded;
            }

            if (comboBox1.Text == "ROT13")
            {
                string input = textBox1.Text;
                string decoded = essentialcrypt.ROT13.Decode(input);
                textBox2.Text = decoded;
            }

            if (comboBox1.Text == "Lambda")
            {
                string input = textBox1.Text;
                string encoded = essentialcrypt.Lambda.Encode(input, Convert.ToInt32(textBox3.Text));
                textBox2.Text = encoded;
            }
        }
    }
}
