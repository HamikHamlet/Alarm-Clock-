using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        string music;
        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (maskedTextBox1.Text != "  :  :")
            {
                label1.Text = maskedTextBox1.Text;
                timer2.Start();
                button2.Enabled = false;
                maskedTextBox1.Enabled = false;
                button1.Enabled = false;
            }
            else
            MessageBox.Show("Խնդրում ենք ներմուծել ավարտի թիվը");
      
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog f = new OpenFileDialog();
            if (f.ShowDialog() == DialogResult.OK)
                textBox1.Text = f.SafeFileName;
            music = f.FileName;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label2.Text = DateTime.Now.Hour.ToString("00") + ":" + DateTime.Now.Minute.ToString("00") + ":" + DateTime.Now.Second.ToString("00");
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            if (label1.Text == label2.Text)
            { media.URL = music;
            button2.Enabled = true;
            maskedTextBox1.Enabled = true;
            button1.Enabled = true;

            }
           
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            label1.Text = "00:00:00";
            timer2.Stop();
            media.Ctlcontrols.stop();
            button2.Enabled = true;
            maskedTextBox1.Enabled = true;
            button1.Enabled = true;

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void maskedTextBox1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }
    }
}
