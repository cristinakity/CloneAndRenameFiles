namespace D2L_DataLake_Templates.Win
{
    partial class CloneAndRename
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.txtSearchFor = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtCloneTo = new System.Windows.Forms.TextBox();
            this.txtBaseFolder = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.chkLstFiles = new System.Windows.Forms.CheckedListBox();
            this.btnListOfFiles = new System.Windows.Forms.Button();
            this.btnClone = new System.Windows.Forms.Button();
            this.chkLstNewFiles = new System.Windows.Forms.CheckedListBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "Search For";
            // 
            // txtSearchFor
            // 
            this.txtSearchFor.Location = new System.Drawing.Point(83, 40);
            this.txtSearchFor.Name = "txtSearchFor";
            this.txtSearchFor.Size = new System.Drawing.Size(214, 23);
            this.txtSearchFor.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Clone to";
            // 
            // txtCloneTo
            // 
            this.txtCloneTo.Location = new System.Drawing.Point(83, 69);
            this.txtCloneTo.Name = "txtCloneTo";
            this.txtCloneTo.Size = new System.Drawing.Size(214, 23);
            this.txtCloneTo.TabIndex = 2;
            // 
            // txtBaseFolder
            // 
            this.txtBaseFolder.Location = new System.Drawing.Point(83, 11);
            this.txtBaseFolder.Name = "txtBaseFolder";
            this.txtBaseFolder.Size = new System.Drawing.Size(424, 23);
            this.txtBaseFolder.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 14);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 15);
            this.label3.TabIndex = 1;
            this.label3.Text = "Base Folder";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.chkLstFiles);
            this.groupBox1.Location = new System.Drawing.Point(13, 98);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(731, 334);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "List of files to clone";
            // 
            // chkLstFiles
            // 
            this.chkLstFiles.FormattingEnabled = true;
            this.chkLstFiles.Location = new System.Drawing.Point(6, 22);
            this.chkLstFiles.Name = "chkLstFiles";
            this.chkLstFiles.Size = new System.Drawing.Size(718, 292);
            this.chkLstFiles.TabIndex = 5;
            // 
            // btnListOfFiles
            // 
            this.btnListOfFiles.Location = new System.Drawing.Point(13, 438);
            this.btnListOfFiles.Name = "btnListOfFiles";
            this.btnListOfFiles.Size = new System.Drawing.Size(252, 23);
            this.btnListOfFiles.TabIndex = 4;
            this.btnListOfFiles.Text = "Get list of files";
            this.btnListOfFiles.UseVisualStyleBackColor = true;
            this.btnListOfFiles.Click += new System.EventHandler(this.btnListOfFiles_Click);
            // 
            // btnClone
            // 
            this.btnClone.Location = new System.Drawing.Point(271, 438);
            this.btnClone.Name = "btnClone";
            this.btnClone.Size = new System.Drawing.Size(236, 23);
            this.btnClone.TabIndex = 4;
            this.btnClone.Text = "Clone";
            this.btnClone.UseVisualStyleBackColor = true;
            this.btnClone.Click += new System.EventHandler(this.btnClone_Click);
            // 
            // chkLstNewFiles
            // 
            this.chkLstNewFiles.FormattingEnabled = true;
            this.chkLstNewFiles.Location = new System.Drawing.Point(6, 22);
            this.chkLstNewFiles.Name = "chkLstNewFiles";
            this.chkLstNewFiles.Size = new System.Drawing.Size(718, 292);
            this.chkLstNewFiles.TabIndex = 5;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.chkLstNewFiles);
            this.groupBox2.Location = new System.Drawing.Point(13, 467);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(731, 334);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "List of files to clone";
            // 
            // CloneAndRename
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(755, 806);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.btnClone);
            this.Controls.Add(this.btnListOfFiles);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtBaseFolder);
            this.Controls.Add(this.txtCloneTo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtSearchFor);
            this.Controls.Add(this.label1);
            this.Name = "CloneAndRename";
            this.Text = "Clone & Rename";
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtSearchFor;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtCloneTo;
        private System.Windows.Forms.TextBox txtBaseFolder;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnListOfFiles;
        private System.Windows.Forms.Button btnClone;
        private System.Windows.Forms.CheckedListBox chkLstFiles;
        private System.Windows.Forms.CheckedListBox chkLstNewFiles;
        private System.Windows.Forms.GroupBox groupBox2;
    }
}

