﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TravelPlannerApp
{
    public partial class info : Form
    {
        public delegate void SendMessage(string Message);
        public SendMessage Sender;
        public info()
        {
            InitializeComponent();
            Sender = new SendMessage(GetMessage);

        }
        private void info_Load(object sender, EventArgs e)
        {

        }
        private void GetMessage(string Message)
        {
            lblName.Text = Message;
        }

    }
}
