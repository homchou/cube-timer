namespace Simple_Cute_Timer
{
    partial class maxtimer
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
            this.millimeters = new System.Windows.Forms.Label();
            this.minutes = new System.Windows.Forms.Label();
            this.seconds = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // millimeters
            // 
            
            this.millimeters.AutoSize = true;
            this.millimeters.Font = new System.Drawing.Font("微软雅黑", 180F);
            this.millimeters.ForeColor = System.Drawing.Color.White;
            this.millimeters.Location = new System.Drawing.Point(933, 220);
            this.millimeters.Name = "millimeters";
            this.millimeters.Size = new System.Drawing.Size(412, 311);
            this.millimeters.TabIndex = 6;
            this.millimeters.Text = "00";
            // 
            // minutes
            // 
            this.minutes.AutoSize = true;
            this.minutes.Font = new System.Drawing.Font("微软雅黑", 180F);
            this.minutes.ForeColor = System.Drawing.Color.White;
            this.minutes.Location = new System.Drawing.Point(42, 220);
            this.minutes.Name = "minutes";
            this.minutes.Size = new System.Drawing.Size(412, 311);
            this.minutes.TabIndex = 4;
            this.minutes.Text = "00";
            // 
            // seconds
            // 
            this.seconds.AutoSize = true;
            this.seconds.Font = new System.Drawing.Font("微软雅黑", 180F);
            this.seconds.ForeColor = System.Drawing.Color.White;
            this.seconds.Location = new System.Drawing.Point(485, 220);
            this.seconds.Name = "seconds";
            this.seconds.Size = new System.Drawing.Size(412, 311);
            this.seconds.TabIndex = 5;
            this.seconds.Text = "00";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("微软雅黑", 180F);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(741, 202);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(370, 311);
            this.label2.TabIndex = 8;
            this.label2.Text = "：";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("微软雅黑", 180F);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(297, 202);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(370, 311);
            this.label1.TabIndex = 7;
            this.label1.Text = "：";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(32, 24);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(119, 12);
            this.label3.TabIndex = 9;
            this.label3.Text = "点击退出全屏（Esc）";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // maxtimer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(1362, 712);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.millimeters);
            this.Controls.Add(this.minutes);
            this.Controls.Add(this.seconds);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "maxtimer";
            this.Text = "maxtimer";
            this.Load += new System.EventHandler(this.maxtimer_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.maxtimer_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.maxtimer_KeyUp);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label millimeters;
        private System.Windows.Forms.Label minutes;
        private System.Windows.Forms.Label seconds;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
    }
}