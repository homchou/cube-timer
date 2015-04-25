namespace Simple_Cute_Timer
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.minutes = new System.Windows.Forms.Label();
            this.seconds = new System.Windows.Forms.Label();
            this.millimeters = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.设置ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.全屏ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.成绩导出设置ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.关于AToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.使用说明ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.关于软件ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.label5 = new System.Windows.Forms.Label();
            this.button4 = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // minutes
            // 
            this.minutes.AutoSize = true;
            this.minutes.Font = new System.Drawing.Font("微软雅黑", 80F);
            this.minutes.Location = new System.Drawing.Point(108, 43);
            this.minutes.Name = "minutes";
            this.minutes.Size = new System.Drawing.Size(186, 140);
            this.minutes.TabIndex = 0;
            this.minutes.Text = "00";
            // 
            // seconds
            // 
            this.seconds.AutoSize = true;
            this.seconds.Font = new System.Drawing.Font("微软雅黑", 80F);
            this.seconds.Location = new System.Drawing.Point(308, 43);
            this.seconds.Name = "seconds";
            this.seconds.Size = new System.Drawing.Size(186, 140);
            this.seconds.TabIndex = 1;
            this.seconds.Text = "00";
            // 
            // millimeters
            // 
            this.millimeters.AutoSize = true;
            this.millimeters.Font = new System.Drawing.Font("微软雅黑", 80F);
            this.millimeters.Location = new System.Drawing.Point(507, 43);
            this.millimeters.Name = "millimeters";
            this.millimeters.Size = new System.Drawing.Size(186, 140);
            this.millimeters.TabIndex = 2;
            this.millimeters.Text = "00";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("微软雅黑", 80F);
            this.label1.Location = new System.Drawing.Point(223, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(167, 140);
            this.label1.TabIndex = 3;
            this.label1.Text = "：";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("微软雅黑", 80F);
            this.label2.Location = new System.Drawing.Point(423, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(167, 140);
            this.label2.TabIndex = 3;
            this.label2.Text = "：";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label4.Location = new System.Drawing.Point(676, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(23, 12);
            this.label4.TabIndex = 4;
            this.label4.Text = "esc";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // listBox1
            // 
            this.listBox1.BackColor = System.Drawing.SystemColors.Window;
            this.listBox1.Font = new System.Drawing.Font("微软雅黑", 10F, System.Drawing.FontStyle.Bold);
            this.listBox1.ForeColor = System.Drawing.Color.DimGray;
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 19;
            this.listBox1.Location = new System.Drawing.Point(27, 244);
            this.listBox1.Name = "listBox1";
            this.listBox1.ScrollAlwaysVisible = true;
            this.listBox1.Size = new System.Drawing.Size(107, 213);
            this.listBox1.TabIndex = 6;
            this.listBox1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.listBox1.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyUp);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(137, 62);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(70, 36);
            this.button1.TabIndex = 7;
            this.button1.Text = "忽略";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            this.button1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.button1.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(137, 113);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(70, 36);
            this.button2.TabIndex = 8;
            this.button2.Text = "POP";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(137, 170);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(70, 36);
            this.button3.TabIndex = 9;
            this.button3.Text = "DNF";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // 设置ToolStripMenuItem
            // 
            this.设置ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.全屏ToolStripMenuItem,
            this.成绩导出设置ToolStripMenuItem});
            this.设置ToolStripMenuItem.Name = "设置ToolStripMenuItem";
            this.设置ToolStripMenuItem.Size = new System.Drawing.Size(59, 21);
            this.设置ToolStripMenuItem.Text = "软件(&S)";
            // 
            // 全屏ToolStripMenuItem
            // 
            this.全屏ToolStripMenuItem.Name = "全屏ToolStripMenuItem";
            this.全屏ToolStripMenuItem.Size = new System.Drawing.Size(148, 22);
            this.全屏ToolStripMenuItem.Text = "全屏";
            this.全屏ToolStripMenuItem.Click += new System.EventHandler(this.全屏ToolStripMenuItem_Click);
            // 
            // 成绩导出设置ToolStripMenuItem
            // 
            this.成绩导出设置ToolStripMenuItem.Name = "成绩导出设置ToolStripMenuItem";
            this.成绩导出设置ToolStripMenuItem.Size = new System.Drawing.Size(148, 22);
            this.成绩导出设置ToolStripMenuItem.Text = "成绩导出设置";
            this.成绩导出设置ToolStripMenuItem.Click += new System.EventHandler(this.成绩导出设置ToolStripMenuItem_Click);
            // 
            // 关于AToolStripMenuItem
            // 
            this.关于AToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.使用说明ToolStripMenuItem,
            this.关于软件ToolStripMenuItem});
            this.关于AToolStripMenuItem.Name = "关于AToolStripMenuItem";
            this.关于AToolStripMenuItem.Size = new System.Drawing.Size(61, 21);
            this.关于AToolStripMenuItem.Text = "帮助(&H)";
            // 
            // 使用说明ToolStripMenuItem
            // 
            this.使用说明ToolStripMenuItem.Name = "使用说明ToolStripMenuItem";
            this.使用说明ToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.使用说明ToolStripMenuItem.Text = "使用说明";
            this.使用说明ToolStripMenuItem.Click += new System.EventHandler(this.使用说明ToolStripMenuItem_Click);
            // 
            // 关于软件ToolStripMenuItem
            // 
            this.关于软件ToolStripMenuItem.Name = "关于软件ToolStripMenuItem";
            this.关于软件ToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.关于软件ToolStripMenuItem.Text = "关于软件";
            this.关于软件ToolStripMenuItem.Click += new System.EventHandler(this.关于软件ToolStripMenuItem_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.Control;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.设置ToolStripMenuItem,
            this.关于AToolStripMenuItem});
            this.menuStrip1.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.HorizontalStackWithOverflow;
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(807, 25);
            this.menuStrip1.TabIndex = 5;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(228, 249);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(89, 12);
            this.label5.TabIndex = 11;
            this.label5.Text = "上次条记录为：";
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(137, 224);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(70, 36);
            this.button4.TabIndex = 12;
            this.button4.Text = "清空复位";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label6.ForeColor = System.Drawing.Color.Red;
            this.label6.Location = new System.Drawing.Point(309, 243);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(41, 21);
            this.label6.TabIndex = 13;
            this.label6.Text = "Null";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(240, 273);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(77, 12);
            this.label7.TabIndex = 11;
            this.label7.Text = "还原个数为：";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label8.ForeColor = System.Drawing.Color.Red;
            this.label8.Location = new System.Drawing.Point(309, 269);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(41, 21);
            this.label8.TabIndex = 13;
            this.label8.Text = "Null";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label9.Location = new System.Drawing.Point(75, 21);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(90, 21);
            this.label9.TabIndex = 15;
            this.label9.Text = "打乱公式：";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(252, 298);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(65, 12);
            this.label10.TabIndex = 16;
            this.label10.Text = "最好成绩：";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(252, 320);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(65, 12);
            this.label11.TabIndex = 17;
            this.label11.Text = "最差成绩：";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(252, 345);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(65, 12);
            this.label12.TabIndex = 18;
            this.label12.Text = "平均成绩：";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label13.ForeColor = System.Drawing.Color.Red;
            this.label13.Location = new System.Drawing.Point(309, 293);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(41, 21);
            this.label13.TabIndex = 19;
            this.label13.Text = "Null";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label14.ForeColor = System.Drawing.Color.Red;
            this.label14.Location = new System.Drawing.Point(309, 315);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(41, 21);
            this.label14.TabIndex = 20;
            this.label14.Text = "Null";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label15.ForeColor = System.Drawing.Color.Red;
            this.label15.Location = new System.Drawing.Point(309, 340);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(41, 21);
            this.label15.TabIndex = 21;
            this.label15.Text = "Null";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.button3);
            this.groupBox1.Controls.Add(this.button4);
            this.groupBox1.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.groupBox1.Location = new System.Drawing.Point(9, 187);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(786, 296);
            this.groupBox1.TabIndex = 22;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "魔方计时器";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.Control;
            this.label3.Image = ((System.Drawing.Image)(resources.GetObject("label3.Image")));
            this.label3.Location = new System.Drawing.Point(787, 1);
            this.label3.MinimumSize = new System.Drawing.Size(20, 20);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(20, 20);
            this.label3.TabIndex = 10;
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(807, 489);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.minutes);
            this.Controls.Add(this.seconds);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.millimeters);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MyTimer Of Cube by:Hom_Chou";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyUp);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseUp);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label minutes;
        private System.Windows.Forms.Label seconds;
        private System.Windows.Forms.Label millimeters;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.ToolStripMenuItem 设置ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 全屏ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 成绩导出设置ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 关于AToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 使用说明ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 关于软件ToolStripMenuItem;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label3;
    }
}

