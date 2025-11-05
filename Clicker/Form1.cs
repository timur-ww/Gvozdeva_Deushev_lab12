using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Clicker
{
    public partial class Form1 : Form
    {
        private int clicks;
        private int milliseconds, seconds; 

        public Form1()
        {
            InitializeComponent();
        }

        private void UpdateLabel()
        {
            labelTime.Text = $"Время: {seconds},{milliseconds}";
            labelClick.Text = $"Нажатий: {clicks}";
        }
          
        private void buttonReset_Click(object sender, EventArgs e)
        {
            timer1.Stop();
            milliseconds = seconds = 0;
            clicks = 0;
            UpdateLabel();
        }

        private void buttonClick_Click(object sender, EventArgs e)
        {
            timer1.Start();
            clicks++;
            UpdateLabel();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            milliseconds += 15;
            if (milliseconds >= 1000)
            {
                milliseconds = 0;
                seconds++;
            }
            UpdateLabel();
        }
    }
}
