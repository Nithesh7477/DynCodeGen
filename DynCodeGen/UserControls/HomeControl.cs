using DynCodeGen.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DynCodeGen.UserControls
{
    public partial class HomeControl : UserControl
    {
        string dirTemplate = System.IO.Directory.GetCurrentDirectory() + "\\Templates";
        public HomeControl()
        {
            InitializeComponent();
        }

        private void HomeControl_Load(object sender, EventArgs e)
        {

        }

        private void tableTemplate_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            DownloadTemplate("Table.xlsx");
        }
        public void DownloadTemplate(string templateName)
        {
            try
            {
                string pathDownload = Path.Join(Environment.GetFolderPath(Environment.SpecialFolder.UserProfile), "Downloads");
                string item = dirTemplate + "\\" + templateName;
                if (File.Exists(item))
                {
                    File.Copy(item, Path.Combine(pathDownload, Path.GetFileName(item)));
                    MessageBox.Show("Template Downloaded Successfully!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void SPTemplate_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            DownloadTemplate("StoredProcedure.xlsx");
        }

        private void LinkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            TableInstructions tableInstructions = new TableInstructions();
            tableInstructions.Show();
        }

        private void lblSPInstructions_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            SPInstructions spInstructions = new SPInstructions();   
            spInstructions.Show();
        }
    }
}
