using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Threading;
using System.IO;

namespace TopLottery
{
    public partial class Form1 : Form
    {
        DataTable ds = new DataTable();
        Thread th;
        bool isGO = false;
        int staffnum;
        int[] counts = { 5, 8, 12, 20,30 };//奖池数量，每抽一个就减一
        int[] totalcounts = { 5, 8, 12, 20, 30 };//总数
        int[] firstcount = { 1,4,4,10,10};//初始值
        int[] secondcount = { 1, 4, 4, 10, 10 };//累计值
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void toolStripDropDownButton1_Click(object sender, EventArgs e)
        {

        }

        private void toolStripLabel1_Click(object sender, EventArgs e)
        {

        }

        private void toolStripLabel2_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.button1.Enabled = false;
            this.button2.Enabled = false;
            CheckForIllegalCrossThreadCalls = false;
            th = new Thread(new ThreadStart(run)); //创建线程 
            th.IsBackground = true;
            th.Start(); //启动线程
        }
        private void run() {
            int k = 0;
            while (true) {
                if (isGO) {
                    if (ds != null && ds.Rows.Count != 0)
                    {
                        this.label1.Font = new System.Drawing.Font("宋体", 96F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
                        Random r = new Random();
                        int i = r.Next(0, ds.Rows.Count);
                        this.label1.Text = ds.Rows[i]["number"].ToString().Trim();
                        k = 1;
                    }
                    else
                    {
                        isGO = false;
                        this.button1.Enabled = false;
                        this.button2.Enabled = false;
                        MessageBox.Show("无人员信息");
                    }

                }
                if (!isGO && k == 1)
                {
                    Random r = new Random();
                    if (comboBox1.SelectedIndex == 0) {
                            staffnum = r.Next(0, ds.Rows.Count);
                            this.label1.Text = ds.Rows[staffnum]["number"].ToString().Trim();
                            ds.Rows.RemoveAt(staffnum);
                        
                     }
                    if (comboBox1.SelectedIndex == 1 || comboBox1.SelectedIndex == 2)
                    {
                        this.label1.Text = "";                       
                        for (int i = 3; i >= 0; i--)
                        {
                                staffnum = r.Next(0, ds.Rows.Count);
                                string numbers1 = ds.Rows[staffnum]["number"].ToString().Trim();
                                this.label1.Text += numbers1 + " ";
                                ds.Rows.RemoveAt(staffnum);
                            
                        }
                        this.label1.Font = new System.Drawing.Font("宋体", 90F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
                    }
                    if (comboBox1.SelectedIndex >=3) {
                        this.label1.Text = "";
                        for (int i = 9; i  >=0; i--) {
                            staffnum = r.Next(0, ds.Rows.Count);
                            string numbers1 = ds.Rows[staffnum]["number"].ToString().Trim();
                            this.label1.Text += numbers1 + " ";
                            ds.Rows.RemoveAt(staffnum);
                        }
                        this.label1.Font= new System.Drawing.Font("宋体", 75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
 
                    }
                   
                    Log(this.label1.Text);
                    k = 0;
                    counts[comboBox1.SelectedIndex]=totalcounts[comboBox1.SelectedIndex]-firstcount[comboBox1.SelectedIndex];
                    firstcount[comboBox1.SelectedIndex]= firstcount[comboBox1.SelectedIndex] + secondcount[comboBox1.SelectedIndex];
                    if (counts[comboBox1.SelectedIndex] <= 0)
                    {
                        this.button1.Enabled = false;
                        this.button2.Enabled = false;
                    }
                    else
                    {
                        this.button1.Enabled = true;
                        this.button2.Enabled = false;
                    }
                }
                System.Threading.Thread.Sleep(30);
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            this.button1.Enabled = false;
            this.button2.Enabled = true;
            isGO = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            isGO = false;
        }
        public static SqlConnection creatConn()
        {
            string connStr = "Data Source=localhost;Initial Catalog=******;User ID=sa;Password=******;Connect Timeout=500";//连接数据库字段
            SqlConnection conn = new SqlConnection(connStr);
            return conn;
        }

        private void 初始化名单ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            gatherdata();
        }
        private void gatherdata()
        {
            SqlConnection conn = creatConn();
            try
            {

                conn.Open();
                string strsql = "select name,number from namenumber";//查询号码语句
                SqlDataAdapter sda = new SqlDataAdapter(strsql, conn);
                ds = new DataTable();
                sda.Fill(ds);
                if (ds != null && ds.Rows.Count != 0)
                {
                    MessageBox.Show("初始化名单成功");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("查询错误！" + ex.Message);
            }
            finally
            {
                    conn.Close();
            }
        }

        private void txtLog_TextChanged(object sender, EventArgs e)
        {

        }
        public void Log(string log)
        {

            string logStr = string.Format("**恭喜号码{0}获{1}**{2}of{3}{4}", log, comboBox1.Text,firstcount[comboBox1.SelectedIndex],totalcounts[comboBox1.SelectedIndex], "\n");
            if (txtLog.InvokeRequired)
            {
                txtLog.Invoke(new Action(delegate
                {
                    int intLines = this.txtLog.GetLineFromCharIndex(this.txtLog.TextLength) + 1;
                    if (intLines > 200)
                    {
                        txtLog.Clear();
                    }
                    txtLog.AppendText(logStr);
                }));
            }
            else
            {
                int intLines = this.txtLog.GetLineFromCharIndex(this.txtLog.TextLength) + 1;
                if (intLines > 2000)
                {
                    txtLog.Clear();
                }
                txtLog.AppendText(logStr);
                this.txtLog.Select(this.txtLog.TextLength, 0);
                this.txtLog.ScrollToCaret();
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (counts[comboBox1.SelectedIndex] <= 0)
            {
                this.button1.Enabled = false;
                this.button2.Enabled = false;
            }
            else
            {
                this.button1.Enabled = true;
                this.button2.Enabled = false;
            }
        }

        private void 保存中奖名单ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "(*.txt)|*.txt|(*.*)|*.*";
            saveFileDialog.FileName = "中奖名单" + DateTime.Now.ToString("yyyyMMddHHmm") + ".txt";
            //将日期时间作为文件名
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                StreamWriter streamWriter = new StreamWriter(saveFileDialog.FileName, true);
                streamWriter.Write(this.txtLog.Text);
                streamWriter.Close();
            }
        }

        private void toolStripDropDownButton2_Click(object sender, EventArgs e)
        {

        }
    }
}
