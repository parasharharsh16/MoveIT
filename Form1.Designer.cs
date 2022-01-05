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
            ((System.ComponentModel.ISupportInitialize)(this.txt_TimeInterval)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(344, 145);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(174, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Developed By: Harsh Parashar";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(146, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(192, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Enter Time In Seconds";
            // 
            // txt_TimeInterval
            // 
            this.txt_TimeInterval.Location = new System.Drawing.Point(175, 52);
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
            this.btn_Stop.Location = new System.Drawing.Point(319, 89);
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
            this.btn_Start.Location = new System.Drawing.Point(94, 89);
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
            this.lbl_RunningStatus.ForeColor = System.Drawing.Color.Red;
            this.lbl_RunningStatus.Location = new System.Drawing.Point(3, 140);
            this.lbl_RunningStatus.Name = "lbl_RunningStatus";
            this.lbl_RunningStatus.Size = new System.Drawing.Size(125, 20);
            this.lbl_RunningStatus.TabIndex = 6;
            this.lbl_RunningStatus.Text = "Status: Stopped";
            // 
            // Form_MoveIT
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.ClientSize = new System.Drawing.Size(519, 169);
            this.Controls.Add(this.lbl_RunningStatus);
            this.Controls.Add(this.btn_Stop);
            this.Controls.Add(this.btn_Start);
            this.Controls.Add(this.txt_TimeInterval);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form_MoveIT";
            this.Text = "MoveIT";
            ((System.ComponentModel.ISupportInitialize)(this.txt_TimeInterval)).EndInit();
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
    }
}

