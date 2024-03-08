using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private double predictValue(double rate)
        {
            Random rand = new Random();
            return rate * (1 + k * (rand.NextDouble() - 0.5));
        }

        double Dollar, Euro, k = 0.1;
        int y = 1;
        bool started = false;
        private void StartStopButton_Click(object sender, EventArgs e)
        {
            if (timer1.Enabled)
            {
                timer1.Stop();
            }
            else
            {
                if (!started)
                {
                    Dollar = Convert.ToDouble(inputDollar.Text);
                    Euro = Convert.ToDouble(inputEuro.Text);
                    chart1.Series[0].Points.AddXY(y, Dollar);
                    chart1.Series[1].Points.AddXY(y, Euro);
                    started = true;
                    
                }
                timer1.Start();
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Dollar = predictValue(Dollar);
            Euro = predictValue(Euro);
            y++;
            chart1.Series[0].Points.AddXY(y, Dollar);
            chart1.Series[1].Points.AddXY(y, Euro);
        }
    }
}
