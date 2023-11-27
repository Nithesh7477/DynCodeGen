using OfficeOpenXml;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DynCodeGen.UserControls
{
    public partial class CreateControl : UserControl
    {
        private Dictionary<string, List<Tuple<string, string, string, string>>> sheetsData = new Dictionary<string, List<Tuple<string, string, string, string>>>();
        private string folderPath = string.Empty;

        public CreateControl()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            BuildConnection frm = new BuildConnection(this);
            frm.Show();
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            if (Validation())
            {
                try
                {
                    ShowOrHideProgressBar("show");
                    //ShowOrHideLabel("show");
                    btnCreate.Enabled = false;  // Disable the button
                    UpdateLabel("validating input...");

                    string apiName = txtProjectName.Text;
                    string apiPath = folderPath + "\\" + apiName;
                    string connectionString = txtConnectionString.Text;

                    // Check if the directory exists, create if not
                    if (!Directory.Exists(apiPath))
                    {
                        Directory.CreateDirectory(apiPath);
                    }

                    if (string.IsNullOrEmpty(apiName) || string.IsNullOrEmpty(apiPath))
                    {
                        MessageBox.Show("API Name and Path must not be empty.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                    UpdateLabel("creating projects...");
                    // await Task.Run(() => GenerateWebAPI(apiName, apiPath, connectionString));
                    UpdateLabel("task completed...");
                    UpdateProgressBar(100);

                    DialogResult result = MessageBox.Show($"API generated successfully..! Do you want to navigate '{apiName}' Application? ", "Success", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);

                    if (result == DialogResult.OK)
                    {
                        try
                        {
                            // Open the file
                            string visualStudioPath = @"C:\Program Files\Microsoft Visual Studio\2022\Community\Common7\IDE\devenv.exe";
                            string solnPath = apiPath + "\\" + apiName + ".sln";
                            System.Diagnostics.Process.Start(visualStudioPath, solnPath);
                        }
                        catch (Exception ex)
                        {
                            // Handle exceptions, for example, file not found
                            MessageBox.Show("Error opening file: " + ex.Message);
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error while API generation! Details: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    ShowOrHideProgressBar("hide");
                    // ShowOrHideLabel("hide");
                    btnCreate.Enabled = true;  // Re-enable the button
                }
            }
        }

        public bool Validation()
        {
            lblvalidConnStr.Visible = false;
            lblValidProjName.Visible = false;
            lblValidProjLoc.Visible = false;
            lblValidProjSource.Visible = false;
            if (txtConnectionString.Text.Length == 0)
            {
                lblvalidConnStr.Visible = true;
                return false;
            }
            else if (txtProjectName.Text.Length < 3)
            {
                lblValidProjName.Visible = true;
                return false;
            }
            else if (txtProjectLocationPath.Text.Length == 0)
            {
                lblValidProjLoc.Visible = true;
                return false;
            }
            else if (txtSourceFilePath.Text.Length == 0 && !txtSourceFilePath.Text.Contains(".xlsx"))
            {
                lblValidProjSource.Visible = true;
                return false;
            }
            else
            {
                return true;
            }
        }

        private void ShowOrHideProgressBar(string text)
        {
            if (progressBar.InvokeRequired)
            {
                // If this method is being called from a different thread, invoke it on the main UI thread.
                this.Invoke(new Action<string>(ShowOrHideProgressBar), text);
            }
            else
            {
                if (text == "show")
                {
                    progressBar.Visible = true;  // Show the ProgressBar
                }
                else
                {
                    progressBar.Visible = false;  // Hide the ProgressBar
                }
            }

        }

        //private void btnSourcefile_Click(object sender, EventArgs e)
        //{
        //  //  if (openFileDialogbox.ShowDialog() == DialogResult.OK)
        //    {
        //        string filePath = openFileDialogbox.FileName;

        //        using (ExcelPackage package = new ExcelPackage(new FileInfo(filePath)))
        //        {
        //            ExcelPackage.LicenseContext = OfficeOpenXml.LicenseContext.NonCommercial;

        //            // Iterate through all worksheets in the Excel package
        //            foreach (ExcelWorksheet worksheet in package.Workbook.Worksheets)
        //            {
        //                List<Tuple<string, string, string, string>> sheetData = new List<Tuple<string, string, string, string>>();

        //                int rowCount = worksheet.Dimension.End.Row;

        //                for (int row = 2; row <= rowCount; row++)
        //                {
        //                    string valueA = worksheet.Cells[row, 1].Text; // Column A
        //                    string valueB = worksheet.Cells[row, 2].Text; // Column B
        //                    string valueC = worksheet.Cells[row, 3].Text; // Column C (Annotations)
        //                    string valueD = worksheet.Cells[row, 4].Text; // Column D (Relationship)

        //                    sheetData.Add(new Tuple<string, string, string, string>(valueA, valueB, valueC, valueD));
        //                }

        //                sheetsData.Add(worksheet.Name, sheetData);
        //            }
        //        }

        //        // txtSourceFilePath.Text = filePath;
        //    }
        //}

        //private void showorhidelabel(string text)
        //{
        //    if (lblprogressstatus.invokerequired)
        //    {
        //        // if this method is being called from a different thread, invoke it on the main ui thread.
        //        this.invoke(new action<string>(showorhidelabel), text);
        //    }
        //    else
        //    {
        //        if (text == "show")
        //        {
        //            lblprogressstatus.visible = true;  // show the label
        //        }
        //        else
        //        {
        //            lblprogressstatus.visible = false;  // hide the label
        //        }
        //    }
        //}
        private void UpdateProgressBar(int value)
        {
            if (progressBar.InvokeRequired)
            {
                // If this method is being called from a different thread, invoke it on the main UI thread.
                this.Invoke(new Action<int>(UpdateProgressBar), value);
            }
            else
            {
                progressBar.Value = value;
            }
        }

        private void UpdateLabel(string text)
        {
            if (lblProgressStatus.InvokeRequired)
            {
                // If this method is being called from a different thread, invoke it on the main UI thread.
                this.Invoke(new Action<string>(UpdateLabel), text);
            }
            else
            {
                lblProgressStatus.Text = text;
            }
        }

        private void lblValidProjLoc_Click(object sender, EventArgs e)
        {

        }
    }
}
