namespace Daily.Custom_Control
{
    partial class HomePage
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HomePage));
            this.labelDay = new System.Windows.Forms.Label();
            this.labelDate = new System.Windows.Forms.Label();
            this.pictureBoxWeather = new System.Windows.Forms.PictureBox();
            this.labelTemprature = new System.Windows.Forms.Label();
            this.labelCity = new System.Windows.Forms.Label();
            this.labelWeather = new System.Windows.Forms.Label();
            this.labelAir = new System.Windows.Forms.Label();
            this.labelC = new System.Windows.Forms.Label();
            this.labelHour = new System.Windows.Forms.Label();
            this.labelMin = new System.Windows.Forms.Label();
            this.panelMid = new System.Windows.Forms.Panel();
            this.panelLeft = new System.Windows.Forms.Panel();
            this.panelRight = new System.Windows.Forms.Panel();
            this.timerClock = new System.Windows.Forms.Timer(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.buttonUp = new System.Windows.Forms.Button();
            this.timerUp = new System.Windows.Forms.Timer(this.components);
            this.buttonClose = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.labelRecent = new System.Windows.Forms.Label();
            this.timerEffect = new System.Windows.Forms.Timer(this.components);
            this.timerEffect2 = new System.Windows.Forms.Timer(this.components);
            this.recentTask3 = new Daily.Custom_Control.RecentTask();
            this.recentTask2 = new Daily.Custom_Control.RecentTask();
            this.recentTask1 = new Daily.Custom_Control.RecentTask();
            this.ButtonTask = new Daily.CircularButton();
            this.ButtonAdd = new Daily.CircularButton();
            this.PictureBoxUser = new Daily.CircularPictureBox();
            this.ellipseControl1 = new Daily.UI.EllipseControl();
            this.timerEffect3 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxWeather)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBoxUser)).BeginInit();
            this.SuspendLayout();
            // 
            // labelDay
            // 
            this.labelDay.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.labelDay.AutoSize = true;
            this.labelDay.Font = new System.Drawing.Font("Impact", 72F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDay.ForeColor = System.Drawing.Color.Azure;
            this.labelDay.Location = new System.Drawing.Point(478, 36);
            this.labelDay.Name = "labelDay";
            this.labelDay.Size = new System.Drawing.Size(149, 117);
            this.labelDay.TabIndex = 0;
            this.labelDay.Text = "23";
            // 
            // labelDate
            // 
            this.labelDate.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.labelDate.AutoSize = true;
            this.labelDate.Font = new System.Drawing.Font("Calibri", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDate.ForeColor = System.Drawing.Color.Azure;
            this.labelDate.Location = new System.Drawing.Point(613, 36);
            this.labelDate.Name = "labelDate";
            this.labelDate.Size = new System.Drawing.Size(232, 118);
            this.labelDate.TabIndex = 0;
            this.labelDate.Text = "May 2017,\r\nFriday";
            // 
            // pictureBoxWeather
            // 
            this.pictureBoxWeather.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.pictureBoxWeather.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxWeather.Image")));
            this.pictureBoxWeather.Location = new System.Drawing.Point(50, 27);
            this.pictureBoxWeather.Name = "pictureBoxWeather";
            this.pictureBoxWeather.Size = new System.Drawing.Size(150, 144);
            this.pictureBoxWeather.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxWeather.TabIndex = 1;
            this.pictureBoxWeather.TabStop = false;
            this.pictureBoxWeather.Click += new System.EventHandler(this.pictureBoxWeather_Click);
            // 
            // labelTemprature
            // 
            this.labelTemprature.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.labelTemprature.AutoSize = true;
            this.labelTemprature.Font = new System.Drawing.Font("Arial", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTemprature.ForeColor = System.Drawing.Color.Azure;
            this.labelTemprature.Location = new System.Drawing.Point(220, 27);
            this.labelTemprature.Name = "labelTemprature";
            this.labelTemprature.Size = new System.Drawing.Size(104, 75);
            this.labelTemprature.TabIndex = 0;
            this.labelTemprature.Text = "03";
            this.labelTemprature.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // labelCity
            // 
            this.labelCity.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelCity.AutoSize = true;
            this.labelCity.Font = new System.Drawing.Font("Calibri", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCity.ForeColor = System.Drawing.Color.Azure;
            this.labelCity.Location = new System.Drawing.Point(307, 102);
            this.labelCity.Name = "labelCity";
            this.labelCity.Size = new System.Drawing.Size(99, 36);
            this.labelCity.TabIndex = 0;
            this.labelCity.Text = "Wuhan";
            // 
            // labelWeather
            // 
            this.labelWeather.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelWeather.AutoSize = true;
            this.labelWeather.Font = new System.Drawing.Font("Calibri", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelWeather.ForeColor = System.Drawing.Color.Azure;
            this.labelWeather.Location = new System.Drawing.Point(214, 102);
            this.labelWeather.Name = "labelWeather";
            this.labelWeather.Size = new System.Drawing.Size(83, 36);
            this.labelWeather.TabIndex = 0;
            this.labelWeather.Text = "Snow";
            // 
            // labelAir
            // 
            this.labelAir.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelAir.AutoSize = true;
            this.labelAir.Font = new System.Drawing.Font("Calibri", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAir.ForeColor = System.Drawing.Color.Azure;
            this.labelAir.Location = new System.Drawing.Point(208, 137);
            this.labelAir.Name = "labelAir";
            this.labelAir.Size = new System.Drawing.Size(210, 36);
            this.labelAir.TabIndex = 0;
            this.labelAir.Text = "Good air quality";
            this.labelAir.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // labelC
            // 
            this.labelC.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.labelC.AutoSize = true;
            this.labelC.Font = new System.Drawing.Font("Arial", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelC.ForeColor = System.Drawing.Color.Azure;
            this.labelC.Location = new System.Drawing.Point(303, 27);
            this.labelC.Name = "labelC";
            this.labelC.Size = new System.Drawing.Size(104, 75);
            this.labelC.TabIndex = 0;
            this.labelC.Text = "°C";
            // 
            // labelHour
            // 
            this.labelHour.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.labelHour.AutoSize = true;
            this.labelHour.Font = new System.Drawing.Font("Arial", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelHour.ForeColor = System.Drawing.Color.Azure;
            this.labelHour.Location = new System.Drawing.Point(314, 187);
            this.labelHour.Name = "labelHour";
            this.labelHour.Size = new System.Drawing.Size(104, 75);
            this.labelHour.TabIndex = 0;
            this.labelHour.Text = "03";
            this.labelHour.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // labelMin
            // 
            this.labelMin.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.labelMin.AutoSize = true;
            this.labelMin.Font = new System.Drawing.Font("Arial", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMin.ForeColor = System.Drawing.Color.Azure;
            this.labelMin.Location = new System.Drawing.Point(485, 187);
            this.labelMin.Name = "labelMin";
            this.labelMin.Size = new System.Drawing.Size(104, 75);
            this.labelMin.TabIndex = 0;
            this.labelMin.Text = "03";
            this.labelMin.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // panelMid
            // 
            this.panelMid.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.panelMid.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.panelMid.Location = new System.Drawing.Point(445, 171);
            this.panelMid.Name = "panelMid";
            this.panelMid.Size = new System.Drawing.Size(10, 100);
            this.panelMid.TabIndex = 2;
            // 
            // panelLeft
            // 
            this.panelLeft.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelLeft.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.panelLeft.Location = new System.Drawing.Point(0, 271);
            this.panelLeft.Name = "panelLeft";
            this.panelLeft.Size = new System.Drawing.Size(200, 3);
            this.panelLeft.TabIndex = 3;
            // 
            // panelRight
            // 
            this.panelRight.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelRight.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.panelRight.Location = new System.Drawing.Point(700, 271);
            this.panelRight.Name = "panelRight";
            this.panelRight.Size = new System.Drawing.Size(200, 3);
            this.panelRight.TabIndex = 3;
            // 
            // timerClock
            // 
            this.timerClock.Interval = 1;
            this.timerClock.Tick += new System.EventHandler(this.timerClock_Tick);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe Script", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.label1.Location = new System.Drawing.Point(30, 315);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(231, 144);
            this.label1.TabIndex = 5;
            this.label1.Text = "What do you \r\nwanna\r\ndo today?";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // buttonUp
            // 
            this.buttonUp.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.buttonUp.FlatAppearance.BorderSize = 0;
            this.buttonUp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonUp.Image = ((System.Drawing.Image)(resources.GetObject("buttonUp.Image")));
            this.buttonUp.Location = new System.Drawing.Point(3, 483);
            this.buttonUp.Name = "buttonUp";
            this.buttonUp.Size = new System.Drawing.Size(897, 37);
            this.buttonUp.TabIndex = 7;
            this.buttonUp.UseVisualStyleBackColor = true;
            this.buttonUp.Click += new System.EventHandler(this.buttonUp_Click);
            // 
            // timerUp
            // 
            this.timerUp.Interval = 3;
            this.timerUp.Tick += new System.EventHandler(this.timerUp_Tick);
            // 
            // buttonClose
            // 
            this.buttonClose.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.buttonClose.FlatAppearance.BorderSize = 0;
            this.buttonClose.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.buttonClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonClose.Image = ((System.Drawing.Image)(resources.GetObject("buttonClose.Image")));
            this.buttonClose.Location = new System.Drawing.Point(859, 12);
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.Size = new System.Drawing.Size(25, 25);
            this.buttonClose.TabIndex = 8;
            this.buttonClose.UseVisualStyleBackColor = true;
            this.buttonClose.Click += new System.EventHandler(this.buttonClose_Click);
            // 
            // panel1
            // 
            this.panel1.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.panel1.Controls.Add(this.recentTask3);
            this.panel1.Controls.Add(this.recentTask2);
            this.panel1.Controls.Add(this.recentTask1);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Location = new System.Drawing.Point(678, 280);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(205, 197);
            this.panel1.TabIndex = 9;
            // 
            // panel2
            // 
            this.panel2.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.panel2.Controls.Add(this.labelRecent);
            this.panel2.Location = new System.Drawing.Point(-1, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(206, 22);
            this.panel2.TabIndex = 0;
            // 
            // labelRecent
            // 
            this.labelRecent.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.labelRecent.AutoSize = true;
            this.labelRecent.Font = new System.Drawing.Font("Gadugi", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelRecent.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.labelRecent.Location = new System.Drawing.Point(62, 4);
            this.labelRecent.Name = "labelRecent";
            this.labelRecent.Size = new System.Drawing.Size(81, 17);
            this.labelRecent.TabIndex = 0;
            this.labelRecent.Text = "Recent Task";
            // 
            // timerEffect
            // 
            this.timerEffect.Interval = 1;
            this.timerEffect.Tick += new System.EventHandler(this.timerEffect_Tick);
            // 
            // timerEffect2
            // 
            this.timerEffect2.Interval = 1;
            this.timerEffect2.Tick += new System.EventHandler(this.timerEffect2_Tick);
            // 
            // recentTask3
            // 
            this.recentTask3.BackColor = System.Drawing.Color.Black;
            this.recentTask3.Location = new System.Drawing.Point(0, 126);
            this.recentTask3.Margin = new System.Windows.Forms.Padding(4);
            this.recentTask3.Name = "recentTask3";
            this.recentTask3.Size = new System.Drawing.Size(205, 45);
            this.recentTask3.TabIndex = 1;
            // 
            // recentTask2
            // 
            this.recentTask2.BackColor = System.Drawing.Color.Black;
            this.recentTask2.Location = new System.Drawing.Point(1, 77);
            this.recentTask2.Margin = new System.Windows.Forms.Padding(4);
            this.recentTask2.Name = "recentTask2";
            this.recentTask2.Size = new System.Drawing.Size(205, 45);
            this.recentTask2.TabIndex = 1;
            // 
            // recentTask1
            // 
            this.recentTask1.BackColor = System.Drawing.Color.Black;
            this.recentTask1.Location = new System.Drawing.Point(0, 27);
            this.recentTask1.Margin = new System.Windows.Forms.Padding(4);
            this.recentTask1.Name = "recentTask1";
            this.recentTask1.Size = new System.Drawing.Size(205, 45);
            this.recentTask1.TabIndex = 1;
            // 
            // ButtonTask
            // 
            this.ButtonTask.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.ButtonTask.BackColor = System.Drawing.Color.Black;
            this.ButtonTask.FlatAppearance.BorderSize = 0;
            this.ButtonTask.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(45)))), ((int)(((byte)(51)))));
            this.ButtonTask.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(42)))), ((int)(((byte)(44)))));
            this.ButtonTask.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonTask.Image = ((System.Drawing.Image)(resources.GetObject("ButtonTask.Image")));
            this.ButtonTask.Location = new System.Drawing.Point(568, 362);
            this.ButtonTask.Name = "ButtonTask";
            this.ButtonTask.Size = new System.Drawing.Size(61, 61);
            this.ButtonTask.TabIndex = 6;
            this.ButtonTask.UseVisualStyleBackColor = false;
            this.ButtonTask.Click += new System.EventHandler(this.ButtonTask_Click);
            // 
            // ButtonAdd
            // 
            this.ButtonAdd.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.ButtonAdd.BackColor = System.Drawing.Color.Black;
            this.ButtonAdd.FlatAppearance.BorderSize = 0;
            this.ButtonAdd.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(45)))), ((int)(((byte)(51)))));
            this.ButtonAdd.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(42)))), ((int)(((byte)(44)))));
            this.ButtonAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonAdd.Image = ((System.Drawing.Image)(resources.GetObject("ButtonAdd.Image")));
            this.ButtonAdd.Location = new System.Drawing.Point(279, 362);
            this.ButtonAdd.Name = "ButtonAdd";
            this.ButtonAdd.Size = new System.Drawing.Size(61, 61);
            this.ButtonAdd.TabIndex = 6;
            this.ButtonAdd.UseVisualStyleBackColor = false;
            this.ButtonAdd.Click += new System.EventHandler(this.ButtonAdd_Click);
            // 
            // PictureBoxUser
            // 
            this.PictureBoxUser.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.PictureBoxUser.Image = ((System.Drawing.Image)(resources.GetObject("PictureBoxUser.Image")));
            this.PictureBoxUser.Location = new System.Drawing.Point(389, 312);
            this.PictureBoxUser.Name = "PictureBoxUser";
            this.PictureBoxUser.Size = new System.Drawing.Size(120, 120);
            this.PictureBoxUser.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PictureBoxUser.TabIndex = 4;
            this.PictureBoxUser.TabStop = false;
            // 
            // ellipseControl1
            // 
            this.ellipseControl1.CornerRadius = 30;
            this.ellipseControl1.TargetControl = this;
            // 
            // timerEffect3
            // 
            this.timerEffect3.Interval = 1;
            this.timerEffect3.Tick += new System.EventHandler(this.timerEffect3_Tick);
            // 
            // HomePage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(42)))), ((int)(((byte)(49)))));
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.buttonClose);
            this.Controls.Add(this.buttonUp);
            this.Controls.Add(this.ButtonTask);
            this.Controls.Add(this.ButtonAdd);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.PictureBoxUser);
            this.Controls.Add(this.panelRight);
            this.Controls.Add(this.panelLeft);
            this.Controls.Add(this.panelMid);
            this.Controls.Add(this.pictureBoxWeather);
            this.Controls.Add(this.labelAir);
            this.Controls.Add(this.labelWeather);
            this.Controls.Add(this.labelCity);
            this.Controls.Add(this.labelDate);
            this.Controls.Add(this.labelC);
            this.Controls.Add(this.labelMin);
            this.Controls.Add(this.labelHour);
            this.Controls.Add(this.labelTemprature);
            this.Controls.Add(this.labelDay);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(180)))), ((int)(((byte)(192)))));
            this.Name = "HomePage";
            this.Size = new System.Drawing.Size(900, 520);
            this.Load += new System.EventHandler(this.HomePage_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxWeather)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBoxUser)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelDay;
        private System.Windows.Forms.Label labelDate;
        private System.Windows.Forms.PictureBox pictureBoxWeather;
        private System.Windows.Forms.Label labelTemprature;
        private System.Windows.Forms.Label labelCity;
        private System.Windows.Forms.Label labelWeather;
        private System.Windows.Forms.Label labelAir;
        private System.Windows.Forms.Label labelC;
        private System.Windows.Forms.Label labelHour;
        private System.Windows.Forms.Label labelMin;
        private System.Windows.Forms.Panel panelMid;
        private System.Windows.Forms.Panel panelLeft;
        private System.Windows.Forms.Panel panelRight;
        private System.Windows.Forms.Timer timerClock;
        private CircularPictureBox PictureBoxUser;
        private System.Windows.Forms.Label label1;
        private CircularButton ButtonAdd;
        private CircularButton ButtonTask;
        private System.Windows.Forms.Button buttonUp;
        private UI.EllipseControl ellipseControl1;
        private System.Windows.Forms.Timer timerUp;
        private System.Windows.Forms.Button buttonClose;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label labelRecent;
        private RecentTask recentTask1;
        private RecentTask recentTask3;
        private RecentTask recentTask2;
        private System.Windows.Forms.Timer timerEffect;
        private System.Windows.Forms.Timer timerEffect2;
        private System.Windows.Forms.Timer timerEffect3;
    }
}
