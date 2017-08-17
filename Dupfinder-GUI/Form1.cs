using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dupfinder_GUI
{
    public partial class Form1 : Form
    {

        #region global_attribute_booleans
        public bool g_bATTRIBUTE_ARCHIVE = false;
        public bool g_bATTRIBUTE_COMPRESSED = false;
        public bool g_bATTRIBUTE_DEVICE = false;
        public bool g_bATTRIBUTE_DIRECTORY = false;
        public bool g_bATTRIBUTE_ENCRYPTED = false;
        public bool g_bATTRIBUTE_HIDDEN = false;
        public bool g_bATTRIBUTE_NORMAL = false;
        public bool g_bATTRIBUTE_NOT_CONTENT_INDEXED = false;
        public bool g_bATTRIBUTE_NO_SCRUB_DATA = false;
        public bool g_bATTRIBUTE_OFFLINE = false;
        public bool g_bATTRIBUTE_READONLY = false;
        public bool g_bATTRIBUTE_RECALL_ON_DATA_ACCESS = false;
        public bool g_bATTRIBUTE_RECALL_ON_OPEN = false;
        public bool g_bATTRIBUTE_REPARSE_POINT = false;
        public bool g_bATTRIBUTE_SPARSE_FILE = false;
        public bool g_bATTRIBUTE_SYSTEM = false;
        public bool g_bATTRIBUTE_TEMPORARY = false;
        public bool g_bATTRIBUTE_VIRTUAL = false;
        #endregion



        public Form1()
        {
            InitializeComponent();
        }

        private void radioBlacklist_CheckedChanged(object sender, EventArgs e)
        {


            if (radioBlacklist.Checked)
            {
                radioWhitelist.Checked = false;
            }


        }

        private void radioWhitelist_CheckedChanged(object sender, EventArgs e)
        {
            if (radioWhitelist.Checked)
            {
                radioBlacklist.Checked = false;
            }
        }

        private void addpathbutton_click(object sender, EventArgs e)
        {
            //openFileDialog1.ShowDialog();
            folderBrowserDialog1.Description = "Select a path to add to the search...";
            folderBrowserDialog1.ShowNewFolderButton = false;
            folderBrowserDialog1.ShowDialog();

            if (textBoxpaths.Text.Contains(folderBrowserDialog1.SelectedPath))
            {
                MessageBox.Show("That path is already added.");
            }
            else
            {
                textBoxpaths.AppendText(folderBrowserDialog1.SelectedPath + "\n");
            }
           
            

            
        }

        #region checkboxes_handling
        private void checkBoxArchive_CheckedChanged(object sender, EventArgs e)
        {

            if (checkBoxArchive.Checked) { g_bATTRIBUTE_ARCHIVE = true; }else
            {
                g_bATTRIBUTE_ARCHIVE = false;
            }

        }

        private void checkBoxCompressed_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxCompressed.Checked) { g_bATTRIBUTE_COMPRESSED = true; }
            else
            {
                g_bATTRIBUTE_COMPRESSED = false;
            }
        }

        private void checkBoxDevice_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxDevice.Checked) { g_bATTRIBUTE_DEVICE = true; }
            else
            {
                g_bATTRIBUTE_DEVICE = false;
            }
        }

        private void checkBoxDirectory_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxDirectory.Checked) { g_bATTRIBUTE_DIRECTORY = true; }
            else
            {
                g_bATTRIBUTE_DIRECTORY = false;
            }
        }

        private void checkBoxEncrypted_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxEncrypted.Checked) { g_bATTRIBUTE_ENCRYPTED = true; }
            else
            {
                g_bATTRIBUTE_ENCRYPTED = false;
            }
        }

        private void checkBoxHidden_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxHidden.Checked) { g_bATTRIBUTE_HIDDEN = true; }
            else
            {
                g_bATTRIBUTE_HIDDEN = false;
            }
        }

        private void checkBoxNormal_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxNormal.Checked) { g_bATTRIBUTE_NORMAL = true; }
            else
            {
                g_bATTRIBUTE_NORMAL = false;
            }
        }

        private void checkBoxOffline_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxOffline.Checked) { g_bATTRIBUTE_OFFLINE = true; }
            else
            {
                g_bATTRIBUTE_OFFLINE = false;
            }
        }

        private void checkBoxReadOnly_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxReadOnly.Checked) { g_bATTRIBUTE_READONLY = true; }
            else
            {
                g_bATTRIBUTE_READONLY = false;
            }
        }

        private void checkBoxNot_Content_Indexed_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxNot_Content_Indexed.Checked) { g_bATTRIBUTE_NOT_CONTENT_INDEXED = true; }
            else
            {
                g_bATTRIBUTE_NOT_CONTENT_INDEXED = false;
            }
        }

        private void checkBoxNo_Scrub_Data_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxNo_Scrub_Data.Checked) { g_bATTRIBUTE_NO_SCRUB_DATA = true; }
            else
            {
                g_bATTRIBUTE_NO_SCRUB_DATA = false;
            }
        }

        private void checkBoxRecall_On_Data_Access_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxRecall_On_Data_Access.Checked) { g_bATTRIBUTE_RECALL_ON_DATA_ACCESS = true; }
            else
            {
                g_bATTRIBUTE_RECALL_ON_DATA_ACCESS = false;
            }

        }

        private void checkBoxRecall_On_Open_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxRecall_On_Open.Checked) { g_bATTRIBUTE_RECALL_ON_OPEN = true; }
            else
            {
                g_bATTRIBUTE_RECALL_ON_OPEN = false;
            }
        }

        private void checkBoxReparse_Point_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxReparse_Point.Checked) { g_bATTRIBUTE_REPARSE_POINT = true; }
            else
            {
                g_bATTRIBUTE_REPARSE_POINT = false;
            }
        }

        private void checkBoxSparse_File_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxSparse_File.Checked) { g_bATTRIBUTE_SPARSE_FILE = true; }
            else
            {
                g_bATTRIBUTE_SPARSE_FILE = false;
            }
        }

        private void checkBoxSystem_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxSystem.Checked) { g_bATTRIBUTE_SYSTEM = true; }
            else
            {
                g_bATTRIBUTE_SYSTEM = false;
            }
        }

        private void checkBoxTemporary_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxTemporary.Checked) { g_bATTRIBUTE_TEMPORARY = true; }
            else
            {
                g_bATTRIBUTE_TEMPORARY = false;
            }
        }

        private void checkBoxVirtual_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxVirtual.Checked) { g_bATTRIBUTE_VIRTUAL = true; }
            else
            {
                g_bATTRIBUTE_VIRTUAL = false;
            }
        }
#endregion
    }
}
