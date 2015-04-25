using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Text;
using System.Windows.Forms;
using System.Threading;
using System.Drawing;
using MyTimer_Of_Cube.Code;

namespace Simple_Cute_Timer
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();

            this.fillData();

            //开始线程
            Control.CheckForIllegalCrossThreadCalls = false;
            runlabe4 = new Thread(new ThreadStart(this.runlabel4));
            runlabe4.IsBackground = true;
            runlabe4.Start();//载入打乱字符串
        }

        Thread runlabe4;

        //设置移动变量
        bool formMove = false;
        Point formPoint;
        //定义时间值
        int indexMinutes = 0;
        int indexSeconds = 0;
        int indexMillimeters = 0;
        //初始化计时器状态
        Boolean isRun = false;
        int k = 0;//区别状态  
        //时间字符串
        string strtime;
        //实例化打乱公式类
        createmove cm;
        private void Form1_Load(object sender, EventArgs e)
        {
            
            button2.Enabled = false;
            button3.Enabled = false;

            //显示打乱公式
            cmove();
        }

        ~Form1()
        {
            //析构函数释放线程
            runlabe4.Abort();
        }

        #region//显示打乱公式
        public void cmove()
        {
            cm = new createmove();
            label9.Text = "打乱公式：" + cm.rndcube(25);
        }
        #endregion

        #region//计算平均成绩返回00：00：00格式字符串
        public string avg()
        {
            decimal _e = 0, _avg = 0, _s;
            int _m;
            string _ss;
            for (int i = 0; i < listBox1.Items.Count; i++)
            {
                _e += convertWS(listBox1.Items[i].ToString());
            }
            _avg = _e / (listBox1.Items.Count);
            _m = Convert.ToInt16(_avg) / 60;
            _s = _avg % 60;
            if (_s < 10)
            {
                _ss = "0" + _s.ToString();
            }
            else
            {
                _ss = _s.ToString();
            }
            return (_m.ToString() + ":" + _ss.Substring(0, 5)).Replace(".", ":");
        }

        //把00:00:00格式字符串转化成decimal的00.00秒的格式
        public decimal convertWS(string min)
        {

            int _m = Convert.ToInt16(min.Substring(0, 2));
            int _s = Convert.ToInt16(min.Substring(3, 2));
            int _ws = Convert.ToInt16(min.Substring(6, 2));
            string emp = (_m * 60 + _s).ToString() + "." + _ws;
            return Convert.ToDecimal(emp);
        }
        #endregion

        #region//一个线程
        private void runlabel4()
        {
            label4.Text = "点击全屏（Esc)";
            //label4.ForeColor = System.Drawing.Color.Red;
        }
        #endregion

        #region//归零方法
        public void tozero()
        {

            indexMinutes = 0;
            indexSeconds = 0;
            indexMillimeters = 0;
            minutes.Text = indexMinutes.ToString("00");
            seconds.Text = indexSeconds.ToString("00");
            millimeters.Text = indexMillimeters.ToString("000").Substring(0, 2);
        }
        #endregion

        #region//开始计时方法
        public void starttimer()
        {
            isRun = true;
            tozero();//首先调用清零计时

            Thread runTime = new Thread(new ThreadStart(this.runingTime));
            runTime.IsBackground = true;
            runTime.Start();
        }
        #endregion

        #region//计时功能方法
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
        #endregion

        #region//填充成绩到listbox
        private void Fillistbox()
        {
            listBox1.Items.Insert(0, strtime);//插入值到第一行
            listBox1.SelectedIndex = 0;//选择新插入的值--第一个值
        }
        #endregion

        #region//键盘事件
        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Space && isRun == false && k != 3)
            {
                millimeters.ForeColor = System.Drawing.Color.Green;
                minutes.ForeColor = System.Drawing.Color.Green;
                seconds.ForeColor = System.Drawing.Color.Green;
                label1.ForeColor = System.Drawing.Color.Green;
                label2.ForeColor = System.Drawing.Color.Green;
            }

            //全屏
            if (e.KeyCode == Keys.Escape)
            {
                storeData();
                this.Hide();
                maxtimer ma = new maxtimer();
                ma.ShowDialog();
            }


            //按下后停止计时
            if (isRun == true && k == 1)
            {
                this.isRun = false;
                k = 2;

                //获取计时停止时间
                strtime = minutes.Text.Trim() + label1.Text.Trim() + seconds.Text.Trim() + label2.Text.Trim() + millimeters.Text.Trim();

                //填充到listbox
                //label5.Text = strtime;
                Fillistbox();

                //显示还原个数
                label8.Text = listBox1.Items.Count.ToString();

                //显示平均成绩
                //label15.Text = avg();

            }
            if (k == 2)
            {
                isRun = false;

            }
            if (k == 3)
            {
                k++;
                //显示上次成绩
                label6.Text = strtime;
                //归零
                this.tozero();

            }
            
        }

        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Space)
            {
                //松开空格计时开始时颜色还原
                this.millimeters.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
                this.seconds.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
                this.minutes.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
                this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
                this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
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
                    //计时完归零后后显示下局打乱公式
                    cmove();
                }
            }
        }
        #endregion

        #region//打开全屏计时
        private void label4_Click(object sender, EventArgs e)
        {
            this.storeData();
            this.Hide();
            maxtimer ma = new maxtimer();
            ma.ShowDialog();
        }
        #endregion

        #region//关闭软件按键
        private void label3_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        #endregion

        #region//关闭软件发生事件
        //private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        //{
        //    DialogResult result = MessageBox.Show("是否要关闭软件", "提示", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

        //    if (result == DialogResult.Yes)
        //    {
        //        e.Cancel = false;//这是一个关闭事件，不取消事件，也就是不关闭
        //    }
        //    else
        //    {
        //        e.Cancel = true;//这是一个关闭事件，取消事件，就是关闭
        //    }
        //}
        #endregion

        #region//移动事件
        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            formPoint = new Point();
            int xOffset;
            int yOffset;
            if (e.Button == MouseButtons.Left)
            {
                xOffset = -e.X - SystemInformation.FrameBorderSize.Width + 5;
                yOffset = -e.Y - SystemInformation.CaptionHeight - SystemInformation.FrameBorderSize.Height + 5;
                formPoint = new Point(xOffset, yOffset);
                formMove = true;
            }
        }
        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            if (formMove == true)
            {
                Point mousePos = Control.MousePosition;
                mousePos.Offset(formPoint.X, formPoint.Y);
                Location = mousePos;
            }
        }
        private void Form1_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                formMove = false;
            }
        }
        #endregion

        #region//忽略成绩
        private void button1_Click(object sender, EventArgs e)
        {
            int i = listBox1.SelectedIndex;
            if (listBox1.Items.Count > 0)
            {
                listBox1.Items.Remove(listBox1.Items[i].ToString());
            }
            if (listBox1.Items.Count > 0)
            {
                listBox1.SelectedIndex = 0;
            }
            label8.Text = listBox1.Items.Count.ToString();
            if (listBox1.Items.Count == 0)
            {
                label15.Text = "00:00:00";
            }
            else
            {
                //显示平均成绩
                //label15.Text = avg();
            }
            listBox1.Focus();
        }
        #endregion

        #region//修改成pop
        private void button2_Click(object sender, EventArgs e)
        {
            int i = listBox1.SelectedIndex;
            if (listBox1.Items.Count > 0)
            {
                listBox1.Items.Remove(listBox1.Items[i].ToString());
                listBox1.Items.Insert(i, "POP");
            }

            if (listBox1.Items.Count > 0)
            {
                listBox1.SelectedIndex = 0;

            }

            listBox1.Focus();
        }
        #endregion

        #region//修改成DNF
        private void button3_Click(object sender, EventArgs e)
        {
            int i = listBox1.SelectedIndex;
            if (listBox1.Items.Count > 0)
            {
                listBox1.Items.Remove(listBox1.Items[i].ToString());
                listBox1.Items.Insert(i, "DNF");

            }
            if (listBox1.Items.Count > 0)
            {
                listBox1.SelectedIndex = 0;

            }
            listBox1.Focus();
        }
        #endregion

        #region//清空复位事件
        private void button4_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            label8.Text = listBox1.Items.Count.ToString();
            listBox1.Focus();
        }
        #endregion

        #region//菜单事件
        private void 全屏ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            maxtimer ma = new maxtimer();
            ma.ShowDialog();
        }


        private void 成绩导出设置ToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void 使用说明ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            helper h = new helper();
            h.ShowDialog();
        }


        private void 关于软件ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            about ab = new about();
            ab.ShowDialog();
        }
        #endregion


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

        /// <summary>
        /// 关闭窗体时事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            System.Diagnostics.Process.GetCurrentProcess().Kill(); 
        }
    }
}
