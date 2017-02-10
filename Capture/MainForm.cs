using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using Capture.Action;

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

        private void MainForm_Shown(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(Properties.Settings.Default.UploadUri))
            {
                ShowSettingForm();
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
            if (e.Button == System.Windows.Forms.MouseButtons.Left && !selecting)
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
                ShowSettingForm();
                selecting = false;
            }

            if (selecting)
            {
                var r = PointToRectangle(begin_pos, Control.MousePosition);
                if (r.Width > 0 && r.Height > 0)
                {
                    Hide();
                    Application.DoEvents();

                    var actions = this.getEnableActions();
                    var bmp = CaptureScreen(r);
                    foreach (var action in actions) {
                        var result = action.Execute(bmp);
                        if (result == ActionResult.Failed)
                        {
                            MessageBox.Show(action.GetErrorMessage());
                            Show();
                            selecting = false;
                            return;
                        }
                    }

                    Close();
                }
                selecting = false;
            }
        }

        private List<ActionInterface> getEnableActions()
        {
            var actions = new List<ActionInterface>();

            if (Properties.Settings.Default.EnableCopy)
            {
                actions.Add(new Copy());
            }

            if (Properties.Settings.Default.EnableUpload)
            {
                actions.Add(new Upload(Properties.Settings.Default.UploadUri));
            }
            return actions;
        }

        private DialogResult ShowSettingForm()
        {
            Hide();

            var ret = (new SettingForm()).ShowDialog();
            if (ret == System.Windows.Forms.DialogResult.Cancel)
            {
                Properties.Settings.Default.Save();
                Close();
            }
            else if (ret == DialogResult.OK)
            {
                Properties.Settings.Default.Save();
                Show();
            }

            return ret;
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

