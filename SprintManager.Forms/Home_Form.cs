﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SprintManager.Forms
{
    public partial class Home_Form : Form
    {
        public Home_Form()
        {
            InitializeComponent();
        }

        private void CreateSprint_btn_Click(object sender, EventArgs e)
        {
            CreateSprint_Form formCreate = new CreateSprint_Form();
            formCreate.Show();
        }
    }
}
