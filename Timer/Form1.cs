using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Timer
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int sayac = 0;
        private void button2_Click(object sender, EventArgs e)
        {
            timer1.Stop();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            sayac++;
            label1.Text = sayac.ToString();
            progressBar1.Value = sayac;
            switch(sayac)
            {
                case 10: this.BackColor = Color.Red; break;
                case 25: this.BackColor = Color.Orange; break;
                case 40: this.BackColor = Color.Yellow; break;
                case 55: this.BackColor = Color.Green; break;
                case 70: this.BackColor = Color.Blue; break;
                case 85: this.BackColor = Color.Purple; break;
            
            }
            if (sayac == 100)
            {
                sayac = 0;
            }
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void btnYenile_Click(object sender, EventArgs e)
        {
            timer1.Stop();
            sayac = 0;
            progressBar1.Value = 0;
            this.BackColor = Color.White;
        }
    }
}
