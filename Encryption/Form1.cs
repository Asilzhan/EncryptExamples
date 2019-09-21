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
        public Form1()
        {
            InitializeComponent();
        }

        private void encryptButton_Click(object sender, EventArgs e)
        {
            richTextBox2.Text = CesarEncrypt(richTextBox1.Text, (byte)keyValue.Value);
        }
        
        private void decryptButton_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = CesarDecrypt(richTextBox2.Text, (byte)keyValue.Value);
        }

        private string CesarEncrypt(string m, byte key)
        {
            StringBuilder stringBuilder = new StringBuilder(m);
            for (int i = 0; i < m.Length; i++)
            {
                stringBuilder[i] = (char)((byte)m[i] + key);
            }
            return stringBuilder.ToString();
        }

        private string CesarDecrypt(string c, byte key)
        {
            StringBuilder stringBuilder = new StringBuilder(c);
            for (int i = 0; i < c.Length; i++)
            {
                stringBuilder[i] = (char)((byte)c[i] - key);
            }
            return stringBuilder.ToString();
        }

        private string VizhinerEncrypt(string m, string key)
        {
            StringBuilder stringBuilder = new StringBuilder(m);
            for (int i = 0; i < m.Length; i++)
            {
                stringBuilder[i] = (char)((byte)m[i] + (byte)key[i]);
            }
            return stringBuilder.ToString();
        }

        private string VizhinerDecrypt(string c, string key)
        {
            StringBuilder stringBuilder = new StringBuilder(c);
            for (int i = 0; i < c.Length; i++)
            {
                stringBuilder[i] = (char)((byte)c[i] - (byte)key[i]);
            }
            return stringBuilder.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            richTextBox4.Text = VizhinerEncrypt(richTextBox3.Text, keyText.Text);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            richTextBox3.Text = VizhinerDecrypt(richTextBox4.Text, keyText.Text);
        }
    }
}
