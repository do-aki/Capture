using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Capture
{
    public partial class SelectingArea : Form
    {
        public int LineSize {
            get {
                return panel1.Left;
            }
        }

        public SelectingArea()
        {
            InitializeComponent();
            Hide();
        }

        public Rectangle AreaRectangle
        {
            set
            {
                value.Inflate(LineSize, LineSize);
                Location = value.Location;
                Size = value.Size;
            }
        }
    }
}
