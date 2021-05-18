﻿using System;
using System.Windows.Forms;

namespace VirtualDesktopNameDeskband
{
    public partial class DeskbandControl : UserControl
    {
        Manager manager;

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
        }

        public DeskbandControl()
        {
            InitializeComponent();
            manager = new Manager(pictureBox1);
        }

        internal void Close()
        {
            manager.Dispose();
        }
    }
}
