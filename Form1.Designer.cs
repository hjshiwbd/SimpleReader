﻿namespace demo002
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.importBtn = new System.Windows.Forms.Button();
            this.pageTextbox = new System.Windows.Forms.TextBox();
            this.pageEndBtn = new System.Windows.Forms.Button();
            this.pageNextBtn = new System.Windows.Forms.Button();
            this.pagePrevBtn = new System.Windows.Forms.Button();
            this.pageFirstBtn = new System.Windows.Forms.Button();
            this.pageGoBtn = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.fontSizeComboBox = new System.Windows.Forms.ComboBox();
            this.pageSizeLabel = new System.Windows.Forms.Label();
            this.buttonSearchPrev = new System.Windows.Forms.Button();
            this.buttonSearchNext = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.pageInfo = new System.Windows.Forms.Label();
            this.textBoxSearch = new System.Windows.Forms.TextBox();
            this.pageCountPerPageCB = new System.Windows.Forms.ComboBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.reopenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.notifyicon_contextmenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.itemShow = new System.Windows.Forms.ToolStripMenuItem();
            this.itemHide = new System.Windows.Forms.ToolStripMenuItem();
            this.itemClose = new System.Windows.Forms.ToolStripMenuItem();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.notifyicon_contextmenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // importBtn
            // 
            this.importBtn.Location = new System.Drawing.Point(17, 20);
            this.importBtn.Name = "importBtn";
            this.importBtn.Size = new System.Drawing.Size(47, 23);
            this.importBtn.TabIndex = 0;
            this.importBtn.Text = "导入";
            this.importBtn.UseVisualStyleBackColor = true;
            this.importBtn.Click += new System.EventHandler(this.importBtn_Click);
            // 
            // pageTextbox
            // 
            this.pageTextbox.Location = new System.Drawing.Point(282, 20);
            this.pageTextbox.Name = "pageTextbox";
            this.pageTextbox.Size = new System.Drawing.Size(43, 21);
            this.pageTextbox.TabIndex = 1;
            this.pageTextbox.KeyUp += new System.Windows.Forms.KeyEventHandler(this.pageTextbox_KeyUp);
            // 
            // pageEndBtn
            // 
            this.pageEndBtn.Location = new System.Drawing.Point(229, 20);
            this.pageEndBtn.Name = "pageEndBtn";
            this.pageEndBtn.Size = new System.Drawing.Size(47, 23);
            this.pageEndBtn.TabIndex = 2;
            this.pageEndBtn.Text = "末页";
            this.pageEndBtn.UseVisualStyleBackColor = true;
            this.pageEndBtn.Click += new System.EventHandler(this.pageEndBtn_Click);
            // 
            // pageNextBtn
            // 
            this.pageNextBtn.Location = new System.Drawing.Point(176, 20);
            this.pageNextBtn.Name = "pageNextBtn";
            this.pageNextBtn.Size = new System.Drawing.Size(47, 23);
            this.pageNextBtn.TabIndex = 3;
            this.pageNextBtn.Text = "下页";
            this.pageNextBtn.UseVisualStyleBackColor = true;
            this.pageNextBtn.Click += new System.EventHandler(this.pageNextBtn_Click);
            // 
            // pagePrevBtn
            // 
            this.pagePrevBtn.Location = new System.Drawing.Point(123, 20);
            this.pagePrevBtn.Name = "pagePrevBtn";
            this.pagePrevBtn.Size = new System.Drawing.Size(47, 23);
            this.pagePrevBtn.TabIndex = 4;
            this.pagePrevBtn.Text = "上页";
            this.pagePrevBtn.UseVisualStyleBackColor = true;
            this.pagePrevBtn.Click += new System.EventHandler(this.pagePrevBtn_Click);
            // 
            // pageFirstBtn
            // 
            this.pageFirstBtn.Location = new System.Drawing.Point(70, 20);
            this.pageFirstBtn.Name = "pageFirstBtn";
            this.pageFirstBtn.Size = new System.Drawing.Size(47, 23);
            this.pageFirstBtn.TabIndex = 5;
            this.pageFirstBtn.Text = "首页";
            this.pageFirstBtn.UseVisualStyleBackColor = true;
            this.pageFirstBtn.Click += new System.EventHandler(this.pageFirstBtn_Click);
            // 
            // pageGoBtn
            // 
            this.pageGoBtn.Location = new System.Drawing.Point(331, 20);
            this.pageGoBtn.Name = "pageGoBtn";
            this.pageGoBtn.Size = new System.Drawing.Size(47, 23);
            this.pageGoBtn.TabIndex = 6;
            this.pageGoBtn.Text = "跳转";
            this.pageGoBtn.UseVisualStyleBackColor = true;
            this.pageGoBtn.Click += new System.EventHandler(this.pageGoBtn_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileOk += new System.ComponentModel.CancelEventHandler(this.openFileDialog1_FileOk);
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.AllowDrop = true;
            this.splitContainer1.Panel1.Controls.Add(this.groupBox1);
            this.splitContainer1.Panel1.Controls.Add(this.menuStrip1);
            this.splitContainer1.Panel1.DragDrop += new System.Windows.Forms.DragEventHandler(this.splitContainer1_Panel1_DragDrop);
            this.splitContainer1.Panel1.DragEnter += new System.Windows.Forms.DragEventHandler(this.splitContainer1_Panel1_DragEnter);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.richTextBox1);
            this.splitContainer1.Size = new System.Drawing.Size(1068, 558);
            this.splitContainer1.SplitterDistance = 100;
            this.splitContainer1.TabIndex = 1;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.fontSizeComboBox);
            this.groupBox1.Controls.Add(this.pageSizeLabel);
            this.groupBox1.Controls.Add(this.importBtn);
            this.groupBox1.Controls.Add(this.pageFirstBtn);
            this.groupBox1.Controls.Add(this.buttonSearchPrev);
            this.groupBox1.Controls.Add(this.pageNextBtn);
            this.groupBox1.Controls.Add(this.buttonSearchNext);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.pageInfo);
            this.groupBox1.Controls.Add(this.textBoxSearch);
            this.groupBox1.Controls.Add(this.pagePrevBtn);
            this.groupBox1.Controls.Add(this.pageEndBtn);
            this.groupBox1.Controls.Add(this.pageTextbox);
            this.groupBox1.Controls.Add(this.pageCountPerPageCB);
            this.groupBox1.Controls.Add(this.pageGoBtn);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Location = new System.Drawing.Point(0, 25);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1068, 73);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            // 
            // fontSizeComboBox
            // 
            this.fontSizeComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.fontSizeComboBox.Items.AddRange(new object[] {
            "9",
            "10",
            "12",
            "14",
            "16",
            "18",
            "20",
            "22",
            "24",
            "26",
            "28",
            "30"});
            this.fontSizeComboBox.Location = new System.Drawing.Point(768, 20);
            this.fontSizeComboBox.Name = "fontSizeComboBox";
            this.fontSizeComboBox.Size = new System.Drawing.Size(64, 20);
            this.fontSizeComboBox.TabIndex = 15;
            this.fontSizeComboBox.SelectedIndexChanged += new System.EventHandler(this.fontSizeComboBox_SelectedIndexChanged);
            // 
            // pageSizeLabel
            // 
            this.pageSizeLabel.AutoSize = true;
            this.pageSizeLabel.Location = new System.Drawing.Point(733, 25);
            this.pageSizeLabel.Name = "pageSizeLabel";
            this.pageSizeLabel.Size = new System.Drawing.Size(29, 12);
            this.pageSizeLabel.TabIndex = 16;
            this.pageSizeLabel.Text = "字号";
            // 
            // buttonSearchPrev
            // 
            this.buttonSearchPrev.Location = new System.Drawing.Point(676, 20);
            this.buttonSearchPrev.Name = "buttonSearchPrev";
            this.buttonSearchPrev.Size = new System.Drawing.Size(51, 23);
            this.buttonSearchPrev.TabIndex = 14;
            this.buttonSearchPrev.Text = "上一个";
            this.buttonSearchPrev.UseVisualStyleBackColor = true;
            this.buttonSearchPrev.Click += new System.EventHandler(this.buttonSearchPrev_Click);
            // 
            // buttonSearchNext
            // 
            this.buttonSearchNext.Location = new System.Drawing.Point(619, 20);
            this.buttonSearchNext.Name = "buttonSearchNext";
            this.buttonSearchNext.Size = new System.Drawing.Size(51, 23);
            this.buttonSearchNext.TabIndex = 12;
            this.buttonSearchNext.Text = "下一个";
            this.buttonSearchNext.UseVisualStyleBackColor = true;
            this.buttonSearchNext.Click += new System.EventHandler(this.buttonSearchNext_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(384, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 12);
            this.label1.TabIndex = 13;
            this.label1.Text = "每页行数";
            // 
            // pageInfo
            // 
            this.pageInfo.AutoSize = true;
            this.pageInfo.Location = new System.Drawing.Point(15, 50);
            this.pageInfo.Name = "pageInfo";
            this.pageInfo.Size = new System.Drawing.Size(53, 12);
            this.pageInfo.TabIndex = 9;
            this.pageInfo.Text = "分页信息";
            // 
            // textBoxSearch
            // 
            this.textBoxSearch.Location = new System.Drawing.Point(513, 20);
            this.textBoxSearch.Name = "textBoxSearch";
            this.textBoxSearch.Size = new System.Drawing.Size(100, 21);
            this.textBoxSearch.TabIndex = 11;
            this.textBoxSearch.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxSearch_KeyPress);
            this.textBoxSearch.KeyUp += new System.Windows.Forms.KeyEventHandler(this.textBoxSearch_KeyUp);
            // 
            // pageCountPerPageCB
            // 
            this.pageCountPerPageCB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.pageCountPerPageCB.Items.AddRange(new object[] {
            "100",
            "500",
            "1000",
            "5000",
            "10000",
            "50000"});
            this.pageCountPerPageCB.Location = new System.Drawing.Point(443, 20);
            this.pageCountPerPageCB.Name = "pageCountPerPageCB";
            this.pageCountPerPageCB.Size = new System.Drawing.Size(64, 20);
            this.pageCountPerPageCB.TabIndex = 7;
            this.pageCountPerPageCB.SelectedIndexChanged += new System.EventHandler(this.ComboBox1_SelectedIndexChanged);
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.Control;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.reopenToolStripMenuItem});
            this.menuStrip1.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.HorizontalStackWithOverflow;
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1068, 25);
            this.menuStrip1.TabIndex = 17;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // reopenToolStripMenuItem
            // 
            this.reopenToolStripMenuItem.Name = "reopenToolStripMenuItem";
            this.reopenToolStripMenuItem.Size = new System.Drawing.Size(68, 21);
            this.reopenToolStripMenuItem.Text = "重新打开";
            // 
            // richTextBox1
            // 
            this.richTextBox1.AllowDrop = true;
            this.richTextBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.richTextBox1.Font = new System.Drawing.Font("SimSun", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.richTextBox1.ForeColor = System.Drawing.Color.ForestGreen;
            this.richTextBox1.Location = new System.Drawing.Point(0, 0);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.ReadOnly = true;
            this.richTextBox1.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical;
            this.richTextBox1.Size = new System.Drawing.Size(1068, 454);
            this.richTextBox1.TabIndex = 0;
            this.richTextBox1.Text = "请导入txt";
            this.richTextBox1.DragDrop += new System.Windows.Forms.DragEventHandler(this.splitContainer1_Panel1_DragDrop);
            this.richTextBox1.DragEnter += new System.Windows.Forms.DragEventHandler(this.splitContainer1_Panel1_DragEnter);
            this.richTextBox1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.RichTextBox1_KeyDown);
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.ContextMenuStrip = this.notifyicon_contextmenu;
            this.notifyIcon1.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon1.Icon")));
            this.notifyIcon1.Text = "SimpleReader";
            this.notifyIcon1.Visible = true;
            this.notifyIcon1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.notifyIcon1_MouseClick);
            // 
            // notifyicon_contextmenu
            // 
            this.notifyicon_contextmenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.itemShow,
            this.itemHide,
            this.itemClose});
            this.notifyicon_contextmenu.Name = "contextMenuStrip1";
            this.notifyicon_contextmenu.Size = new System.Drawing.Size(101, 70);
            // 
            // itemShow
            // 
            this.itemShow.Name = "itemShow";
            this.itemShow.Size = new System.Drawing.Size(100, 22);
            this.itemShow.Text = "显示";
            this.itemShow.Click += new System.EventHandler(this.itemShow_Click);
            // 
            // itemHide
            // 
            this.itemHide.Name = "itemHide";
            this.itemHide.Size = new System.Drawing.Size(100, 22);
            this.itemHide.Text = "隐藏";
            this.itemHide.Click += new System.EventHandler(this.itemHide_Click);
            // 
            // itemClose
            // 
            this.itemClose.Name = "itemClose";
            this.itemClose.Size = new System.Drawing.Size(100, 22);
            this.itemClose.Text = "退出";
            this.itemClose.Click += new System.EventHandler(this.itemClose_Click);
            // 
            // imageList1
            // 
            this.imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageList1.ImageSize = new System.Drawing.Size(16, 16);
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1068, 558);
            this.Controls.Add(this.splitContainer1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SimpleReader";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.notifyicon_contextmenu.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button importBtn;
        private System.Windows.Forms.TextBox pageTextbox;
        private System.Windows.Forms.Button pageEndBtn;
        private System.Windows.Forms.Button pageNextBtn;
        private System.Windows.Forms.Button pagePrevBtn;
        private System.Windows.Forms.Button pageFirstBtn;
        private System.Windows.Forms.Button pageGoBtn;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.ComboBox pageCountPerPageCB;
        private System.Windows.Forms.Label pageInfo;
        private System.Windows.Forms.Button buttonSearchNext;
        private System.Windows.Forms.TextBox textBoxSearch;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonSearchPrev;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
        private System.Windows.Forms.ContextMenuStrip notifyicon_contextmenu;
        private System.Windows.Forms.ToolStripMenuItem itemClose;
        private System.Windows.Forms.ToolStripMenuItem itemShow;
        private System.Windows.Forms.ToolStripMenuItem itemHide;
        private System.Windows.Forms.ComboBox fontSizeComboBox;
        private System.Windows.Forms.Label pageSizeLabel;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem reopenToolStripMenuItem;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}

