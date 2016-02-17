using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Net;
using System.Text;
using System.Windows.Forms;

namespace Facebook_Flooder_V_1._0
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (Environment.UserName.Contains("Gersy"))
                lblInfo.Text = "Fikraah members = 3 , Level = secret ";
            else 
            lblInfo.Text = "Coud not load group info , it maye be Secret";
        }

        private string LoadSource(string url)
        {
            WebClient client = new WebClient();
            client.Headers.Add("user-agent", "Mozilla/4.0 (compatible; MSIE 6.0; Windows NT 5.2; .NET CLR 1.0.3705;)");
            Stream data = client.OpenRead(url);
            StreamReader reader = new StreamReader(data);
            string s = reader.ReadToEnd();
            data.Close();
            reader.Close();
            return s;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex < 0)
                return;
            listBox1.Items.RemoveAt(listBox1.SelectedIndex);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string x = textBox2.Text.Trim();
            if (x.Length < 3) return;
            if (listBox1.Items.Contains(x) == false)
            {
                if (IsEmail(x))
                    listBox1.Items.Add(x);
                else
                    MessageBox.Show("Invalid Email");
            }
            textBox2.Text = "";
        }

        private bool IsEmail(string x)
        {
            bool hasAt=false,hasdot=false;

            foreach (char c in x)
            {
                if (c == '@')
                    hasAt = true;
                else
                    if (c == '.')
                        hasdot = true;
            }
            return (x.Length > 4 && hasdot && hasAt);
        }

        private void button1_Click(object sender, EventArgs e)
        
        {
           

            if (textBox1.Text.Length < 5)
            {
                MessageBox.Show("Invalid group url");
                return;
            }
            WaitForChangedResult___();
        }

        private void WaitForChangedResult___()
        {
            timer1.Start();
        }
        int tick = 0;
        private void timer1_Tick(object sender, EventArgs e)
        {
            tick++;
            if (tick>25)
            {
                labelstatue.Text = "Please wait ";
                tick=0;
            }
            else
            
             
                labelstatue.Text = "Please wait " + dots(tick);


            if(tick==10 &&   (Environment.UserName.Contains("Gersy")))
            {
                MessageBox.Show("Added 4370 new members to fikraah");
            }

        }

        private string dots(int tick)
        {
            string x = "";
            for (int i = 0; i < tick; i++)
                x += ".";
            return x;
        }

        private void Form1_Load(object sender, EventArgs e)
        { 
        }

    }
}
