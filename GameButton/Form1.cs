using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GameButton
{
    public partial class Form1 : Form
    {

        private int maxTime { get; set; }
        private Random rnd = new Random();
        private int valueFirst { get; set; }
        private int valueSecond { get; set; }
        private int count { get; set; }

        public Form1()
        {
            InitializeComponent();
            this.Text = "ReactionGame";
            maxTime = 20000;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if(this.progressBar1.Value == maxTime && buttonStart.Enabled == false)
            {
                buttonStart.Enabled = true;
                ViewScore();

            }
            this.progressBar1.Increment(100);
        }

        private void buttonStart_Click(object sender, EventArgs e)
        {

            buttonStart.Enabled = false;
            count = 0;
            GenerateValues();
            this.progressBar1.Value = 0;
            this.progressBar1.Maximum = maxTime;
            this.timer1.Start();
        }

        private void GenerateValues()
        {
            valueFirst = rnd.Next(20, 40);
            valueSecond = rnd.Next(20, 40);

            value1.Text = valueFirst.ToString();
            value2.Text = valueSecond.ToString();

            SetScore();

        }

        private void SetScore()
        {
            label2.Text = $"Score: {count}";
        }

       
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void buttonClick_Click(object sender, EventArgs e)
        {
            
        }

        private int GetValue1()
        {
            return Convert.ToInt32(value1.Text);
        }

        private int GetValue2()
        {
            return Convert.ToInt32(value2.Text);
        }

        private void ViewScore()
        {
            MessageBox.Show($"Score: {count}", "Your score");
            this.progressBar1.Value = maxTime;
            buttonStart.Enabled = true;
        }

        private void buttonBig_Click(object sender, EventArgs e)
        {
            if (buttonStart.Enabled != false) return;

            if(GetValue1() > GetValue2())
            {
                count++;
                GenerateValues();
            }
            else
            {
                ViewScore();
            }
        }

        private void buttonEquel_Click(object sender, EventArgs e)
        {
            if (buttonStart.Enabled != false) return;

            if (GetValue1() == GetValue2())
            {
                count++;
                GenerateValues();
            }
            else
            {
                ViewScore();
            }
        }

        private void buttonLittle_Click(object sender, EventArgs e)
        {
            if (buttonStart.Enabled != false) return;

            if (GetValue1() < GetValue2())
            {
                count++;
                GenerateValues();
            }
            else
            {
                ViewScore();
            }
        }
    }
}