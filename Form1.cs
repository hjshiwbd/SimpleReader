﻿using OnlineEditLib;
using PubOp;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Text.RegularExpressions;
using System.Web.Script.Serialization;
using System.Windows.Forms;

namespace demo002
{
    public partial class Form1 : Form
    {
        //
        private string appname = "simplereader";
        //txt内容转储到list
        List<string> list = new List<string>();
        //当前页
        int page = 1;
        //每页100行
        int countPerPage = 100;
        //翻页对象
        Pager p = null;
        //配置文件
        string configPath;
        //配置项
        string SECTION_PAGINATION = "pagination";
        readonly string SECTION_GLOBAL = "global";
        readonly string KEY_REOPENLIST = "ReopenList";
        //打开的文件名,不是全路径
        string txtName;
        //当前搜索到第几行,用于连续搜索的开始点
        int searchIndex = -1;

        //启动初始化
        public Form1()
        {
            InitializeComponent();
            InitConfigFile();
            InitReopen();

            //初始化
            //combobox的选项
            this.fontSizeComboBox.SelectedIndex = 5;
            this.pageCountPerPageCB.SelectedIndex = 0;
        }

        //初始化reopen内容
        private void InitReopen()
        {
            reopenToolStripMenuItem.DropDownItems.Clear();

            var reopenFromIni = OperateIniFile.ReadIniData(SECTION_GLOBAL, KEY_REOPENLIST, "[]", this.configPath);
            JavaScriptSerializer serializer = new JavaScriptSerializer();
            List<Dictionary<object, object>> list = serializer.Deserialize<List<Dictionary<object, object>>>(reopenFromIni);
            for (int i = list.Count - 1; i >= 0; i--)
            {
                var d = list[i];
                ToolStripMenuItem item = new ToolStripMenuItem();
                item.Text = d["filename"].ToString();
                item.Click += ReopenItemClick;
                reopenToolStripMenuItem.DropDownItems.Add(item);
            }
        }

        //选择打开过的文件
        private void ReopenItemClick(object sender, EventArgs e)
        {
            var fname = sender.ToString();
            LoadFile(fname);
        }

        //生成配置文件
        private void InitConfigFile()
        {
            // 创建
            string appData = System.Environment.GetFolderPath(System.Environment.SpecialFolder.ApplicationData);
            appData += "\\SimpleReader";
            if (!Directory.Exists(appData))
            {
                Directory.CreateDirectory(appData);
            }
            appData += "\\conf.ini";
            if (!File.Exists(appData))
            {
                File.CreateText(appData);
            }
            this.configPath = appData;
        }

        //导入文件
        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {
            LoadFile(openFileDialog1.FileName);
        }

        //加载txt
        private void LoadFile(string filename)
        {
            if (!filename.ToLower().EndsWith(".txt"))
            {
                MessageBox.Show("文件格式不是txt");
                return;
            }

            //打开记录
            SaveOpenRecord(filename);
            // 保存当前阅读书签
            SaveReadMark();
            // 加载新txt
            CacheFile(filename);

            //Console.WriteLine(string.Format("time cost:{0}, line count:{1}", stopWatch.ElapsedMilliseconds, list.Count));

            // 上次阅读的位置
            GetLastReadMark(this.txtName);
            // 加载
            LoadPage(this.page, this.countPerPage, true);
        }

        //历史阅读文件
        private void SaveOpenRecord(string filename)
        {
            string name = Path.GetFileName(filename);
            JavaScriptSerializer serializer = new JavaScriptSerializer();
            string reopenFromIni = OperateIniFile.ReadIniData(SECTION_GLOBAL, KEY_REOPENLIST, "[]", configPath);
            List<Dictionary<object, object>> list = serializer.Deserialize<List<Dictionary<object, object>>>(reopenFromIni);
            int i = list.FindIndex(x => x["filename"].ToString() == filename);
            if (i != -1)
            {
                //已存在,删除
                list.RemoveAt(i);
            }
            //加到末尾,显示时倒序即末尾最先显示
            list.Add(new Dictionary<object, object>
                {
                    {"filename",filename },
                    {"name",name }
                }
            );
            //只保留30个历史打开记录
            for (int j = 30; j < list.Count; j++)
            {
                list.RemoveAt(j);
            }

            var json = serializer.Serialize(list);
            OperateIniFile.WriteIniData(SECTION_GLOBAL, KEY_REOPENLIST, json, configPath);

            //修改reopen list
            InitReopen();
        }


        //缓存文件内容
        private void CacheFile(string filename)
        {
            Log($"filename:{filename}");

            list.Clear();

            //文件名称
            this.txtName = Path.GetFileName(filename);//书名存到全局
            this.Text = "SimpleReader - " + this.txtName;//修改title

            Encoding e = GetEncoding(filename);

            //FileStream fs = File.Open(filename, FileMode.Open);
            //Encoding encoding = TxtFileEncoding.GetEncoding(fs);
            //Log($"encoding:{encoding.EncodingName}");

            using (StreamReader reader = new StreamReader(filename))
            {
                string s1;
                while ((s1 = reader.ReadLine()) != null)
                {
                    list.Add(s1);
                }
            }
        }

        //重新加载到上次阅读的位置
        private Boolean GetLastReadMark(string txtName)
        {
            string bookname = MD5Encrypt16(txtName);
            string page = OperateIniFile.ReadIniData(SECTION_PAGINATION, bookname + ".page", "nodata", configPath);
            string countPerPage = OperateIniFile.ReadIniData(SECTION_PAGINATION, bookname + ".countPerPage", "nodata", configPath);
            if (page.Equals("nodata"))
            {
                this.page = 1;
                this.countPerPage = 100;
                return false;
            }
            else
            {
                this.page = Convert.ToInt32(page);
                this.countPerPage = Convert.ToInt32(countPerPage);
                return true;
            }
        }

        //打印日志
        private void Log(string v)
        {
            Console.WriteLine(v);
        }

        //导入点击
        private void importBtn_Click(object sender, EventArgs e)
        {
            openFileDialog1.FileName = "";
            openFileDialog1.ShowDialog();
        }

        //首页点击
        private void pageFirstBtn_Click(object sender, EventArgs e)
        {
            //MessageBox.Show("出错啦");
            page = 1;
            LoadPage(page);
        }

        //上一页点击
        private void pagePrevBtn_Click(object sender, EventArgs e)
        {
            page = page - 1;
            LoadPage(page);
        }

        //下一页点击
        private void pageNextBtn_Click(object sender, EventArgs e)
        {
            page = page + 1;
            LoadPage(page);
        }

        //末页点击
        private void pageEndBtn_Click(object sender, EventArgs e)
        {
            page = p != null ? p.GetTotalPage() : 1;
            LoadPage(page);
        }

        //页码输入,点击跳转
        private void pageGoBtn_Click(object sender, EventArgs e)
        {
            if (Regex.IsMatch(pageTextbox.Text, @"^\d+$"))
            {
                page = Convert.ToInt32(pageTextbox.Text);
            }
            else
            {
                return;
            }
            LoadPage(page);
        }

        //文档滚动条回到顶部
        private void RichTextBoxScrollToTop()
        {
            richTextBox1.Focus();//获取焦点
            richTextBox1.Select(0, 0);//光标定位到文本最后
            richTextBox1.ScrollToCaret();
        }

        //文档域内按下键盘
        private void RichTextBox1_KeyDown(object sender, KeyEventArgs e)
        {
            //空格
            if (e.KeyCode == Keys.Space)
            {
                SendKeys.Send("{PGDN}");//点击空格时,模拟翻页按钮
                e.SuppressKeyPress = true;//关闭"ding"的声音
            }

            //左
            if (e.KeyCode == Keys.Left)
            {
                pagePrevBtn_Click(null, null);
                e.SuppressKeyPress = true;//关闭"ding"的声音
            }

            //右
            if (e.KeyCode == Keys.Right)
            {
                pageNextBtn_Click(null, null);
                e.SuppressKeyPress = true;//关闭"ding"的声音
            }
            //esc
            if (e.KeyCode == Keys.Escape)
            {
                this.Hide();
            }
        }

        //翻页后设置page
        private void SetPage()
        {
            page = p != null ? p.GetCurtPage() : 1;
        }

        //每页行数,下拉框改变
        private void ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (pageCountPerPageCB.SelectedIndex == -1)
            {
                return;
            }
            this.countPerPage = Convert.ToInt32(pageCountPerPageCB.SelectedItem.ToString());
            LoadPage(1);
        }

        //加载第n页
        private void LoadPage(int page)
        {
            LoadPage(page, this.countPerPage, false);
        }

        //加载第n页
        private void LoadPage(int page, int countPerPage, Boolean isForceRefresh)
        {
            richTextBox1.Text = GetContent(page, countPerPage, isForceRefresh);
            SetPage();
            RichTextBoxScrollToTop();
            UpdatePageInfoLabel();
        }

        //更新翻页信息
        private void UpdatePageInfoLabel()
        {
            if (p == null)
            {
                return;
            }
            string s = string.Format("页数{0}/{1},每页{2}行,共{3}行.", p.GetCurtPage(), p.GetTotalPage(), p.countPerPage, p.total);
            pageInfo.Text = s;
        }

        //获取第n页的内容
        private string GetContent(int page, int countPerPage, Boolean isForceRefresh)
        {
            if (list.Count == 0)
            {
                return "文件内容为空";
            }
            if (p == null || isForceRefresh)
            {
                p = new Pager(list.Count);
            }
            p.countPerPage = countPerPage;
            p.curtPage = page;
            int start = (p.GetCurtPage() - 1) * p.countPerPage;
            int end = start + p.countPerPage;

            StringBuilder buffer = new StringBuilder();
            for (int i = start; i < end; i++)
            {
                if (i < 0 || i >= list.Count)
                {
                    break;
                }
                string s2 = list.ElementAt(i);
                buffer.Append(s2).Append("\n");
            }

            //Console.WriteLine(buffer.ToString());
            return buffer.ToString();
        }

        //翻页方法
        private string GetContent(int page)
        {
            return GetContent(page, this.countPerPage, false);
        }

        // 关闭事件
        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            SaveReadMark();
            DialogResult dr = MessageBox.Show("确定退出？", "提示", MessageBoxButtons.OKCancel);
            if (dr == DialogResult.Cancel)
            {
                e.Cancel = true;
            }
        }

        // 保存当前的阅读状态
        private void SaveReadMark()
        {
            if (txtName != null)
            {
                //第几页,每页行数写入配置
                OperateIniFile.WriteIniData(SECTION_PAGINATION, MD5Encrypt16(txtName) + ".page", this.page + "", configPath);
                OperateIniFile.WriteIniData(SECTION_PAGINATION, MD5Encrypt16(txtName) + ".countPerPage", this.countPerPage + "", configPath);
            }
        }

        ///编码
        public static string EncodeBase64(string code_type, string code)
        {
            string encode = "";
            byte[] bytes = Encoding.GetEncoding(code_type).GetBytes(code);
            try
            {
                encode = Convert.ToBase64String(bytes);
            }
            catch
            {
                encode = code;
            }
            return encode;
        }
        ///解码
        public static string DecodeBase64(string code_type, string code)
        {
            string decode = "";
            byte[] bytes = Convert.FromBase64String(code);
            try
            {
                decode = Encoding.GetEncoding(code_type).GetString(bytes);
            }
            catch
            {
                decode = code;
            }
            return decode;
        }

        //txt拖入
        private void splitContainer1_Panel1_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
            {
                e.Effect = DragDropEffects.Copy;
            }
            else
            {
                e.Effect = DragDropEffects.None;
            }
        }

        //txt拖入
        private void splitContainer1_Panel1_DragDrop(object sender, DragEventArgs e)
        {
            string[] filenames = (string[])e.Data.GetData(DataFormats.FileDrop);
            LoadFile(filenames[0]);//拖入多个txt时只处理第一个txt
        }

        //MD5加密
        public static string MD5Encrypt16(string password)
        {
            var md5 = new MD5CryptoServiceProvider();
            string t2 = BitConverter.ToString(md5.ComputeHash(Encoding.Default.GetBytes(password)), 4, 8);
            t2 = t2.Replace("-", "");
            return t2;
        }

        //下一个搜索
        private void buttonSearchNext_Click(object sender, EventArgs e)
        {
            SearchAndSelectTxt(true);
        }

        //上一个搜索
        private void buttonSearchPrev_Click(object sender, EventArgs e)
        {
            SearchAndSelectTxt(false);
        }
        //搜索+选中文本
        private void SearchAndSelectTxt(Boolean forward)
        {
            if (this.textBoxSearch.Text.Length == 0)
            {
                return;
            }
            //搜索
            int lineNum = GetSearchTextLine(forward);
            if (lineNum >= 0)
            {
                //第几页
                decimal page = Math.Ceiling((decimal)(lineNum + 1) / countPerPage);
                //加载该页
                LoadPage(((int)page));
                //选中高亮的区域,起点坐标
                int position = GetSearchPositionInPage(lineNum, ((int)page));
                //从起点坐标选择n个长度,文字高亮
                this.richTextBox1.Select(position, this.textBoxSearch.Text.Length);
            }
            else
            {
                MessageBox.Show("未找到");
                this.searchIndex = -1;
            }
        }



        // 搜索内容在当前页的位置(开始下标,结束下标)
        private int GetSearchPositionInPage(int lineNum, int page)
        {
            //搜索结果所在行内容
            string lineStr = list.ElementAt(lineNum);
            //搜索结果所在行号
            int searchLine = lineNum - (page - 1) * countPerPage;
            //搜索结果所在行起始点
            int lineStart = lineStr.IndexOf(this.textBoxSearch.Text);
            int posiStart = 0;
            //[搜索结果页的第0行->结果所在行-1]的所有字数累加
            for (int i = (page - 1) * countPerPage; i <= lineNum - 1; i++)
            {
                posiStart += list.ElementAt(i).Length + 1;//+1是回车
            }
            posiStart += lineStart;
            return posiStart;
        }

        /// <summary>
        /// 搜索内容行号
        /// </summary>
        /// <param name="forward">true,从前往后; false-从后往前</param>
        /// <returns></returns>
        private int GetSearchTextLine(Boolean forward = true)
        {
            if (forward)
            {
                //搜索方向,从开始到结尾
                for (int i = this.searchIndex + 1; i < list.Count; i++)
                {
                    if (list.ElementAt(i).Contains(this.textBoxSearch.Text))
                    {
                        this.searchIndex = i;
                        return i;
                    }
                }
            }
            else
            {
                //搜索方向,从结尾到开始
                for (int i = this.searchIndex - 1; i > 0; i--)
                {
                    if (list.ElementAt(i).Contains(this.textBoxSearch.Text))
                    {
                        this.searchIndex = i;
                        return i;
                    }
                }
            }
            //没找到
            return -1;
        }

        //搜索框输入时,搜索索引归零
        private void textBoxSearch_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (this.searchIndex != 0)
            {
                this.searchIndex = 0;
            }
        }

        //搜索框回车触发搜索
        private void textBoxSearch_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                buttonSearchNext_Click(sender, e);
            }
        }

        //页码框回车触发搜索
        private void pageTextbox_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                pageGoBtn_Click(sender, e);
            }
        }

        //获取文件编码
        public Encoding GetEncoding(string filename)
        {
            // Read the BOM
            var bom = new byte[4];
            using (var file = new FileStream(filename, FileMode.Open, FileAccess.Read))
            {
                file.Read(bom, 0, 4);
            }

            // Analyze the BOM
            if (bom[0] == 0x2b && bom[1] == 0x2f && bom[2] == 0x76) return Encoding.UTF7;
            if (bom[0] == 0xef && bom[1] == 0xbb && bom[2] == 0xbf) return Encoding.UTF8;
            if (bom[0] == 0xff && bom[1] == 0xfe && bom[2] == 0 && bom[3] == 0) return Encoding.UTF32; //UTF-32LE
            if (bom[0] == 0xff && bom[1] == 0xfe) return Encoding.Unicode; //UTF-16LE
            if (bom[0] == 0xfe && bom[1] == 0xff) return Encoding.BigEndianUnicode; //UTF-16BE
            if (bom[0] == 0 && bom[1] == 0 && bom[2] == 0xfe && bom[3] == 0xff) return new UTF32Encoding(true, true);  //UTF-32BE

            // We actually have no idea what the encoding is if we reach this point, so
            // you may wish to return null instead of defaulting to ASCII

            return Encoding.Default;
        }

        //右下任务栏图标,显示
        private void itemShow_Click(object sender, EventArgs e)
        {
            this.Show();
            this.Activate();
        }

        //右下任务栏,关闭
        private void itemClose_Click(object sender, EventArgs e)
        {
            SaveReadMark();
            this.Dispose();//施放资源
            System.Environment.Exit(System.Environment.ExitCode);
        }

        //右下任务栏,隐藏
        private void itemHide_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        //右下任务栏,双击切换显示/隐藏
        private void notifyIcon1_MouseClick(object sender, MouseEventArgs e)
        {
            if (this.Visible == true)
            {
                this.Hide();
            }
            else
            {
                this.Show();
                this.Activate();
            }

        }

        private void fontSizeComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.richTextBox1.Font = new System.Drawing.Font("宋体", float.Parse(this.fontSizeComboBox.SelectedItem.ToString()),
                System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
        }

    }

    //翻页工具类
    class Pager
    {
        public int curtPage;
        public int countPerPage = 1000;
        public int total;
        public int totalPage;

        public Pager()
        {
        }

        public Pager(int total)
        {
            this.total = total;
        }

        public int GetCurtPage()
        {
            if (curtPage == 0)
            {
                curtPage = 1;
            }

            if (curtPage > GetTotalPage())
            {
                curtPage = GetTotalPage();
            }

            return curtPage;
        }

        public int GetTotalPage()
        {
            double d = (double)total / countPerPage;
            totalPage = (int)Math.Ceiling(d);
            return totalPage;
        }
    }
}
