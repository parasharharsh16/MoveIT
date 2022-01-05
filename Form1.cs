using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MoveIT
{
    public partial class Form_MoveIT : Form
    {
        Random random = new Random();
        public Form_MoveIT()
        {
            InitializeComponent();
            btn_Stop.BackColor = Color.DarkGray;
            
        }

        private void Move_Cursor()
        {
            // Set the Current cursor, move the cursor's Position,
            // and set its clipping rectangle to the form. 
            var randonNumberForX = random.Next(-20, 10);
            var randonNumberForY = random.Next(-20, 10);
            this.Cursor = new Cursor(Cursor.Current.Handle);
            Cursor.Position = new Point(Cursor.Position.X - (randonNumberForX), Cursor.Position.Y - (randonNumberForY));
            //Cursor.Clip = new Rectangle(this.Location, this.Size);
        }
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
        private void timer_Tick(object sender, EventArgs e)
        {
            Move_Cursor();
        }

        private void btn_Start_Click(object sender, EventArgs e)
        {
            InitTimer("Start");
            btn_Start.BackColor = Color.DarkGray;
            btn_Stop.BackColor = Color.Red;
            lbl_RunningStatus.Text = "Status: Running";
            lbl_RunningStatus.ForeColor = Color.Green;
        }
        private void btn_Stop_Click(object sender, EventArgs e)
        {
            InitTimer("Stop");
            btn_Start.BackColor = Color.Green;
            btn_Stop.BackColor = Color.DarkGray;
            lbl_RunningStatus.Text = "Status: Stopped";
            lbl_RunningStatus.ForeColor = Color.Red;
        }
    }
}
