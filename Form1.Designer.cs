namespace TCPUDP调试工具
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
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.button_link = new System.Windows.Forms.Button();
            this.m_portRemote = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.m_portLocal = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.m_ipRemote = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button4 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button_clear = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.Textrecv = new System.Windows.Forms.RichTextBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button_send = new System.Windows.Forms.Button();
            this.buttonOpenHtml = new System.Windows.Forms.Button();
            this.sendTabControl = new System.Windows.Forms.TabControl();
            this.tabPageAdd = new System.Windows.Forms.TabPage();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel2 = new System.Windows.Forms.ToolStripStatusLabel();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.sendTabControl.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // button_link
            // 
            this.button_link.Location = new System.Drawing.Point(67, 119);
            this.button_link.Name = "button_link";
            this.button_link.Size = new System.Drawing.Size(75, 23);
            this.button_link.TabIndex = 0;
            this.button_link.Text = "连接网络";
            this.button_link.UseVisualStyleBackColor = true;
            this.button_link.Click += new System.EventHandler(this.button_link_Click);
            // 
            // m_portRemote
            // 
            this.m_portRemote.FormattingEnabled = true;
            this.m_portRemote.Location = new System.Drawing.Point(77, 198);
            this.m_portRemote.Name = "m_portRemote";
            this.m_portRemote.Size = new System.Drawing.Size(71, 20);
            this.m_portRemote.TabIndex = 2;
            this.m_portRemote.Text = "0";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 201);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 12);
            this.label1.TabIndex = 3;
            this.label1.Text = "远程端口";
            // 
            // m_portLocal
            // 
            this.m_portLocal.FormattingEnabled = true;
            this.m_portLocal.Items.AddRange(new object[] {
            "33445",
            "80",
            "8080"});
            this.m_portLocal.Location = new System.Drawing.Point(77, 224);
            this.m_portLocal.Name = "m_portLocal";
            this.m_portLocal.Size = new System.Drawing.Size(71, 20);
            this.m_portLocal.TabIndex = 2;
            this.m_portLocal.Text = "33445";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 227);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 12);
            this.label2.TabIndex = 3;
            this.label2.Text = "本地端口";
            // 
            // m_ipRemote
            // 
            this.m_ipRemote.Location = new System.Drawing.Point(20, 171);
            this.m_ipRemote.Name = "m_ipRemote";
            this.m_ipRemote.Size = new System.Drawing.Size(128, 21);
            this.m_ipRemote.TabIndex = 4;
            this.m_ipRemote.Text = "127.0.0.1";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button4);
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.button_clear);
            this.groupBox1.Controls.Add(this.m_ipRemote);
            this.groupBox1.Controls.Add(this.m_portRemote);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.m_portLocal);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.groupBox3);
            this.groupBox1.Location = new System.Drawing.Point(12, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(170, 552);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "设置";
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(20, 503);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(114, 33);
            this.button4.TabIndex = 0;
            this.button4.Text = "编辑发送脚本";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(20, 465);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(114, 33);
            this.button2.TabIndex = 0;
            this.button2.Text = "编辑接收脚本";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button_clear
            // 
            this.button_clear.Location = new System.Drawing.Point(20, 290);
            this.button_clear.Name = "button_clear";
            this.button_clear.Size = new System.Drawing.Size(114, 33);
            this.button_clear.TabIndex = 0;
            this.button_clear.Text = "清空接收区(&C)";
            this.button_clear.UseVisualStyleBackColor = true;
            this.button_clear.Click += new System.EventHandler(this.button_clear_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.radioButton3);
            this.groupBox2.Controls.Add(this.radioButton2);
            this.groupBox2.Controls.Add(this.radioButton1);
            this.groupBox2.Location = new System.Drawing.Point(6, 32);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(148, 93);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "通信方式";
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.Checked = true;
            this.radioButton3.Location = new System.Drawing.Point(14, 64);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(41, 16);
            this.radioButton3.TabIndex = 5;
            this.radioButton3.TabStop = true;
            this.radioButton3.Text = "UDP";
            this.radioButton3.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(14, 42);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(83, 16);
            this.radioButton2.TabIndex = 5;
            this.radioButton2.Text = "TCP Server";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(14, 20);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(83, 16);
            this.radioButton1.TabIndex = 5;
            this.radioButton1.Text = "TCP Client";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.button_link);
            this.groupBox3.Location = new System.Drawing.Point(6, 131);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(148, 153);
            this.groupBox3.TabIndex = 7;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "设置";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 25);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 12);
            this.label3.TabIndex = 3;
            this.label3.Text = "远程IP";
            // 
            // Textrecv
            // 
            this.Textrecv.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Textrecv.Location = new System.Drawing.Point(6, 13);
            this.Textrecv.Name = "Textrecv";
            this.Textrecv.Size = new System.Drawing.Size(583, 226);
            this.Textrecv.TabIndex = 7;
            this.Textrecv.Text = "";
            this.Textrecv.TextChanged += new System.EventHandler(this.Textrecv_TextChanged);
            // 
            // groupBox4
            // 
            this.groupBox4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox4.Controls.Add(this.Textrecv);
            this.groupBox4.Location = new System.Drawing.Point(189, 13);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(595, 244);
            this.groupBox4.TabIndex = 8;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "接收区";
            // 
            // groupBox5
            // 
            this.groupBox5.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox5.Controls.Add(this.sendTabControl);
            this.groupBox5.Controls.Add(this.button1);
            this.groupBox5.Controls.Add(this.button_send);
            this.groupBox5.Location = new System.Drawing.Point(189, 274);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(680, 291);
            this.groupBox5.TabIndex = 9;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "发送区域";
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.Enabled = false;
            this.button1.Location = new System.Drawing.Point(601, 180);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(73, 55);
            this.button1.TabIndex = 8;
            this.button1.Text = "执行发送脚本，并发送 (&R)";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button_send
            // 
            this.button_send.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.button_send.Enabled = false;
            this.button_send.Location = new System.Drawing.Point(601, 56);
            this.button_send.Name = "button_send";
            this.button_send.Size = new System.Drawing.Size(73, 55);
            this.button_send.TabIndex = 0;
            this.button_send.Text = "发送(&S)";
            this.button_send.UseVisualStyleBackColor = true;
            this.button_send.Click += new System.EventHandler(this.button_send_Click);
            // 
            // buttonOpenHtml
            // 
            this.buttonOpenHtml.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonOpenHtml.Enabled = false;
            this.buttonOpenHtml.Location = new System.Drawing.Point(790, 26);
            this.buttonOpenHtml.Name = "buttonOpenHtml";
            this.buttonOpenHtml.Size = new System.Drawing.Size(73, 226);
            this.buttonOpenHtml.TabIndex = 8;
            this.buttonOpenHtml.Text = "执行脚本(&Q)";
            this.buttonOpenHtml.UseVisualStyleBackColor = true;
            this.buttonOpenHtml.Click += new System.EventHandler(this.buttonOpenHtml_Click);
            // 
            // sendTabControl
            // 
            this.sendTabControl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.sendTabControl.Controls.Add(this.tabPageAdd);
            this.sendTabControl.Location = new System.Drawing.Point(6, 20);
            this.sendTabControl.Name = "sendTabControl";
            this.sendTabControl.SelectedIndex = 0;
            this.sendTabControl.Size = new System.Drawing.Size(583, 265);
            this.sendTabControl.TabIndex = 9;
            this.sendTabControl.SelectedIndexChanged += new System.EventHandler(this.sendTabControl_SelectedIndexChanged);
            this.sendTabControl.Click += new System.EventHandler(this.sendTabControl_Click);
            // 
            // tabPageAdd
            // 
            this.tabPageAdd.Cursor = System.Windows.Forms.Cursors.Default;
            this.tabPageAdd.Location = new System.Drawing.Point(4, 22);
            this.tabPageAdd.Name = "tabPageAdd";
            this.tabPageAdd.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageAdd.Size = new System.Drawing.Size(575, 239);
            this.tabPageAdd.TabIndex = 0;
            this.tabPageAdd.Text = "+";
            this.tabPageAdd.UseVisualStyleBackColor = true;
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1,
            this.toolStripStatusLabel2});
            this.statusStrip1.Location = new System.Drawing.Point(0, 580);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(881, 22);
            this.statusStrip1.TabIndex = 10;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(19, 17);
            this.toolStripStatusLabel1.Text = "ip";
            // 
            // toolStripStatusLabel2
            // 
            this.toolStripStatusLabel2.Name = "toolStripStatusLabel2";
            this.toolStripStatusLabel2.Size = new System.Drawing.Size(33, 17);
            this.toolStripStatusLabel2.Text = "port";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(881, 602);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.buttonOpenHtml);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox4);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "UDP脚本调试器";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            this.sendTabControl.ResumeLayout(false);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_link;
        private System.Windows.Forms.ComboBox m_portRemote;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox m_portLocal;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox m_ipRemote;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button_clear;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton radioButton3;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.RichTextBox Textrecv;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Button button_send;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button buttonOpenHtml;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TabControl sendTabControl;
        private System.Windows.Forms.TabPage tabPageAdd;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel2;
    }
}

