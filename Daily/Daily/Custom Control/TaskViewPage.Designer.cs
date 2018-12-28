﻿namespace Daily.Custom_Control
{
    partial class TaskViewPage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TaskViewPage));
            this.panelTop = new System.Windows.Forms.Panel();
            this.buttonWeek = new System.Windows.Forms.Button();
            this.buttonAll = new System.Windows.Forms.Button();
            this.buttonDay = new System.Windows.Forms.Button();
            this.Year = new System.Windows.Forms.Label();
            this.PanelTasks = new System.Windows.Forms.FlowLayoutPanel();
            this.eachTask1 = new Daily.Custom_Control.EachTask();
            this.panelTop.SuspendLayout();
            this.PanelTasks.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelTop
            // 
            this.panelTop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(30)))), ((int)(((byte)(35)))));
            this.panelTop.Controls.Add(this.buttonWeek);
            this.panelTop.Controls.Add(this.buttonAll);
            this.panelTop.Controls.Add(this.buttonDay);
            this.panelTop.Controls.Add(this.Year);
            this.panelTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTop.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.panelTop.Location = new System.Drawing.Point(0, 0);
            this.panelTop.Name = "panelTop";
            this.panelTop.Size = new System.Drawing.Size(900, 90);
            this.panelTop.TabIndex = 0;
            // 
            // buttonWeek
            // 
            this.buttonWeek.FlatAppearance.BorderSize = 0;
            this.buttonWeek.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonWeek.Image = ((System.Drawing.Image)(resources.GetObject("buttonWeek.Image")));
            this.buttonWeek.Location = new System.Drawing.Point(495, 50);
            this.buttonWeek.Name = "buttonWeek";
            this.buttonWeek.Size = new System.Drawing.Size(55, 37);
            this.buttonWeek.TabIndex = 2;
            this.buttonWeek.UseVisualStyleBackColor = true;
            this.buttonWeek.Click += new System.EventHandler(this.buttonWeek_Click);
            // 
            // buttonAll
            // 
            this.buttonAll.FlatAppearance.BorderSize = 0;
            this.buttonAll.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAll.Image = ((System.Drawing.Image)(resources.GetObject("buttonAll.Image")));
            this.buttonAll.Location = new System.Drawing.Point(347, 50);
            this.buttonAll.Name = "buttonAll";
            this.buttonAll.Size = new System.Drawing.Size(55, 37);
            this.buttonAll.TabIndex = 2;
            this.buttonAll.UseVisualStyleBackColor = true;
            this.buttonAll.Click += new System.EventHandler(this.buttonAll_Click);
            // 
            // buttonDay
            // 
            this.buttonDay.FlatAppearance.BorderSize = 0;
            this.buttonDay.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonDay.Image = ((System.Drawing.Image)(resources.GetObject("buttonDay.Image")));
            this.buttonDay.Location = new System.Drawing.Point(422, 50);
            this.buttonDay.Name = "buttonDay";
            this.buttonDay.Size = new System.Drawing.Size(55, 37);
            this.buttonDay.TabIndex = 2;
            this.buttonDay.UseVisualStyleBackColor = true;
            this.buttonDay.Click += new System.EventHandler(this.buttonDay_Click);
            // 
            // Year
            // 
            this.Year.AutoSize = true;
            this.Year.Font = new System.Drawing.Font("Trebuchet MS", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Year.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Year.Location = new System.Drawing.Point(418, 18);
            this.Year.Name = "Year";
            this.Year.Size = new System.Drawing.Size(69, 29);
            this.Year.TabIndex = 0;
            this.Year.Text = "2018";
            // 
            // PanelTasks
            // 
            this.PanelTasks.AutoScroll = true;
            this.PanelTasks.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.PanelTasks.Controls.Add(this.eachTask1);
            this.PanelTasks.Location = new System.Drawing.Point(67, 96);
            this.PanelTasks.Name = "PanelTasks";
            this.PanelTasks.Size = new System.Drawing.Size(765, 337);
            this.PanelTasks.TabIndex = 1;
            // 
            // eachTask1
            // 
            this.eachTask1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.eachTask1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.eachTask1.Location = new System.Drawing.Point(3, 3);
            this.eachTask1.Name = "eachTask1";
            this.eachTask1.Size = new System.Drawing.Size(367, 63);
            this.eachTask1.TabIndex = 0;
            // 
            // TaskViewPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.Controls.Add(this.PanelTasks);
            this.Controls.Add(this.panelTop);
            this.Name = "TaskViewPage";
            this.Size = new System.Drawing.Size(900, 450);
            this.panelTop.ResumeLayout(false);
            this.panelTop.PerformLayout();
            this.PanelTasks.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelTop;
        private System.Windows.Forms.Label Year;
        private System.Windows.Forms.Button buttonDay;
        private System.Windows.Forms.Button buttonWeek;
        private System.Windows.Forms.Button buttonAll;
        private System.Windows.Forms.FlowLayoutPanel PanelTasks;
        private EachTask eachTask1;
    }
}
