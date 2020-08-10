using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace v1._0
{
    public partial class Form1 : Form
    {
        int seconds;
        int minutes;
        int hours;
        int micro;

        public Form1()
        {
            InitializeComponent();
            seconds = minutes = hours = micro = 0;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            micro++;

            if (micro > 9)
            {
                seconds++;
                micro = 0;
            }

            if(seconds>59)
            {
                minutes++;
                seconds = 0;
            }
            if(minutes>59)
            {
                hours++;
                minutes = 0;
            }

            lblHour.Text = appendZero(hours);
            lblMin.Text = appendZero(minutes);
            lblsec.Text = appendZero(seconds);
            lblMicro.Text = appendZero(micro);
        }

        private string appendZero(double str)
        {
            if(str < 10)
            {
                return "0" + str;
            }
            else 
            {
                return str.ToString();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            timer1.Stop();
            seconds = minutes = hours = micro = 0;
            lblHour.Text = appendZero(hours);
            lblMin.Text = appendZero(minutes);
            lblsec.Text = appendZero(seconds);
            lblMicro.Text = appendZero(micro);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            timer1.Stop();
        }

        private void lblHour_Click(object sender, EventArgs e)
        {

        }
    }
}
