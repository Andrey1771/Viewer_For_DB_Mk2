﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Lab7_Bd.Controller;

namespace Lab7_Bd
{
    public partial class LoginForm : Form
    {
        private Controller.Controller db;
        public LoginForm(ref Controller.Controller adb)// лучше решить сигналами
        {
            InitializeComponent();
            db = adb;
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            db.MakeConnect(loginTextBox.Text, passwordTextBox.Text);
            Close();
        }

        private void registrationButton_Click(object sender, EventArgs e)
        {
            db.MakeNewLoginToUser(loginTextBox.Text, passwordTextBox.Text, roleTextBox.Text);
        }
    }
}