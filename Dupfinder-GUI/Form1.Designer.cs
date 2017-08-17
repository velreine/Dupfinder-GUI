namespace Dupfinder_GUI
{
    partial class Form1
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
            this.labelMinFileSize = new System.Windows.Forms.Label();
            this.textBoxMinFileSize = new System.Windows.Forms.TextBox();
            this.checkBoxArchive = new System.Windows.Forms.CheckBox();
            this.checkBoxCompressed = new System.Windows.Forms.CheckBox();
            this.checkBoxDevice = new System.Windows.Forms.CheckBox();
            this.checkBoxDirectory = new System.Windows.Forms.CheckBox();
            this.checkBoxEncrypted = new System.Windows.Forms.CheckBox();
            this.checkBoxHidden = new System.Windows.Forms.CheckBox();
            this.checkBoxNormal = new System.Windows.Forms.CheckBox();
            this.checkBoxOffline = new System.Windows.Forms.CheckBox();
            this.checkBoxReadOnly = new System.Windows.Forms.CheckBox();
            this.checkBoxVirtual = new System.Windows.Forms.CheckBox();
            this.checkBoxTemporary = new System.Windows.Forms.CheckBox();
            this.checkBoxSystem = new System.Windows.Forms.CheckBox();
            this.checkBoxSparse_File = new System.Windows.Forms.CheckBox();
            this.checkBoxReparse_Point = new System.Windows.Forms.CheckBox();
            this.checkBoxRecall_On_Open = new System.Windows.Forms.CheckBox();
            this.checkBoxRecall_On_Data_Access = new System.Windows.Forms.CheckBox();
            this.checkBoxNo_Scrub_Data = new System.Windows.Forms.CheckBox();
            this.checkBoxNot_Content_Indexed = new System.Windows.Forms.CheckBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.textBoxFileExtensions = new System.Windows.Forms.TextBox();
            this.radioWhitelist = new System.Windows.Forms.RadioButton();
            this.radioBlacklist = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.addpathbutton = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.textBoxpaths = new System.Windows.Forms.TextBox();
            this.labelPaths = new System.Windows.Forms.Label();
            this.radioBlacklist2 = new System.Windows.Forms.RadioButton();
            this.radioWhitelist2 = new System.Windows.Forms.RadioButton();
            this.label4 = new System.Windows.Forms.Label();
            this.beginsearchbutton = new System.Windows.Forms.Button();
            this.labelMaxFileSize = new System.Windows.Forms.Label();
            this.textBoxMaxFileSize = new System.Windows.Forms.TextBox();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelMinFileSize
            // 
            this.labelMinFileSize.AutoSize = true;
            this.labelMinFileSize.Location = new System.Drawing.Point(12, 9);
            this.labelMinFileSize.Name = "labelMinFileSize";
            this.labelMinFileSize.Size = new System.Drawing.Size(117, 17);
            this.labelMinFileSize.TabIndex = 0;
            this.labelMinFileSize.Text = "Min. Filesize(KB):";
            // 
            // textBoxMinFileSize
            // 
            this.textBoxMinFileSize.Location = new System.Drawing.Point(15, 42);
            this.textBoxMinFileSize.Name = "textBoxMinFileSize";
            this.textBoxMinFileSize.Size = new System.Drawing.Size(114, 22);
            this.textBoxMinFileSize.TabIndex = 1;
            this.textBoxMinFileSize.Text = "256";
            this.textBoxMinFileSize.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // checkBoxArchive
            // 
            this.checkBoxArchive.AutoSize = true;
            this.checkBoxArchive.Location = new System.Drawing.Point(6, 37);
            this.checkBoxArchive.Name = "checkBoxArchive";
            this.checkBoxArchive.Size = new System.Drawing.Size(89, 21);
            this.checkBoxArchive.TabIndex = 2;
            this.checkBoxArchive.Text = "ARCHIVE";
            this.checkBoxArchive.UseVisualStyleBackColor = true;
            this.checkBoxArchive.CheckedChanged += new System.EventHandler(this.checkBoxArchive_CheckedChanged);
            // 
            // checkBoxCompressed
            // 
            this.checkBoxCompressed.AutoSize = true;
            this.checkBoxCompressed.Location = new System.Drawing.Point(6, 64);
            this.checkBoxCompressed.Name = "checkBoxCompressed";
            this.checkBoxCompressed.Size = new System.Drawing.Size(126, 21);
            this.checkBoxCompressed.TabIndex = 4;
            this.checkBoxCompressed.Text = "COMPRESSED";
            this.checkBoxCompressed.UseVisualStyleBackColor = true;
            this.checkBoxCompressed.CheckedChanged += new System.EventHandler(this.checkBoxCompressed_CheckedChanged);
            // 
            // checkBoxDevice
            // 
            this.checkBoxDevice.AutoSize = true;
            this.checkBoxDevice.Location = new System.Drawing.Point(6, 91);
            this.checkBoxDevice.Name = "checkBoxDevice";
            this.checkBoxDevice.Size = new System.Drawing.Size(79, 21);
            this.checkBoxDevice.TabIndex = 5;
            this.checkBoxDevice.Text = "DEVICE";
            this.checkBoxDevice.UseVisualStyleBackColor = true;
            this.checkBoxDevice.CheckedChanged += new System.EventHandler(this.checkBoxDevice_CheckedChanged);
            // 
            // checkBoxDirectory
            // 
            this.checkBoxDirectory.AutoSize = true;
            this.checkBoxDirectory.Location = new System.Drawing.Point(6, 118);
            this.checkBoxDirectory.Name = "checkBoxDirectory";
            this.checkBoxDirectory.Size = new System.Drawing.Size(110, 21);
            this.checkBoxDirectory.TabIndex = 6;
            this.checkBoxDirectory.Text = "DIRECTORY";
            this.checkBoxDirectory.UseVisualStyleBackColor = true;
            this.checkBoxDirectory.CheckedChanged += new System.EventHandler(this.checkBoxDirectory_CheckedChanged);
            // 
            // checkBoxEncrypted
            // 
            this.checkBoxEncrypted.AutoSize = true;
            this.checkBoxEncrypted.Location = new System.Drawing.Point(6, 145);
            this.checkBoxEncrypted.Name = "checkBoxEncrypted";
            this.checkBoxEncrypted.Size = new System.Drawing.Size(114, 21);
            this.checkBoxEncrypted.TabIndex = 7;
            this.checkBoxEncrypted.Text = "ENCRYPTED";
            this.checkBoxEncrypted.UseVisualStyleBackColor = true;
            this.checkBoxEncrypted.CheckedChanged += new System.EventHandler(this.checkBoxEncrypted_CheckedChanged);
            // 
            // checkBoxHidden
            // 
            this.checkBoxHidden.AutoSize = true;
            this.checkBoxHidden.Location = new System.Drawing.Point(6, 172);
            this.checkBoxHidden.Name = "checkBoxHidden";
            this.checkBoxHidden.Size = new System.Drawing.Size(82, 21);
            this.checkBoxHidden.TabIndex = 8;
            this.checkBoxHidden.Text = "HIDDEN";
            this.checkBoxHidden.UseVisualStyleBackColor = true;
            this.checkBoxHidden.CheckedChanged += new System.EventHandler(this.checkBoxHidden_CheckedChanged);
            // 
            // checkBoxNormal
            // 
            this.checkBoxNormal.AutoSize = true;
            this.checkBoxNormal.Location = new System.Drawing.Point(6, 199);
            this.checkBoxNormal.Name = "checkBoxNormal";
            this.checkBoxNormal.Size = new System.Drawing.Size(89, 21);
            this.checkBoxNormal.TabIndex = 9;
            this.checkBoxNormal.Text = "NORMAL";
            this.checkBoxNormal.UseVisualStyleBackColor = true;
            this.checkBoxNormal.CheckedChanged += new System.EventHandler(this.checkBoxNormal_CheckedChanged);
            // 
            // checkBoxOffline
            // 
            this.checkBoxOffline.AutoSize = true;
            this.checkBoxOffline.Location = new System.Drawing.Point(6, 226);
            this.checkBoxOffline.Name = "checkBoxOffline";
            this.checkBoxOffline.Size = new System.Drawing.Size(87, 21);
            this.checkBoxOffline.TabIndex = 10;
            this.checkBoxOffline.Text = "OFFLINE";
            this.checkBoxOffline.UseVisualStyleBackColor = true;
            this.checkBoxOffline.CheckedChanged += new System.EventHandler(this.checkBoxOffline_CheckedChanged);
            // 
            // checkBoxReadOnly
            // 
            this.checkBoxReadOnly.AutoSize = true;
            this.checkBoxReadOnly.Location = new System.Drawing.Point(6, 253);
            this.checkBoxReadOnly.Name = "checkBoxReadOnly";
            this.checkBoxReadOnly.Size = new System.Drawing.Size(106, 21);
            this.checkBoxReadOnly.TabIndex = 11;
            this.checkBoxReadOnly.Text = "READONLY";
            this.checkBoxReadOnly.UseVisualStyleBackColor = true;
            this.checkBoxReadOnly.CheckedChanged += new System.EventHandler(this.checkBoxReadOnly_CheckedChanged);
            // 
            // checkBoxVirtual
            // 
            this.checkBoxVirtual.AutoSize = true;
            this.checkBoxVirtual.Location = new System.Drawing.Point(155, 253);
            this.checkBoxVirtual.Name = "checkBoxVirtual";
            this.checkBoxVirtual.Size = new System.Drawing.Size(88, 21);
            this.checkBoxVirtual.TabIndex = 20;
            this.checkBoxVirtual.Text = "VIRTUAL";
            this.checkBoxVirtual.UseVisualStyleBackColor = true;
            this.checkBoxVirtual.CheckedChanged += new System.EventHandler(this.checkBoxVirtual_CheckedChanged);
            // 
            // checkBoxTemporary
            // 
            this.checkBoxTemporary.AutoSize = true;
            this.checkBoxTemporary.Location = new System.Drawing.Point(155, 226);
            this.checkBoxTemporary.Name = "checkBoxTemporary";
            this.checkBoxTemporary.Size = new System.Drawing.Size(117, 21);
            this.checkBoxTemporary.TabIndex = 19;
            this.checkBoxTemporary.Text = "TEMPORARY";
            this.checkBoxTemporary.UseVisualStyleBackColor = true;
            this.checkBoxTemporary.CheckedChanged += new System.EventHandler(this.checkBoxTemporary_CheckedChanged);
            // 
            // checkBoxSystem
            // 
            this.checkBoxSystem.AutoSize = true;
            this.checkBoxSystem.Location = new System.Drawing.Point(155, 199);
            this.checkBoxSystem.Name = "checkBoxSystem";
            this.checkBoxSystem.Size = new System.Drawing.Size(86, 21);
            this.checkBoxSystem.TabIndex = 18;
            this.checkBoxSystem.Text = "SYSTEM";
            this.checkBoxSystem.UseVisualStyleBackColor = true;
            this.checkBoxSystem.CheckedChanged += new System.EventHandler(this.checkBoxSystem_CheckedChanged);
            // 
            // checkBoxSparse_File
            // 
            this.checkBoxSparse_File.AutoSize = true;
            this.checkBoxSparse_File.Location = new System.Drawing.Point(155, 172);
            this.checkBoxSparse_File.Name = "checkBoxSparse_File";
            this.checkBoxSparse_File.Size = new System.Drawing.Size(121, 21);
            this.checkBoxSparse_File.TabIndex = 17;
            this.checkBoxSparse_File.Text = "SPARSE_FILE";
            this.checkBoxSparse_File.UseVisualStyleBackColor = true;
            this.checkBoxSparse_File.CheckedChanged += new System.EventHandler(this.checkBoxSparse_File_CheckedChanged);
            // 
            // checkBoxReparse_Point
            // 
            this.checkBoxReparse_Point.AutoSize = true;
            this.checkBoxReparse_Point.Location = new System.Drawing.Point(155, 145);
            this.checkBoxReparse_Point.Name = "checkBoxReparse_Point";
            this.checkBoxReparse_Point.Size = new System.Drawing.Size(145, 21);
            this.checkBoxReparse_Point.TabIndex = 16;
            this.checkBoxReparse_Point.Text = "REPARSE_POINT";
            this.checkBoxReparse_Point.UseVisualStyleBackColor = true;
            this.checkBoxReparse_Point.CheckedChanged += new System.EventHandler(this.checkBoxReparse_Point_CheckedChanged);
            // 
            // checkBoxRecall_On_Open
            // 
            this.checkBoxRecall_On_Open.AutoSize = true;
            this.checkBoxRecall_On_Open.Location = new System.Drawing.Point(155, 118);
            this.checkBoxRecall_On_Open.Name = "checkBoxRecall_On_Open";
            this.checkBoxRecall_On_Open.Size = new System.Drawing.Size(159, 21);
            this.checkBoxRecall_On_Open.TabIndex = 15;
            this.checkBoxRecall_On_Open.Text = "RECALL_ON_OPEN";
            this.checkBoxRecall_On_Open.UseVisualStyleBackColor = true;
            this.checkBoxRecall_On_Open.CheckedChanged += new System.EventHandler(this.checkBoxRecall_On_Open_CheckedChanged);
            // 
            // checkBoxRecall_On_Data_Access
            // 
            this.checkBoxRecall_On_Data_Access.AutoSize = true;
            this.checkBoxRecall_On_Data_Access.Location = new System.Drawing.Point(155, 91);
            this.checkBoxRecall_On_Data_Access.Name = "checkBoxRecall_On_Data_Access";
            this.checkBoxRecall_On_Data_Access.Size = new System.Drawing.Size(219, 21);
            this.checkBoxRecall_On_Data_Access.TabIndex = 14;
            this.checkBoxRecall_On_Data_Access.Text = "RECALL_ON_DATA_ACCESS";
            this.checkBoxRecall_On_Data_Access.UseVisualStyleBackColor = true;
            this.checkBoxRecall_On_Data_Access.CheckedChanged += new System.EventHandler(this.checkBoxRecall_On_Data_Access_CheckedChanged);
            // 
            // checkBoxNo_Scrub_Data
            // 
            this.checkBoxNo_Scrub_Data.AutoSize = true;
            this.checkBoxNo_Scrub_Data.Location = new System.Drawing.Point(155, 64);
            this.checkBoxNo_Scrub_Data.Name = "checkBoxNo_Scrub_Data";
            this.checkBoxNo_Scrub_Data.Size = new System.Drawing.Size(151, 21);
            this.checkBoxNo_Scrub_Data.TabIndex = 13;
            this.checkBoxNo_Scrub_Data.Text = "NO_SCRUB_DATA";
            this.checkBoxNo_Scrub_Data.UseVisualStyleBackColor = true;
            this.checkBoxNo_Scrub_Data.CheckedChanged += new System.EventHandler(this.checkBoxNo_Scrub_Data_CheckedChanged);
            // 
            // checkBoxNot_Content_Indexed
            // 
            this.checkBoxNot_Content_Indexed.AutoSize = true;
            this.checkBoxNot_Content_Indexed.Location = new System.Drawing.Point(155, 37);
            this.checkBoxNot_Content_Indexed.Name = "checkBoxNot_Content_Indexed";
            this.checkBoxNot_Content_Indexed.Size = new System.Drawing.Size(203, 21);
            this.checkBoxNot_Content_Indexed.TabIndex = 12;
            this.checkBoxNot_Content_Indexed.Text = "NOT_CONTENT_INDEXED";
            this.checkBoxNot_Content_Indexed.UseVisualStyleBackColor = true;
            this.checkBoxNot_Content_Indexed.CheckedChanged += new System.EventHandler(this.checkBoxNot_Content_Indexed_CheckedChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.checkBoxArchive);
            this.groupBox1.Controls.Add(this.checkBoxVirtual);
            this.groupBox1.Controls.Add(this.checkBoxCompressed);
            this.groupBox1.Controls.Add(this.checkBoxTemporary);
            this.groupBox1.Controls.Add(this.checkBoxDevice);
            this.groupBox1.Controls.Add(this.checkBoxSystem);
            this.groupBox1.Controls.Add(this.checkBoxDirectory);
            this.groupBox1.Controls.Add(this.checkBoxSparse_File);
            this.groupBox1.Controls.Add(this.checkBoxEncrypted);
            this.groupBox1.Controls.Add(this.checkBoxReparse_Point);
            this.groupBox1.Controls.Add(this.checkBoxHidden);
            this.groupBox1.Controls.Add(this.checkBoxRecall_On_Open);
            this.groupBox1.Controls.Add(this.checkBoxNormal);
            this.groupBox1.Controls.Add(this.checkBoxRecall_On_Data_Access);
            this.groupBox1.Controls.Add(this.checkBoxOffline);
            this.groupBox1.Controls.Add(this.checkBoxNo_Scrub_Data);
            this.groupBox1.Controls.Add(this.checkBoxReadOnly);
            this.groupBox1.Controls.Add(this.checkBoxNot_Content_Indexed);
            this.groupBox1.Location = new System.Drawing.Point(12, 86);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(377, 285);
            this.groupBox1.TabIndex = 21;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Check attributes to include::";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.textBoxFileExtensions);
            this.groupBox2.Controls.Add(this.radioWhitelist);
            this.groupBox2.Controls.Add(this.radioBlacklist);
            this.groupBox2.Location = new System.Drawing.Point(469, 86);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(370, 285);
            this.groupBox2.TabIndex = 22;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Add file-extensions:";
            // 
            // textBoxFileExtensions
            // 
            this.textBoxFileExtensions.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxFileExtensions.Location = new System.Drawing.Point(6, 102);
            this.textBoxFileExtensions.Multiline = true;
            this.textBoxFileExtensions.Name = "textBoxFileExtensions";
            this.textBoxFileExtensions.Size = new System.Drawing.Size(358, 172);
            this.textBoxFileExtensions.TabIndex = 2;
            this.textBoxFileExtensions.Text = ".dll+.zip+.mp3";
            // 
            // radioWhitelist
            // 
            this.radioWhitelist.AutoSize = true;
            this.radioWhitelist.Location = new System.Drawing.Point(6, 75);
            this.radioWhitelist.Name = "radioWhitelist";
            this.radioWhitelist.Size = new System.Drawing.Size(90, 21);
            this.radioWhitelist.TabIndex = 1;
            this.radioWhitelist.Text = "Whitelist?";
            this.radioWhitelist.UseVisualStyleBackColor = true;
            this.radioWhitelist.CheckedChanged += new System.EventHandler(this.radioWhitelist_CheckedChanged);
            // 
            // radioBlacklist
            // 
            this.radioBlacklist.AutoSize = true;
            this.radioBlacklist.Checked = true;
            this.radioBlacklist.Location = new System.Drawing.Point(6, 37);
            this.radioBlacklist.Name = "radioBlacklist";
            this.radioBlacklist.Size = new System.Drawing.Size(88, 21);
            this.radioBlacklist.TabIndex = 0;
            this.radioBlacklist.TabStop = true;
            this.radioBlacklist.Text = "Blacklist?";
            this.radioBlacklist.UseVisualStyleBackColor = true;
            this.radioBlacklist.CheckedChanged += new System.EventHandler(this.radioBlacklist_CheckedChanged);
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(487, 374);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(346, 23);
            this.label2.TabIndex = 3;
            this.label2.Text = "NB: Seperate file extensions with the \' + \' character.";
            // 
            // addpathbutton
            // 
            this.addpathbutton.Location = new System.Drawing.Point(743, 543);
            this.addpathbutton.Name = "addpathbutton";
            this.addpathbutton.Size = new System.Drawing.Size(96, 32);
            this.addpathbutton.TabIndex = 23;
            this.addpathbutton.Text = "Add path...";
            this.addpathbutton.UseVisualStyleBackColor = true;
            this.addpathbutton.Click += new System.EventHandler(this.addpathbutton_click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // textBoxpaths
            // 
            this.textBoxpaths.Location = new System.Drawing.Point(12, 429);
            this.textBoxpaths.Multiline = true;
            this.textBoxpaths.Name = "textBoxpaths";
            this.textBoxpaths.ReadOnly = true;
            this.textBoxpaths.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxpaths.Size = new System.Drawing.Size(725, 146);
            this.textBoxpaths.TabIndex = 24;
            this.textBoxpaths.Text = "C:\\Windows\r\nC:\\Videos\\\r\nD:\\\r\n";
            // 
            // labelPaths
            // 
            this.labelPaths.AutoSize = true;
            this.labelPaths.Location = new System.Drawing.Point(15, 399);
            this.labelPaths.Name = "labelPaths";
            this.labelPaths.Size = new System.Drawing.Size(48, 17);
            this.labelPaths.TabIndex = 25;
            this.labelPaths.Text = "Paths:";
            // 
            // radioBlacklist2
            // 
            this.radioBlacklist2.AutoSize = true;
            this.radioBlacklist2.Checked = true;
            this.radioBlacklist2.Location = new System.Drawing.Point(743, 430);
            this.radioBlacklist2.Name = "radioBlacklist2";
            this.radioBlacklist2.Size = new System.Drawing.Size(88, 21);
            this.radioBlacklist2.TabIndex = 26;
            this.radioBlacklist2.TabStop = true;
            this.radioBlacklist2.Text = "Blacklist?";
            this.radioBlacklist2.UseVisualStyleBackColor = true;
            // 
            // radioWhitelist2
            // 
            this.radioWhitelist2.AutoSize = true;
            this.radioWhitelist2.Location = new System.Drawing.Point(743, 469);
            this.radioWhitelist2.Name = "radioWhitelist2";
            this.radioWhitelist2.Size = new System.Drawing.Size(90, 21);
            this.radioWhitelist2.TabIndex = 27;
            this.radioWhitelist2.Text = "Whitelist?";
            this.radioWhitelist2.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(15, 555);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(386, 17);
            this.label4.TabIndex = 28;
            this.label4.Text = "OBS: Specifying a folder will also include any subdirectories!";
            // 
            // beginsearchbutton
            // 
            this.beginsearchbutton.Location = new System.Drawing.Point(712, 12);
            this.beginsearchbutton.Name = "beginsearchbutton";
            this.beginsearchbutton.Size = new System.Drawing.Size(128, 52);
            this.beginsearchbutton.TabIndex = 29;
            this.beginsearchbutton.Text = "Begin search...";
            this.beginsearchbutton.UseVisualStyleBackColor = true;
            // 
            // labelMaxFileSize
            // 
            this.labelMaxFileSize.AutoSize = true;
            this.labelMaxFileSize.Location = new System.Drawing.Point(171, 9);
            this.labelMaxFileSize.Name = "labelMaxFileSize";
            this.labelMaxFileSize.Size = new System.Drawing.Size(120, 17);
            this.labelMaxFileSize.TabIndex = 30;
            this.labelMaxFileSize.Text = "Max. Filesize(KB):";
            // 
            // textBoxMaxFileSize
            // 
            this.textBoxMaxFileSize.Location = new System.Drawing.Point(174, 42);
            this.textBoxMaxFileSize.Name = "textBoxMaxFileSize";
            this.textBoxMaxFileSize.Size = new System.Drawing.Size(117, 22);
            this.textBoxMaxFileSize.TabIndex = 31;
            this.textBoxMaxFileSize.Text = "204.800";
            this.textBoxMaxFileSize.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(852, 593);
            this.Controls.Add(this.textBoxMaxFileSize);
            this.Controls.Add(this.labelMaxFileSize);
            this.Controls.Add(this.beginsearchbutton);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.radioWhitelist2);
            this.Controls.Add(this.radioBlacklist2);
            this.Controls.Add(this.labelPaths);
            this.Controls.Add(this.textBoxpaths);
            this.Controls.Add(this.addpathbutton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.textBoxMinFileSize);
            this.Controls.Add(this.labelMinFileSize);
            this.Name = "Form1";
            this.Text = "Dupfinder-GUI";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelMinFileSize;
        private System.Windows.Forms.TextBox textBoxMinFileSize;
        private System.Windows.Forms.CheckBox checkBoxArchive;
        private System.Windows.Forms.CheckBox checkBoxCompressed;
        private System.Windows.Forms.CheckBox checkBoxDevice;
        private System.Windows.Forms.CheckBox checkBoxDirectory;
        private System.Windows.Forms.CheckBox checkBoxEncrypted;
        private System.Windows.Forms.CheckBox checkBoxHidden;
        private System.Windows.Forms.CheckBox checkBoxNormal;
        private System.Windows.Forms.CheckBox checkBoxOffline;
        private System.Windows.Forms.CheckBox checkBoxReadOnly;
        private System.Windows.Forms.CheckBox checkBoxVirtual;
        private System.Windows.Forms.CheckBox checkBoxTemporary;
        private System.Windows.Forms.CheckBox checkBoxSystem;
        private System.Windows.Forms.CheckBox checkBoxSparse_File;
        private System.Windows.Forms.CheckBox checkBoxReparse_Point;
        private System.Windows.Forms.CheckBox checkBoxRecall_On_Open;
        private System.Windows.Forms.CheckBox checkBoxRecall_On_Data_Access;
        private System.Windows.Forms.CheckBox checkBoxNo_Scrub_Data;
        private System.Windows.Forms.CheckBox checkBoxNot_Content_Indexed;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox textBoxFileExtensions;
        private System.Windows.Forms.RadioButton radioWhitelist;
        private System.Windows.Forms.RadioButton radioBlacklist;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button addpathbutton;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.TextBox textBoxpaths;
        private System.Windows.Forms.Label labelPaths;
        private System.Windows.Forms.RadioButton radioBlacklist2;
        private System.Windows.Forms.RadioButton radioWhitelist2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button beginsearchbutton;
        private System.Windows.Forms.Label labelMaxFileSize;
        private System.Windows.Forms.TextBox textBoxMaxFileSize;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
    }
}

