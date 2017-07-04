using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace RabbitVsTortoise
{
    public partial class RabbitVsTortoiseForm : Form
    {
        public RabbitVsTortoiseForm()
        {
            InitializeComponent();
        }
        Competitor rabbit = new Competitor();
        Competitor tortoise = new Competitor();
        Thread rabbitRun;
        Thread tortoiseRun;

        private void startButton_Click(object sender, EventArgs e)
        {
            rabbitRun = new Thread(rabbit.run);
            rabbitRun.Start();
            tortoiseRun = new Thread(tortoise.run);
            tortoiseRun.Start();
        }

        private void rabbitTrackBar_Scroll(object sender, EventArgs e)
        {
            rabbit.setSpeed(rabbitTrackBar.Value);
        }

        private void tortoiseTrackBar_Scroll(object sender, EventArgs e)
        {
            tortoise.setSpeed(tortoiseTrackBar.Value);
        }

        private void draw()
        {
            System.Drawing.Graphics graphics = this.CreateGraphics();
            System.Drawing.Rectangle rectangle = new System.Drawing.Rectangle(
                5, 10, 15, 15);
            graphics.DrawEllipse(System.Drawing.Pens.Black, rectangle);
            graphics.DrawRectangle(System.Drawing.Pens.Red, rectangle);
        }

        private void RabbitVsTortoiseForm_Load(object sender, EventArgs e)
        {
            //draw();
            System.Drawing.Graphics graphics = this.CreateGraphics();
            System.Drawing.Rectangle rectangle = new System.Drawing.Rectangle(
                5, 10, 15, 15);
            graphics.DrawEllipse(System.Drawing.Pens.Black, rectangle);
            graphics.DrawRectangle(System.Drawing.Pens.Red, rectangle);
        }

    }

    public class Competitor
    {
        private int currentSpeed = 100;
        public void run()
        {
            for (int i = 0; i < 10; i++)
            {
                Thread.Sleep(currentSpeed);
                MessageBox.Show("ha ha");
            }
        }
        public void setSpeed(int speed)
        {
            currentSpeed = speed;
        }
        public int getSpeed()
        {
            return currentSpeed;
        }
    }
}
