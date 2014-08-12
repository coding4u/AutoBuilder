using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.ServiceProcess;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using Utility;

namespace AutoCompileManager
{
    public partial class Form1 : Form
    {

        Configuration c;
        LogModel lm;

        public Form1()
        {
            InitializeComponent();
            
            InitialView();
        }

        private void InitialView()
        {
            lbConfigs.Items.Clear();
            tvResult.Nodes.Clear();
            InitialTreeView();
            InitialConfig();
            ServiceController sc = ServiceHelper.FindService(tbServiceName.Text);
            if (sc.Status == ServiceControllerStatus.Running)
            {
                btnStart.Text = "Stop";
                tbServiceName.Enabled = false;
            }
            if (sc.Status == ServiceControllerStatus.Stopped)
            {
                btnStart.Text = "Start";
            }
        }

        private void InitialConfig()
        {
            if (File.Exists(GlobalVariable.ConfigXml))
            {
                List<Configuration> cList = Configuration.GetAll(GlobalVariable.ConfigXml);
                if (cList != null)
                {
                    foreach (var item in cList)
                    {
                        lbConfigs.Items.Add(item.buildType);
                    }
                }
            }
        }

        #region Config

        private void btnScan_Click(object sender, EventArgs e)
        {
            //openFileDialog1.Filter = "exe files(*.exe)|*.exe";
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

        private void btnAdd_Click(object sender, EventArgs e)
        {
            c = new Configuration();
            c.csPath = tbCsPath.Text;
            c.dllpath = tbDllPath.Text;
            c.logPath = tbCscPath.Text;
            c.resultPath = tbTargetPath.Text;
            c.buildType = tbName.Text;
            c.Interval = tbTimeSpan.Text;

            Configuration con = Configuration.GetConfig(GlobalVariable.ConfigXml, tbName.Text);
            if (con == null)
            {
                if (c.AddConfiguration(GlobalVariable.ConfigXml))
                {
                    lbConfigs.Items.Add(c.buildType);
                    InitialView();
                    MessageBox.Show("添加成功");
                }
            }
            else
            {
                if (Configuration.Modify(tbName.Text, c))
                {
                    InitialView();
                    MessageBox.Show("修改成功");
                }
            }
            
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            string[] str = new string[]
            {
                GlobalVariable.ConfigXml
            };
            if (btnStart.Text == "Start")
            {
                if (ServiceHelper.StartAutoCompileService(str, tbServiceName.Text))
                {
                    btnStart.Text = "Stop";
                    tbServiceName.Enabled = false;
                }
            }

            if (btnStart.Text == "Stop")
            {
                if (ServiceHelper.StopAutoCompileService(tbServiceName.Text))
                {
                    btnStart.Text = "Start";
                    tbServiceName.Enabled = true;
                }
            }
            
        }

        private void menuDelete_Click(object sender, EventArgs e)
        {
            ListBox listbox = contextMenuStrip1.SourceControl as ListBox;
            int i = listbox.SelectedIndex;

            if (i >= 0)
            {
                Configuration.Remove(listbox.Items[i].ToString());
                listbox.Items.Remove(listbox.Items[i]);
            }
        }

        private void menuUpdate_Click(object sender, EventArgs e)
        {
            ListBox listbox = contextMenuStrip1.SourceControl as ListBox;
            int i = listbox.SelectedIndex;

            if (i >= 0)
            {
                Configuration c = Configuration.GetConfig(GlobalVariable.ConfigXml, listbox.Items[i].ToString());
                UpdateForm uf = new UpdateForm(listbox.Items[i].ToString(), c);
                uf.ShowDialog();
            }
        }

        private void lbConfigs_SelectedIndexChanged(object sender, EventArgs e)
        {
            int i = lbConfigs.SelectedIndex;
            if (i>= 0)
            {
                Configuration c = Configuration.GetConfig(GlobalVariable.ConfigXml, lbConfigs.Items[i].ToString());
                Ininial(c);
            }
        }

        private void Ininial(Configuration config)
        {
            tbCsPath.Text = config.csPath;
            tbDllPath.Text = config.dllpath;
            tbCscPath.Text = config.logPath;
            tbTargetPath.Text = config.resultPath;
            tbName.Text = config.buildType;
            tbTimeSpan.Text = config.Interval;
        }
        #endregion

        #region Object View
        private void InitialTreeView()
        {
            TreeNode tn1 = new TreeNode("Object View");
            tvResult.Nodes.Add(tn1);
            AddNode(tn1, ReflectionHelper.GetDllNames());

        }

        private void AddNode(TreeNode tn, List<string> nodesName)
        {
            foreach (var item in nodesName)
            {
                //string[] s = item.Split(new char[] {'\\'});
                //TreeNode tnChild = new TreeNode(s[s.Length-1]);
                TreeNode tnChild = new TreeNode(item);
                Configuration c = Configuration.GetConfig(GlobalVariable.ConfigXml, item);
                if (c != null)
                {
                    tn.Nodes.Add(tnChild);
                    AddChildNodes(tnChild, ReflectionHelper.GetClassNames(c.resultPath + @"\" + item));
                }
               
            }
        }

        private void AddChildNodes(TreeNode tn, List<string> nodesName)
        {
            foreach (var item in nodesName)
            {
                TreeNode tnChild = new TreeNode(item);
                tn.Nodes.Add(tnChild);
            }
        }
        #endregion

        

        private void toolRefresh_Click(object sender, EventArgs e)
        {
            InitialView();
        }

        private void toolsExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        

        private void tvResult_AfterSelect(object sender, TreeViewEventArgs e)
        {
            tbResult.Clear();
            TreeNode a = e.Node;

            Configuration c = Configuration.GetConfig(GlobalVariable.ConfigXml, a.Text);
            if (c != null)
            {
                FileInfo f = FileHelper.GetLastFile(c);
                if (f != null)
                {
                    lm = SerializeHelper.DeserializeFromXML<LogModel>(f.FullName);
                    InitialTbResult(lm);
                }
                
            }
        }

        private void InitialTbResult(LogModel lm)
        {
            tbResult.Clear();
            if (lm.Results.IsBuildSuccess)
            {
                AddMsgToTbResult("Build Success!", Color.Green);
            }
            else
            {
                AddMsgToTbResult("Build Failed!", Color.Red);
            }
            if (lm.Results.Warnings.Count > 0 && cbWarnings.Checked)
            {
                AddMsgToTbResult("", Color.Black);
                AddMsgToTbResult("Warnings:", Color.Yellow);
                foreach (var item in lm.Results.Warnings)
                {
                    string s = string.Format("FileName:{0}\nLine:{1}, Column:{2}\nError Number:{3}\nError Text:{4}.\n\n", 
                        item.FileName,item.Line, item.Column, item.ErrorNumber, item.ErrorText);
                    AddMsgToTbResult(s, Color.Yellow);
                }
            }

            if (lm.Results.Errors.Count > 0 && cbErrors.Checked)
            {
                AddMsgToTbResult("", Color.Black);
                AddMsgToTbResult("Errors:", Color.Red);
                foreach (var item in lm.Results.Errors)
                {
                    string s = string.Format("FileName:{0}\nLine:{1}, Column:{2}\nError Number:{3}\nError Text:{4}.\n\n",
                        item.FileName,item.Line, item.Column, item.ErrorNumber, item.ErrorText);
                    AddMsgToTbResult(s, Color.Red);
                }
            }
        }

        private void AddMsgToTbResult(string str, Color color)
        {
            str = str + "\n";
            tbResult.SelectionColor = color;
            tbResult.SelectedText = str;
        }

        private void CheckBox_CheckChanged(object sender, EventArgs e)
        {
            if (lm != null)
            {
                InitialTbResult(lm);
            }
            
        }
    }
}
