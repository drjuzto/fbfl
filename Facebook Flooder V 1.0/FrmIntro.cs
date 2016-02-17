using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Facebook_Flooder_V_1._0
{
    public partial class FrmIntro : Form
    {
        public FrmIntro()
        {
            InitializeComponent();
        }

        private void FrmIntro_Load(object sender, EventArgs e)
        {
            this.MinimumSize = this.MaximumSize = this.Size;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.Close();
        }

        private void btnAgree_Click(object sender, EventArgs e)
        {
            this.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.Close();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            this.counter--;
            this.btnAgree .Text= "I agree (" +counter+ ")";
            if (counter == 0)
            {
                this.btnAgree.Text = "I agree ";
                this.timer1.Stop();
                this.btnAgree.Enabled = true;
            }
        }

        public int counter =10;// { get; set; }
    }
}
