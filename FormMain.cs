using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace SmartGG
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        private void Form_main_Load(object sender, EventArgs e)
        {
            InstallFormMainUI();
        }

        private void FormMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            UninstallFormMainUI();
        }

        private void button_send_Click(object sender, EventArgs e)
        {
            ProcUserInput();
        }
    }
}
