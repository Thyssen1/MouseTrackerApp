﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MouseTracker
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Thread trackerThread = new Thread(Tracker);
            trackerThread.Start();
        }

        private void Tracker()
        {
            while(true)
            {
                int x = MousePosition.X;
                int y = MousePosition.Y;

                this.Invoke((MethodInvoker)delegate
                {
                    labelX.Text = x.ToString();
                    labelY.Text = y.ToString();
                });

                Thread.Sleep(30);
            }
        }
    }
}
