using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace File_Attribute_Editor
{
	public partial class File_Attribute_Editor : Form
	{
		private FileInfo _FileInfo;

		public File_Attribute_Editor()
		{
			InitializeComponent();
		}

		#region GUI Actions
		/// <summary>
		/// Executed when the "Save Changes" button is clicked
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void btnWrite_Click(object sender, EventArgs e)
		{
			//check to make sure that a file is loaded for modifying
			if (txtFile.Text != "")
			{
				UpdateFileData();
			}
			else
			{
				MessageBox.Show("You need to select a file to modify first", "No File Chosen",
					MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		/// <summary>
		/// Executed when the "File" button is clicked
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void btnFile_Click(object sender, EventArgs e)
		{
			try
			{
				//create the open dialog box
				OpenFileDialog open = new OpenFileDialog();
				open.DefaultExt = "*.*";
				open.Filter = "All Files|*.*";
				open.Title = "Choose a file to modify";
				open.CheckFileExists = true;
				open.CheckPathExists = true;
				open.Multiselect = false;
				open.ShowDialog();

				//save the filename for later and clean up the OpenFileDialog object
				txtFile.Text = open.FileName;
				open.Dispose();

				ParseAttributestoGUI(open.FileName);
			}
			catch (UnauthorizedAccessException ex)
			{
				MessageBox.Show("You do not have the necessary permissions to access this file.",
					"File Permissions Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
			catch (NotSupportedException ex)
			{
				MessageBox.Show("This file is not supported.", "Unsupported File",
					MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
			catch (Exception ex)
			{
				MessageBox.Show("Unknown File Error.\n\n" + ex.Message + "\n\n" + ex.InnerException,
					"File Permissions Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}
		#endregion

		#region Methods
		/// <summary>
		/// Take the attributes of the file and turn it into GUI actions
		/// </summary>
		private void ParseAttributestoGUI(string filePath)
		{
			_FileInfo = new FileInfo(filePath);

			//parse the filename and size info
			txtFName.Text = Path.GetFileNameWithoutExtension(filePath);
			txtFExt.Text = _FileInfo.Extension;
			txtFSize.Text = _FileInfo.Length.ToString();

			//Parse the creation date metadata
			DateTime created = _FileInfo.CreationTime;
			dtpCreated.Value = created;

			//Parse the access date metadata
			DateTime accessed = _FileInfo.LastAccessTime;
			dtpAccessed.Value = accessed;

			//Parse the modification date metadata
			DateTime modifed = _FileInfo.LastWriteTime;
			dtpModified.Value = modifed;

			//parse the individual file attributes
			FileAttributes fAtt = _FileInfo.Attributes;

			cboxArchive.Checked = ((fAtt & FileAttributes.Archive) == FileAttributes.Archive) ? true : false;
			cboxCompressed.Checked = ((fAtt & FileAttributes.Compressed) == FileAttributes.Compressed) ? true : false;
			cboxDevice.Checked = ((fAtt & FileAttributes.Device) == FileAttributes.Device) ? true : false;
			cboxDirectory.Checked = ((fAtt & FileAttributes.Directory) == FileAttributes.Directory) ? true : false;
			cboxEncrypted.Checked = ((fAtt & FileAttributes.Encrypted) == FileAttributes.Encrypted) ? true : false;
			cboxHidden.Checked = ((fAtt & FileAttributes.Hidden) == FileAttributes.Hidden) ? true : false;
			cboxNormal.Checked = ((fAtt & FileAttributes.Normal) == FileAttributes.Normal) ? true : false;
			cboxNotContentIndexed.Checked = ((fAtt & FileAttributes.NotContentIndexed) == FileAttributes.NotContentIndexed) ? true : false;
			cboxOffline.Checked = ((fAtt & FileAttributes.Offline) == FileAttributes.Offline) ? true : false;
			cboxReadOnly.Checked = ((fAtt & FileAttributes.ReadOnly) == FileAttributes.ReadOnly) ? true : false;
			cboxReparsePoint.Checked = ((fAtt & FileAttributes.ReparsePoint) == FileAttributes.ReparsePoint) ? true : false;
			cboxSparseFile.Checked = ((fAtt & FileAttributes.SparseFile) == FileAttributes.SparseFile) ? true : false;
			cboxSystem.Checked = ((fAtt & FileAttributes.System) == FileAttributes.System) ? true : false;
			cboxTemporary.Checked = ((fAtt & FileAttributes.Temporary) == FileAttributes.Temporary) ? true : false;
		}		

		/// <summary>
		/// Fired when the file needs to be updated
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void UpdateFileData()
		{
			try
			{
				//check the filename and extension
				string path = Path.GetDirectoryName(txtFile.Text);
				string name = txtFName.Text;
				string extension = txtFExt.Text;
				extension = (extension[0] == '.') ? extension.Substring(1) : extension;
				string fullPath = Path.Combine(path, name + "." + extension);

				if ((name != Path.GetFileNameWithoutExtension(txtFile.Text)) || (extension != Path.GetExtension(txtFile.Text)))
				{
					//update the filename
					File.Move(txtFile.Text, fullPath);
					txtFile.Text = fullPath;
					_FileInfo = new FileInfo(fullPath);
				}

				//Set the various metadata dates in the FileInfo 
				_FileInfo.CreationTime = dtpCreated.Value;
				_FileInfo.LastAccessTime = dtpAccessed.Value;
				_FileInfo.LastWriteTime = dtpModified.Value;

				//set the file attributes
				UpdateAttributes(fullPath, cboxArchive.Checked, FileAttributes.Archive);
				UpdateAttributes(fullPath, cboxCompressed.Checked, FileAttributes.Compressed);
				UpdateAttributes(fullPath, cboxDevice.Checked, FileAttributes.Device);
				UpdateAttributes(fullPath, cboxDirectory.Checked, FileAttributes.Directory);
				UpdateAttributes(fullPath, cboxEncrypted.Checked, FileAttributes.Encrypted);
				UpdateAttributes(fullPath, cboxHidden.Checked, FileAttributes.Hidden);
				UpdateAttributes(fullPath, cboxNormal.Checked, FileAttributes.Normal);
				UpdateAttributes(fullPath, cboxNotContentIndexed.Checked, FileAttributes.NotContentIndexed);
				UpdateAttributes(fullPath, cboxOffline.Checked, FileAttributes.Offline);
				UpdateAttributes(fullPath, cboxReadOnly.Checked, FileAttributes.ReadOnly);
				UpdateAttributes(fullPath, cboxReparsePoint.Checked, FileAttributes.ReparsePoint);
				UpdateAttributes(fullPath, cboxSparseFile.Checked, FileAttributes.SparseFile);
				UpdateAttributes(fullPath, cboxSystem.Checked, FileAttributes.System);
				UpdateAttributes(fullPath, cboxTemporary.Checked, FileAttributes.Temporary);
			}
			catch (Exception ex)
			{

			}
		}

		/// <summary>
		/// Updates the inputted file by adding or removing the file attributes passed
		/// </summary>
		/// <param name="filePath"></param>
		/// <param name="removeAttribute"></param>
		/// <param name="fAtt"></param>
		private void UpdateAttributes(string filePath, bool removeAttribute, FileAttributes fAtt)
		{
			try
			{
				//check to see if we are adding or removing attributes
				if (!removeAttribute)
				{	
					File.SetAttributes(filePath, File.GetAttributes(filePath) | fAtt);
				}
				else
				{
					File.SetAttributes(filePath, RemoveAttribute(File.GetAttributes(filePath), fAtt));
				}
			}
			catch (Exception ex)
			{
				Console.WriteLine(ex.Message + "\n" + ex.InnerException + "\n" + ex.StackTrace);
			}
		}

		/// <summary>
		/// Removes a particular set of file attributes from another set of file attributes
		/// </summary>
		/// <param name="fileAttributes"></param>
		/// <param name="removeAttributes"></param>
		/// <returns></returns>
		private static FileAttributes RemoveAttribute(FileAttributes fileAttributes, FileAttributes removeAttributes)
		{
			return fileAttributes & ~removeAttributes;
		}
		#endregion
	}
}
