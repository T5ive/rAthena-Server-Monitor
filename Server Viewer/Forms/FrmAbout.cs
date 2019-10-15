using System;
using System.Windows.Forms;
using System.Diagnostics;

namespace Server_Viewer.Forms
{
    public partial class FrmAbout : Form
    {
        public FrmAbout()
        {
            InitializeComponent();
        }


        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Process.Start("http://rathena.org/board/");
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            Process.Start("http://irataprojects.de/");
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Process.Start("http://irataprojects.de/");
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("http://rathena.org/board/topic/67465-server-monitor/");
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("http://creativecommons.org/licenses/by-nc-sa/3.0/");
        }

    }
}
