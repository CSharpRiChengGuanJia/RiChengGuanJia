namespace Daily.Custom_Control
{
    partial class RecentTask
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
            this.labelTask = new System.Windows.Forms.Label();
            this.labelTime = new System.Windows.Forms.Label();
            this.ellipseControl1 = new Daily.UI.EllipseControl();
            this.SuspendLayout();
            // 
            // labelTask
            // 
            this.labelTask.AutoSize = true;
            this.labelTask.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTask.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.labelTask.Location = new System.Drawing.Point(20, 13);
            this.labelTask.Name = "labelTask";
            this.labelTask.Size = new System.Drawing.Size(71, 18);
            this.labelTask.TabIndex = 0;
            this.labelTask.Text = "OneTask";
            // 
            // labelTime
            // 
            this.labelTime.AutoSize = true;
            this.labelTime.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTime.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.labelTime.Location = new System.Drawing.Point(125, 13);
            this.labelTime.Name = "labelTime";
            this.labelTime.Size = new System.Drawing.Size(40, 16);
            this.labelTime.TabIndex = 0;
            this.labelTime.Text = "Time";
            // 
            // ellipseControl1
            // 
            this.ellipseControl1.CornerRadius = 30;
            this.ellipseControl1.TargetControl = this;
            // 
            // RecentTask
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.Controls.Add(this.labelTime);
            this.Controls.Add(this.labelTask);
            this.Name = "RecentTask";
            this.Size = new System.Drawing.Size(205, 45);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private UI.EllipseControl ellipseControl1;
        private System.Windows.Forms.Label labelTask;
        private System.Windows.Forms.Label labelTime;
    }
}
