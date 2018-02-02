using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace KSSUMapEditor
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            Icon = Properties.Resources.Kirby_1;
            InitializeComponent();
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AboutDialog about = new AboutDialog();
            about.ShowDialog();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void repoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ProcessStartInfo repoLink = new ProcessStartInfo("https://github.com/BenHall-7/KSSUMapEditor");
            Process.Start(repoLink);
        }
    }
}
