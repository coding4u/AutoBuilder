namespace AutoCompileManager
{
    partial class UpdateForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tbDllPath = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tbTimeSpan = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.tbName = new System.Windows.Forms.TextBox();
            this.tbCscPath = new System.Windows.Forms.TextBox();
            this.tbCsPath = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tbTargetPath = new System.Windows.Forms.TextBox();
            this.btnTarget = new System.Windows.Forms.Button();
            this.btnScan = new System.Windows.Forms.Button();
            this.btnDll = new System.Windows.Forms.Button();
            this.btnCs = new System.Windows.Forms.Button();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.SuspendLayout();
            // 
            // tbDllPath
            // 
            this.tbDllPath.Location = new System.Drawing.Point(106, 108);
            this.tbDllPath.Name = "tbDllPath";
            this.tbDllPath.Size = new System.Drawing.Size(361, 20);
            this.tbDllPath.TabIndex = 43;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(414, 188);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(31, 13);
            this.label7.TabIndex = 55;
            this.label7.Text = "分钟";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(30, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 13);
            this.label1.TabIndex = 37;
            this.label1.Text = "<Log> 路径：";
            // 
            // tbTimeSpan
            // 
            this.tbTimeSpan.Location = new System.Drawing.Point(308, 185);
            this.tbTimeSpan.Name = "tbTimeSpan";
            this.tbTimeSpan.Size = new System.Drawing.Size(100, 20);
            this.tbTimeSpan.TabIndex = 54;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 13);
            this.label2.TabIndex = 38;
            this.label2.Text = "<cs> 文件路径：";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(241, 188);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(61, 13);
            this.label6.TabIndex = 53;
            this.label6.Text = "时间间隔：";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(41, 111);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 13);
            this.label3.TabIndex = 39;
            this.label3.Text = "<dll> 路径：";
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(454, 227);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 52;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(18, 152);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(85, 13);
            this.label4.TabIndex = 40;
            this.label4.Text = "生成目标路径：";
            // 
            // tbName
            // 
            this.tbName.Location = new System.Drawing.Point(109, 185);
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(100, 20);
            this.tbName.TabIndex = 51;
            // 
            // tbCscPath
            // 
            this.tbCscPath.Location = new System.Drawing.Point(106, 23);
            this.tbCscPath.Name = "tbCscPath";
            this.tbCscPath.Size = new System.Drawing.Size(361, 20);
            this.tbCscPath.TabIndex = 41;
            // 
            // tbCsPath
            // 
            this.tbCsPath.Location = new System.Drawing.Point(106, 66);
            this.tbCsPath.Name = "tbCsPath";
            this.tbCsPath.Size = new System.Drawing.Size(361, 20);
            this.tbCsPath.TabIndex = 42;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(18, 188);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(85, 13);
            this.label5.TabIndex = 49;
            this.label5.Text = "生成文件名称：";
            // 
            // tbTargetPath
            // 
            this.tbTargetPath.Location = new System.Drawing.Point(109, 149);
            this.tbTargetPath.Name = "tbTargetPath";
            this.tbTargetPath.Size = new System.Drawing.Size(361, 20);
            this.tbTargetPath.TabIndex = 44;
            // 
            // btnTarget
            // 
            this.btnTarget.Location = new System.Drawing.Point(476, 147);
            this.btnTarget.Name = "btnTarget";
            this.btnTarget.Size = new System.Drawing.Size(53, 23);
            this.btnTarget.TabIndex = 48;
            this.btnTarget.Text = "浏览";
            this.btnTarget.UseVisualStyleBackColor = true;
            this.btnTarget.Click += new System.EventHandler(this.btnTarget_Click);
            // 
            // btnScan
            // 
            this.btnScan.Location = new System.Drawing.Point(476, 23);
            this.btnScan.Name = "btnScan";
            this.btnScan.Size = new System.Drawing.Size(53, 23);
            this.btnScan.TabIndex = 45;
            this.btnScan.Text = "浏览";
            this.btnScan.UseVisualStyleBackColor = true;
            this.btnScan.Click += new System.EventHandler(this.btnScan_Click);
            // 
            // btnDll
            // 
            this.btnDll.Location = new System.Drawing.Point(476, 106);
            this.btnDll.Name = "btnDll";
            this.btnDll.Size = new System.Drawing.Size(53, 23);
            this.btnDll.TabIndex = 47;
            this.btnDll.Text = "浏览";
            this.btnDll.UseVisualStyleBackColor = true;
            this.btnDll.Click += new System.EventHandler(this.btnDll_Click);
            // 
            // btnCs
            // 
            this.btnCs.Location = new System.Drawing.Point(476, 64);
            this.btnCs.Name = "btnCs";
            this.btnCs.Size = new System.Drawing.Size(53, 23);
            this.btnCs.TabIndex = 46;
            this.btnCs.Text = "浏览";
            this.btnCs.UseVisualStyleBackColor = true;
            this.btnCs.Click += new System.EventHandler(this.btnCs_Click);
            // 
            // UpdateForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(547, 262);
            this.Controls.Add(this.tbDllPath);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbTimeSpan);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tbName);
            this.Controls.Add(this.tbCscPath);
            this.Controls.Add(this.tbCsPath);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.tbTargetPath);
            this.Controls.Add(this.btnTarget);
            this.Controls.Add(this.btnScan);
            this.Controls.Add(this.btnDll);
            this.Controls.Add(this.btnCs);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "UpdateForm";
            this.Text = "Update";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbDllPath;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbTimeSpan;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbName;
        private System.Windows.Forms.TextBox tbCscPath;
        private System.Windows.Forms.TextBox tbCsPath;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbTargetPath;
        private System.Windows.Forms.Button btnTarget;
        private System.Windows.Forms.Button btnScan;
        private System.Windows.Forms.Button btnDll;
        private System.Windows.Forms.Button btnCs;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
    }
}