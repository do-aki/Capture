﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Capture
{
    public partial class SettingForm : Form
    {
        public SettingForm()
        {
            InitializeComponent();
        }

        private void button_Save_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void textBox_UploadUri_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter) {
                Close();
            }
        }

        private void SettingForm_Load(object sender, EventArgs e)
        {
            Activate();
        }

        private void button_About_Click(object sender, EventArgs e)
        {
            (new AboutForm()).ShowDialog();
        }
    }
}