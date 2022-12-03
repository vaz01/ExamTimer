using Microsoft.VisualBasic;
using System.ComponentModel.Design;
using System.DirectoryServices;
using System.Drawing.Design;

namespace ExamTimer
{
    public partial class Form1 : Form
    {
        
        public int min1;
        public int read1;
        public int min2;
        public int read2;
        public int min3;
        public int read3;
        public int min4;
        public int read4;
        public int min5;
        public int read5;
        public bool timer1pause;
        public bool timer2pause;
        public bool timer3pause;
        public bool timer4pause;
        public bool timer5pause;
        public bool readtime1pause;
        public bool readtime2pause;
        public bool readtime3pause;
        public bool readtime4pause;
        public bool readtime5pause;
        public bool readend1;
        public bool readend2;
        public bool readend3;
        public bool readend4;
        public bool readend5;
        public Form1()
        {
            InitializeComponent();
            //timer1.Stop();
            //timer2.Stop();
            //timer3.Stop();
            //timer4.Stop();
            //timer5.Stop();
            timer1.Enabled = false;
            timer2.Enabled = false;
            timer3.Enabled = false; 
            timer4.Enabled = false;
            timer5.Enabled = false;
            WindowState= FormWindowState.Maximized;
        }
        
        static int convertmin(string input)
        {

            if (input == "30 Min")
            {
                return 1800;
            }
            else if (input == "60 Min")
            {
                return 3600;
            }
            else if (input == "90 Min")
            {
                return 5400;
            }
            else if (input == "120 Min")
            {
                return 7200;
            }
            else if (input == "150 Min")
            {
                return 9000;
            }
            else if (input == "180 Min")
            {
                return 10800;
            }
            else if (input == "test")
            {
                return 10;
            }
            else
            {
                return 0;
            }
        }
        static string convertsec(int input)
        {
            string input1 = input.ToString();
            TimeSpan time = TimeSpan.FromSeconds(input);
            string str = time.ToString(@"hh\:mm\:ss");
            return str;
        }
        static int convertread(string input)
        {
            if (input == "10 Min")
            {
                return 600; 
            }
            else if (input == "5 Min")
            {
                return 300;
            }
            else if (input == "test")
            {
                return 10;
            }
            else
            {
                return 0;
            }
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private void start1_Click_1(object sender, EventArgs e)
        {
            //readtime1.Start();
            readtime1.Enabled = true;
            string timeremain1 = selected1.GetItemText(selected1.SelectedItem);
            string readingtime1 = rselect1.GetItemText(rselect1.SelectedItem);
            read1 = convertread(readingtime1);
            min1 = convertmin(timeremain1);

        }
        private void pause1_Click(object sender, EventArgs e)
        {
            //FIX THE PAUSE BUTTON 
            if (readend1 == true)
            {
                if (timer1.Enabled)
                {
                    timer1.Enabled = false;
                    pause1.Text = "Resume";
                }
                else
                {
                    timer1.Enabled = true;
                    pause1.Text = "Pause";
                }
            }
            else
            {
                if (readtime1.Enabled)
                {
                    readtime1.Enabled = false;
                    pause1.Text = "Resume";
                }
                else
                {
                    readtime1.Enabled = true;
                    pause1.Text = "Pause";
                }
            }
        }
        private void readtime1_Tick(object sender, EventArgs e)
        {
            //convert to function 
            read1 = read1 - 1;
            string read11 = convertsec(read1);
            readisp1.Text = read11;
            if (read11 == "00:00:00")
            {
                readtime1.Enabled = false;
                // Make the text change to red 
                readisp1.ForeColor= Color.Red;
                timer1.Enabled = true;
                readend1 = true;
                
            }
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            // convert this to a function to make it ready for other components 

            min1 = min1 - 1;
            string min11 = convertsec(min1);
            timedisp1.Text = min11.ToString();
            if (min11 == "00:00:00")
            {
                timer1.Enabled = false;
                timedisp1.ForeColor = Color.Red;
            }


        }

        private void start2_Click_1(object sender, EventArgs e)
        {
            //readtime2.Start();
            readtime2.Enabled = true;
            string timeremain1 = selected1.GetItemText(selected2.SelectedItem);
            string readingtime1 = rselect1.GetItemText(rselect2.SelectedItem);
            read2 = convertread(readingtime1);
            min2 = convertmin(timeremain1);
        }
        private void timer2_Tick(object sender, EventArgs e)
        {
            min2 = min2 - 1;
            string min11 = convertsec(min2);
            timedisp2.Text = min11.ToString();
            if (min11 == "00:00:00")
            {
                timer2.Enabled = false;
                timedisp2.ForeColor = Color.Red;
            }
        }
        private void readtime2_Tick(object sender, EventArgs e)
        {
            read2 = read2 - 1;
            string read11 = convertsec(read2);
            readisp2.Text = read11;
            if (read11 == "00:00:00")
            {
                readtime2.Enabled = false;
                readisp2.ForeColor = Color.Red;
                timer2.Enabled = true;
                readend2 = true;
            }

        }

        private void start3_Click_1(object sender, EventArgs e)
        {
            //readtime3.Start();
            readtime3.Enabled = true;
            string timeremain1 = selected3.GetItemText(selected3.SelectedItem);
            string readingtime1 = rselect3.GetItemText(rselect3.SelectedItem);
            read3 = convertread(readingtime1);
            min3 = convertmin(timeremain1);
        }
        private void timer3_Tick(object sender, EventArgs e)
        {
            min3 = min3 - 1;
            string min11 = convertsec(min3);
            timedisp3.Text = min11.ToString();
            if (min11 == "00:00:00")
            {
                timer3.Enabled = false;
                timedisp3.ForeColor = Color.Red;
            }
        }

        private void readtime3_Tick(object sender, EventArgs e)
        {
            read3 = read3 - 1;
            string read11 = convertsec(read3);
            readisp3.Text = read11;
            if (read11 == "00:00:00")
            {
                readtime3.Enabled = false;
                readisp3.ForeColor = Color.Red;
                timer3.Enabled = true;
                readend3 = true;
            }

        }


        private void start4_Click_1(object sender, EventArgs e)
        {
            //readtime4.Start();
            readtime4.Enabled = true;
            string timeremain1 = selected4.GetItemText(selected4.SelectedItem);
            string readingtime1 = rselect4.GetItemText(rselect4.SelectedItem);
            read4 = convertread(readingtime1);
            min4 = convertmin(timeremain1);
        }
        private void timer4_Tick(object sender, EventArgs e)
        {
            min4 = min4 - 1;
            string min11 = convertsec(min4);
            timedisp4.Text = min11.ToString();
            if (min11 == "00:00:00")
            {
                timer4.Enabled = false;
                timedisp4.ForeColor = Color.Red;
            }
        }

        private void readtime4_Tick(object sender, EventArgs e)
        {
            read4 = read4 - 1;
            string read11 = convertsec(read4);
            readisp4.Text = read11;
            if (read11 == "00:00:00")
            {
                readtime4.Enabled = false;
                readisp4.ForeColor = Color.Red;
                timer4.Enabled = true;
                readend4 = true;
            }
        }
        private void start5_Click_1(object sender, EventArgs e)
        {
            //readtime5.Start();
            readtime5.Enabled = true;
            string timeremain1 = selected5.GetItemText(selected5.SelectedItem);
            string readingtime1 = rselect5.GetItemText(rselect5.SelectedItem);
            read5 = convertread(readingtime1);
            min5 = convertmin(timeremain1);
        }
        private void timer5_Tick(object sender, EventArgs e)
        {
            min5 = min5 - 1;
            string min11 = convertsec(min5);
            timedisp5.Text = min11.ToString();
            if (min11 == "00:00:00")
            {
                timer5.Enabled = false;
                timedisp5.ForeColor = Color.Red;
            }
        }

        private void readtime5_Tick(object sender, EventArgs e)
        {
            read5 = read5 - 1;
            string read11 = convertsec(read5);
            readisp5.Text = read11;
            if (read11 == "00:00:00")
            {
                readtime5.Enabled = false;
                readisp5.ForeColor = Color.Red;
                timer5.Enabled = true;
                readend5 = true;
            }
        }

        private void pause2_Click(object sender, EventArgs e)
        {
            if (readend2 == true)
            {
                if (timer2.Enabled)
                {
                    timer2.Enabled = false;
                    pause2.Text = "Resume";
                }
                else
                {
                    timer2.Enabled = true;
                    pause2.Text = "Pause";
                }
            }
            else
            {
                if (readtime2.Enabled)
                {
                    readtime2.Enabled = false;
                    pause2.Text = "Resume";
                }
                else
                {
                    readtime2.Enabled = true;
                    pause2.Text = "Pause";
                }
            }
        }

        private void pause3_Click(object sender, EventArgs e)
        {
            if (readend3 == true)
            {
                if (timer3.Enabled)
                {
                    timer3.Enabled = false;
                    pause3.Text = "Resume";
                }
                else
                {
                    timer3.Enabled = true;
                    pause3.Text = "Pause";
                }
            }
            else
            {
                if (readtime3.Enabled)
                {
                    readtime3.Enabled = false;
                    pause3.Text = "Resume";
                }
                else
                {
                    readtime3.Enabled = true;
                    pause3.Text = "Pause";
                }
            }
        }

        private void pause4_Click(object sender, EventArgs e)
        {
            if (readend4 == true)
            {
                if (timer4.Enabled)
                {
                    timer4.Enabled = false;
                    pause4.Text = "Resume";
                }
                else
                {
                    timer4.Enabled = true;
                    pause4.Text = "Pause";
                }
            }
            else
            {
                if (readtime4.Enabled)
                {
                    readtime4.Enabled = false;
                    pause4.Text = "Resume";
                }
                else
                {
                    readtime4.Enabled = true;
                    pause4.Text = "Pause";
                }
            }
        }

        private void pause5_Click(object sender, EventArgs e)
        {
            if (readend5 == true)
            {
                if (timer5.Enabled)
                {
                    timer5.Enabled = false;
                    pause5.Text = "Resume";
                }
                else
                {
                    timer5.Enabled = true;
                    pause5.Text = "Pause";
                }
            }
            else
            {
                if (readtime5.Enabled)
                {
                    readtime5.Enabled = false;
                    pause5.Text = "Resume";
                }
                else
                {
                    readtime5.Enabled = true;
                    pause5.Text = "Pause";
                }
            }
        }


    }
}