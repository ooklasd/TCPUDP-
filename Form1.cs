using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading;
using System.Net;
using System.IO;
using System.Text.RegularExpressions;
using System.Reflection;

namespace TCPUDP调试工具
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            recvJSFileName = "recv.js";
            sendJSFileName = "send.js";
            recvCSFileName = "recv.cs";
            sendCSFileName = "send.cs";
            JSPath = AppDomain.CurrentDomain.BaseDirectory + "js\\";

           // addPage("发送消息");

            //textShow.Navigate(AppDomain.CurrentDomain.BaseDirectory+@"index.html");
        }

        Thread m_recvThread;
        InterfaceSendRecv m_curSendRecv;
        bool isStopRecvThread;
        byte[] revcBuffer;      //接收缓冲区
        byte[] revcBufferBin;   //当前显示的二进制源数据
        string recvJSFileName;
        string sendJSFileName;  

        string recvCSFileName;
        string sendCSFileName;

        string JSPath;
        string textSend
        {
            get
            {
                if (sendTabControl.SelectedTab.Controls.Count == 0) return "";
                var temp = sendTabControl.SelectedTab.Controls[0];
                var richedit = (RichTextBox)temp;
                return richedit.Text;
            }
            set
            {
                if (sendTabControl.SelectedTab.Controls.Count == 0) return;
                var temp = sendTabControl.SelectedTab.Controls[0];
                var richedit = (RichTextBox)temp;
                richedit.Text = value;
            }

        }

        private void button_link_Click(object sender, EventArgs e)
        {
            //连接网络
            if (radioButton3.Checked)
            {
                var udp = new UDPSendRecv();
                udp.portLocal = Convert.ToInt32(m_portLocal.Text);
                udp.ipRemote = m_ipRemote.Text;
                udp.portRemote = Convert.ToInt32(m_portRemote.Text);
                m_curSendRecv = udp;
            }

            try
            {
                //初始化
                m_curSendRecv.init();
                m_curSendRecv.start();

                var ipinfo = (IPEndPoint)m_curSendRecv.getLocalInfo();
                toolStripStatusLabel1.Text = "ip:" + ipinfo.Address.ToString();
                toolStripStatusLabel2.Text = "port:" + ipinfo.Port.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            //启动接收线程
            isStopRecvThread = false;
            button_link.Enabled = false;
            m_recvThread = new Thread(new ThreadStart(recvThreadRun));
            m_recvThread.Start();
            textSend_TextChanged(sender,e);
            button_link.Text = "断开连接";
            button_link.Click -= new System.EventHandler(this.button_link_Click);
            button_link.Click += new System.EventHandler(this.button_Stoplink_Click);
           
        }

        private void button_Stoplink_Click(object sender, EventArgs e)
        {
            //断开连接
            button_link.Enabled = false; 
            m_curSendRecv.stop();
            isStopRecvThread = true;
            m_recvThread.Join();
            button_link.Enabled = true;

            button_link.Text = "连接网络";
            button_link.Click -= new System.EventHandler(this.button_Stoplink_Click);
            button_link.Click += new System.EventHandler(this.button_link_Click);
        }   
    
        void Enablebutton_link(bool enable)
        {
            if (button_link.InvokeRequired)
            {
                // 当一个控件的InvokeRequired属性值为真时，说明有一个创建它以外的线程想访问它
                Action<bool> actionDelegate = (x) => { 
                    this.button_link.Enabled = x;
                };
                // 或者
                this.button_link.Invoke(actionDelegate, enable);
            }
            else
            {
                this.button_link.Enabled = enable;
            }
        }


        void SetTextm_ipRemote(string text)
        {
            if (m_ipRemote.InvokeRequired)
            {
                // 当一个控件的InvokeRequired属性值为真时，说明有一个创建它以外的线程想访问它
                Action<string> actionDelegate = (x) => { this.m_ipRemote.Text = text; };
                // 或者
                this.m_ipRemote.Invoke(actionDelegate, text);
            }
        }

        void SetTextm_portRemote(string text)
        {
            if (m_portRemote.InvokeRequired)
            {
                // 当一个控件的InvokeRequired属性值为真时，说明有一个创建它以外的线程想访问它
                Action<string> actionDelegate = (x) => { this.m_portRemote.Text = x; };
                // 或者
                this.m_portRemote.Invoke(actionDelegate, text);
            }
        }

        void setTextTextrecv(string text)
        {
            if (Textrecv.InvokeRequired)
            {
                // 当一个控件的InvokeRequired属性值为真时，说明有一个创建它以外的线程想访问它
                Action<string> actionDelegate = (x) => { this.Textrecv.Text = x;};
                // 或者
                this.Textrecv.Invoke(actionDelegate, text);
            }
        }

        void SetTexttextShow(string text)
        {
            //if (textShow.InvokeRequired)
            //{
            //    // 当一个控件的InvokeRequired属性值为真时，说明有一个创建它以外的线程想访问它
            //    Action<string> actionDelegate = (x) => { this.textShow.DocumentText = x; };
            //    // 或者
            //    this.textShow.Invoke(actionDelegate, text);
            //}
        }

        private void recvThreadRun()
        {
            Enablebutton_link(true);

            //button_link.Enabled = true;
            while (isStopRecvThread == false)
            {
                //接收到某个信息
                var recvNumber = m_curSendRecv.recv(ref revcBuffer);
                if (recvNumber < 0) continue;

                revcBufferBin = copybyte(revcBufferBin, revcBuffer, recvNumber);               

                if (isStopRecvThread) break;

                //获取远程信息
                var info = (IPEndPoint)m_curSendRecv.getRemoteInfo();
                SetTextm_ipRemote(info.Address.ToString());
                SetTextm_portRemote(info.Port.ToString());

                string revcBufferString = Encoding.Default.GetString(revcBufferBin, 0, revcBufferBin.Length);
                setTextTextrecv(revcBufferString);

                //string result = "";
                //try
                //{
                //    //触发脚本
                //    //jsExecuteRecvScript(recvText);
                //    result = csExecuteRecvScript(revcBufferBin);
                //}
                //catch(Exception ex)
                //{
                //    MessageBox.Show(ex.Message);
                //}                

                ////生成网页，刷新到控件
                //SetTexttextShow(result);
            }
            //button_link.Enabled = true;
           //Enablebutton_link(true);
        }

        private string csExecuteRecvScript(byte[] recvText)
        {
            myCSScript script = new myCSScript();
            script.loadscriptfile(JSPath + recvCSFileName);
            return script.run("recv",recvText);
        }

        private string csExecuteSendScript(byte[] recvText)
        {
            myCSScript script = new myCSScript();
            script.loadscriptfile(JSPath + sendCSFileName);
            return script.run("send", recvText);
        }

        public string jsExecuteRecvScript(string buffer)
        {
            string path = JSPath + recvJSFileName;
            if (File.Exists(path) == false) return "";
            string str2 = File.ReadAllText(path);
            buffer = Regex.Replace(buffer, @"[/n]", "");
            string fun = string.Format(@"recv('{0}')", buffer);
            return ExecuteScript(fun, str2);
        }

        public string jsExecuteSendScript(string buffer)
        {
            string path = JSPath + recvJSFileName;
            if (File.Exists(path) == false) return "";
            string str2 = File.ReadAllText(path);
            buffer = Regex.Replace(buffer, @"[/n]", "");
            string fun = string.Format(@"send('{0}')", buffer);
           return ExecuteScript(fun, str2);
        }


        /// <summary>
        /// 执行JS
        /// </summary>
        /// <param name="sExpression">参数体</param>
        /// <param name="sCode">JavaScript代码的字符串</param>
        /// <returns></returns>
        private string ExecuteScript(string sExpression, string sCode)
        {
            
            try
            {
                MSScriptControl.ScriptControl scriptControl = new MSScriptControl.ScriptControl();
                scriptControl.UseSafeSubset = true;
                scriptControl.Language = "JScript";
                scriptControl.AddCode(sCode);
                string str = scriptControl.Eval(sExpression).ToString();
                return str;
            }
            catch (Exception ex)
            {
                string str = ex.Message;
                MessageBox.Show("脚本加载失败："+str);
            }
            return null;
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                //断开连接
                button_link.Enabled = false;
                if (m_curSendRecv != null) m_curSendRecv.stop();
                isStopRecvThread = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                if (m_recvThread != null) m_recvThread.Abort();
            }            
        }

        private void button_clear_Click(object sender, EventArgs e)
        {
            revcBufferBin = null;            
            Textrecv.Clear();
            //textShow.DocumentText = "";
        }

        private void button_send_Click(object sender, EventArgs e)
        {
            string sendString = textSend;
            sendString = sendString.Trim();
            if (sendString.Length == 0) return;
            m_curSendRecv.send(Encoding.Default.GetBytes(sendString));
        }

        private void button4_Click(object sender, EventArgs e)
        {
            string file = JSPath + sendCSFileName;
            try
            {
                var path = Path.GetDirectoryName(file);
                System.Diagnostics.Process.Start(file);
                System.Diagnostics.Process.Start(path);
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message + file);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string file = JSPath + recvCSFileName;
            try
            {
                var path = Path.GetDirectoryName(file);
                System.Diagnostics.Process.Start(file);
                System.Diagnostics.Process.Start(path);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + file);
            }
        }

        public static byte[] copybyte(byte[] a, byte[] b)
        {
            int alen = a == null ? 0 : a.Length;
            int blen = b == null ? 0 : b.Length;
            return copybyte(a,b);
        }

        public static byte[] copybyte(byte[] a,int alen, byte[] b, int blen)
        {
            byte[] c = new byte[alen + blen];
            if (a != null) Array.Copy(a, 0, c, 0, alen);
            if (b != null) Array.Copy(b, 0, c, alen, blen);
            return c;
        }

        public static byte[] copybyte(byte[] a, byte[] b, int blen)
        {
            return copybyte(a, a==null?0:a.Length, b, blen);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            addPage("发送消息");
        }

        private void buttonOpenHtml_Click(object sender, EventArgs e)
        {
            if (revcBufferBin == null || revcBufferBin.Length == 0) return;
            string result = "";
            try
            {
                //触发脚本
                //jsExecuteRecvScript(recvText);
                result = csExecuteRecvScript(revcBufferBin);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            if(result.Length ==0) return ;         

            //生成网页，刷新到控件
            //刷新到某个临时文件            
            var tempFilehtml = AppDomain.CurrentDomain.BaseDirectory + @"html\index.html";
            

            File.WriteAllText(tempFilehtml, result);           
            //打开临时文件
            System.Diagnostics.Process.Start(tempFilehtml);
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string sendString = textSend;

            try
            {
                var gb = Encoding.GetEncoding("GB2312").GetBytes(sendString);
                sendString = csExecuteSendScript(gb);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            if (sendString == null) sendString = textSend;

            if (m_curSendRecv != null)
                m_curSendRecv.send(Encoding.Default.GetBytes(sendString));
        }

        private void Textrecv_TextChanged(object sender, EventArgs e)
        {
            buttonOpenHtml.Enabled = Textrecv.Text.Length != 0;            
        }

        private void textSend_TextChanged(object sender, EventArgs e)
        {
            bool isEnableSend = (m_curSendRecv != null) && textSend.Length != 0;
            button_send.Enabled = button1.Enabled = isEnableSend;

            var control = sender as Control;
            if (control != null)
            {
                var page = control.Parent as TabPage;
                if (page != null)
                {
                    page.Text = control.Text.Substring(0, Math.Min(20, control.Text.Length));
                }
            }            
        }

        private void sendTabControl_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (sendTabControl.SelectedIndex == sendTabControl.TabCount-1)
           {
               addPage("发送消息");
           }
        }



        private void addPage(string name)
        {
            var item = new System.Windows.Forms.RichTextBox();

            item.Name = "sendText";
            //item.Parent = sendTabControl;
            item.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            item.Location = new System.Drawing.Point(1, 2);
            item.TabIndex = 0;
            item.Show();

            item.TextChanged += new EventHandler(textSend_TextChanged);
            ;

            TabPage tb = new TabPage(name);
            tb.Controls.Add(item); 
            tb.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            //sendTabControl.TabPages.Add(tb);
            tb.Show();
           
            int index = sendTabControl.TabCount - 1;
            sendTabControl.TabPages.Insert(index,tb);
            sendTabControl.SelectedTab = tb;
        }

        private void sendTabControl_Click(object sender, EventArgs e)
        {
            var mv = (MouseEventArgs)(e);
            if (mv.Button == System.Windows.Forms.MouseButtons.Right)
            {
                for (int i = 0; i < sendTabControl.TabCount-1; i++)
                {
                    var recTab = sendTabControl.GetTabRect(i);
                    if (recTab.Contains(mv.Location))
                    {

                        sendTabControl.TabPages.RemoveAt(i);
                    }
                }

            }

            if(sendTabControl.TabCount == 1)
            {
                addPage("发送消息");
            }
        }
        

  

    }
}
