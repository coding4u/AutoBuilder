namespace AutoCompileManager
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.tbServiceName = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.btnStart = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label9 = new System.Windows.Forms.Label();
            this.tbDllPath = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tbTimeSpan = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.tbName = new System.Windows.Forms.TextBox();
            this.tbCscPath = new System.Windows.Forms.TextBox();
            this.tbCsPath = new System.Windows.Forms.TextBox();
            this.tbTargetPath = new System.Windows.Forms.TextBox();
            this.btnTarget = new System.Windows.Forms.Button();
            this.btnScan = new System.Windows.Forms.Button();
            this.btnDll = new System.Windows.Forms.Button();
            this.btnCs = new System.Windows.Forms.Button();
            this.group1 = new System.Windows.Forms.GroupBox();
            this.lbConfigs = new System.Windows.Forms.ListBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.menuDelete = new System.Windows.Forms.ToolStripMenuItem();
            this.menuUpdate = new System.Windows.Forms.ToolStripMenuItem();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabConfig = new System.Windows.Forms.TabPage();
            this.tabView = new System.Windows.Forms.TabPage();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.tvResult = new System.Windows.Forms.TreeView();
            this.tbResult = new System.Windows.Forms.RichTextBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.functionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolRefresh = new System.Windows.Forms.ToolStripMenuItem();
            this.toolsExit = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1 = new System.Windows.Forms.Panel();
            this.splitContainer3 = new System.Windows.Forms.SplitContainer();
            this.cbWarnings = new System.Windows.Forms.CheckBox();
            this.cbErrors = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.group1.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabConfig.SuspendLayout();
            this.tabView.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer3)).BeginInit();
            this.splitContainer3.Panel1.SuspendLayout();
            this.splitContainer3.Panel2.SuspendLayout();
            this.splitContainer3.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(3, 3);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.groupBox2);
            this.splitContainer1.Panel1.Controls.Add(this.groupBox1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.group1);
            this.splitContainer1.Size = new System.Drawing.Size(698, 361);
            this.splitContainer1.SplitterDistance = 539;
            this.splitContainer1.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.tbServiceName);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.btnStart);
            this.groupBox2.Location = new System.Drawing.Point(12, 275);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(527, 81);
            this.groupBox2.TabIndex = 38;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Service Controller";
            // 
            // tbServiceName
            // 
            this.tbServiceName.Location = new System.Drawing.Point(95, 37);
            this.tbServiceName.Name = "tbServiceName";
            this.tbServiceName.Size = new System.Drawing.Size(171, 20);
            this.tbServiceName.TabIndex = 2;
            this.tbServiceName.Text = "AutoCompileService";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(9, 40);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(80, 13);
            this.label8.TabIndex = 1;
            this.label8.Text = "Service Name: ";
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(295, 35);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(75, 23);
            this.btnStart.TabIndex = 0;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.tbDllPath);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.tbTimeSpan);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.btnAdd);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.tbName);
            this.groupBox1.Controls.Add(this.tbCscPath);
            this.groupBox1.Controls.Add(this.tbCsPath);
            this.groupBox1.Controls.Add(this.tbTargetPath);
            this.groupBox1.Controls.Add(this.btnTarget);
            this.groupBox1.Controls.Add(this.btnScan);
            this.groupBox1.Controls.Add(this.btnDll);
            this.groupBox1.Controls.Add(this.btnCs);
            this.groupBox1.Location = new System.Drawing.Point(12, 16);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(527, 253);
            this.groupBox1.TabIndex = 37;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Add or Update Configuration";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(3, 184);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(86, 13);
            this.label9.TabIndex = 50;
            this.label9.Text = "Build File Name: ";
            // 
            // tbDllPath
            // 
            this.tbDllPath.Location = new System.Drawing.Point(92, 104);
            this.tbDllPath.Name = "tbDllPath";
            this.tbDllPath.Size = new System.Drawing.Size(361, 20);
            this.tbDllPath.TabIndex = 22;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(399, 184);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(44, 13);
            this.label7.TabIndex = 36;
            this.label7.Text = "Minutes";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(30, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 13);
            this.label1.TabIndex = 16;
            this.label1.Text = "Log Path: ";
            // 
            // tbTimeSpan
            // 
            this.tbTimeSpan.Location = new System.Drawing.Point(293, 181);
            this.tbTimeSpan.Name = "tbTimeSpan";
            this.tbTimeSpan.Size = new System.Drawing.Size(100, 20);
            this.tbTimeSpan.TabIndex = 35;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(34, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 13);
            this.label2.TabIndex = 17;
            this.label2.Text = "CS Path: ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(213, 184);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(74, 13);
            this.label6.TabIndex = 34;
            this.label6.Text = "Time Interval: ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(36, 107);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 13);
            this.label3.TabIndex = 18;
            this.label3.Text = "Dll Path: ";
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(440, 213);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 31;
            this.btnAdd.Text = "Save";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(28, 148);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 13);
            this.label4.TabIndex = 19;
            this.label4.Text = "BuildPath: ";
            // 
            // tbName
            // 
            this.tbName.Location = new System.Drawing.Point(95, 181);
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(100, 20);
            this.tbName.TabIndex = 30;
            // 
            // tbCscPath
            // 
            this.tbCscPath.Location = new System.Drawing.Point(92, 19);
            this.tbCscPath.Name = "tbCscPath";
            this.tbCscPath.Size = new System.Drawing.Size(361, 20);
            this.tbCscPath.TabIndex = 20;
            // 
            // tbCsPath
            // 
            this.tbCsPath.Location = new System.Drawing.Point(92, 62);
            this.tbCsPath.Name = "tbCsPath";
            this.tbCsPath.Size = new System.Drawing.Size(361, 20);
            this.tbCsPath.TabIndex = 21;
            // 
            // tbTargetPath
            // 
            this.tbTargetPath.Location = new System.Drawing.Point(95, 145);
            this.tbTargetPath.Name = "tbTargetPath";
            this.tbTargetPath.Size = new System.Drawing.Size(361, 20);
            this.tbTargetPath.TabIndex = 23;
            // 
            // btnTarget
            // 
            this.btnTarget.Location = new System.Drawing.Point(462, 143);
            this.btnTarget.Name = "btnTarget";
            this.btnTarget.Size = new System.Drawing.Size(53, 23);
            this.btnTarget.TabIndex = 27;
            this.btnTarget.Text = "Scan";
            this.btnTarget.UseVisualStyleBackColor = true;
            this.btnTarget.Click += new System.EventHandler(this.btnTarget_Click);
            // 
            // btnScan
            // 
            this.btnScan.Location = new System.Drawing.Point(462, 17);
            this.btnScan.Name = "btnScan";
            this.btnScan.Size = new System.Drawing.Size(53, 23);
            this.btnScan.TabIndex = 24;
            this.btnScan.Text = "Scan";
            this.btnScan.UseVisualStyleBackColor = true;
            this.btnScan.Click += new System.EventHandler(this.btnScan_Click);
            // 
            // btnDll
            // 
            this.btnDll.Location = new System.Drawing.Point(462, 102);
            this.btnDll.Name = "btnDll";
            this.btnDll.Size = new System.Drawing.Size(53, 23);
            this.btnDll.TabIndex = 26;
            this.btnDll.Text = "Scan";
            this.btnDll.UseVisualStyleBackColor = true;
            this.btnDll.Click += new System.EventHandler(this.btnDll_Click);
            // 
            // btnCs
            // 
            this.btnCs.Location = new System.Drawing.Point(462, 60);
            this.btnCs.Name = "btnCs";
            this.btnCs.Size = new System.Drawing.Size(53, 23);
            this.btnCs.TabIndex = 25;
            this.btnCs.Text = "Scan";
            this.btnCs.UseVisualStyleBackColor = true;
            this.btnCs.Click += new System.EventHandler(this.btnCs_Click);
            // 
            // group1
            // 
            this.group1.Controls.Add(this.lbConfigs);
            this.group1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.group1.Location = new System.Drawing.Point(0, 0);
            this.group1.Name = "group1";
            this.group1.Size = new System.Drawing.Size(155, 361);
            this.group1.TabIndex = 1;
            this.group1.TabStop = false;
            this.group1.Text = "Existing Configuration";
            // 
            // lbConfigs
            // 
            this.lbConfigs.ContextMenuStrip = this.contextMenuStrip1;
            this.lbConfigs.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbConfigs.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbConfigs.FormattingEnabled = true;
            this.lbConfigs.ItemHeight = 16;
            this.lbConfigs.Location = new System.Drawing.Point(3, 16);
            this.lbConfigs.Name = "lbConfigs";
            this.lbConfigs.Size = new System.Drawing.Size(149, 342);
            this.lbConfigs.TabIndex = 0;
            this.lbConfigs.SelectedIndexChanged += new System.EventHandler(this.lbConfigs_SelectedIndexChanged);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuDelete,
            this.menuUpdate});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(113, 48);
            // 
            // menuDelete
            // 
            this.menuDelete.Name = "menuDelete";
            this.menuDelete.Size = new System.Drawing.Size(112, 22);
            this.menuDelete.Text = "Delete";
            this.menuDelete.Click += new System.EventHandler(this.menuDelete_Click);
            // 
            // menuUpdate
            // 
            this.menuUpdate.Name = "menuUpdate";
            this.menuUpdate.Size = new System.Drawing.Size(112, 22);
            this.menuUpdate.Text = "Update";
            this.menuUpdate.Click += new System.EventHandler(this.menuUpdate_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabConfig);
            this.tabControl1.Controls.Add(this.tabView);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(712, 393);
            this.tabControl1.TabIndex = 3;
            // 
            // tabConfig
            // 
            this.tabConfig.Controls.Add(this.splitContainer1);
            this.tabConfig.Location = new System.Drawing.Point(4, 22);
            this.tabConfig.Name = "tabConfig";
            this.tabConfig.Padding = new System.Windows.Forms.Padding(3);
            this.tabConfig.Size = new System.Drawing.Size(704, 367);
            this.tabConfig.TabIndex = 0;
            this.tabConfig.Text = "Config";
            this.tabConfig.UseVisualStyleBackColor = true;
            // 
            // tabView
            // 
            this.tabView.Controls.Add(this.splitContainer2);
            this.tabView.Location = new System.Drawing.Point(4, 22);
            this.tabView.Name = "tabView";
            this.tabView.Padding = new System.Windows.Forms.Padding(3);
            this.tabView.Size = new System.Drawing.Size(704, 367);
            this.tabView.TabIndex = 1;
            this.tabView.Text = "Object View";
            this.tabView.UseVisualStyleBackColor = true;
            // 
            // splitContainer2
            // 
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.splitContainer2.Location = new System.Drawing.Point(3, 3);
            this.splitContainer2.Name = "splitContainer2";
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this.tvResult);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.splitContainer3);
            this.splitContainer2.Size = new System.Drawing.Size(698, 361);
            this.splitContainer2.SplitterDistance = 277;
            this.splitContainer2.TabIndex = 2;
            // 
            // tvResult
            // 
            this.tvResult.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tvResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tvResult.Location = new System.Drawing.Point(0, 0);
            this.tvResult.Name = "tvResult";
            this.tvResult.Size = new System.Drawing.Size(277, 361);
            this.tvResult.TabIndex = 0;
            this.tvResult.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.tvResult_AfterSelect);
            // 
            // tbResult
            // 
            this.tbResult.BackColor = System.Drawing.Color.Black;
            this.tbResult.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbResult.Location = new System.Drawing.Point(0, 0);
            this.tbResult.Name = "tbResult";
            this.tbResult.ReadOnly = true;
            this.tbResult.Size = new System.Drawing.Size(417, 332);
            this.tbResult.TabIndex = 1;
            this.tbResult.Text = "";
            this.tbResult.WordWrap = false;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.functionToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(712, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // functionToolStripMenuItem
            // 
            this.functionToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolRefresh,
            this.toolsExit});
            this.functionToolStripMenuItem.Name = "functionToolStripMenuItem";
            this.functionToolStripMenuItem.Size = new System.Drawing.Size(66, 20);
            this.functionToolStripMenuItem.Text = "Function";
            // 
            // toolRefresh
            // 
            this.toolRefresh.Name = "toolRefresh";
            this.toolRefresh.Size = new System.Drawing.Size(113, 22);
            this.toolRefresh.Text = "Refresh";
            this.toolRefresh.Click += new System.EventHandler(this.toolRefresh_Click);
            // 
            // toolsExit
            // 
            this.toolsExit.Name = "toolsExit";
            this.toolsExit.Size = new System.Drawing.Size(113, 22);
            this.toolsExit.Text = "Exit";
            this.toolsExit.Click += new System.EventHandler(this.toolsExit_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.tabControl1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 24);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(712, 393);
            this.panel1.TabIndex = 1;
            // 
            // splitContainer3
            // 
            this.splitContainer3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer3.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.splitContainer3.Location = new System.Drawing.Point(0, 0);
            this.splitContainer3.Name = "splitContainer3";
            this.splitContainer3.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer3.Panel1
            // 
            this.splitContainer3.Panel1.Controls.Add(this.cbErrors);
            this.splitContainer3.Panel1.Controls.Add(this.cbWarnings);
            // 
            // splitContainer3.Panel2
            // 
            this.splitContainer3.Panel2.Controls.Add(this.tbResult);
            this.splitContainer3.Size = new System.Drawing.Size(417, 361);
            this.splitContainer3.SplitterDistance = 25;
            this.splitContainer3.TabIndex = 2;
            // 
            // cbWarnings
            // 
            this.cbWarnings.AutoSize = true;
            this.cbWarnings.Checked = true;
            this.cbWarnings.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbWarnings.Location = new System.Drawing.Point(3, 3);
            this.cbWarnings.Name = "cbWarnings";
            this.cbWarnings.Size = new System.Drawing.Size(101, 17);
            this.cbWarnings.TabIndex = 0;
            this.cbWarnings.Text = "Show Warnings";
            this.cbWarnings.UseVisualStyleBackColor = true;
            this.cbWarnings.CheckedChanged += new System.EventHandler(this.CheckBox_CheckChanged);
            // 
            // cbErrors
            // 
            this.cbErrors.AutoSize = true;
            this.cbErrors.Checked = true;
            this.cbErrors.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbErrors.Location = new System.Drawing.Point(130, 3);
            this.cbErrors.Name = "cbErrors";
            this.cbErrors.Size = new System.Drawing.Size(83, 17);
            this.cbErrors.TabIndex = 1;
            this.cbErrors.Text = "Show Errors";
            this.cbErrors.UseVisualStyleBackColor = true;
            this.cbErrors.CheckedChanged += new System.EventHandler(this.CheckBox_CheckChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(712, 417);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "AutoCompile Manager";
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.group1.ResumeLayout(false);
            this.contextMenuStrip1.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.tabConfig.ResumeLayout(false);
            this.tabView.ResumeLayout(false);
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.splitContainer3.Panel1.ResumeLayout(false);
            this.splitContainer3.Panel1.PerformLayout();
            this.splitContainer3.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer3)).EndInit();
            this.splitContainer3.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.TextBox tbName;
        private System.Windows.Forms.Button btnTarget;
        private System.Windows.Forms.Button btnDll;
        private System.Windows.Forms.Button btnCs;
        private System.Windows.Forms.Button btnScan;
        private System.Windows.Forms.TextBox tbTargetPath;
        private System.Windows.Forms.TextBox tbDllPath;
        private System.Windows.Forms.TextBox tbCsPath;
        private System.Windows.Forms.TextBox tbCscPath;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox lbConfigs;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tbTimeSpan;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox group1;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.TextBox tbServiceName;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem menuDelete;
        private System.Windows.Forms.ToolStripMenuItem menuUpdate;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabConfig;
        private System.Windows.Forms.TabPage tabView;
        private System.Windows.Forms.TreeView tvResult;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem functionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolRefresh;
        private System.Windows.Forms.ToolStripMenuItem toolsExit;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RichTextBox tbResult;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.SplitContainer splitContainer3;
        private System.Windows.Forms.CheckBox cbErrors;
        private System.Windows.Forms.CheckBox cbWarnings;

    }
}

