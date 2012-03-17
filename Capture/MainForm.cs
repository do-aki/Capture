using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Drawing.Imaging;
using System.Runtime.InteropServices;
using System.Net;
using System.Collections.Specialized;
using System.IO;
using System.Diagnostics;

namespace Capture
{
    public partial class MainForm : Form
    {
        private SelectingArea SelectingArea = new SelectingArea();

        public MainForm()
        {
            InitializeComponent();
        }

        protected override CreateParams CreateParams
        {
            get {
                // レイヤードウィンドウにする
                const int WS_EX_LAYERED     = 0x00080000;
                const int WS_EX_NOACTIVATE  = 0x08000000;
                var cp = base.CreateParams;
                cp.ExStyle |= WS_EX_LAYERED;
                cp.ExStyle |= WS_EX_NOACTIVATE;
                
                // ウィンドウサイズを最大にする
                cp.X = Screen.AllScreens.Min((s) => { return s.Bounds.X; });
                cp.Y = Screen.AllScreens.Min((s) => { return s.Bounds.Y; });
                cp.Width = Screen.AllScreens.Sum((s) => { return s.Bounds.Width; });
                cp.Height = Screen.AllScreens.Sum((s) => { return s.Bounds.Height; });

                return cp;
            }
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            Activate();
        }

        
        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            if (selecting) {
                SelectingArea.AreaRectangle = PointToRectangle(begin_pos, Control.MousePosition);
            }
        }

        bool selecting = false;
        Point begin_pos;
        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            if (!selecting)
            {
                selecting = true;
                begin_pos = Control.MousePosition;

                SelectingArea.Show();
                SelectingArea.AreaRectangle = new Rectangle(begin_pos, new Size(0,0));
            }
        }

        private void Form1_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == System.Windows.Forms.MouseButtons.Right) {
                Close();
            }

            if (selecting)
            {
                var r = PointToRectangle(begin_pos, Control.MousePosition);
                if (r.Width > 0 && r.Height > 0)
                {
                    Hide();
                    Application.DoEvents();

                    var bmp = CaptureScreen(r);
                    var tmp = Path.GetTempFileName();
                    bmp.Save(tmp, ImageFormat.Png);

                    var uri = getUploadUri();
                    if (String.IsNullOrEmpty(uri)) {
                        Close();
                        return;
                    }

                    try
                    {
                        UploadFile(uri, tmp);
                        Properties.Settings.Default.Save();
                    }
                    catch (WebException exception)
                    {
                        MessageBox.Show("投稿に失敗しました\n\n" + exception.Message);
                    }
                    finally
                    {
                        File.Delete(tmp);
                    }
                    
                    Close();
                }
                selecting = false;
            }
        }

        private string getUploadUri()
        {
            if (String.IsNullOrEmpty(Properties.Settings.Default.UploadUri)) {
                (new SettingForm()).ShowDialog();
            }
          
            if (!Uri.IsWellFormedUriString(Properties.Settings.Default.UploadUri, UriKind.Absolute)) { 
                return null;
            }

            return Properties.Settings.Default.UploadUri;
        }

        private void UploadFile(string uri, string file) {
            string boundary = System.Environment.TickCount.ToString();
            var req = (HttpWebRequest)System.Net.WebRequest.Create(uri);
            req.Method = "POST";
            req.ContentType = "multipart/form-data; boundary=" + boundary;

            using (var reqStream = req.GetRequestStream())
            {
                StreamWriteBytes(reqStream, Encoding.UTF8.GetBytes("--" + boundary + "\r\n" +
                    "Content-Disposition: form-data; name=\"imagedata\"; filename=\"image.png\"\r\n" +
                    "Content-Type: application/octet-stream\r\n" +
                    "Content-Transfer-Encoding: binary\r\n" +
                    "\r\n"
                ));

                StreamWriteFile(reqStream, file);

                StreamWriteBytes(reqStream, Encoding.UTF8.GetBytes("\r\n--" + boundary + "--\r\n"));
            }

            string res;
            using (var sr = new StreamReader(((HttpWebResponse)req.GetResponse()).GetResponseStream(), Encoding.UTF8))
            {
                res = sr.ReadToEnd();
            }

            if (res.StartsWith("http://") || res.StartsWith("https://"))
            {
                Process.Start(res);
            }
        }


        private static void StreamWriteBytes(Stream stm, byte[] data)
        {
            stm.Write(data, 0, data.Length);
        }

        private static void StreamWriteFile(Stream stm, string file)
        {
            var fs = new FileStream(file, FileMode.Open, FileAccess.Read);

            byte[] readData = new byte[0x1024];
            int readSize = 0;
            while (true)
            {
                readSize = fs.Read(readData, 0, readData.Length);
                if (readSize == 0)
                    break;
                stm.Write(readData, 0, readSize);
            }

            fs.Close();
        }

        private static Rectangle PointToRectangle(Point p1, Point p2)
        {
            int x = Math.Min(p1.X, p2.X);
            int y = Math.Min(p1.Y, p2.Y);
            int w = Math.Abs(p1.X - p2.X);
            int h = Math.Abs(p1.Y - p2.Y);

            return new Rectangle(x, y, w, h);
        }

        private static Bitmap CaptureScreen(Rectangle rect)
        {
            Bitmap bmp = new Bitmap(rect.Width, rect.Height);
            Graphics g = Graphics.FromImage(bmp);
            g.CopyFromScreen(rect.Location, new Point(0, 0), rect.Size);
            g.Dispose();

            return bmp;
        }

    }
}

