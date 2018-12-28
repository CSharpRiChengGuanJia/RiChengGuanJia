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
            this.ButtonNextYear = new Daily.CircularButton();
            this.ButtonPreviousYear = new Daily.CircularButton();
            this.labelYear = new System.Windows.Forms.Label();
            this.panelDay = new System.Windows.Forms.Panel();
            this.panelWeek = new System.Windows.Forms.Panel();
            this.week1 = new Daily.Custom_Control.Week();
            this.week7 = new Daily.Custom_Control.Week();
            this.week2 = new Daily.Custom_Control.Week();
            this.week6 = new Daily.Custom_Control.Week();
            this.week3 = new Daily.Custom_Control.Week();
            this.week5 = new Daily.Custom_Control.Week();
            this.week4 = new Daily.Custom_Control.Week();
            this.buttonToday = new System.Windows.Forms.Button();
            this.buttonJump = new System.Windows.Forms.Button();
            this.panelTop.SuspendLayout();
            this.panelWeek.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelTop
            // 
            this.panelTop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.panelTop.Controls.Add(this.textBoxYear);
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
            this.textBoxYear.Location = new System.Drawing.Point(599, 12);
            this.textBoxYear.Name = "textBoxYear";
            this.textBoxYear.Size = new System.Drawing.Size(65, 25);
            this.textBoxYear.TabIndex = 3;
            this.textBoxYear.Visible = false;
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
            // 
            // panelDay
            // 
            this.panelDay.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.panelDay.Location = new System.Drawing.Point(73, 119);
            this.panelDay.Name = "panelDay";
            this.panelDay.Size = new System.Drawing.Size(755, 331);
            this.panelDay.TabIndex = 1;
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
            this.panelWeek.Location = new System.Drawing.Point(73, 80);
            this.panelWeek.Name = "panelWeek";
            this.panelWeek.Size = new System.Drawing.Size(755, 39);
            this.panelWeek.TabIndex = 1;
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
            // buttonToday
            // 
            this.buttonToday.FlatAppearance.BorderSize = 0;
            this.buttonToday.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonToday.Font = new System.Drawing.Font("Ebrima", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonToday.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.buttonToday.Image = ((System.Drawing.Image)(resources.GetObject("buttonToday.Image")));
            this.buttonToday.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.buttonToday.Location = new System.Drawing.Point(3, 196);
            this.buttonToday.Name = "buttonToday";
            this.buttonToday.Size = new System.Drawing.Size(69, 87);
            this.buttonToday.TabIndex = 2;
            this.buttonToday.Text = "TODAY";
            this.buttonToday.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.buttonToday.UseVisualStyleBackColor = true;
            this.buttonToday.Click += new System.EventHandler(this.buttonToday_Click);
            // 
            // buttonJump
            // 
            this.buttonJump.FlatAppearance.BorderSize = 0;
            this.buttonJump.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonJump.Font = new System.Drawing.Font("Ebrima", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonJump.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.buttonJump.Image = ((System.Drawing.Image)(resources.GetObject("buttonJump.Image")));
            this.buttonJump.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.buttonJump.Location = new System.Drawing.Point(829, 196);
            this.buttonJump.Name = "buttonJump";
            this.buttonJump.Size = new System.Drawing.Size(69, 87);
            this.buttonJump.TabIndex = 2;
            this.buttonJump.Text = "JUMP";
            this.buttonJump.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.buttonJump.UseVisualStyleBackColor = true;
            this.buttonJump.Click += new System.EventHandler(this.buttonJump_Click);
            // 
            // CalendarPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(30)))), ((int)(((byte)(35)))));
            this.Controls.Add(this.buttonJump);
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
        private System.Windows.Forms.Button buttonJump;
    }
}
