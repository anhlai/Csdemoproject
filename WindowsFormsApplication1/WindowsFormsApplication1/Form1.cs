﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            try
            {
                string aS = "aga";
                int a = Int32.Parse(aS);
            }
            catch (Exception)
            {
                throw;
            }
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            try
            {
                string aS = "aga";
                int a = Int32.Parse(aS);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
