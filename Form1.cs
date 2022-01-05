using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace MoveIT
{
    public partial class Form_MoveIT : Form
    {
        Random random = new Random();
        public Form_MoveIT()
        {
            InitializeComponent();
            btn_Stop.BackColor = Color.DarkGray;
            btn_Stop.Enabled = false;
            btn_resetDefault.Enabled = false;

        }
        //---------------------------TAB 1 Code Start -------------------------------------------------//

        // Code to move the cursor wih random position number
        private void Move_Cursor() 
        {
            // Set the Current cursor, move the cursor's Position,
            // and set its clipping rectangle to the form. 
            var randonNumberForX = random.Next(-50, 50);
            var randonNumberForY = random.Next(-50, 50);
            this.Cursor = new Cursor(Cursor.Current.Handle);
            Cursor.Position = new Point(Cursor.Position.X - (randonNumberForX), Cursor.Position.Y - (randonNumberForY));
            Cursor.Clip = new Rectangle(this.Location, this.Size);
        }

        //code to Start the timer for interval of the cursor movement
        private Timer timer;
        public void InitTimer(string act)
        {
            if (act == "Start") {
                var timeInSec = txt_TimeInterval.Value;
                timer = new Timer();
                timer.Tick += new EventHandler(timer_Tick);
                timer.Interval = Convert.ToInt32(timeInSec)*1000; // in miliseconds
                timer.Start();
            }
            if (act == "Stop")
            {
                timer.Stop();
            }
        }

        //Clock Tick
        private void timer_Tick(object sender, EventArgs e)
        {
            Move_Cursor();
        }
        //---------------------------TAB 1 Code End -------------------------------------------------//

        //---------------------------------------------------------------------------------------------//
        //---------------------------TAB 2 Code Start -------------------------------------------------//
        //Method to keep screen awake

        public static void ForceSystemAwake() 
        {
            NativeMethods.SetThreadExecutionState(NativeMethods.EXECUTION_STATE.ES_CONTINUOUS |
                                                  NativeMethods.EXECUTION_STATE.ES_DISPLAY_REQUIRED |
                                                  NativeMethods.EXECUTION_STATE.ES_SYSTEM_REQUIRED |
                                                  NativeMethods.EXECUTION_STATE.ES_AWAYMODE_REQUIRED);
        }

        public static void ResetSystemDefault() //Method to reset to default setting of screen saver
        {
            NativeMethods.SetThreadExecutionState(NativeMethods.EXECUTION_STATE.ES_CONTINUOUS);
        }


        internal static partial class NativeMethods
        {
            [DllImport("kernel32.dll", CharSet = CharSet.Auto, SetLastError = true)]
            public static extern EXECUTION_STATE SetThreadExecutionState(EXECUTION_STATE esFlags);

            [FlagsAttribute]
            public enum EXECUTION_STATE : uint
            {
                ES_AWAYMODE_REQUIRED = 0x00000040,
                ES_CONTINUOUS = 0x80000000,
                ES_DISPLAY_REQUIRED = 0x00000002,
                ES_SYSTEM_REQUIRED = 0x00000001

                // Legacy flag, should not be used.
                // ES_USER_PRESENT = 0x00000004
            }
        }

        //---------------------------TAB 2 Code end -------------------------------------------------//

        //Button click methods
        private void btn_Start_Click(object sender, EventArgs e)
        {
            InitTimer("Start");
            btn_Stop.Enabled = true;
            btn_Start.BackColor = Color.DarkGray;
            btn_Stop.BackColor = Color.Red;
            lbl_RunningStatus.Text = "Status: Running";
            lbl_RunningStatus.ForeColor = Color.Green;
            btn_Start.Enabled = false;
        }
        private void btn_Stop_Click(object sender, EventArgs e)
        {
            InitTimer("Stop");
            btn_Start.BackColor = Color.Green;
            btn_Stop.BackColor = Color.DarkGray;
            lbl_RunningStatus.Text = "Status: Stopped";
            lbl_RunningStatus.ForeColor = Color.Red;
            btn_Stop.Enabled = false;
            btn_Start.Enabled = true;
        }
        private void btn_preventSleep_Click(object sender, EventArgs e)
        {
            ForceSystemAwake();
            btn_preventSleep.Enabled = false;
            btn_preventSleep.BackColor = Color.DarkGray;
            btn_resetDefault.Enabled = true;
            btn_resetDefault.BackColor = Color.FromArgb(192, 255, 192);
            lbl_ScreenAwakeStatus.Text = "Force Awake: ON";
            lbl_ScreenAwakeStatus.ForeColor = Color.Green;
        }
        private void btn_resetDefault_Click(object sender, EventArgs e)
        {
            ResetSystemDefault();
            btn_preventSleep.Enabled = true;
            btn_resetDefault.Enabled = false;
            btn_resetDefault.BackColor = Color.DarkGray;
            btn_preventSleep.BackColor = Color.FromArgb(192, 255, 192);
            lbl_ScreenAwakeStatus.Text = "Force Awake: OFF";
            lbl_ScreenAwakeStatus.ForeColor = Color.Red;
        }
    }

}
