using System;

namespace Daily.Forms
{
    partial class LoginForm
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
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
            this.PanelTitle = new System.Windows.Forms.Panel();
            this.buttonMinus = new System.Windows.Forms.Button();
            this.buttonClose = new System.Windows.Forms.Button();
            this.labelTitle2 = new System.Windows.Forms.Label();
            this.labelTitle1 = new System.Windows.Forms.Label();
            this.labelName = new System.Windows.Forms.Label();
            this.pictureBoxLogo = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.labelLogin = new System.Windows.Forms.Label();
            this.pictureBoxUser = new System.Windows.Forms.PictureBox();
            this.pictureBoxPass = new System.Windows.Forms.PictureBox();
            this.textBoxUser = new System.Windows.Forms.TextBox();
            this.textBoxPass = new System.Windows.Forms.TextBox();
            this.labelForget = new System.Windows.Forms.Label();
            this.panelUser = new System.Windows.Forms.Panel();
            this.panelPass = new System.Windows.Forms.Panel();
            this.circularButtonLogin = new Daily.CircularButton();
            this.dragControl1 = new Daily.DragControl();
            this.dragControl2 = new Daily.DragControl();
            this.dragControl3 = new Daily.DragControl();
            this.dragControl4 = new Daily.DragControl();
            this.dragControl5 = new Daily.DragControl();
            this.PanelTitle.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxUser)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPass)).BeginInit();
            this.SuspendLayout();
            // 
            // PanelTitle
            // 
            this.PanelTitle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
            this.PanelTitle.Controls.Add(this.buttonMinus);
            this.PanelTitle.Controls.Add(this.buttonClose);
            this.PanelTitle.Controls.Add(this.labelTitle2);
            this.PanelTitle.Controls.Add(this.labelTitle1);
            this.PanelTitle.Controls.Add(this.labelName);
            this.PanelTitle.Controls.Add(this.pictureBoxLogo);
            this.PanelTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.PanelTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(180)))), ((int)(((byte)(192)))));
            this.PanelTitle.Location = new System.Drawing.Point(0, 0);
            this.PanelTitle.Name = "PanelTitle";
            this.PanelTitle.Size = new System.Drawing.Size(465, 160);
            this.PanelTitle.TabIndex = 0;
            // 
            // buttonMinus
            // 
            this.buttonMinus.FlatAppearance.BorderSize = 0;
            this.buttonMinus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonMinus.Image = ((System.Drawing.Image)(resources.GetObject("buttonMinus.Image")));
            this.buttonMinus.Location = new System.Drawing.Point(387, 6);
            this.buttonMinus.Name = "buttonMinus";
            this.buttonMinus.Size = new System.Drawing.Size(34, 23);
            this.buttonMinus.TabIndex = 5;
            this.buttonMinus.UseVisualStyleBackColor = true;
            this.buttonMinus.Click += new System.EventHandler(this.buttonMinus_Click);
            // 
            // buttonClose
            // 
            this.buttonClose.FlatAppearance.BorderSize = 0;
            this.buttonClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonClose.Image = ((System.Drawing.Image)(resources.GetObject("buttonClose.Image")));
            this.buttonClose.Location = new System.Drawing.Point(426, 3);
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.Size = new System.Drawing.Size(36, 29);
            this.buttonClose.TabIndex = 4;
            this.buttonClose.UseVisualStyleBackColor = true;
            this.buttonClose.Click += new System.EventHandler(this.buttonClose_Click);
            // 
            // labelTitle2
            // 
            this.labelTitle2.AutoSize = true;
            this.labelTitle2.Font = new System.Drawing.Font("Impact", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTitle2.Location = new System.Drawing.Point(262, 75);
            this.labelTitle2.Name = "labelTitle2";
            this.labelTitle2.Size = new System.Drawing.Size(115, 60);
            this.labelTitle2.TabIndex = 3;
            this.labelTitle2.Text = "TIME";
            // 
            // labelTitle1
            // 
            this.labelTitle1.AutoSize = true;
            this.labelTitle1.Font = new System.Drawing.Font("Impact", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTitle1.Location = new System.Drawing.Point(213, 41);
            this.labelTitle1.Name = "labelTitle1";
            this.labelTitle1.Size = new System.Drawing.Size(220, 34);
            this.labelTitle1.TabIndex = 2;
            this.labelTitle1.Text = "MASTER YOUR OWN";
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(180)))), ((int)(((byte)(192)))));
            this.labelName.Location = new System.Drawing.Point(3, 9);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(95, 12);
            this.labelName.TabIndex = 1;
            this.labelName.Text = "TimeMaster v1.0";
            // 
            // pictureBoxLogo
            // 
            this.pictureBoxLogo.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxLogo.Image")));
            this.pictureBoxLogo.Location = new System.Drawing.Point(81, 41);
            this.pictureBoxLogo.Name = "pictureBoxLogo";
            this.pictureBoxLogo.Size = new System.Drawing.Size(95, 96);
            this.pictureBoxLogo.TabIndex = 0;
            this.pictureBoxLogo.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 160);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(465, 1);
            this.panel1.TabIndex = 2;
            // 
            // labelLogin
            // 
            this.labelLogin.AutoSize = true;
            this.labelLogin.Font = new System.Drawing.Font("Lucida Console", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelLogin.Location = new System.Drawing.Point(336, 186);
            this.labelLogin.Name = "labelLogin";
            this.labelLogin.Size = new System.Drawing.Size(52, 15);
            this.labelLogin.TabIndex = 5;
            this.labelLogin.Text = "LOGIN";
            // 
            // pictureBoxUser
            // 
            this.pictureBoxUser.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxUser.Image")));
            this.pictureBoxUser.Location = new System.Drawing.Point(62, 203);
            this.pictureBoxUser.Name = "pictureBoxUser";
            this.pictureBoxUser.Size = new System.Drawing.Size(27, 29);
            this.pictureBoxUser.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxUser.TabIndex = 6;
            this.pictureBoxUser.TabStop = false;
            // 
            // pictureBoxPass
            // 
            this.pictureBoxPass.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxPass.Image")));
            this.pictureBoxPass.Location = new System.Drawing.Point(62, 254);
            this.pictureBoxPass.Name = "pictureBoxPass";
            this.pictureBoxPass.Size = new System.Drawing.Size(27, 28);
            this.pictureBoxPass.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxPass.TabIndex = 6;
            this.pictureBoxPass.TabStop = false;
            // 
            // textBoxUser
            // 
            this.textBoxUser.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
            this.textBoxUser.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxUser.Font = new System.Drawing.Font("宋体", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.textBoxUser.ForeColor = System.Drawing.Color.Gray;
            this.textBoxUser.HideSelection = false;
            this.textBoxUser.Location = new System.Drawing.Point(101, 212);
            this.textBoxUser.Name = "textBoxUser";
            this.textBoxUser.Size = new System.Drawing.Size(154, 15);
            this.textBoxUser.TabIndex = 7;
            this.textBoxUser.Text = "username";
            this.textBoxUser.Click += new System.EventHandler(this.textBoxUser_Click);
            // 
            // textBoxPass
            // 
            this.textBoxPass.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
            this.textBoxPass.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxPass.Font = new System.Drawing.Font("宋体", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.textBoxPass.ForeColor = System.Drawing.Color.Gray;
            this.textBoxPass.HideSelection = false;
            this.textBoxPass.Location = new System.Drawing.Point(101, 264);
            this.textBoxPass.Name = "textBoxPass";
            this.textBoxPass.PasswordChar = '*';
            this.textBoxPass.Size = new System.Drawing.Size(154, 15);
            this.textBoxPass.TabIndex = 7;
            this.textBoxPass.Text = "password";
            this.textBoxPass.Click += new System.EventHandler(this.textBoxPass_Click);
            // 
            // labelForget
            // 
            this.labelForget.AutoSize = true;
            this.labelForget.Cursor = System.Windows.Forms.Cursors.Hand;
            this.labelForget.Font = new System.Drawing.Font("宋体", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labelForget.Location = new System.Drawing.Point(57, 306);
            this.labelForget.Name = "labelForget";
            this.labelForget.Size = new System.Drawing.Size(119, 13);
            this.labelForget.TabIndex = 8;
            this.labelForget.Text = "Forget password?";
            // 
            // panelUser
            // 
            this.panelUser.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.panelUser.Location = new System.Drawing.Point(100, 228);
            this.panelUser.Name = "panelUser";
            this.panelUser.Size = new System.Drawing.Size(157, 1);
            this.panelUser.TabIndex = 9;
            // 
            // panelPass
            // 
            this.panelPass.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.panelPass.Location = new System.Drawing.Point(100, 279);
            this.panelPass.Name = "panelPass";
            this.panelPass.Size = new System.Drawing.Size(157, 1);
            this.panelPass.TabIndex = 9;
            // 
            // circularButtonLogin
            // 
            this.circularButtonLogin.FlatAppearance.BorderSize = 0;
            this.circularButtonLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.circularButtonLogin.Image = ((System.Drawing.Image)(resources.GetObject("circularButtonLogin.Image")));
            this.circularButtonLogin.Location = new System.Drawing.Point(301, 204);
            this.circularButtonLogin.Name = "circularButtonLogin";
            this.circularButtonLogin.Size = new System.Drawing.Size(120, 115);
            this.circularButtonLogin.TabIndex = 4;
            this.circularButtonLogin.UseVisualStyleBackColor = true;
            this.circularButtonLogin.Click += new System.EventHandler(this.circularButtonLogin_Click);
            // 
            // dragControl1
            // 
            this.dragControl1.SelectControl = this.PanelTitle;
            // 
            // dragControl2
            // 
            this.dragControl2.SelectControl = this.labelTitle1;
            // 
            // dragControl3
            // 
            this.dragControl3.SelectControl = this.labelTitle2;
            // 
            // dragControl4
            // 
            this.dragControl4.SelectControl = this.pictureBoxLogo;
            // 
            // dragControl5
            // 
            this.dragControl5.SelectControl = this.labelName;
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
            this.ClientSize = new System.Drawing.Size(465, 335);
            this.Controls.Add(this.panelPass);
            this.Controls.Add(this.panelUser);
            this.Controls.Add(this.labelForget);
            this.Controls.Add(this.textBoxPass);
            this.Controls.Add(this.textBoxUser);
            this.Controls.Add(this.pictureBoxPass);
            this.Controls.Add(this.pictureBoxUser);
            this.Controls.Add(this.labelLogin);
            this.Controls.Add(this.circularButtonLogin);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.PanelTitle);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(180)))), ((int)(((byte)(192)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "LoginForm";
            this.Text = "Form1";
            this.PanelTitle.ResumeLayout(false);
            this.PanelTitle.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxUser)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPass)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

       
        #endregion

        private System.Windows.Forms.Panel PanelTitle;
        private System.Windows.Forms.PictureBox pictureBoxLogo;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.Label labelTitle1;
        private System.Windows.Forms.Label labelTitle2;
        private System.Windows.Forms.Button buttonClose;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button buttonMinus;
        private CircularButton circularButtonLogin;
        private System.Windows.Forms.Label labelLogin;
        private System.Windows.Forms.PictureBox pictureBoxUser;
        private System.Windows.Forms.PictureBox pictureBoxPass;
        private System.Windows.Forms.TextBox textBoxUser;
        private System.Windows.Forms.TextBox textBoxPass;
        private System.Windows.Forms.Label labelForget;
        private System.Windows.Forms.Panel panelUser;
        private System.Windows.Forms.Panel panelPass;
        private DragControl dragControl1;
        private DragControl dragControl2;
        private DragControl dragControl3;
        private DragControl dragControl4;
        private DragControl dragControl5;
    }
}

