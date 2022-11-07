using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp5
{
    public partial class Form1 : Form
    {
        Random _r = new Random();
        public Form1()
        {
            InitializeComponent();
            //Width = 1000;
            //Height = 1000;
            // Random _r = new Random();
            // int count = 10;
            // int size = 100;

            //for (int y = 0; y < count; y++)
            //{
            //    for (int x = 0; x < count; x++)
            //    {
            //        var b = new Button() { Parent = this, Text = Convert.ToString(check), };
            //        b.BackColor = Color.FromArgb(_r.Next(255), _r.Next(255), _r.Next(255));
            //        b.SetBounds(10 + x * size, 10 + y * size, size, size);
            //        b.Click += Test_Click;
            //        CheckRemove();
            //    }
            //}
            //var b = new Button();

            CheckRemove();

        }





        public static int check = 1;
        public int Check { get; set; }
        public void CheckRemove()
        {
            BackColor = Color.Gray;
            check++;
        }


        private void Test_Click(object sender, EventArgs e)
        {
            Button b = sender as Button;
            b.Text = Convert.ToString(check);
            b.Visible = false;

        }



        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            //foreach(RadioButton radioButton in Controls.OfType<RadioButton>()){
            //    if (radioButton1.Checked) { BackColor = Color.Red; }
            //    else if (radioButton2.Checked) { BackColor = Color.Green; }
            //    else if (radioButton3.Checked) { BackColor = Color.Blue; }
            //    else { BackColor = Color.Yellow; }
            //}
        }
        private void Form1_Load_1(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Timer tim = new System.Windows.Forms.Timer();
            tim.Interval = 1000;
            tim.Tick += textBox1_TextChanged;
            tim.Start();
        }

        private void button1_MouseEnter_1(object sender, EventArgs e)
        {

            button1.Location = new Point(button1.Location.X, button1.Location.Y - 50);
            this.button1.Location = new Point(
            this.button1.Location.X,
            this.button1.Location.Y);
            int n = _r.Next(35, 50);

            button1.Location = new Point(button1.Location.X + n, button1.Location.Y + n + 30);

        }

        private void button1_KeyDown(object sender, KeyEventArgs e)
        {

            if (e.KeyCode == Keys.A)
            {
                button1.Location = new Point(button1.Location.X - 50, button1.Location.Y);
                this.button1.Location = new Point(
                this.button1.Location.X,
                this.button1.Location.Y);
            }
            else if (e.KeyCode == Keys.D)
            {
                button1.Location = new Point(button1.Location.X + 50, button1.Location.Y);
                this.button1.Location = new Point(
                this.button1.Location.X,
                this.button1.Location.Y);
            }
            else if (e.KeyCode == Keys.S)
            {
                button1.Location = new Point(button1.Location.X,button1.Location.Y + 50);
                this.button1.Location = new Point(
                this.button1.Location.X,
                this.button1.Location.Y);
            }
            else if (e.KeyCode == Keys.W)
            {
                button1.Location = new Point(button1.Location.X,button1.Location.Y - 50);
                this.button1.Location = new Point(
                 this.button1.Location.X,
                 this.button1.Location.Y);
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

            DateTime dt1 = DateTime.Now;
            DateTime dt2 = new DateTime(DateTime.Now.Year + 1, 1, 1);
            TimeSpan ts = dt2 - dt1;
            textBox1.Text = String.Format("{0},{1},{2},{3} \n Всего это {5} дней",
                ts.Days, ts.Hours, ts.Minutes, ts.Seconds,
                ts.TotalDays / 30, ts.TotalDays, ts.TotalHours, ts.TotalMinutes, ts.TotalSeconds);

        }
    }
}