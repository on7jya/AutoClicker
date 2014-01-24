using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.Threading;

namespace AutoClicker
{
    public partial class Form1 : Form
    {
        int clicks = 0;
        string mode = "stop";

        public Form1()
        {
            TopMost = true;
            InitializeComponent();
            track_count_Scroll(null, null);
            track_time_Scroll(null, null);
            track_timeout_Scroll(null, null);
            track_cycle_Scroll(null, null);
            toolTip1.SetToolTip(label_info_count, "the number of clicks that you want to do");
            toolTip1.SetToolTip(label_info_time, " time interval between clicks");
            toolTip1.SetToolTip(label_timeout, "delay start");
            toolTip1.SetToolTip( label_cycle, "looping cycle of clicks");
        }

        private void track_count_Scroll(object sender, EventArgs e)
        {
            label_show_count.Text = track_count.Value.ToString() + " clicks";
        }

        private void track_time_Scroll(object sender, EventArgs e)
        {
            label_show_time.Text = track_time.Value.ToString() + " milliseconds";
        }

        private void track_timeout_Scroll(object sender, EventArgs e)
        {
            label_show_timeout.Text = track_timeout.Value.ToString() + " seconds";
        }

        private void track_cycle_Scroll(object sender, EventArgs e)
        {
            if (track_cycle.Value == 1)
                label_show_cycle.Text = "yes";
            else
                label_show_cycle.Text = "no";
        }

        private void button_start_Click(object sender, EventArgs e)
        {
            if (mode == "stop")
                start_clicker();
            else
                stop_clicker();
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            make_click();
        }

        void start_clicker()
        {
            mode = "play";
            button_start_stop.Text = "Stop!";
            clicks = track_count.Value;
            Thread.Sleep(track_timeout.Value*1000);
            //for (int i = track_timeout.Value; i!= 0; i--)
            // {
            //     label_tablo_timeout.Text = i.ToString();
            //     Thread.Sleep(1000);
            // }
            timer.Interval = track_time.Value;
            timer.Enabled = true;
            track_count.Enabled = false;
            track_time.Enabled = false;
            track_timeout.Enabled = false;
            track_cycle.Enabled = false;
        }
        
        void make_click()
        {
            if (mode == "stop") return;
            clicks--;
            DoMouseClick();
            if (clicks == 0)
            {
                if (track_cycle.Value == 1)
                    start_clicker();
                else
                    stop_clicker();
                }
        }

        void stop_clicker()
        {
            mode = "stop";
            button_start_stop.Text = "Start clicking!";
            timer.Enabled = false;
            track_count.Enabled = true;
            track_time.Enabled = true;
            track_timeout.Enabled = true;
            track_cycle.Enabled = true;
        }

        public void DoMouseClick()
        {
            //Call the imported function with the cursor's current position
            uint X = (uint)Cursor.Position.X;
            uint Y = (uint)Cursor.Position.Y;
            mouse_event(MOUSEEVENTF_LEFTDOWN | MOUSEEVENTF_LEFTUP, X, Y, 0, 0);
        }

        [DllImport("user32.dll", CharSet = CharSet.Auto, CallingConvention = CallingConvention.StdCall)]
        public static extern void mouse_event(uint dwFlags, uint dx, uint dy, uint cButtons, uint dwExtraInfo);

        private const int MOUSEEVENTF_LEFTDOWN = 0x02;
        private const int MOUSEEVENTF_LEFTUP = 0x04;
        private const int MOUSEEVENTF_RIGHTDOWN = 0x08;
        private const int MOUSEEVENTF_RIGHTUP = 0x10;

        private void Form1_HelpButtonClicked(object sender, CancelEventArgs e)
        {
            MessageBox.Show("   AutoClicker by on7j\n \n  Application Instructions\n \r'Click':\r the number of clicks that you want to do, from 1 to 1000 clicks\n \r'Click Interval':\r time interval between clicks, from 1 to 1000 milliseconds\n \r'Timeout':\r delay start. If 'Looping' is 'On', this is the time interval between group of clicks, from 1 to 5 seconds\n \r'Looping':\r endless cycle of clicks, saving 'Click Interval' and 'Timeout', stop the cycle of 'Stop!' button", "About programm", MessageBoxButtons.OK);
            e.Cancel  = true;
        }
    }
}
