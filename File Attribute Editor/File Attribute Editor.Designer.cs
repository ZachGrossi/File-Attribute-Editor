namespace File_Attribute_Editor
{
	partial class File_Attribute_Editor
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
			this.btnFile = new System.Windows.Forms.Button();
			this.txtFName = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.txtFExt = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.txtFSize = new System.Windows.Forms.TextBox();
			this.label4 = new System.Windows.Forms.Label();
			this.dtpCreated = new System.Windows.Forms.DateTimePicker();
			this.label5 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.label7 = new System.Windows.Forms.Label();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.txtFile = new System.Windows.Forms.TextBox();
			this.label8 = new System.Windows.Forms.Label();
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			this.dtpModified = new System.Windows.Forms.DateTimePicker();
			this.dtpAccessed = new System.Windows.Forms.DateTimePicker();
			this.groupBox3 = new System.Windows.Forms.GroupBox();
			this.cboxSparseFile = new System.Windows.Forms.CheckBox();
			this.cboxReparsePoint = new System.Windows.Forms.CheckBox();
			this.cboxDevice = new System.Windows.Forms.CheckBox();
			this.cboxTemporary = new System.Windows.Forms.CheckBox();
			this.cboxSystem = new System.Windows.Forms.CheckBox();
			this.cboxReadOnly = new System.Windows.Forms.CheckBox();
			this.cboxOffline = new System.Windows.Forms.CheckBox();
			this.cboxNotContentIndexed = new System.Windows.Forms.CheckBox();
			this.cboxHidden = new System.Windows.Forms.CheckBox();
			this.cboxNormal = new System.Windows.Forms.CheckBox();
			this.cboxEncrypted = new System.Windows.Forms.CheckBox();
			this.cboxDirectory = new System.Windows.Forms.CheckBox();
			this.cboxCompressed = new System.Windows.Forms.CheckBox();
			this.cboxArchive = new System.Windows.Forms.CheckBox();
			this.btnWrite = new System.Windows.Forms.Button();
			this.groupBox1.SuspendLayout();
			this.groupBox2.SuspendLayout();
			this.groupBox3.SuspendLayout();
			this.SuspendLayout();
			// 
			// btnFile
			// 
			this.btnFile.Location = new System.Drawing.Point(327, 12);
			this.btnFile.Name = "btnFile";
			this.btnFile.Size = new System.Drawing.Size(45, 23);
			this.btnFile.TabIndex = 2;
			this.btnFile.Text = "File";
			this.btnFile.UseVisualStyleBackColor = true;
			this.btnFile.Click += new System.EventHandler(this.btnFile_Click);
			// 
			// txtFName
			// 
			this.txtFName.Location = new System.Drawing.Point(65, 19);
			this.txtFName.Name = "txtFName";
			this.txtFName.Size = new System.Drawing.Size(281, 20);
			this.txtFName.TabIndex = 1;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(24, 22);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(35, 13);
			this.label1.TabIndex = 2;
			this.label1.Text = "Name";
			// 
			// txtFExt
			// 
			this.txtFExt.Location = new System.Drawing.Point(65, 45);
			this.txtFExt.Name = "txtFExt";
			this.txtFExt.Size = new System.Drawing.Size(116, 20);
			this.txtFExt.TabIndex = 2;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(6, 48);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(53, 13);
			this.label2.TabIndex = 4;
			this.label2.Text = "Extension";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(32, 74);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(27, 13);
			this.label3.TabIndex = 5;
			this.label3.Text = "Size";
			// 
			// txtFSize
			// 
			this.txtFSize.Location = new System.Drawing.Point(65, 71);
			this.txtFSize.Name = "txtFSize";
			this.txtFSize.ReadOnly = true;
			this.txtFSize.Size = new System.Drawing.Size(116, 20);
			this.txtFSize.TabIndex = 3;
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(187, 74);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(33, 13);
			this.label4.TabIndex = 7;
			this.label4.Text = "Bytes";
			// 
			// dtpCreated
			// 
			this.dtpCreated.CustomFormat = "MM/dd/yyyy  hh:mm:ss";
			this.dtpCreated.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
			this.dtpCreated.Location = new System.Drawing.Point(89, 19);
			this.dtpCreated.Name = "dtpCreated";
			this.dtpCreated.Size = new System.Drawing.Size(203, 20);
			this.dtpCreated.TabIndex = 1;
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(39, 22);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(44, 13);
			this.label5.TabIndex = 9;
			this.label5.Text = "Created";
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Location = new System.Drawing.Point(6, 48);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(77, 13);
			this.label6.TabIndex = 10;
			this.label6.Text = "Last Accessed";
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Location = new System.Drawing.Point(13, 74);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(70, 13);
			this.label7.TabIndex = 11;
			this.label7.Text = "Last Modified";
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.label1);
			this.groupBox1.Controls.Add(this.txtFName);
			this.groupBox1.Controls.Add(this.label2);
			this.groupBox1.Controls.Add(this.txtFExt);
			this.groupBox1.Controls.Add(this.txtFSize);
			this.groupBox1.Controls.Add(this.label4);
			this.groupBox1.Controls.Add(this.label3);
			this.groupBox1.Location = new System.Drawing.Point(12, 51);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(360, 100);
			this.groupBox1.TabIndex = 3;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "File";
			// 
			// txtFile
			// 
			this.txtFile.Location = new System.Drawing.Point(49, 14);
			this.txtFile.Name = "txtFile";
			this.txtFile.ReadOnly = true;
			this.txtFile.Size = new System.Drawing.Size(272, 20);
			this.txtFile.TabIndex = 1;
			// 
			// label8
			// 
			this.label8.AutoSize = true;
			this.label8.Location = new System.Drawing.Point(20, 17);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(23, 13);
			this.label8.TabIndex = 16;
			this.label8.Text = "File";
			// 
			// groupBox2
			// 
			this.groupBox2.Controls.Add(this.dtpModified);
			this.groupBox2.Controls.Add(this.dtpAccessed);
			this.groupBox2.Controls.Add(this.label6);
			this.groupBox2.Controls.Add(this.dtpCreated);
			this.groupBox2.Controls.Add(this.label5);
			this.groupBox2.Controls.Add(this.label7);
			this.groupBox2.Location = new System.Drawing.Point(12, 157);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Size = new System.Drawing.Size(360, 97);
			this.groupBox2.TabIndex = 4;
			this.groupBox2.TabStop = false;
			this.groupBox2.Text = "Dates";
			// 
			// dtpModified
			// 
			this.dtpModified.CustomFormat = "MM/dd/yyyy  hh:mm:ss";
			this.dtpModified.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
			this.dtpModified.Location = new System.Drawing.Point(89, 71);
			this.dtpModified.Name = "dtpModified";
			this.dtpModified.Size = new System.Drawing.Size(203, 20);
			this.dtpModified.TabIndex = 3;
			// 
			// dtpAccessed
			// 
			this.dtpAccessed.CustomFormat = "MM/dd/yyyy  hh:mm:ss";
			this.dtpAccessed.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
			this.dtpAccessed.Location = new System.Drawing.Point(89, 45);
			this.dtpAccessed.Name = "dtpAccessed";
			this.dtpAccessed.Size = new System.Drawing.Size(203, 20);
			this.dtpAccessed.TabIndex = 2;
			// 
			// groupBox3
			// 
			this.groupBox3.Controls.Add(this.cboxSparseFile);
			this.groupBox3.Controls.Add(this.cboxReparsePoint);
			this.groupBox3.Controls.Add(this.cboxDevice);
			this.groupBox3.Controls.Add(this.cboxTemporary);
			this.groupBox3.Controls.Add(this.cboxSystem);
			this.groupBox3.Controls.Add(this.cboxReadOnly);
			this.groupBox3.Controls.Add(this.cboxOffline);
			this.groupBox3.Controls.Add(this.cboxNotContentIndexed);
			this.groupBox3.Controls.Add(this.cboxHidden);
			this.groupBox3.Controls.Add(this.cboxNormal);
			this.groupBox3.Controls.Add(this.cboxEncrypted);
			this.groupBox3.Controls.Add(this.cboxDirectory);
			this.groupBox3.Controls.Add(this.cboxCompressed);
			this.groupBox3.Controls.Add(this.cboxArchive);
			this.groupBox3.Location = new System.Drawing.Point(12, 260);
			this.groupBox3.Name = "groupBox3";
			this.groupBox3.Size = new System.Drawing.Size(360, 140);
			this.groupBox3.TabIndex = 5;
			this.groupBox3.TabStop = false;
			this.groupBox3.Text = "Attributes";
			// 
			// cboxSparseFile
			// 
			this.cboxSparseFile.AutoSize = true;
			this.cboxSparseFile.Location = new System.Drawing.Point(261, 43);
			this.cboxSparseFile.Name = "cboxSparseFile";
			this.cboxSparseFile.Size = new System.Drawing.Size(78, 17);
			this.cboxSparseFile.TabIndex = 12;
			this.cboxSparseFile.Text = "Sparse File";
			this.cboxSparseFile.UseVisualStyleBackColor = true;
			// 
			// cboxReparsePoint
			// 
			this.cboxReparsePoint.AutoSize = true;
			this.cboxReparsePoint.Location = new System.Drawing.Point(261, 19);
			this.cboxReparsePoint.Name = "cboxReparsePoint";
			this.cboxReparsePoint.Size = new System.Drawing.Size(93, 17);
			this.cboxReparsePoint.TabIndex = 11;
			this.cboxReparsePoint.Text = "Reparse Point";
			this.cboxReparsePoint.UseVisualStyleBackColor = true;
			// 
			// cboxDevice
			// 
			this.cboxDevice.AutoSize = true;
			this.cboxDevice.Location = new System.Drawing.Point(6, 66);
			this.cboxDevice.Name = "cboxDevice";
			this.cboxDevice.Size = new System.Drawing.Size(60, 17);
			this.cboxDevice.TabIndex = 3;
			this.cboxDevice.Text = "Device";
			this.cboxDevice.UseVisualStyleBackColor = true;
			// 
			// cboxTemporary
			// 
			this.cboxTemporary.AutoSize = true;
			this.cboxTemporary.Location = new System.Drawing.Point(261, 89);
			this.cboxTemporary.Name = "cboxTemporary";
			this.cboxTemporary.Size = new System.Drawing.Size(76, 17);
			this.cboxTemporary.TabIndex = 14;
			this.cboxTemporary.Text = "Temporary";
			this.cboxTemporary.UseVisualStyleBackColor = true;
			// 
			// cboxSystem
			// 
			this.cboxSystem.AutoSize = true;
			this.cboxSystem.Location = new System.Drawing.Point(261, 66);
			this.cboxSystem.Name = "cboxSystem";
			this.cboxSystem.Size = new System.Drawing.Size(60, 17);
			this.cboxSystem.TabIndex = 13;
			this.cboxSystem.Text = "System";
			this.cboxSystem.UseVisualStyleBackColor = true;
			// 
			// cboxReadOnly
			// 
			this.cboxReadOnly.AutoSize = true;
			this.cboxReadOnly.Location = new System.Drawing.Point(122, 112);
			this.cboxReadOnly.Name = "cboxReadOnly";
			this.cboxReadOnly.Size = new System.Drawing.Size(76, 17);
			this.cboxReadOnly.TabIndex = 10;
			this.cboxReadOnly.Text = "Read Only";
			this.cboxReadOnly.UseVisualStyleBackColor = true;
			// 
			// cboxOffline
			// 
			this.cboxOffline.AutoSize = true;
			this.cboxOffline.Location = new System.Drawing.Point(122, 89);
			this.cboxOffline.Name = "cboxOffline";
			this.cboxOffline.Size = new System.Drawing.Size(56, 17);
			this.cboxOffline.TabIndex = 9;
			this.cboxOffline.Text = "Offline";
			this.cboxOffline.UseVisualStyleBackColor = true;
			// 
			// cboxNotContentIndexed
			// 
			this.cboxNotContentIndexed.AutoSize = true;
			this.cboxNotContentIndexed.Location = new System.Drawing.Point(122, 66);
			this.cboxNotContentIndexed.Name = "cboxNotContentIndexed";
			this.cboxNotContentIndexed.Size = new System.Drawing.Size(124, 17);
			this.cboxNotContentIndexed.TabIndex = 8;
			this.cboxNotContentIndexed.Text = "Not Content Indexed";
			this.cboxNotContentIndexed.UseVisualStyleBackColor = true;
			// 
			// cboxHidden
			// 
			this.cboxHidden.AutoSize = true;
			this.cboxHidden.Location = new System.Drawing.Point(122, 19);
			this.cboxHidden.Name = "cboxHidden";
			this.cboxHidden.Size = new System.Drawing.Size(60, 17);
			this.cboxHidden.TabIndex = 6;
			this.cboxHidden.Text = "Hidden";
			this.cboxHidden.UseVisualStyleBackColor = true;
			// 
			// cboxNormal
			// 
			this.cboxNormal.AutoSize = true;
			this.cboxNormal.Location = new System.Drawing.Point(122, 43);
			this.cboxNormal.Name = "cboxNormal";
			this.cboxNormal.Size = new System.Drawing.Size(59, 17);
			this.cboxNormal.TabIndex = 7;
			this.cboxNormal.Text = "Normal";
			this.cboxNormal.UseVisualStyleBackColor = true;
			// 
			// cboxEncrypted
			// 
			this.cboxEncrypted.AutoSize = true;
			this.cboxEncrypted.Location = new System.Drawing.Point(6, 112);
			this.cboxEncrypted.Name = "cboxEncrypted";
			this.cboxEncrypted.Size = new System.Drawing.Size(74, 17);
			this.cboxEncrypted.TabIndex = 5;
			this.cboxEncrypted.Text = "Encrypted";
			this.cboxEncrypted.UseVisualStyleBackColor = true;
			// 
			// cboxDirectory
			// 
			this.cboxDirectory.AutoSize = true;
			this.cboxDirectory.Location = new System.Drawing.Point(6, 89);
			this.cboxDirectory.Name = "cboxDirectory";
			this.cboxDirectory.Size = new System.Drawing.Size(68, 17);
			this.cboxDirectory.TabIndex = 4;
			this.cboxDirectory.Text = "Directory";
			this.cboxDirectory.UseVisualStyleBackColor = true;
			// 
			// cboxCompressed
			// 
			this.cboxCompressed.AutoSize = true;
			this.cboxCompressed.Enabled = false;
			this.cboxCompressed.Location = new System.Drawing.Point(6, 43);
			this.cboxCompressed.Name = "cboxCompressed";
			this.cboxCompressed.Size = new System.Drawing.Size(84, 17);
			this.cboxCompressed.TabIndex = 2;
			this.cboxCompressed.Text = "Compressed";
			this.cboxCompressed.UseVisualStyleBackColor = true;
			// 
			// cboxArchive
			// 
			this.cboxArchive.AutoSize = true;
			this.cboxArchive.Location = new System.Drawing.Point(6, 19);
			this.cboxArchive.Name = "cboxArchive";
			this.cboxArchive.Size = new System.Drawing.Size(62, 17);
			this.cboxArchive.TabIndex = 1;
			this.cboxArchive.Text = "Archive";
			this.cboxArchive.UseVisualStyleBackColor = true;
			// 
			// btnWrite
			// 
			this.btnWrite.Location = new System.Drawing.Point(12, 406);
			this.btnWrite.Name = "btnWrite";
			this.btnWrite.Size = new System.Drawing.Size(360, 27);
			this.btnWrite.TabIndex = 15;
			this.btnWrite.Text = "Save Changes";
			this.btnWrite.UseVisualStyleBackColor = true;
			this.btnWrite.Click += new System.EventHandler(this.btnWrite_Click);
			// 
			// File_Attribute_Editor
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(384, 445);
			this.Controls.Add(this.btnWrite);
			this.Controls.Add(this.groupBox3);
			this.Controls.Add(this.groupBox2);
			this.Controls.Add(this.label8);
			this.Controls.Add(this.txtFile);
			this.Controls.Add(this.groupBox1);
			this.Controls.Add(this.btnFile);
			this.MaximumSize = new System.Drawing.Size(400, 483);
			this.MinimumSize = new System.Drawing.Size(400, 483);
			this.Name = "File_Attribute_Editor";
			this.Text = "File Attribute Editor";
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			this.groupBox2.ResumeLayout(false);
			this.groupBox2.PerformLayout();
			this.groupBox3.ResumeLayout(false);
			this.groupBox3.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button btnFile;
		private System.Windows.Forms.TextBox txtFName;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox txtFExt;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox txtFSize;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.DateTimePicker dtpCreated;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.TextBox txtFile;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.GroupBox groupBox2;
		private System.Windows.Forms.DateTimePicker dtpModified;
		private System.Windows.Forms.DateTimePicker dtpAccessed;
		private System.Windows.Forms.GroupBox groupBox3;
		private System.Windows.Forms.CheckBox cboxSparseFile;
		private System.Windows.Forms.CheckBox cboxReparsePoint;
		private System.Windows.Forms.CheckBox cboxDevice;
		private System.Windows.Forms.CheckBox cboxTemporary;
		private System.Windows.Forms.CheckBox cboxSystem;
		private System.Windows.Forms.CheckBox cboxReadOnly;
		private System.Windows.Forms.CheckBox cboxOffline;
		private System.Windows.Forms.CheckBox cboxNotContentIndexed;
		private System.Windows.Forms.CheckBox cboxHidden;
		private System.Windows.Forms.CheckBox cboxNormal;
		private System.Windows.Forms.CheckBox cboxEncrypted;
		private System.Windows.Forms.CheckBox cboxDirectory;
		private System.Windows.Forms.CheckBox cboxCompressed;
		private System.Windows.Forms.CheckBox cboxArchive;
		private System.Windows.Forms.Button btnWrite;
	}
}

