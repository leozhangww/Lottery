using System.Windows.Forms;

namespace TopLottery
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripDropDownButton1 = new System.Windows.Forms.ToolStripDropDownButton();
            this.初始化名单ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.保存中奖名单ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripDropDownButton2 = new System.Windows.Forms.ToolStripDropDownButton();
            this.抽奖程序ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.最终解释权152012261ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.txtLog = new System.Windows.Forms.RichTextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.BackColor = System.Drawing.Color.Salmon;
            this.label1.Font = new System.Drawing.Font("宋体", 96F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(562, 334);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(850, 225);
            this.label1.TabIndex = 0;
            this.label1.Text = "--开始抽奖--";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(717, 671);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(183, 67);
            this.button1.TabIndex = 1;
            this.button1.Text = "开始";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(1028, 671);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(184, 67);
            this.button2.TabIndex = 2;
            this.button2.Text = "停止";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripDropDownButton1,
            this.toolStripSeparator1,
            this.toolStripDropDownButton2});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1984, 25);
            this.toolStrip1.TabIndex = 3;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripDropDownButton1
            // 
            this.toolStripDropDownButton1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.初始化名单ToolStripMenuItem,
            this.保存中奖名单ToolStripMenuItem});
            this.toolStripDropDownButton1.Name = "toolStripDropDownButton1";
            this.toolStripDropDownButton1.Size = new System.Drawing.Size(45, 22);
            this.toolStripDropDownButton1.Text = "选项";
            // 
            // 初始化名单ToolStripMenuItem
            // 
            this.初始化名单ToolStripMenuItem.Name = "初始化名单ToolStripMenuItem";
            this.初始化名单ToolStripMenuItem.Size = new System.Drawing.Size(148, 22);
            this.初始化名单ToolStripMenuItem.Text = "初始化名单";
            this.初始化名单ToolStripMenuItem.Click += new System.EventHandler(this.初始化名单ToolStripMenuItem_Click);
            // 
            // 保存中奖名单ToolStripMenuItem
            // 
            this.保存中奖名单ToolStripMenuItem.Name = "保存中奖名单ToolStripMenuItem";
            this.保存中奖名单ToolStripMenuItem.Size = new System.Drawing.Size(148, 22);
            this.保存中奖名单ToolStripMenuItem.Text = "保存中奖名单";
            this.保存中奖名单ToolStripMenuItem.Click += new System.EventHandler(this.保存中奖名单ToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripDropDownButton2
            // 
            this.toolStripDropDownButton2.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.抽奖程序ToolStripMenuItem,
            this.最终解释权152012261ToolStripMenuItem});
            this.toolStripDropDownButton2.Name = "toolStripDropDownButton2";
            this.toolStripDropDownButton2.Size = new System.Drawing.Size(45, 22);
            this.toolStripDropDownButton2.Text = "关于";
            this.toolStripDropDownButton2.Click += new System.EventHandler(this.toolStripDropDownButton2_Click);
            // 
            // 抽奖程序ToolStripMenuItem
            // 
            this.抽奖程序ToolStripMenuItem.Name = "抽奖程序ToolStripMenuItem";
            this.抽奖程序ToolStripMenuItem.Size = new System.Drawing.Size(234, 22);
            this.抽奖程序ToolStripMenuItem.Text = "抽奖程序";
            // 
            // 最终解释权152012261ToolStripMenuItem
            // 
            this.最终解释权152012261ToolStripMenuItem.Name = "最终解释权152012261ToolStripMenuItem";
            this.最终解释权152012261ToolStripMenuItem.Size = new System.Drawing.Size(234, 22);
            this.最终解释权152012261ToolStripMenuItem.Text = "有问题可联系QQ:152012261";
            // 
            // txtLog
            // 
            this.txtLog.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtLog.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtLog.ForeColor = System.Drawing.Color.Red;
            this.txtLog.Location = new System.Drawing.Point(1368, 616);
            this.txtLog.Name = "txtLog";
            this.txtLog.Size = new System.Drawing.Size(336, 297);
            this.txtLog.TabIndex = 4;
            this.txtLog.Text = "";
            this.txtLog.TextChanged += new System.EventHandler(this.txtLog_TextChanged);
            // 
            // comboBox1
            // 
            this.comboBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.comboBox1.BackColor = System.Drawing.Color.IndianRed;
            this.comboBox1.DropDownHeight = 145;
            this.comboBox1.Font = new System.Drawing.Font("宋体", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.comboBox1.IntegralHeight = false;
            this.comboBox1.Items.AddRange(new object[] {
            "特等奖",
            "一等奖",
            "二等奖",
            "三等奖",
            "四等级"});
            this.comboBox1.Location = new System.Drawing.Point(1478, 533);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(126, 32);
            this.comboBox1.TabIndex = 5;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // Form1
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.AutoSize = true;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1984, 1061);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.txtLog);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Lottery";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private ToolStripDropDownButton toolStripDropDownButton1;
        private ToolStripMenuItem 初始化名单ToolStripMenuItem;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripDropDownButton toolStripDropDownButton2;
        private ToolStripMenuItem 抽奖程序ToolStripMenuItem;
        private RichTextBox txtLog;
        private ComboBox comboBox1;
        private ToolStripMenuItem 保存中奖名单ToolStripMenuItem;
        private ToolStripMenuItem 最终解释权152012261ToolStripMenuItem;
    }
}

