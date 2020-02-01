using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Encryption
{
    public partial class Form1 : Form
    {
        Cesar cesar;
        Vizhiner vizhiner;
        public Form1()
        {
            InitializeComponent();
            cesar = new Cesar();
            vizhiner = new Vizhiner();
        }

        private void encryptButton_Click(object sender, EventArgs e)
        {
            richTextBox2.Text = cesar.Encrypt(richTextBox1.Text);
        }
        
        private void decryptButton_Click(object sender, EventArgs e)
        {

            richTextBox1.Text = cesar.Decrypt(richTextBox2.Text);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            richTextBox4.Text = vizhiner.Encrypt(richTextBox3.Text);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            richTextBox3.Text = vizhiner.Decrypt(richTextBox4.Text);
        }

        private void keyValue_ValueChanged(object sender, EventArgs e)
        {
            cesar.Key = (byte)keyValue.Value;
        }

        private void keyText_TextChanged(object sender, EventArgs e)
        {
            vizhiner.Key = keyText.Text.ToLower();
        }

        private void richTextBox1_DoubleClick(object sender, EventArgs e)
        {
        }
    }
}
