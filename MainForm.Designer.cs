using System;
using System.Collections.Generic;
using System.Windows.Forms;

using System.Drawing;
using System.Text;
using System.Threading;

using AForge.Video;
using AForge.Video.DirectShow;
using AForge.Controls;
namespace Player
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
        protected override void Dispose( bool disposing )
        {
            if ( disposing && ( components != null ) )
            {
                components.Dispose( );
            }
            base.Dispose( disposing );
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent( )
        {
            this.components = new System.ComponentModel.Container();
            this.mainMenuStrip = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.localVideoCaptureDeviceToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openVideofileusingDirectShowToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openJPEGURLToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openMJPEGURLToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.capture1stDisplayToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.fpsLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.mainPanel = new System.Windows.Forms.Panel();
            this.pictureBox1 = new AForge.Controls.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.videoSourcePlayer = new AForge.Controls.VideoSourcePlayer();
            this.mainMenuStrip.SuspendLayout();
            this.statusStrip.SuspendLayout();
            this.mainPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // mainMenuStrip
            // 
            this.mainMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.mainMenuStrip.Location = new System.Drawing.Point(0, 0);
            this.mainMenuStrip.Name = "mainMenuStrip";
            this.mainMenuStrip.Size = new System.Drawing.Size(1908, 24);
            this.mainMenuStrip.TabIndex = 0;
            this.mainMenuStrip.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.localVideoCaptureDeviceToolStripMenuItem,
            this.openVideofileusingDirectShowToolStripMenuItem,
            this.openJPEGURLToolStripMenuItem,
            this.openMJPEGURLToolStripMenuItem,
            this.capture1stDisplayToolStripMenuItem,
            this.toolStripMenuItem1,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "&File";
            // 
            // localVideoCaptureDeviceToolStripMenuItem
            // 
            this.localVideoCaptureDeviceToolStripMenuItem.Name = "localVideoCaptureDeviceToolStripMenuItem";
            this.localVideoCaptureDeviceToolStripMenuItem.Size = new System.Drawing.Size(257, 22);
            this.localVideoCaptureDeviceToolStripMenuItem.Text = "Local &Video Capture Device";
            this.localVideoCaptureDeviceToolStripMenuItem.Click += new System.EventHandler(this.localVideoCaptureDeviceToolStripMenuItem_Click);
            // 
            // openVideofileusingDirectShowToolStripMenuItem
            // 
            this.openVideofileusingDirectShowToolStripMenuItem.Name = "openVideofileusingDirectShowToolStripMenuItem";
            this.openVideofileusingDirectShowToolStripMenuItem.Size = new System.Drawing.Size(257, 22);
            this.openVideofileusingDirectShowToolStripMenuItem.Text = "Open video &file (using DirectShow)";
            this.openVideofileusingDirectShowToolStripMenuItem.Click += new System.EventHandler(this.openVideofileusingDirectShowToolStripMenuItem_Click);
            // 
            // openJPEGURLToolStripMenuItem
            // 
            this.openJPEGURLToolStripMenuItem.Name = "openJPEGURLToolStripMenuItem";
            this.openJPEGURLToolStripMenuItem.Size = new System.Drawing.Size(257, 22);
            this.openJPEGURLToolStripMenuItem.Text = "Open JPEG &URL";
            this.openJPEGURLToolStripMenuItem.Click += new System.EventHandler(this.openJPEGURLToolStripMenuItem_Click);
            // 
            // openMJPEGURLToolStripMenuItem
            // 
            this.openMJPEGURLToolStripMenuItem.Name = "openMJPEGURLToolStripMenuItem";
            this.openMJPEGURLToolStripMenuItem.Size = new System.Drawing.Size(257, 22);
            this.openMJPEGURLToolStripMenuItem.Text = "Open &MJPEG URL";
            this.openMJPEGURLToolStripMenuItem.Click += new System.EventHandler(this.openMJPEGURLToolStripMenuItem_Click);
            // 
            // capture1stDisplayToolStripMenuItem
            // 
            this.capture1stDisplayToolStripMenuItem.Name = "capture1stDisplayToolStripMenuItem";
            this.capture1stDisplayToolStripMenuItem.Size = new System.Drawing.Size(257, 22);
            this.capture1stDisplayToolStripMenuItem.Text = "Capture 1st display";
            this.capture1stDisplayToolStripMenuItem.Click += new System.EventHandler(this.capture1stDisplayToolStripMenuItem_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(254, 6);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(257, 22);
            this.exitToolStripMenuItem.Text = "E&xit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // timer
            // 
            this.timer.Interval = 1000;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // openFileDialog
            // 
            this.openFileDialog.Filter = "AVI files (*.avi)|*.avi|All files (*.*)|*.*";
            this.openFileDialog.Title = "Opem movie";
            // 
            // fpsLabel
            // 
            this.fpsLabel.Name = "fpsLabel";
            this.fpsLabel.Size = new System.Drawing.Size(1893, 17);
            this.fpsLabel.Spring = true;
            this.fpsLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // statusStrip
            // 
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fpsLabel});
            this.statusStrip.Location = new System.Drawing.Point(0, 963);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Size = new System.Drawing.Size(1908, 22);
            this.statusStrip.TabIndex = 1;
            this.statusStrip.Text = "statusStrip1";
            // 
            // mainPanel
            // 
            this.mainPanel.Controls.Add(this.pictureBox1);
            this.mainPanel.Controls.Add(this.button1);
            this.mainPanel.Controls.Add(this.videoSourcePlayer);
            this.mainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainPanel.Location = new System.Drawing.Point(0, 24);
            this.mainPanel.Name = "mainPanel";
            this.mainPanel.Size = new System.Drawing.Size(1908, 939);
            this.mainPanel.TabIndex = 2;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = null;
            this.pictureBox1.Location = new System.Drawing.Point(1121, 348);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(299, 242);
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button1.Location = new System.Drawing.Point(1037, 95);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(147, 53);
            this.button1.TabIndex = 1;
            this.button1.Text = "load video";
            this.button1.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.button1.UseCompatibleTextRendering = true;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // videoSourcePlayer
            // 
            this.videoSourcePlayer.AutoSizeControl = true;
            this.videoSourcePlayer.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.videoSourcePlayer.ForeColor = System.Drawing.Color.White;
            this.videoSourcePlayer.Location = new System.Drawing.Point(793, 348);
            this.videoSourcePlayer.Name = "videoSourcePlayer";
            this.videoSourcePlayer.Size = new System.Drawing.Size(322, 242);
            this.videoSourcePlayer.TabIndex = 0;
            this.videoSourcePlayer.VideoSource = null;
            this.videoSourcePlayer.Visible = false;
            this.videoSourcePlayer.NewFrame += new AForge.Controls.VideoSourcePlayer.NewFrameHandler(this.videoSourcePlayer_NewFrame);
            this.videoSourcePlayer.PlayingFinished += new AForge.Video.PlayingFinishedEventHandler(this.videoSourcePlayer_PlayingFinished);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1908, 985);
            this.ControlBox = false;
            this.Controls.Add(this.mainPanel);
            this.Controls.Add(this.statusStrip);
            this.Controls.Add(this.mainMenuStrip);
            this.ForeColor = System.Drawing.SystemColors.Control;
            this.MainMenuStrip = this.mainMenuStrip;
            this.Name = "MainForm";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Simple Player";
            this.TransparencyKey = System.Drawing.SystemColors.Control;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.mainMenuStrip.ResumeLayout(false);
            this.mainMenuStrip.PerformLayout();
            this.statusStrip.ResumeLayout(false);
            this.statusStrip.PerformLayout();
            this.mainPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip mainMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem localVideoCaptureDeviceToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.ToolStripMenuItem openVideofileusingDirectShowToolStripMenuItem;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.ToolStripMenuItem openJPEGURLToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openMJPEGURLToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem capture1stDisplayToolStripMenuItem;
        private System.Windows.Forms.ToolStripStatusLabel fpsLabel;
        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.Panel mainPanel;
        private Button button1;
        private AForge.Controls.PictureBox pictureBox1;
        private VideoSourcePlayer videoSourcePlayer;
    }
}

