namespace Daily.Custom_Control
{
    partial class CalendarPage
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

        #region 组件设计器生成的代码

        /// <summary> 
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CalendarPage));
            this.panelTop = new System.Windows.Forms.Panel();
            this.textBoxYear = new System.Windows.Forms.TextBox();
            this.month11 = new Daily.Custom_Control.Month();
            this.month12 = new Daily.Custom_Control.Month();
            this.month10 = new Daily.Custom_Control.Month();
            this.month9 = new Daily.Custom_Control.Month();
            this.month8 = new Daily.Custom_Control.Month();
            this.month7 = new Daily.Custom_Control.Month();
            this.month6 = new Daily.Custom_Control.Month();
            this.month5 = new Daily.Custom_Control.Month();
            this.month4 = new Daily.Custom_Control.Month();
            this.month3 = new Daily.Custom_Control.Month();
            this.month2 = new Daily.Custom_Control.Month();
            this.month1 = new Daily.Custom_Control.Month();
            this.ButtonNextYear = new Daily.CircularButton();
            this.ButtonPreviousYear = new Daily.CircularButton();
            this.labelYear = new System.Windows.Forms.Label();
            this.panelDay = new System.Windows.Forms.Panel();
            this.week7 = new Daily.Custom_Control.Week();
            this.week6 = new Daily.Custom_Control.Week();
            this.week5 = new Daily.Custom_Control.Week();
            this.week4 = new Daily.Custom_Control.Week();
            this.week3 = new Daily.Custom_Control.Week();
            this.week2 = new Daily.Custom_Control.Week();
            this.week1 = new Daily.Custom_Control.Week();
            this.panelWeek = new System.Windows.Forms.Panel();
            this.buttonToday = new System.Windows.Forms.Button();
            this.panelTop.SuspendLayout();
            this.panelWeek.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelTop
            // 
            this.panelTop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.panelTop.Controls.Add(this.textBoxYear);
            this.panelTop.Controls.Add(this.month11);
            this.panelTop.Controls.Add(this.month12);
            this.panelTop.Controls.Add(this.month10);
            this.panelTop.Controls.Add(this.month9);
            this.panelTop.Controls.Add(this.month8);
            this.panelTop.Controls.Add(this.month7);
            this.panelTop.Controls.Add(this.month6);
            this.panelTop.Controls.Add(this.month5);
            this.panelTop.Controls.Add(this.month4);
            this.panelTop.Controls.Add(this.month3);
            this.panelTop.Controls.Add(this.month2);
            this.panelTop.Controls.Add(this.month1);
            this.panelTop.Controls.Add(this.ButtonNextYear);
            this.panelTop.Controls.Add(this.ButtonPreviousYear);
            this.panelTop.Controls.Add(this.labelYear);
            this.panelTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTop.Location = new System.Drawing.Point(0, 0);
            this.panelTop.Name = "panelTop";
            this.panelTop.Size = new System.Drawing.Size(900, 80);
            this.panelTop.TabIndex = 0;
            // 
            // textBoxYear
            // 
            this.textBoxYear.Font = new System.Drawing.Font("宋体", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.textBoxYear.Location = new System.Drawing.Point(331, 16);
            this.textBoxYear.Name = "textBoxYear";
            this.textBoxYear.Size = new System.Drawing.Size(65, 25);
            this.textBoxYear.TabIndex = 3;
            this.textBoxYear.Visible = false;
            // 
            // month11
            // 
            this.month11.anyText = "11";
            this.month11.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.month11.Cursor = System.Windows.Forms.Cursors.Hand;
            this.month11.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.month11.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.month11.Location = new System.Drawing.Point(647, 38);
            this.month11.Margin = new System.Windows.Forms.Padding(4);
            this.month11.Name = "month11";
            this.month11.Size = new System.Drawing.Size(37, 37);
            this.month11.TabIndex = 2;
            this.month11.Click += new System.EventHandler(this.month11_Click);
            // 
            // month12
            // 
            this.month12.anyText = "12";
            this.month12.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.month12.Cursor = System.Windows.Forms.Cursors.Hand;
            this.month12.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.month12.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.month12.Location = new System.Drawing.Point(695, 38);
            this.month12.Margin = new System.Windows.Forms.Padding(4);
            this.month12.Name = "month12";
            this.month12.Size = new System.Drawing.Size(37, 37);
            this.month12.TabIndex = 2;
            this.month12.Click += new System.EventHandler(this.month12_Click);
            // 
            // month10
            // 
            this.month10.anyText = "10";
            this.month10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.month10.Cursor = System.Windows.Forms.Cursors.Hand;
            this.month10.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.month10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.month10.Location = new System.Drawing.Point(599, 38);
            this.month10.Margin = new System.Windows.Forms.Padding(4);
            this.month10.Name = "month10";
            this.month10.Size = new System.Drawing.Size(37, 37);
            this.month10.TabIndex = 2;
            this.month10.Click += new System.EventHandler(this.month10_Click);
            // 
            // month9
            // 
            this.month9.anyText = "9";
            this.month9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.month9.Cursor = System.Windows.Forms.Cursors.Hand;
            this.month9.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.month9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.month9.Location = new System.Drawing.Point(551, 38);
            this.month9.Margin = new System.Windows.Forms.Padding(4);
            this.month9.Name = "month9";
            this.month9.Size = new System.Drawing.Size(37, 37);
            this.month9.TabIndex = 2;
            this.month9.Click += new System.EventHandler(this.month9_Click);
            // 
            // month8
            // 
            this.month8.anyText = "8";
            this.month8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.month8.Cursor = System.Windows.Forms.Cursors.Hand;
            this.month8.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.month8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.month8.Location = new System.Drawing.Point(503, 38);
            this.month8.Margin = new System.Windows.Forms.Padding(4);
            this.month8.Name = "month8";
            this.month8.Size = new System.Drawing.Size(37, 37);
            this.month8.TabIndex = 2;
            this.month8.Click += new System.EventHandler(this.month8_Click);
            // 
            // month7
            // 
            this.month7.anyText = "7";
            this.month7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.month7.Cursor = System.Windows.Forms.Cursors.Hand;
            this.month7.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.month7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.month7.Location = new System.Drawing.Point(455, 38);
            this.month7.Margin = new System.Windows.Forms.Padding(4);
            this.month7.Name = "month7";
            this.month7.Size = new System.Drawing.Size(37, 37);
            this.month7.TabIndex = 2;
            this.month7.Click += new System.EventHandler(this.month7_Click);
            // 
            // month6
            // 
            this.month6.anyText = "6";
            this.month6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.month6.Cursor = System.Windows.Forms.Cursors.Hand;
            this.month6.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.month6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.month6.Location = new System.Drawing.Point(407, 38);
            this.month6.Margin = new System.Windows.Forms.Padding(4);
            this.month6.Name = "month6";
            this.month6.Size = new System.Drawing.Size(37, 37);
            this.month6.TabIndex = 2;
            this.month6.Click += new System.EventHandler(this.month6_Click);
            // 
            // month5
            // 
            this.month5.anyText = "5";
            this.month5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.month5.Cursor = System.Windows.Forms.Cursors.Hand;
            this.month5.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.month5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.month5.Location = new System.Drawing.Point(359, 38);
            this.month5.Margin = new System.Windows.Forms.Padding(4);
            this.month5.Name = "month5";
            this.month5.Size = new System.Drawing.Size(37, 37);
            this.month5.TabIndex = 2;
            this.month5.Click += new System.EventHandler(this.month5_Click);
            // 
            // month4
            // 
            this.month4.anyText = "4";
            this.month4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.month4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.month4.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.month4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.month4.Location = new System.Drawing.Point(311, 38);
            this.month4.Margin = new System.Windows.Forms.Padding(4);
            this.month4.Name = "month4";
            this.month4.Size = new System.Drawing.Size(37, 37);
            this.month4.TabIndex = 2;
            this.month4.Click += new System.EventHandler(this.month4_Click);
            // 
            // month3
            // 
            this.month3.anyText = "3";
            this.month3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.month3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.month3.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.month3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.month3.Location = new System.Drawing.Point(263, 38);
            this.month3.Margin = new System.Windows.Forms.Padding(4);
            this.month3.Name = "month3";
            this.month3.Size = new System.Drawing.Size(37, 37);
            this.month3.TabIndex = 2;
            this.month3.Click += new System.EventHandler(this.month3_Click);
            // 
            // month2
            // 
            this.month2.anyText = "2";
            this.month2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.month2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.month2.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.month2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.month2.Location = new System.Drawing.Point(215, 38);
            this.month2.Margin = new System.Windows.Forms.Padding(4);
            this.month2.Name = "month2";
            this.month2.Size = new System.Drawing.Size(37, 37);
            this.month2.TabIndex = 2;
            this.month2.Click += new System.EventHandler(this.month2_Click);
            // 
            // month1
            // 
            this.month1.anyText = "1";
            this.month1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.month1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.month1.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.month1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.month1.Location = new System.Drawing.Point(167, 38);
            this.month1.Margin = new System.Windows.Forms.Padding(4);
            this.month1.Name = "month1";
            this.month1.Size = new System.Drawing.Size(37, 37);
            this.month1.TabIndex = 2;
            this.month1.Click += new System.EventHandler(this.month1_Click);
            // 
            // ButtonNextYear
            // 
            this.ButtonNextYear.FlatAppearance.BorderSize = 0;
            this.ButtonNextYear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonNextYear.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ButtonNextYear.Image = ((System.Drawing.Image)(resources.GetObject("ButtonNextYear.Image")));
            this.ButtonNextYear.Location = new System.Drawing.Point(830, 16);
            this.ButtonNextYear.Name = "ButtonNextYear";
            this.ButtonNextYear.Size = new System.Drawing.Size(50, 50);
            this.ButtonNextYear.TabIndex = 1;
            this.ButtonNextYear.UseVisualStyleBackColor = true;
            this.ButtonNextYear.Click += new System.EventHandler(this.ButtonNextYear_Click);
            // 
            // ButtonPreviousYear
            // 
            this.ButtonPreviousYear.FlatAppearance.BorderSize = 0;
            this.ButtonPreviousYear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonPreviousYear.Image = ((System.Drawing.Image)(resources.GetObject("ButtonPreviousYear.Image")));
            this.ButtonPreviousYear.Location = new System.Drawing.Point(19, 16);
            this.ButtonPreviousYear.Name = "ButtonPreviousYear";
            this.ButtonPreviousYear.Size = new System.Drawing.Size(50, 50);
            this.ButtonPreviousYear.TabIndex = 1;
            this.ButtonPreviousYear.UseVisualStyleBackColor = true;
            this.ButtonPreviousYear.Click += new System.EventHandler(this.ButtonPreviousYear_Click);
            // 
            // labelYear
            // 
            this.labelYear.AutoSize = true;
            this.labelYear.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelYear.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.labelYear.Location = new System.Drawing.Point(420, 12);
            this.labelYear.Name = "labelYear";
            this.labelYear.Size = new System.Drawing.Size(65, 30);
            this.labelYear.TabIndex = 0;
            this.labelYear.Text = "2018";
            this.labelYear.DoubleClick += new System.EventHandler(this.labelYear_DoubleClick);
            // 
            // panelDay
            // 
            this.panelDay.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.panelDay.Location = new System.Drawing.Point(71, 119);
            this.panelDay.Name = "panelDay";
            this.panelDay.Size = new System.Drawing.Size(755, 331);
            this.panelDay.TabIndex = 1;
            // 
            // week7
            // 
            this.week7.anyText = "SAT";
            this.week7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(95)))), ((int)(((byte)(95)))));
            this.week7.ForeColor = System.Drawing.Color.White;
            this.week7.Location = new System.Drawing.Point(643, 0);
            this.week7.Margin = new System.Windows.Forms.Padding(4);
            this.week7.Name = "week7";
            this.week7.Size = new System.Drawing.Size(70, 39);
            this.week7.TabIndex = 0;
            // 
            // week6
            // 
            this.week6.anyText = "FRI";
            this.week6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(95)))), ((int)(((byte)(95)))));
            this.week6.ForeColor = System.Drawing.Color.White;
            this.week6.Location = new System.Drawing.Point(543, 0);
            this.week6.Margin = new System.Windows.Forms.Padding(4);
            this.week6.Name = "week6";
            this.week6.Size = new System.Drawing.Size(70, 39);
            this.week6.TabIndex = 0;
            // 
            // week5
            // 
            this.week5.anyText = "THU";
            this.week5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(95)))), ((int)(((byte)(95)))));
            this.week5.ForeColor = System.Drawing.Color.White;
            this.week5.Location = new System.Drawing.Point(443, 0);
            this.week5.Margin = new System.Windows.Forms.Padding(4);
            this.week5.Name = "week5";
            this.week5.Size = new System.Drawing.Size(70, 39);
            this.week5.TabIndex = 0;
            // 
            // week4
            // 
            this.week4.anyText = "WED";
            this.week4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(95)))), ((int)(((byte)(95)))));
            this.week4.ForeColor = System.Drawing.Color.White;
            this.week4.Location = new System.Drawing.Point(343, 0);
            this.week4.Margin = new System.Windows.Forms.Padding(4);
            this.week4.Name = "week4";
            this.week4.Size = new System.Drawing.Size(70, 39);
            this.week4.TabIndex = 0;
            // 
            // week3
            // 
            this.week3.anyText = "TUE";
            this.week3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(95)))), ((int)(((byte)(95)))));
            this.week3.ForeColor = System.Drawing.Color.White;
            this.week3.Location = new System.Drawing.Point(243, 0);
            this.week3.Margin = new System.Windows.Forms.Padding(4);
            this.week3.Name = "week3";
            this.week3.Size = new System.Drawing.Size(70, 39);
            this.week3.TabIndex = 0;
            // 
            // week2
            // 
            this.week2.anyText = "MON";
            this.week2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(95)))), ((int)(((byte)(95)))));
            this.week2.ForeColor = System.Drawing.Color.White;
            this.week2.Location = new System.Drawing.Point(143, 0);
            this.week2.Margin = new System.Windows.Forms.Padding(4);
            this.week2.Name = "week2";
            this.week2.Size = new System.Drawing.Size(70, 39);
            this.week2.TabIndex = 0;
            // 
            // week1
            // 
            this.week1.anyText = "SUN";
            this.week1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(95)))), ((int)(((byte)(95)))));
            this.week1.ForeColor = System.Drawing.Color.White;
            this.week1.Location = new System.Drawing.Point(43, 0);
            this.week1.Margin = new System.Windows.Forms.Padding(4);
            this.week1.Name = "week1";
            this.week1.Size = new System.Drawing.Size(70, 39);
            this.week1.TabIndex = 0;
            // 
            // panelWeek
            // 
            this.panelWeek.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(95)))), ((int)(((byte)(95)))));
            this.panelWeek.Controls.Add(this.week1);
            this.panelWeek.Controls.Add(this.week7);
            this.panelWeek.Controls.Add(this.week2);
            this.panelWeek.Controls.Add(this.week6);
            this.panelWeek.Controls.Add(this.week3);
            this.panelWeek.Controls.Add(this.week5);
            this.panelWeek.Controls.Add(this.week4);
            this.panelWeek.Location = new System.Drawing.Point(71, 80);
            this.panelWeek.Name = "panelWeek";
            this.panelWeek.Size = new System.Drawing.Size(755, 39);
            this.panelWeek.TabIndex = 1;
            // 
            // buttonToday
            // 
            this.buttonToday.FlatAppearance.BorderSize = 0;
            this.buttonToday.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonToday.Font = new System.Drawing.Font("Ebrima", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonToday.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.buttonToday.Image = ((System.Drawing.Image)(resources.GetObject("buttonToday.Image")));
            this.buttonToday.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.buttonToday.Location = new System.Drawing.Point(0, 196);
            this.buttonToday.Name = "buttonToday";
            this.buttonToday.Size = new System.Drawing.Size(69, 87);
            this.buttonToday.TabIndex = 2;
            this.buttonToday.Text = "TODAY";
            this.buttonToday.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.buttonToday.UseVisualStyleBackColor = true;
            this.buttonToday.Click += new System.EventHandler(this.buttonToday_Click);
            // 
            // CalendarPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(30)))), ((int)(((byte)(35)))));
            this.Controls.Add(this.buttonToday);
            this.Controls.Add(this.panelWeek);
            this.Controls.Add(this.panelDay);
            this.Controls.Add(this.panelTop);
            this.Name = "CalendarPage";
            this.Size = new System.Drawing.Size(900, 450);
            this.Load += new System.EventHandler(this.CalendarPage_Load);
            this.panelTop.ResumeLayout(false);
            this.panelTop.PerformLayout();
            this.panelWeek.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelTop;
        private System.Windows.Forms.Panel panelDay;
        private System.Windows.Forms.Label labelYear;
        private CircularButton ButtonNextYear;
        private CircularButton ButtonPreviousYear;
        private Month month11;
        private Month month12;
        private Month month10;
        private Month month9;
        private Month month8;
        private Month month7;
        private Month month6;
        private Month month5;
        private Month month4;
        private Month month3;
        private Month month2;
        private Month month1;
        private Week week7;
        private Week week6;
        private Week week5;
        private Week week4;
        private Week week3;
        private Week week2;
        private Week week1;
        private System.Windows.Forms.Panel panelWeek;
        private System.Windows.Forms.TextBox textBoxYear;
        private System.Windows.Forms.Button buttonToday;
    }
}
