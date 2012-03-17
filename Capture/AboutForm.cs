using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Deployment.Application;
using System.IO;

namespace Capture
{
    public partial class AboutForm : Form
    {
        public AboutForm()
        {
            InitializeComponent();
        }

        private void AboutForm_Load(object sender, EventArgs e)
        {
            labelProductName.Text = Application.ProductName;
            label_ProductVersion.Text = Application.ProductVersion;

            label_PublishVersion.Text = "publish version " +
                ((ApplicationDeployment.IsNetworkDeployed) ? ApplicationDeployment.CurrentDeployment.CurrentVersion.ToString() : "[no deployment]");

            string path = Path.Combine(Path.GetDirectoryName(Application.ExecutablePath), "changelog.txt");
            if (File.Exists(path))
            {
                textBox_Changelog.Text = File.ReadAllText(path);
            }
        }

        private void button_Close_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
