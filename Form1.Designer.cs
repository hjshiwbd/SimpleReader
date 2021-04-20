namespace demo002
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
            this.importBtn = new System.Windows.Forms.Button();
            this.pageTextbox = new System.Windows.Forms.TextBox();
            this.pageEndBtn = new System.Windows.Forms.Button();
            this.pageNextBtn = new System.Windows.Forms.Button();
            this.pagePrevBtn = new System.Windows.Forms.Button();
            this.pageFirstBtn = new System.Windows.Forms.Button();
            this.pageGoBtn = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonSearch = new System.Windows.Forms.Button();
            this.textBoxSearch = new System.Windows.Forms.TextBox();
            this.saveBookmark = new System.Windows.Forms.Button();
            this.pageInfo = new System.Windows.Forms.Label();
            this.bookName = new System.Windows.Forms.Label();
            this.pageCountPerPageCB = new System.Windows.Forms.ComboBox();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // importBtn
            // 
            this.importBtn.Location = new System.Drawing.Point(18, 11);
            this.importBtn.Name = "importBtn";
            this.importBtn.Size = new System.Drawing.Size(47, 23);
            this.importBtn.TabIndex = 0;
            this.importBtn.Text = "导入";
            this.importBtn.UseVisualStyleBackColor = true;
            this.importBtn.Click += new System.EventHandler(this.importBtn_Click);
            // 
            // pageTextbox
            // 
            this.pageTextbox.Location = new System.Drawing.Point(283, 11);
            this.pageTextbox.Name = "pageTextbox";
            this.pageTextbox.Size = new System.Drawing.Size(43, 21);
            this.pageTextbox.TabIndex = 1;
            // 
            // pageEndBtn
            // 
            this.pageEndBtn.Location = new System.Drawing.Point(230, 11);
            this.pageEndBtn.Name = "pageEndBtn";
            this.pageEndBtn.Size = new System.Drawing.Size(47, 23);
            this.pageEndBtn.TabIndex = 2;
            this.pageEndBtn.Text = "末页";
            this.pageEndBtn.UseVisualStyleBackColor = true;
            this.pageEndBtn.Click += new System.EventHandler(this.pageEndBtn_Click);
            // 
            // pageNextBtn
            // 
            this.pageNextBtn.Location = new System.Drawing.Point(177, 11);
            this.pageNextBtn.Name = "pageNextBtn";
            this.pageNextBtn.Size = new System.Drawing.Size(47, 23);
            this.pageNextBtn.TabIndex = 3;
            this.pageNextBtn.Text = "下页";
            this.pageNextBtn.UseVisualStyleBackColor = true;
            this.pageNextBtn.Click += new System.EventHandler(this.pageNextBtn_Click);
            // 
            // pagePrevBtn
            // 
            this.pagePrevBtn.Location = new System.Drawing.Point(124, 11);
            this.pagePrevBtn.Name = "pagePrevBtn";
            this.pagePrevBtn.Size = new System.Drawing.Size(47, 23);
            this.pagePrevBtn.TabIndex = 4;
            this.pagePrevBtn.Text = "上页";
            this.pagePrevBtn.UseVisualStyleBackColor = true;
            this.pagePrevBtn.Click += new System.EventHandler(this.pagePrevBtn_Click);
            // 
            // pageFirstBtn
            // 
            this.pageFirstBtn.Location = new System.Drawing.Point(71, 11);
            this.pageFirstBtn.Name = "pageFirstBtn";
            this.pageFirstBtn.Size = new System.Drawing.Size(47, 23);
            this.pageFirstBtn.TabIndex = 5;
            this.pageFirstBtn.Text = "首页";
            this.pageFirstBtn.UseVisualStyleBackColor = true;
            this.pageFirstBtn.Click += new System.EventHandler(this.pageFirstBtn_Click);
            // 
            // pageGoBtn
            // 
            this.pageGoBtn.Location = new System.Drawing.Point(332, 11);
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
            this.splitContainer1.Panel1.Controls.Add(this.label1);
            this.splitContainer1.Panel1.Controls.Add(this.buttonSearch);
            this.splitContainer1.Panel1.Controls.Add(this.textBoxSearch);
            this.splitContainer1.Panel1.Controls.Add(this.saveBookmark);
            this.splitContainer1.Panel1.Controls.Add(this.pageInfo);
            this.splitContainer1.Panel1.Controls.Add(this.bookName);
            this.splitContainer1.Panel1.Controls.Add(this.pageCountPerPageCB);
            this.splitContainer1.Panel1.Controls.Add(this.pageFirstBtn);
            this.splitContainer1.Panel1.Controls.Add(this.pageGoBtn);
            this.splitContainer1.Panel1.Controls.Add(this.importBtn);
            this.splitContainer1.Panel1.Controls.Add(this.pageTextbox);
            this.splitContainer1.Panel1.Controls.Add(this.pagePrevBtn);
            this.splitContainer1.Panel1.Controls.Add(this.pageEndBtn);
            this.splitContainer1.Panel1.Controls.Add(this.pageNextBtn);
            this.splitContainer1.Panel1.DragDrop += new System.Windows.Forms.DragEventHandler(this.splitContainer1_Panel1_DragDrop);
            this.splitContainer1.Panel1.DragEnter += new System.Windows.Forms.DragEventHandler(this.splitContainer1_Panel1_DragEnter);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.richTextBox1);
            this.splitContainer1.Size = new System.Drawing.Size(800, 457);
            this.splitContainer1.SplitterDistance = 64;
            this.splitContainer1.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(384, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 12);
            this.label1.TabIndex = 13;
            this.label1.Text = "每页行数";
            // 
            // buttonSearch
            // 
            this.buttonSearch.Location = new System.Drawing.Point(628, 9);
            this.buttonSearch.Name = "buttonSearch";
            this.buttonSearch.Size = new System.Drawing.Size(51, 23);
            this.buttonSearch.TabIndex = 12;
            this.buttonSearch.Text = "搜索";
            this.buttonSearch.UseVisualStyleBackColor = true;
            this.buttonSearch.Click += new System.EventHandler(this.buttonSearch_Click);
            // 
            // textBoxSearch
            // 
            this.textBoxSearch.Location = new System.Drawing.Point(522, 10);
            this.textBoxSearch.Name = "textBoxSearch";
            this.textBoxSearch.Size = new System.Drawing.Size(100, 21);
            this.textBoxSearch.TabIndex = 11;
            // 
            // saveBookmark
            // 
            this.saveBookmark.Location = new System.Drawing.Point(685, 9);
            this.saveBookmark.Name = "saveBookmark";
            this.saveBookmark.Size = new System.Drawing.Size(75, 23);
            this.saveBookmark.TabIndex = 10;
            this.saveBookmark.Text = "设书签";
            this.saveBookmark.UseVisualStyleBackColor = true;
            this.saveBookmark.Click += new System.EventHandler(this.saveBookmark_Click);
            // 
            // pageInfo
            // 
            this.pageInfo.AutoSize = true;
            this.pageInfo.Location = new System.Drawing.Point(230, 40);
            this.pageInfo.Name = "pageInfo";
            this.pageInfo.Size = new System.Drawing.Size(53, 12);
            this.pageInfo.TabIndex = 9;
            this.pageInfo.Text = "分页信息";
            // 
            // bookName
            // 
            this.bookName.AutoSize = true;
            this.bookName.Location = new System.Drawing.Point(18, 41);
            this.bookName.Name = "bookName";
            this.bookName.Size = new System.Drawing.Size(53, 12);
            this.bookName.TabIndex = 8;
            this.bookName.Text = "暂无书名";
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
            this.pageCountPerPageCB.Location = new System.Drawing.Point(442, 11);
            this.pageCountPerPageCB.Name = "pageCountPerPageCB";
            this.pageCountPerPageCB.Size = new System.Drawing.Size(64, 20);
            this.pageCountPerPageCB.TabIndex = 7;
            this.pageCountPerPageCB.SelectedIndexChanged += new System.EventHandler(this.ComboBox1_SelectedIndexChanged);
            // 
            // richTextBox1
            // 
            this.richTextBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.richTextBox1.Font = new System.Drawing.Font("宋体", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.richTextBox1.ForeColor = System.Drawing.Color.ForestGreen;
            this.richTextBox1.Location = new System.Drawing.Point(0, 0);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.ReadOnly = true;
            this.richTextBox1.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical;
            this.richTextBox1.Size = new System.Drawing.Size(800, 389);
            this.richTextBox1.TabIndex = 0;
            this.richTextBox1.Text = "请导入txt";
            this.richTextBox1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.RichTextBox1_KeyDown);
            this.richTextBox1.AllowDrop = true;
            this.richTextBox1.DragEnter += new System.Windows.Forms.DragEventHandler(this.splitContainer1_Panel1_DragEnter);
            this.richTextBox1.DragDrop += new System.Windows.Forms.DragEventHandler(this.splitContainer1_Panel1_DragDrop);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 457);
            this.Controls.Add(this.splitContainer1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SimpleReader";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.ResumeLayout(false);
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
        private System.Windows.Forms.Label bookName;
        private System.Windows.Forms.Label pageInfo;
        private System.Windows.Forms.Button saveBookmark;
        private System.Windows.Forms.Button buttonSearch;
        private System.Windows.Forms.TextBox textBoxSearch;
        private System.Windows.Forms.Label label1;
    }
}

