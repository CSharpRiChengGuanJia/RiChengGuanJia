namespace Daily.Forms
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.panelTop = new System.Windows.Forms.Panel();
            this.circularButtonDown = new Daily.CircularButton();
            this.circularButtonTheme = new Daily.CircularButton();
            this.circularButtonMinus = new Daily.CircularButton();
            this.circularButtonExit = new Daily.CircularButton();
            this.labelWelcome = new System.Windows.Forms.Label();
            this.labelTop = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.timerPanelLeft = new System.Windows.Forms.Timer(this.components);
            this.panelPage = new System.Windows.Forms.Panel();
            this.notifyIconTray = new System.Windows.Forms.NotifyIcon(this.components);
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.sHOWToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.eXITToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ellipseControlOut = new Daily.UI.EllipseControl();
            this.dragControl1 = new Daily.DragControl();
            this.dragControl2 = new Daily.DragControl();
            this.dragControl3 = new Daily.DragControl();
            this.dragControl4 = new Daily.DragControl();
            this.circularPictureBox1 = new Daily.CircularPictureBox();
            this.calendarPage1 = new Daily.Custom_Control.CalendarPage();
            this.panelTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.circularPictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panelTop
            // 
            this.panelTop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(30)))), ((int)(((byte)(35)))));
            this.panelTop.Controls.Add(this.circularButtonDown);
            this.panelTop.Controls.Add(this.circularButtonTheme);
            this.panelTop.Controls.Add(this.circularButtonMinus);
            this.panelTop.Controls.Add(this.circularButtonExit);
            this.panelTop.Controls.Add(this.labelWelcome);
            this.panelTop.Controls.Add(this.labelTop);
            this.panelTop.Controls.Add(this.pictureBox1);
            this.panelTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTop.Location = new System.Drawing.Point(0, 0);
            this.panelTop.Name = "panelTop";
            this.panelTop.Size = new System.Drawing.Size(900, 35);
            this.panelTop.TabIndex = 0;
            // 
            // circularButtonDown
            // 
            this.circularButtonDown.FlatAppearance.BorderSize = 0;
            this.circularButtonDown.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(44)))), ((int)(((byte)(60)))));
            this.circularButtonDown.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(60)))), ((int)(((byte)(80)))));
            this.circularButtonDown.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.circularButtonDown.Image = ((System.Drawing.Image)(resources.GetObject("circularButtonDown.Image")));
            this.circularButtonDown.Location = new System.Drawing.Point(779, 2);
            this.circularButtonDown.Margin = new System.Windows.Forms.Padding(2);
            this.circularButtonDown.Name = "circularButtonDown";
            this.circularButtonDown.Size = new System.Drawing.Size(29, 29);
            this.circularButtonDown.TabIndex = 5;
            this.circularButtonDown.UseVisualStyleBackColor = true;
            this.circularButtonDown.Click += new System.EventHandler(this.circularButtonDown_Click);
            // 
            // circularButtonTheme
            // 
            this.circularButtonTheme.FlatAppearance.BorderSize = 0;
            this.circularButtonTheme.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(44)))), ((int)(((byte)(60)))));
            this.circularButtonTheme.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(60)))), ((int)(((byte)(80)))));
            this.circularButtonTheme.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.circularButtonTheme.Image = ((System.Drawing.Image)(resources.GetObject("circularButtonTheme.Image")));
            this.circularButtonTheme.Location = new System.Drawing.Point(696, 2);
            this.circularButtonTheme.Margin = new System.Windows.Forms.Padding(2);
            this.circularButtonTheme.Name = "circularButtonTheme";
            this.circularButtonTheme.Size = new System.Drawing.Size(29, 29);
            this.circularButtonTheme.TabIndex = 5;
            this.circularButtonTheme.UseVisualStyleBackColor = true;
            this.circularButtonTheme.Click += new System.EventHandler(this.circularButtonTheme_Click);
            // 
            // circularButtonMinus
            // 
            this.circularButtonMinus.FlatAppearance.BorderSize = 0;
            this.circularButtonMinus.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(44)))), ((int)(((byte)(60)))));
            this.circularButtonMinus.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(60)))), ((int)(((byte)(80)))));
            this.circularButtonMinus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.circularButtonMinus.Image = ((System.Drawing.Image)(resources.GetObject("circularButtonMinus.Image")));
            this.circularButtonMinus.Location = new System.Drawing.Point(816, 2);
            this.circularButtonMinus.Name = "circularButtonMinus";
            this.circularButtonMinus.Size = new System.Drawing.Size(29, 29);
            this.circularButtonMinus.TabIndex = 4;
            this.circularButtonMinus.UseVisualStyleBackColor = true;
            this.circularButtonMinus.Click += new System.EventHandler(this.circularButtonMinus_Click_1);
            // 
            // circularButtonExit
            // 
            this.circularButtonExit.FlatAppearance.BorderSize = 0;
            this.circularButtonExit.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Maroon;
            this.circularButtonExit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkRed;
            this.circularButtonExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.circularButtonExit.Image = ((System.Drawing.Image)(resources.GetObject("circularButtonExit.Image")));
            this.circularButtonExit.Location = new System.Drawing.Point(853, 2);
            this.circularButtonExit.Name = "circularButtonExit";
            this.circularButtonExit.Size = new System.Drawing.Size(29, 29);
            this.circularButtonExit.TabIndex = 3;
            this.circularButtonExit.UseVisualStyleBackColor = true;
            this.circularButtonExit.Click += new System.EventHandler(this.circularButtonExit_Click);
            // 
            // labelWelcome
            // 
            this.labelWelcome.AutoSize = true;
            this.labelWelcome.Font = new System.Drawing.Font("Franklin Gothic Medium", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelWelcome.Location = new System.Drawing.Point(393, 4);
            this.labelWelcome.Name = "labelWelcome";
            this.labelWelcome.Size = new System.Drawing.Size(112, 26);
            this.labelWelcome.TabIndex = 2;
            this.labelWelcome.Text = "WELCOME!";
            // 
            // labelTop
            // 
            this.labelTop.AutoSize = true;
            this.labelTop.Font = new System.Drawing.Font("Sitka Text", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTop.Location = new System.Drawing.Point(52, 0);
            this.labelTop.Name = "labelTop";
            this.labelTop.Size = new System.Drawing.Size(124, 28);
            this.labelTop.TabIndex = 1;
            this.labelTop.Text = "Time Master";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(10, 1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(32, 37);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // timerPanelLeft
            // 
            this.timerPanelLeft.Interval = 1;
            // 
            // panelPage
            // 
            this.panelPage.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelPage.Location = new System.Drawing.Point(0, 485);
            this.panelPage.Name = "panelPage";
            this.panelPage.Size = new System.Drawing.Size(900, 35);
            this.panelPage.TabIndex = 3;
            // 
            // notifyIconTray
            // 
            this.notifyIconTray.BalloonTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.notifyIconTray.ContextMenuStrip = this.contextMenuStrip1;
            this.notifyIconTray.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIconTray.Icon")));
            this.notifyIconTray.Text = "Time Master v1.0\r\nRunning...";
            this.notifyIconTray.MouseClick += new System.Windows.Forms.MouseEventHandler(this.notifyIconTray_MouseClick);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(42)))), ((int)(((byte)(49)))));
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sHOWToolStripMenuItem,
            this.eXITToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(115, 48);
            // 
            // sHOWToolStripMenuItem
            // 
            this.sHOWToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.sHOWToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.sHOWToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("sHOWToolStripMenuItem.Image")));
            this.sHOWToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(42)))), ((int)(((byte)(49)))));
            this.sHOWToolStripMenuItem.Name = "sHOWToolStripMenuItem";
            this.sHOWToolStripMenuItem.Size = new System.Drawing.Size(114, 22);
            this.sHOWToolStripMenuItem.Text = "SHOW";
            this.sHOWToolStripMenuItem.Click += new System.EventHandler(this.sHOWToolStripMenuItem_Click);
            // 
            // eXITToolStripMenuItem
            // 
            this.eXITToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.eXITToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.eXITToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("eXITToolStripMenuItem.Image")));
            this.eXITToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(42)))), ((int)(((byte)(49)))));
            this.eXITToolStripMenuItem.Name = "eXITToolStripMenuItem";
            this.eXITToolStripMenuItem.Size = new System.Drawing.Size(114, 22);
            this.eXITToolStripMenuItem.Text = "EXIT";
            this.eXITToolStripMenuItem.Click += new System.EventHandler(this.eXITToolStripMenuItem_Click);
            // 
            // ellipseControlOut
            // 
            this.ellipseControlOut.CornerRadius = 30;
            this.ellipseControlOut.TargetControl = this;
            // 
            // dragControl1
            // 
            this.dragControl1.SelectControl = this.labelTop;
            // 
            // dragControl2
            // 
            this.dragControl2.SelectControl = this.panelTop;
            // 
            // dragControl3
            // 
            this.dragControl3.SelectControl = this.pictureBox1;
            // 
            // dragControl4
            // 
            this.dragControl4.SelectControl = this.labelWelcome;
            // 
            // circularPictureBox1
            // 
            this.circularPictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("circularPictureBox1.Image")));
            this.circularPictureBox1.Location = new System.Drawing.Point(738, 2);
            this.circularPictureBox1.Name = "circularPictureBox1";
            this.circularPictureBox1.Size = new System.Drawing.Size(29, 29);
            this.circularPictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.circularPictureBox1.TabIndex = 4;
            this.circularPictureBox1.TabStop = false;
            // 
            // calendarPage1
            // 
            this.calendarPage1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(30)))), ((int)(((byte)(35)))));
            this.calendarPage1.Location = new System.Drawing.Point(0, 37);
            this.calendarPage1.Name = "calendarPage1";
            this.calendarPage1.Size = new System.Drawing.Size(900, 450);
            this.calendarPage1.TabIndex = 5;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(30)))), ((int)(((byte)(35)))));
            this.ClientSize = new System.Drawing.Size(900, 520);
            this.Controls.Add(this.calendarPage1);
            this.Controls.Add(this.circularPictureBox1);
            this.Controls.Add(this.panelPage);
            this.Controls.Add(this.panelTop);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(180)))), ((int)(((byte)(192)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.panelTop.ResumeLayout(false);
            this.panelTop.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.circularPictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelTop;
        private UI.EllipseControl ellipseControlOut;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label labelTop;
        private System.Windows.Forms.Label labelWelcome;
        private CircularButton circularButtonExit;
        private CircularButton circularButtonMinus;
        private CircularButton circularButtonTheme;
        private CircularButton circularButtonDown;
        private System.Windows.Forms.Timer timerPanelLeft;
        private System.Windows.Forms.Panel panelPage;
        private CircularPictureBox circularPictureBox1;
        private System.Windows.Forms.NotifyIcon notifyIconTray;
        private DragControl dragControl1;
        private DragControl dragControl2;
        private DragControl dragControl3;
        private DragControl dragControl4;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem sHOWToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem eXITToolStripMenuItem;
        private Custom_Control.CalendarPage calendarPage1;
    }
}