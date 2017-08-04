using System;
using System.Drawing;
using System.Globalization;
using System.Net;
using System.Windows.Forms;

namespace InternetChecker
{
    public partial class Form1 : Form
    {
        private readonly IniFile _myIni;
        private bool _sentmail = false;
        private Timer _timerCheck;
        private Timer _timerPost;

        public Form1()
        {
            InitializeComponent();
            _myIni = new IniFile();
            LoadSettings();
          
        }

        private void LoadSettings()
        {
            postTb.Text = _myIni.Read("Post","Config");
            mailTb.Text = _myIni.Read("Mail", "Config");
            urlTb.Text = _myIni.Read("Read", "Config");
            cbCheck.Checked = Convert.ToBoolean(_myIni.Read("AutoCheck", "Config"));
            cbPost.Checked = Convert.ToBoolean(_myIni.Read("AutoPost", "Config"));
            if (cbCheck.Checked == true)
            {
                InitTimer(_timerCheck, 1);
            }
            if (cbPost.Checked == true)
            {
                InitTimer(_timerPost, 2);
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            InitTimer(_timerCheck,1);
        }

        
        public void InitTimer(Timer tim, int type)
        {
            tim = new Timer();
            if(type == 1)
            { tim.Tick += new EventHandler(timer1_Tick); }
            else
            {
                tim.Tick += new EventHandler(timer2_Tick);
            }
            
            tim.Interval = 30000; // in miliseconds
            tim.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            isonline();
            Console.WriteLine(DateTime.Now.ToString("yyyyMMddHHmmss"));
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            try
            {
                GetContent(postTb.Text);
                sentlb.Text = "Last updated: " + DateTime.Now;
            }
            catch (Exception exception)
            {
                sentlb.Text = "Last updated: ERROR NO INTERNET";
                throw;
            }
           
        }

        private void isonline()
        {
            using (WebClient client = new WebClient())
            {
                string htmlCode = client.DownloadString(urlTb.Text);
                DateTime onlineTime = DateTime.ParseExact(htmlCode, "yyyyMMddHHmmss", CultureInfo.InvariantCulture);
                TimeSpan X = DateTime.Now - onlineTime;

                TimeSpan span = DateTime.Now.Subtract(onlineTime);

                if (span.Minutes >= 5)
                {
                    statuslb.ForeColor = Color.Red;
                    statuslb.Text = "No connection, waiting to send mail!";
                }

                if (span.Minutes >= 15)
                {
                    if (!_sentmail)
                    {
                        GetContent(mailTb.Text);
                        _sentmail = true;
                    }
                    
                    statuslb.ForeColor = Color.Red;
                    statuslb.Text = "No connection, Mail Sent!";

                }
                else
                {
                    statuslb.ForeColor = Color.Green;
                    statuslb.Text = "All OK";
                    _sentmail = false;
                }

               

            }
            checklb.Text = "Last checked: " + DateTime.Now;
        }
        public static string GetContent(string uri)
        {
            using (WebClient client = new WebClient())
            {
                // Pretend to be IE6
                client.Headers.Add("user-agent", "Mozilla/4.0 (compatible; MSIE 6.0; Windows NT 5.2; .NET CLR 1.0.3705;)");

                return client.DownloadString(uri);
            }

        }
        private void ImportStatusForm_Resize(object sender, EventArgs e)
        {

            if (this.WindowState == FormWindowState.Minimized)
            {
                notifyIcon1.Visible = true;
                notifyIcon1.ShowBalloonTip(3000);
                this.ShowInTaskbar = false;
            }

        }

        private void notifyIcon_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            this.WindowState = FormWindowState.Normal;
            this.ShowInTaskbar = true;
            notifyIcon1.Visible = false;
        }
        private void button2_Click(object sender, EventArgs e)
        {
           InitTimer(_timerPost,2);
            
        }
    }
}
