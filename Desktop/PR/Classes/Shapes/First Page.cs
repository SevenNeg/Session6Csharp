﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Shapes
{
    public partial class First_Page : Form
    {
        public First_Page()
        {
            InitializeComponent();
        }

        private void SignUpbutton_Click(object sender, EventArgs e)
        {
            Form1 Form = new Form1();
            this.Hide();
            Form.ShowDialog();
            this.Show();
        }

        private void SignInbutton_Click(object sender, EventArgs e)
        {
            Signedin Form = new Signedin();
            this.Hide();
            Form.ShowDialog();
            this.Show();
        }
    }
}
