using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Utility;

namespace AutoCompileManager
{
    public partial class UpdateForm : Form
    {
        private string Id = "";
        public UpdateForm(string id, Configuration config)
        {
            InitializeComponent();
            tbCsPath.Text = config.csPath;
            tbDllPath.Text = config.dllpath;
            tbCscPath.Text = config.logPath;
            tbTargetPath.Text = config.resultPath;
            tbName.Text = config.buildType;
            tbTimeSpan.Text = config.Interval;
            this.Id = id;
        }

        private void btnScan_Click(object sender, EventArgs e)
        {
            if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
            {
                tbCscPath.Text = folderBrowserDialog1.SelectedPath;
            }
        }

        private void btnCs_Click(object sender, EventArgs e)
        {
            if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
            {
                tbCsPath.Text = folderBrowserDialog1.SelectedPath;
            }
        }

        private void btnDll_Click(object sender, EventArgs e)
        {
            if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
            {
                tbDllPath.Text = folderBrowserDialog1.SelectedPath;
            }
        }

        private void btnTarget_Click(object sender, EventArgs e)
        {
            if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
            {
                tbTargetPath.Text = folderBrowserDialog1.SelectedPath;
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            Configuration c = new Configuration();
            c.csPath = tbCsPath.Text;
            c.dllpath = tbDllPath.Text;
            c.logPath = tbCscPath.Text;
            c.resultPath = tbTargetPath.Text;
            c.buildType = tbName.Text;
            c.Interval = tbTimeSpan.Text;
            if (Configuration.Modify(Id, c))
            {
                this.Close();
            }
        }
    }
}
