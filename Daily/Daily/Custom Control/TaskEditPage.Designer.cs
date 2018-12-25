namespace Daily.Custom_Control
{
    partial class TaskEditPage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TaskEditPage));
            this.buttonBack = new System.Windows.Forms.Button();
            this.labelDate = new System.Windows.Forms.Label();
            this.panelEdit = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.textBoxDetails = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.labelAll = new System.Windows.Forms.Label();
            this.Else = new Daily.CircularPictureBox();
            this.Graduation = new Daily.CircularPictureBox();
            this.Anniversary = new Daily.CircularPictureBox();
            this.AllDay = new Daily.CircularPictureBox();
            this.Birthday = new Daily.CircularPictureBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.labelEnd = new System.Windows.Forms.Label();
            this.labelStart = new System.Windows.Forms.Label();
            this.buttonChoose = new System.Windows.Forms.Button();
            this.textBoxEnd = new System.Windows.Forms.TextBox();
            this.textBoxStart = new System.Windows.Forms.TextBox();
            this.textBoxLocation = new System.Windows.Forms.TextBox();
            this.textBoxTitle = new System.Windows.Forms.TextBox();
            this.Save = new System.Windows.Forms.Button();
            this.Delete = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.panelEdit.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Else)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Graduation)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Anniversary)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.AllDay)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Birthday)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonBack
            // 
            this.buttonBack.FlatAppearance.BorderSize = 0;
            this.buttonBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonBack.Image = ((System.Drawing.Image)(resources.GetObject("buttonBack.Image")));
            this.buttonBack.Location = new System.Drawing.Point(15, 4);
            this.buttonBack.Name = "buttonBack";
            this.buttonBack.Size = new System.Drawing.Size(48, 47);
            this.buttonBack.TabIndex = 0;
            this.buttonBack.UseVisualStyleBackColor = true;
            // 
            // labelDate
            // 
            this.labelDate.AutoSize = true;
            this.labelDate.Font = new System.Drawing.Font("Lucida Sans Unicode", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.labelDate.Location = new System.Drawing.Point(315, 14);
            this.labelDate.Name = "labelDate";
            this.labelDate.Size = new System.Drawing.Size(261, 20);
            this.labelDate.TabIndex = 1;
            this.labelDate.Text = "25 December 2018, Tuesday";
            // 
            // panelEdit
            // 
            this.panelEdit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.panelEdit.Controls.Add(this.panel1);
            this.panelEdit.Controls.Add(this.pictureBox1);
            this.panelEdit.Controls.Add(this.label6);
            this.panelEdit.Controls.Add(this.label4);
            this.panelEdit.Controls.Add(this.label3);
            this.panelEdit.Controls.Add(this.label2);
            this.panelEdit.Controls.Add(this.labelAll);
            this.panelEdit.Controls.Add(this.Else);
            this.panelEdit.Controls.Add(this.Graduation);
            this.panelEdit.Controls.Add(this.Anniversary);
            this.panelEdit.Controls.Add(this.AllDay);
            this.panelEdit.Controls.Add(this.Birthday);
            this.panelEdit.Controls.Add(this.label5);
            this.panelEdit.Controls.Add(this.label1);
            this.panelEdit.Controls.Add(this.labelEnd);
            this.panelEdit.Controls.Add(this.label7);
            this.panelEdit.Controls.Add(this.labelStart);
            this.panelEdit.Controls.Add(this.buttonChoose);
            this.panelEdit.Controls.Add(this.textBoxEnd);
            this.panelEdit.Controls.Add(this.textBoxStart);
            this.panelEdit.Controls.Add(this.textBoxLocation);
            this.panelEdit.Controls.Add(this.textBoxTitle);
            this.panelEdit.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelEdit.Location = new System.Drawing.Point(0, 57);
            this.panelEdit.Name = "panelEdit";
            this.panelEdit.Size = new System.Drawing.Size(900, 393);
            this.panelEdit.TabIndex = 2;
            this.panelEdit.Paint += new System.Windows.Forms.PaintEventHandler(this.panelEdit_Paint);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(30)))), ((int)(((byte)(35)))));
            this.panel1.Controls.Add(this.textBoxDetails);
            this.panel1.Location = new System.Drawing.Point(122, 280);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(747, 90);
            this.panel1.TabIndex = 6;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // textBoxDetails
            // 
            this.textBoxDetails.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(30)))), ((int)(((byte)(35)))));
            this.textBoxDetails.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxDetails.Dock = System.Windows.Forms.DockStyle.Top;
            this.textBoxDetails.Font = new System.Drawing.Font("Segoe Script", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxDetails.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.textBoxDetails.Location = new System.Drawing.Point(0, 0);
            this.textBoxDetails.Name = "textBoxDetails";
            this.textBoxDetails.Size = new System.Drawing.Size(747, 21);
            this.textBoxDetails.TabIndex = 0;
            this.textBoxDetails.Text = "Details";
            this.textBoxDetails.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBoxDetails.Click += new System.EventHandler(this.textBoxDetails_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(36, 149);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(50, 51);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label6.Font = new System.Drawing.Font("Segoe Script", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(668, 224);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(46, 27);
            this.label6.TabIndex = 4;
            this.label6.Text = "Else";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Cursor = System.Windows.Forms.Cursors.Default;
            this.label4.Font = new System.Drawing.Font("Segoe Script", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(496, 224);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(113, 27);
            this.label4.TabIndex = 4;
            this.label4.Text = "Graduation";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Cursor = System.Windows.Forms.Cursors.Default;
            this.label3.Font = new System.Drawing.Font("Segoe Script", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(316, 224);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(118, 27);
            this.label3.TabIndex = 4;
            this.label3.Text = "Anniversary";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Cursor = System.Windows.Forms.Cursors.Default;
            this.label2.Font = new System.Drawing.Font("Segoe Script", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(172, 224);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 27);
            this.label2.TabIndex = 4;
            this.label2.Text = "Birthday";
            // 
            // labelAll
            // 
            this.labelAll.AutoSize = true;
            this.labelAll.Cursor = System.Windows.Forms.Cursors.Default;
            this.labelAll.Font = new System.Drawing.Font("Segoe Script", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAll.Location = new System.Drawing.Point(439, 86);
            this.labelAll.Name = "labelAll";
            this.labelAll.Size = new System.Drawing.Size(95, 31);
            this.labelAll.TabIndex = 4;
            this.labelAll.Text = "All Day";
            // 
            // Else
            // 
            this.Else.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Else.Image = ((System.Drawing.Image)(resources.GetObject("Else.Image")));
            this.Else.Location = new System.Drawing.Point(618, 212);
            this.Else.Name = "Else";
            this.Else.Size = new System.Drawing.Size(44, 49);
            this.Else.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Else.TabIndex = 3;
            this.Else.TabStop = false;
            this.Else.Click += new System.EventHandler(this.Else_Click);
            // 
            // Graduation
            // 
            this.Graduation.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Graduation.Image = ((System.Drawing.Image)(resources.GetObject("Graduation.Image")));
            this.Graduation.Location = new System.Drawing.Point(446, 212);
            this.Graduation.Name = "Graduation";
            this.Graduation.Size = new System.Drawing.Size(44, 49);
            this.Graduation.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Graduation.TabIndex = 3;
            this.Graduation.TabStop = false;
            this.Graduation.Click += new System.EventHandler(this.Graduation_Click);
            // 
            // Anniversary
            // 
            this.Anniversary.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Anniversary.Image = ((System.Drawing.Image)(resources.GetObject("Anniversary.Image")));
            this.Anniversary.Location = new System.Drawing.Point(266, 212);
            this.Anniversary.Name = "Anniversary";
            this.Anniversary.Size = new System.Drawing.Size(44, 49);
            this.Anniversary.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Anniversary.TabIndex = 3;
            this.Anniversary.TabStop = false;
            this.Anniversary.Click += new System.EventHandler(this.Anniversary_Click);
            // 
            // AllDay
            // 
            this.AllDay.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AllDay.Image = ((System.Drawing.Image)(resources.GetObject("AllDay.Image")));
            this.AllDay.Location = new System.Drawing.Point(362, 69);
            this.AllDay.Name = "AllDay";
            this.AllDay.Size = new System.Drawing.Size(71, 66);
            this.AllDay.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.AllDay.TabIndex = 3;
            this.AllDay.TabStop = false;
            this.AllDay.Click += new System.EventHandler(this.AllDay_Click);
            // 
            // Birthday
            // 
            this.Birthday.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Birthday.Image = ((System.Drawing.Image)(resources.GetObject("Birthday.Image")));
            this.Birthday.Location = new System.Drawing.Point(122, 212);
            this.Birthday.Name = "Birthday";
            this.Birthday.Size = new System.Drawing.Size(44, 49);
            this.Birthday.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Birthday.TabIndex = 3;
            this.Birthday.TabStop = false;
            this.Birthday.Click += new System.EventHandler(this.Birthday_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(31, 303);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(70, 18);
            this.label5.TabIndex = 2;
            this.label5.Text = "Details:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(32, 228);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 18);
            this.label1.TabIndex = 2;
            this.label1.Text = "Events:";
            // 
            // labelEnd
            // 
            this.labelEnd.AutoSize = true;
            this.labelEnd.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelEnd.Location = new System.Drawing.Point(23, 111);
            this.labelEnd.Name = "labelEnd";
            this.labelEnd.Size = new System.Drawing.Size(84, 18);
            this.labelEnd.TabIndex = 2;
            this.labelEnd.Text = "EndTime:";
            // 
            // labelStart
            // 
            this.labelStart.AutoSize = true;
            this.labelStart.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelStart.Location = new System.Drawing.Point(12, 73);
            this.labelStart.Name = "labelStart";
            this.labelStart.Size = new System.Drawing.Size(96, 18);
            this.labelStart.TabIndex = 2;
            this.labelStart.Text = "StartTime:";
            // 
            // buttonChoose
            // 
            this.buttonChoose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonChoose.FlatAppearance.BorderSize = 0;
            this.buttonChoose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonChoose.Image = ((System.Drawing.Image)(resources.GetObject("buttonChoose.Image")));
            this.buttonChoose.Location = new System.Drawing.Point(34, 0);
            this.buttonChoose.Name = "buttonChoose";
            this.buttonChoose.Size = new System.Drawing.Size(52, 58);
            this.buttonChoose.TabIndex = 1;
            this.buttonChoose.UseVisualStyleBackColor = true;
            // 
            // textBoxEnd
            // 
            this.textBoxEnd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(30)))), ((int)(((byte)(35)))));
            this.textBoxEnd.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxEnd.Font = new System.Drawing.Font("Segoe Script", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxEnd.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.textBoxEnd.Location = new System.Drawing.Point(122, 108);
            this.textBoxEnd.Name = "textBoxEnd";
            this.textBoxEnd.Size = new System.Drawing.Size(188, 20);
            this.textBoxEnd.TabIndex = 0;
            this.textBoxEnd.Text = "9:00 PM";
            this.textBoxEnd.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBoxEnd.Click += new System.EventHandler(this.textBoxEnd_Click);
            // 
            // textBoxStart
            // 
            this.textBoxStart.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(30)))), ((int)(((byte)(35)))));
            this.textBoxStart.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxStart.Font = new System.Drawing.Font("Segoe Script", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxStart.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.textBoxStart.Location = new System.Drawing.Point(122, 70);
            this.textBoxStart.Name = "textBoxStart";
            this.textBoxStart.Size = new System.Drawing.Size(188, 20);
            this.textBoxStart.TabIndex = 0;
            this.textBoxStart.Text = "9:00 AM";
            this.textBoxStart.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBoxStart.Click += new System.EventHandler(this.textBoxStart_Click);
            // 
            // textBoxLocation
            // 
            this.textBoxLocation.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(30)))), ((int)(((byte)(35)))));
            this.textBoxLocation.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxLocation.Font = new System.Drawing.Font("Segoe Script", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxLocation.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.textBoxLocation.Location = new System.Drawing.Point(122, 168);
            this.textBoxLocation.Name = "textBoxLocation";
            this.textBoxLocation.Size = new System.Drawing.Size(747, 25);
            this.textBoxLocation.TabIndex = 0;
            this.textBoxLocation.Text = "Location";
            this.textBoxLocation.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBoxLocation.Click += new System.EventHandler(this.textBoxLocation_Click);
            // 
            // textBoxTitle
            // 
            this.textBoxTitle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(30)))), ((int)(((byte)(35)))));
            this.textBoxTitle.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxTitle.Font = new System.Drawing.Font("Segoe Script", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.textBoxTitle.Location = new System.Drawing.Point(122, 16);
            this.textBoxTitle.Name = "textBoxTitle";
            this.textBoxTitle.Size = new System.Drawing.Size(747, 25);
            this.textBoxTitle.TabIndex = 0;
            this.textBoxTitle.Text = "Title";
            this.textBoxTitle.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBoxTitle.Click += new System.EventHandler(this.textBoxTitle_Click);
            // 
            // Save
            // 
            this.Save.FlatAppearance.BorderSize = 0;
            this.Save.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Save.Image = ((System.Drawing.Image)(resources.GetObject("Save.Image")));
            this.Save.Location = new System.Drawing.Point(734, 9);
            this.Save.Name = "Save";
            this.Save.Size = new System.Drawing.Size(47, 47);
            this.Save.TabIndex = 3;
            this.Save.UseVisualStyleBackColor = true;
            this.Save.Click += new System.EventHandler(this.Save_Click);
            // 
            // Delete
            // 
            this.Delete.FlatAppearance.BorderSize = 0;
            this.Delete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Delete.Image = ((System.Drawing.Image)(resources.GetObject("Delete.Image")));
            this.Delete.Location = new System.Drawing.Point(801, 9);
            this.Delete.Name = "Delete";
            this.Delete.Size = new System.Drawing.Size(47, 47);
            this.Delete.TabIndex = 4;
            this.Delete.UseVisualStyleBackColor = true;
            this.Delete.Click += new System.EventHandler(this.Delete_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(579, 93);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(68, 18);
            this.label7.TabIndex = 2;
            this.label7.Text = "Status:";
            // 
            // TaskEditPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(30)))), ((int)(((byte)(35)))));
            this.Controls.Add(this.Delete);
            this.Controls.Add(this.Save);
            this.Controls.Add(this.panelEdit);
            this.Controls.Add(this.labelDate);
            this.Controls.Add(this.buttonBack);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.Name = "TaskEditPage";
            this.Size = new System.Drawing.Size(900, 450);
            this.Load += new System.EventHandler(this.TaskEditPage_Load);
            this.panelEdit.ResumeLayout(false);
            this.panelEdit.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Else)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Graduation)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Anniversary)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.AllDay)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Birthday)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonBack;
        private System.Windows.Forms.Label labelDate;
        private System.Windows.Forms.Panel panelEdit;
        private System.Windows.Forms.TextBox textBoxTitle;
        private System.Windows.Forms.Button buttonChoose;
        private System.Windows.Forms.Label labelEnd;
        private System.Windows.Forms.Label labelStart;
        private System.Windows.Forms.TextBox textBoxEnd;
        private System.Windows.Forms.TextBox textBoxStart;
        private CircularPictureBox Birthday;
        private System.Windows.Forms.Label labelAll;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox textBoxLocation;
        private System.Windows.Forms.Label label1;
        private CircularPictureBox Else;
        private CircularPictureBox Graduation;
        private CircularPictureBox Anniversary;
        private CircularPictureBox AllDay;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox textBoxDetails;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button Save;
        private System.Windows.Forms.Button Delete;
        private System.Windows.Forms.Label label7;
    }
}
