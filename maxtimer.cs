using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;

using System.Text;
using System.Windows.Forms;
using System.Threading;
using MyTimer_Of_Cube.Code;


namespace Simple_Cute_Timer
{
    public partial class maxtimer : Form
    {
        public maxtimer()
        {
            InitializeComponent();

            //适配大于传统笔记本的显示器，全屏数字position
            Rectangle rect = Screen.GetWorkingArea(this);
            int lableExtendWidht = rect.Width > this.bookWidht ? (rect.Width - this.bookWidht) / 2 : 0;
            int lableExtendHeight = rect.Height > this.bookHeight ? (rect.Height - this.bookHeight) / 2 : 0;

            this.label1.Location = new System.Drawing.Point(297 + lableExtendWidht, 202 + lableExtendHeight);
            this.label2.Location = new System.Drawing.Point(741 + lableExtendWidht, 202 + lableExtendHeight);
            this.seconds.Location = new System.Drawing.Point(485 + lableExtendWidht, 220 + lableExtendHeight);
            this.minutes.Location = new System.Drawing.Point(42 + lableExtendWidht, 220 + lableExtendHeight);
            this.millimeters.Location = new System.Drawing.Point(933 + lableExtendWidht, 220 + lableExtendHeight);

            //开始线程
            Control.CheckForIllegalCrossThreadCalls = false;
            runlabe3 = new Thread(new ThreadStart(this.runlabel3));
            runlabe3.Start();//载入打乱字符串
        }

        ~maxtimer()
        {
            //析构函数释放线程
            runlabe3.Abort();
        }

        Thread runlabe3;

        //笔记本高度-40
        int bookHeight = 768 - 40;
        //笔记本宽度
        int bookWidht = 1366;

        int indexMinutes = 0;
        int indexSeconds = 0;
        int indexMillimeters = 0;
        //初始化计时器状态
        Boolean isRun = false;
        int k = 0;//区别状态


        //一个线程
        private void runlabel3()
        {
            label3.Text = "点击退出全屏（Esc）";
            label3.ForeColor = System.Drawing.Color.Red;
        }

        //归零方法
        public void tozero()
        {
            indexMinutes = 0;
            indexSeconds = 0;
            indexMillimeters = 0;
            minutes.Text = indexMinutes.ToString("00");
            seconds.Text = indexSeconds.ToString("00");
            millimeters.Text = indexMillimeters.ToString("000").Substring(0, 2);
        }

        //开始计时方法
        public void starttimer()
        {
            isRun = true;
            tozero();//首先调用清零计时

            Thread runTime = new Thread(new ThreadStart(this.runingTime));
            runTime.IsBackground = true;
            runTime.Start();
        }

        /// <summary>
        /// 计时部分方法
        /// </summary>
        public void runingTime()//object source,System.Timers.ElapsedEventArgs e)
        {
            isRun = true;
            int aa = 0;//每次循环的起始毫秒数
            int bb = 0;//毫秒数累加，用于判断是否到了1秒
            while (isRun)
            {
                aa = System.Environment.TickCount;//系统启动到当前时间的毫秒数
                if (bb <= 999)
                {
                    millimeters.Text = bb.ToString("000").Substring(0, 2);

                }
                if (bb >= 999)
                {
                    bb = bb - 999;
                    indexSeconds++;
                    seconds.Text = indexSeconds.ToString("00");
                    if (indexSeconds == 60)
                    {
                        indexSeconds = 0;
                        seconds.Text = indexSeconds.ToString("00");
                        indexMinutes++;
                        minutes.Text = indexMinutes.ToString("00");

                    }
                }

                bb += System.Environment.TickCount - aa; //bb为已经累加的毫秒数

            }

        }

        /// <summary>
        /// 窗体加载事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void maxtimer_Load(object sender, EventArgs e)
        {
            //全屏
            this.TopMost = true;
            this.FormBorderStyle = FormBorderStyle.None;
            this.WindowState = FormWindowState.Maximized;
            //初始化颜色
            minutes.ForeColor = System.Drawing.Color.White;
            seconds.ForeColor = System.Drawing.Color.White;
            millimeters.ForeColor = System.Drawing.Color.White;
            label1.ForeColor = System.Drawing.Color.White;
            label2.ForeColor = System.Drawing.Color.White;
            label3.ForeColor = System.Drawing.Color.White;

            fillData();
        }

        /// <summary>
        /// 点击退出全屏
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void label3_Click(object sender, EventArgs e)
        {
            storeData();
            this.Hide();
            Form1 form1 = new Form1();
            form1.ShowDialog();
        }

        /// <summary>
        /// 键盘按键按下
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void maxtimer_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Space && isRun == false && k != 3)
            {
                millimeters.ForeColor = System.Drawing.Color.Green;
                minutes.ForeColor = System.Drawing.Color.Green;
                seconds.ForeColor = System.Drawing.Color.Green;
                label1.ForeColor = System.Drawing.Color.Green;
                label2.ForeColor = System.Drawing.Color.Green;
            }

            if (e.KeyCode == Keys.Escape)
            {
                storeData();
                this.Hide();
                Form1 form1 = new Form1();
                form1.ShowDialog();
            }

            if (isRun == true && k == 1)
            {
                this.isRun = false;
                k = 2;
            }
            if (k == 2)
            {
                isRun = false;
            }
            if (k == 3)
            {
                k++;
                this.tozero();
            }
            
        }

        /// <summary>
        /// 键盘按键按起
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void maxtimer_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Space)
            {
                minutes.ForeColor = System.Drawing.Color.White;
                seconds.ForeColor = System.Drawing.Color.White;
                millimeters.ForeColor = System.Drawing.Color.White;
                label1.ForeColor = System.Drawing.Color.White;
                label2.ForeColor = System.Drawing.Color.White;
                label3.ForeColor = System.Drawing.Color.White;
                if (this.isRun == false && k == 0)
                {
                    starttimer();
                    k = 1;
                }
                if (k == 2)
                {
                    k++;
                }
                if (k == 4)
                {
                    k = 0;
                    //rndCube();//打乱
                }
            }
        }

        /// <summary>
        /// 窗体显示事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void maxtimer_Shown(object sender, EventArgs e)
        {
            
        }

        /// <summary>
        /// 存储当前窗口值
        /// </summary>
        private void storeData()
        {
            StaticSpace.mm = this.minutes.Text;
            StaticSpace.ss = this.seconds.Text;
            StaticSpace.ff = this.millimeters.Text;
        }

        /// <summary>
        /// 填充存储的数据
        /// </summary>
        private void fillData()
        {
            this.minutes.Text = StaticSpace.mm;
            this.seconds.Text = StaticSpace.ss;
            this.millimeters.Text = StaticSpace.ff;
            if (StaticSpace.mm != "00" || StaticSpace.ss != "00" || StaticSpace.ff != "00")
            {
                this.isRun = false;
                this.k = 3;
            }
        }



    }
}
