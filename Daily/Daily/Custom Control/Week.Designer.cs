namespace Daily.Custom_Control
{
    partial class Week
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
            this.ellipseControl1 = new Daily.UI.EllipseControl();
            this.labelWeek = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // ellipseControl1
            // 
            this.ellipseControl1.CornerRadius = 10;
            this.ellipseControl1.TargetControl = this;
            // 
            // labelWeek
            // 
            this.labelWeek.AutoSize = true;
            this.labelWeek.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelWeek.Location = new System.Drawing.Point(8, 3);
            this.labelWeek.Name = "labelWeek";
            this.labelWeek.Size = new System.Drawing.Size(54, 30);
            this.labelWeek.TabIndex = 0;
            this.labelWeek.Text = "Mon";
            this.labelWeek.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Week
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(95)))), ((int)(((byte)(95)))));
            this.Controls.Add(this.labelWeek);
            this.ForeColor = System.Drawing.Color.White;
            this.Name = "Week";
            this.Size = new System.Drawing.Size(70, 39);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private UI.EllipseControl ellipseControl1;
        private System.Windows.Forms.Label labelWeek;
    }
}
