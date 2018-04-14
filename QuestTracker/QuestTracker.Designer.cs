namespace QuestTracker
{
    partial class QuestTracker
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
            this.spltMain = new System.Windows.Forms.SplitContainer();
            this.ctxMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.newTrackerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loadTrackerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveTrackerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveTrackerAsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.ctxList = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tsNewQuest = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.spltMain)).BeginInit();
            this.spltMain.Panel1.SuspendLayout();
            this.spltMain.SuspendLayout();
            this.ctxMenu.SuspendLayout();
            this.ctxList.SuspendLayout();
            this.SuspendLayout();
            // 
            // spltMain
            // 
            this.spltMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.spltMain.Location = new System.Drawing.Point(0, 0);
            this.spltMain.Name = "spltMain";
            this.spltMain.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // spltMain.Panel1
            // 
            this.spltMain.Panel1.Controls.Add(this.listBox1);
            this.spltMain.Panel1.DoubleClick += new System.EventHandler(this.QuestTracker_DoubleClick);
            // 
            // spltMain.Panel2
            // 
            this.spltMain.Panel2.DoubleClick += new System.EventHandler(this.QuestTracker_DoubleClick);
            this.spltMain.Size = new System.Drawing.Size(580, 514);
            this.spltMain.SplitterDistance = 193;
            this.spltMain.TabIndex = 0;
            // 
            // ctxMenu
            // 
            this.ctxMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newTrackerToolStripMenuItem,
            this.loadTrackerToolStripMenuItem,
            this.saveTrackerToolStripMenuItem,
            this.saveTrackerAsToolStripMenuItem,
            this.quitToolStripMenuItem});
            this.ctxMenu.Name = "ctxMenu";
            this.ctxMenu.Size = new System.Drawing.Size(157, 114);
            // 
            // newTrackerToolStripMenuItem
            // 
            this.newTrackerToolStripMenuItem.Name = "newTrackerToolStripMenuItem";
            this.newTrackerToolStripMenuItem.Size = new System.Drawing.Size(156, 22);
            this.newTrackerToolStripMenuItem.Text = "New Tracker";
            this.newTrackerToolStripMenuItem.Click += new System.EventHandler(this.NewTrackerToolStripMenuItem_Click);
            // 
            // loadTrackerToolStripMenuItem
            // 
            this.loadTrackerToolStripMenuItem.Name = "loadTrackerToolStripMenuItem";
            this.loadTrackerToolStripMenuItem.Size = new System.Drawing.Size(156, 22);
            this.loadTrackerToolStripMenuItem.Text = "Load Tracker";
            // 
            // saveTrackerToolStripMenuItem
            // 
            this.saveTrackerToolStripMenuItem.Name = "saveTrackerToolStripMenuItem";
            this.saveTrackerToolStripMenuItem.Size = new System.Drawing.Size(156, 22);
            this.saveTrackerToolStripMenuItem.Text = "Save Tracker";
            // 
            // saveTrackerAsToolStripMenuItem
            // 
            this.saveTrackerAsToolStripMenuItem.Name = "saveTrackerAsToolStripMenuItem";
            this.saveTrackerAsToolStripMenuItem.Size = new System.Drawing.Size(156, 22);
            this.saveTrackerAsToolStripMenuItem.Text = "Save Tracker As";
            // 
            // quitToolStripMenuItem
            // 
            this.quitToolStripMenuItem.Name = "quitToolStripMenuItem";
            this.quitToolStripMenuItem.Size = new System.Drawing.Size(156, 22);
            this.quitToolStripMenuItem.Text = "Quit";
            this.quitToolStripMenuItem.Click += new System.EventHandler(this.quitToolStripMenuItem_Click);
            // 
            // listBox1
            // 
            this.listBox1.ContextMenuStrip = this.ctxList;
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(12, 12);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(556, 173);
            this.listBox1.TabIndex = 0;
            // 
            // ctxList
            // 
            this.ctxList.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsNewQuest});
            this.ctxList.Name = "ctxList";
            this.ctxList.Size = new System.Drawing.Size(133, 26);
            // 
            // tsNewQuest
            // 
            this.tsNewQuest.Name = "tsNewQuest";
            this.tsNewQuest.Size = new System.Drawing.Size(132, 22);
            this.tsNewQuest.Text = "New Quest";
            // 
            // QuestTracker
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(580, 514);
            this.ContextMenuStrip = this.ctxMenu;
            this.Controls.Add(this.spltMain);
            this.Name = "QuestTracker";
            this.Text = "DG QuestTracker";
            this.Load += new System.EventHandler(this.QuestTracker_Load);
            this.DoubleClick += new System.EventHandler(this.QuestTracker_DoubleClick);
            this.spltMain.Panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.spltMain)).EndInit();
            this.spltMain.ResumeLayout(false);
            this.ctxMenu.ResumeLayout(false);
            this.ctxList.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer spltMain;
        private System.Windows.Forms.ContextMenuStrip ctxMenu;
        private System.Windows.Forms.ToolStripMenuItem newTrackerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem loadTrackerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveTrackerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveTrackerAsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quitToolStripMenuItem;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.ContextMenuStrip ctxList;
        private System.Windows.Forms.ToolStripMenuItem tsNewQuest;
    }
}

