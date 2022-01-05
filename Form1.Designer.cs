namespace MoveIT
{
    partial class Form_MoveIT
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_MoveIT));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_TimeInterval = new System.Windows.Forms.NumericUpDown();
            this.btn_Stop = new System.Windows.Forms.Button();
            this.btn_Start = new System.Windows.Forms.Button();
            this.lbl_RunningStatus = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.lbl_screenAwakeInfo = new System.Windows.Forms.Label();
            this.btn_resetDefault = new System.Windows.Forms.Button();
            this.btn_preventSleep = new System.Windows.Forms.Button();
            this.lbl_ScreenAwakeStatus = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.txt_TimeInterval)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(344, 191);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(174, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Developed By: Harsh Parashar";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(149, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(192, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Enter Time In Seconds";
            // 
            // txt_TimeInterval
            // 
            this.txt_TimeInterval.Location = new System.Drawing.Point(170, 44);
            this.txt_TimeInterval.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.txt_TimeInterval.Name = "txt_TimeInterval";
            this.txt_TimeInterval.Size = new System.Drawing.Size(142, 26);
            this.txt_TimeInterval.TabIndex = 3;
            this.txt_TimeInterval.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            // 
            // btn_Stop
            // 
            this.btn_Stop.BackColor = System.Drawing.Color.Red;
            this.btn_Stop.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Stop.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_Stop.Location = new System.Drawing.Point(350, 44);
            this.btn_Stop.Name = "btn_Stop";
            this.btn_Stop.Size = new System.Drawing.Size(76, 32);
            this.btn_Stop.TabIndex = 5;
            this.btn_Stop.Text = "Stop";
            this.btn_Stop.UseVisualStyleBackColor = false;
            this.btn_Stop.Click += new System.EventHandler(this.btn_Stop_Click);
            // 
            // btn_Start
            // 
            this.btn_Start.BackColor = System.Drawing.Color.Green;
            this.btn_Start.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btn_Start.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_Start.Location = new System.Drawing.Point(57, 44);
            this.btn_Start.Name = "btn_Start";
            this.btn_Start.Size = new System.Drawing.Size(75, 32);
            this.btn_Start.TabIndex = 4;
            this.btn_Start.Text = "Start";
            this.btn_Start.UseVisualStyleBackColor = false;
            this.btn_Start.Click += new System.EventHandler(this.btn_Start_Click);
            // 
            // lbl_RunningStatus
            // 
            this.lbl_RunningStatus.AutoSize = true;
            this.lbl_RunningStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_RunningStatus.ForeColor = System.Drawing.Color.Red;
            this.lbl_RunningStatus.Location = new System.Drawing.Point(1, 126);
            this.lbl_RunningStatus.Name = "lbl_RunningStatus";
            this.lbl_RunningStatus.Size = new System.Drawing.Size(140, 20);
            this.lbl_RunningStatus.TabIndex = 6;
            this.lbl_RunningStatus.Text = "Status: Stopped";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(12, 2);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(506, 186);
            this.tabControl1.TabIndex = 7;
            // 
            // tabPage1
            // 
            this.tabPage1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.tabPage1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.btn_Stop);
            this.tabPage1.Controls.Add(this.btn_Start);
            this.tabPage1.Controls.Add(this.lbl_RunningStatus);
            this.tabPage1.Controls.Add(this.txt_TimeInterval);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Location = new System.Drawing.Point(4, 29);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(498, 153);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Mouse Mover";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.tabPage2.Controls.Add(this.lbl_ScreenAwakeStatus);
            this.tabPage2.Controls.Add(this.lbl_screenAwakeInfo);
            this.tabPage2.Controls.Add(this.btn_resetDefault);
            this.tabPage2.Controls.Add(this.btn_preventSleep);
            this.tabPage2.Location = new System.Drawing.Point(4, 29);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(498, 153);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Screen Awake";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // lbl_screenAwakeInfo
            // 
            this.lbl_screenAwakeInfo.AutoSize = true;
            this.lbl_screenAwakeInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_screenAwakeInfo.Location = new System.Drawing.Point(6, 79);
            this.lbl_screenAwakeInfo.Name = "lbl_screenAwakeInfo";
            this.lbl_screenAwakeInfo.Size = new System.Drawing.Size(476, 40);
            this.lbl_screenAwakeInfo.TabIndex = 2;
            this.lbl_screenAwakeInfo.Text = "This function will keep your screen awake. Click on \"Reset Default\"\r\nto stop <For" +
    "ce Awake>";
            this.lbl_screenAwakeInfo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btn_resetDefault
            // 
            this.btn_resetDefault.BackColor = System.Drawing.Color.Gray;
            this.btn_resetDefault.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_resetDefault.Location = new System.Drawing.Point(154, 44);
            this.btn_resetDefault.Name = "btn_resetDefault";
            this.btn_resetDefault.Size = new System.Drawing.Size(172, 32);
            this.btn_resetDefault.TabIndex = 1;
            this.btn_resetDefault.Text = "Reset Default";
            this.btn_resetDefault.UseVisualStyleBackColor = false;
            this.btn_resetDefault.Click += new System.EventHandler(this.btn_resetDefault_Click);
            // 
            // btn_preventSleep
            // 
            this.btn_preventSleep.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btn_preventSleep.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_preventSleep.ForeColor = System.Drawing.Color.Black;
            this.btn_preventSleep.Location = new System.Drawing.Point(154, 6);
            this.btn_preventSleep.Name = "btn_preventSleep";
            this.btn_preventSleep.Size = new System.Drawing.Size(172, 32);
            this.btn_preventSleep.TabIndex = 0;
            this.btn_preventSleep.Text = "Prevent Sleep";
            this.btn_preventSleep.UseVisualStyleBackColor = false;
            this.btn_preventSleep.Click += new System.EventHandler(this.btn_preventSleep_Click);
            // 
            // lbl_ScreenAwakeStatus
            // 
            this.lbl_ScreenAwakeStatus.AutoSize = true;
            this.lbl_ScreenAwakeStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_ScreenAwakeStatus.ForeColor = System.Drawing.Color.Red;
            this.lbl_ScreenAwakeStatus.Location = new System.Drawing.Point(1, 126);
            this.lbl_ScreenAwakeStatus.Name = "lbl_ScreenAwakeStatus";
            this.lbl_ScreenAwakeStatus.Size = new System.Drawing.Size(158, 20);
            this.lbl_ScreenAwakeStatus.TabIndex = 3;
            this.lbl_ScreenAwakeStatus.Text = "Force Awake: OFF";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 86);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(476, 40);
            this.label3.TabIndex = 7;
            this.label3.Text = "This function will move the cursor randomly in time interval provided\r\nby user";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form_MoveIT
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(144F, 144F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.ClientSize = new System.Drawing.Size(533, 215);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form_MoveIT";
            this.Text = "MoveIT";
            ((System.ComponentModel.ISupportInitialize)(this.txt_TimeInterval)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown txt_TimeInterval;
        private System.Windows.Forms.Button btn_Start;
        private System.Windows.Forms.Button btn_Stop;
        private System.Windows.Forms.Label lbl_RunningStatus;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label lbl_screenAwakeInfo;
        private System.Windows.Forms.Button btn_resetDefault;
        private System.Windows.Forms.Button btn_preventSleep;
        private System.Windows.Forms.Label lbl_ScreenAwakeStatus;
        private System.Windows.Forms.Label label3;
    }
}

