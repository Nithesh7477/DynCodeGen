using DynCodeGen.CodeGeneration.Controller;
using DynCodeGen.CodeGeneration.Entity;
using DynCodeGen.CodeGeneration.Project;
using OfficeOpenXml;
using OfficeOpenXml.Packaging.Ionic.Zlib;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace DynCodeGen.UserControls
{
    public partial class CreateModelControl : UserControl
    {
        private CreateControl createControlInstance;
        public DynCodeGen _dynCodeGenInstance;
        public SpControl spControlInstance;
        private Dictionary<string, List<Tuple<string, string, string, string>>> sheetsData = new Dictionary<string, List<Tuple<string, string, string, string>>>();
        private string folderPath = string.Empty;
        DataTable dt = new DataTable();

        /// <summary>
        /// SpControl.
        /// </summary>
        public CreateModelControl(DynCodeGen dynCodeGenParent)
        {
            InitializeComponent();
            _dynCodeGenInstance = dynCodeGenParent;
            btnValidate.Hide();  

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            BuildConnection frm = new BuildConnection(createControlInstance, spControlInstance, this);
            frm.Show();
        }

        /// <summary>
        /// btnProjectLocation_Click.
        /// </summary>
        /// <param name="sender">sender.</param>
        /// <param name="e">e.</param>
        private void btnProjectLocation_Click(object sender, EventArgs e)
        {
            using (FolderBrowserDialog folderDialog = new FolderBrowserDialog())
            {
                DialogResult result = folderDialog.ShowDialog();
                if (result == DialogResult.OK)
                {
                    folderPath = folderDialog.SelectedPath;
                }
                txtProjectLocationPath.Text = folderPath;
            }
        }

        /// <summary>
        /// btnSourcefile_Click.
        /// </summary>
        /// <param name="sender">sender.</param>
        /// <param name="e">e.</param>
        private void btnSourcefile_Click(object sender, EventArgs e)
        {
            btnValidate.Enabled = true;

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                if ((openFileDialog.FileName.Contains("StoredProcedure") || (openFileDialog.FileName.Contains("Table"))))
                {
                    string filePath = openFileDialog.FileName;

                    ExcelPackage.LicenseContext = OfficeOpenXml.LicenseContext.NonCommercial;

                    using (ExcelPackage package = new ExcelPackage(new FileInfo(filePath)))
                    {

                        foreach (ExcelWorksheet worksheet in package.Workbook.Worksheets)
                        {
                            List<Tuple<string, string, string, string>> sheetData = new List<Tuple<string, string, string, string>>();

                            int rowCount = worksheet.Dimension.End.Row;

                            for (int row = 2; row <= rowCount; row++)
                            {
                                string valueA = worksheet.Cells[row, 1].Text;
                                string valueB = worksheet.Cells[row, 2].Text;
                                string valueC = worksheet.Cells[row, 3].Text;
                                string valueD = worksheet.Cells[row, 4].Text;

                                sheetData.Add(new Tuple<string, string, string, string>(valueA, valueB, valueC, valueD));
                            }

                            sheetsData.Add(worksheet.Name, sheetData);
                        }
                    }

                    txtSourceFilePath.Text = filePath;
                }
                else
                {
                    MessageBox.Show($"Please use the {(openFileDialog.FileName.Contains("StoredProcedure") ? "StoredProcedure" : "Table")} template.\r\n\r\nIf you don't have one, download it from the home, update the template, and then try uploading it here.");
                }
            }
        }

        private async void btnCreate_Click(object sender, EventArgs e)
        {
            //if (DtValidation())
            //{
            txtLog.Visible = true;
            //    dgSP.Visible = false;

            try
                {
                    ShowOrHideProgressBar("show");
                    //ShowOrHideLabel("show");
                    btnCreate.Enabled = false;  // Disable the button
                    UpdateLabel("validating input...");
                    UpdateProgressBar(25);

                    string apiName = Path.GetFileName(folderPath);
                    string apiPath = folderPath;
                    string connectionString = txtConnectionString.Text;

                    // Check if the directory exists, create if not
                    //if (!Directory.Exists(apiPath))
                    //{
                    //    Directory.CreateDirectory(apiPath);
                    //}

                    if (string.IsNullOrEmpty(apiPath))
                    {
                        MessageBox.Show("Existing project Path must not be empty.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                    UpdateLabel("creating project files...");
                    UpdateProgressBar(70);
                    await Task.Run(() => GenerateCreateModelInExistingProject(apiName, apiPath, connectionString));
                    UpdateLabel("task completed...");
                    UpdateProgressBar(100);

                    DialogResult result = MessageBox.Show($"Model Class has been generated successfully..! Do you want to navigate '{apiName}' Application? ", "Success", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);

                    if (result == DialogResult.OK)
                    {
                        try
                        {
                            // Open the file
                            string visualStudioPath = @"C:\Program Files\Microsoft Visual Studio\2022\Community\Common7\IDE\devenv.exe";
                            string solnPath = folderPath + "\\" + apiName + ".sln";
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
            //else
            //{
            //    MessageBox.Show("Please select any one value");
            //}
        //}
        private void GenerateCreateModelInExistingProject(string apiName, string apiPath, string connectionString)
        {
            try
            {

                string dbContextPath = Path.Combine(apiPath, $"{apiName}.Infrastructure", "Data", "ApplicationDbContext.cs");


                string modelClassPath = Path.Combine(apiPath, $"{apiName}.Domain", "Entities");


                foreach (var sheetEntry in sheetsData)
                {
                    string IdName = "";
                    foreach (var Value in sheetEntry.Value)
                    {
                        if (Value.Item1.Contains("Id") && !Value.Item3.Contains("ForeignKey"))
                        {
                            IdName = Value.Item1;
                        }
                    }

                    // Generate repositories
                    string className = sheetEntry.Key;
                }
                ModelClassGenerator.GenerateModelClassesFromData(sheetsData, modelClassPath);
                DBContext.UpdateApplicationDbContextWithModels(sheetsData, dbContextPath);
                //UpdateStartupFile.UpdateStartupForRepositoriesAndServices(apiName, apiPath, sheetsData, "Table");
                UpdateProgramFile.CreateOrUpdateProgramFile(apiName, apiPath);
                string migrationPath = Path.Combine(apiPath, $"{apiName}.WebAPI");
                string infrastructurePath = Path.Combine(apiPath, $"{apiName}.Infrastructure");
            }

            catch (Exception ex)
            {
                if (ex.ToString().Contains("Code Duplication"))
                {
                    MessageBox.Show($"The Model Class code has alredy created in the given file path");
                }
            }
        }

        //private void btnValidate_Click(object sender, EventArgs e)
        //{

        //    dt.Rows.Clear();
        //    if (sheetsData.Count != 0)
        //    {
        //        if (_dynCodeGenInstance.lblHead.Text == "Enhance Project > Entity Framework- SP" || _dynCodeGenInstance.lblHead.Text == "Enhance Project > ADO.Net - SP")
        //        {
        //            txtLog.Visible = false;
        //            dgSP.Visible = true;
        //            dt.Columns.Add("SP_Name", typeof(string));
        //            dt.Columns.Add("GET/GETALL", typeof(bool));
        //            dt.Columns.Add("INSERT/UPDATE", typeof(bool));

        //            foreach (var sheetEntry in sheetsData)
        //            {


        //                DataRow dataRow = dt.NewRow();
        //                dataRow["SP_Name"] = sheetEntry.Key.ToString();
        //                dataRow["GET/GETALL"] = false;
        //                dataRow["INSERT/UPDATE"] = false;

        //                dt.Rows.Add(dataRow);
        //            }

        //            dgSP.DataSource = dt;
        //            dgSP.Columns["SP_Name"].Width = 751;
        //            dgTable.Hide();
        //            dgSP.Show();
        //            btnValidate.ForeColor = Color.FromArgb(227, 227, 227);
        //            btnValidate.Enabled = false;
        //            btnCreate.Enabled = true;
        //        }
        //        else if (_dynCodeGenInstance.lblHead.Text == "Enhance Project > Entity Framework-Code First")
        //        {
        //            dt.Rows.Clear();
        //            txtLog.Visible = false;
        //            dgTable.Visible = true;
        //            dt.Columns.Add("Table", typeof(string));
        //            dt.Columns.Add("Get", typeof(bool));
        //            dt.Columns.Add("GetAll", typeof(bool));
        //            dt.Columns.Add("Insert", typeof(bool));
        //            dt.Columns.Add("Update", typeof(bool));
        //            dt.Columns.Add("Delete", typeof(bool));


        //            foreach (var sheetEntry in sheetsData)
        //            {
        //                string tablenName = sheetEntry.Key.ToString();

        //                DataRow dataRow = dt.NewRow();
        //                dataRow["Table"] = tablenName;
        //                dataRow["Get"] = true;
        //                dataRow["GetAll"] = true;
        //                dataRow["Insert"] = true;
        //                dataRow["Update"] = true;
        //                dataRow["Delete"] = true;
        //                dt.Rows.Add(dataRow);
        //            }

        //            dgTable.DataSource = dt;
        //            dgTable.Columns[0].Width = 377;
        //            btnValidate.ForeColor = Color.FromArgb(227, 227, 227);
        //            btnValidate.Enabled = false;
        //            dgSP.Hide();
        //            dgTable.Show();
        //            btnCreate.Enabled = true;
        //        }
        //    }
        //}
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
        private void showorhidelabel(string text)
        {
            if (lblProgressStatus.InvokeRequired)
            {
                // if this method is being called from a different thread, invoke it on the main ui thread.
                this.Invoke(new Action<string>(showorhidelabel), text);
            }
            else
            {
                if (text == "show")
                {
                    lblProgressStatus.Visible = true;  // show the label
                }
                else
                {
                    lblProgressStatus.Visible = false;  // hide the label
                }
            }
        }

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
        public bool DtValidation()
        {
            int count = 0;
            foreach (DataColumn column in dt.Columns)
            {
                if (column.DataType == typeof(bool))
                {
                    foreach (DataRow row in dt.Rows)
                    {
                        bool columnValue = Convert.ToBoolean(row[column]);
                        if (columnValue)
                        {
                            count++;
                        }
                    }
                }
            }
            if (count >= 1)
            {
                return true;
            }
            else
            {
                return false;
            }

        }
        private void dgSP_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            if (e.RowIndex >= 0 && e.ColumnIndex == dgSP.Columns["GET/GETALL"].Index)
            {
                bool currentStatus = (bool)dt.Rows[e.RowIndex]["GET/GETALL"];

                bool newStatus = (currentStatus == true) ? false : true;

                dt.Rows[e.RowIndex]["GET/GETALL"] = newStatus;
                dt.Rows[e.RowIndex]["INSERT/UPDATE"] = ((bool)dt.Rows[e.RowIndex]["GET/GETALL"] == true) ? false : dt.Rows[e.RowIndex]["GET/GETALL"];

                dgSP[e.ColumnIndex, e.RowIndex].Value = (newStatus == true) ? true : false;


            }
            if (e.RowIndex >= 0 && e.ColumnIndex == dgSP.Columns["INSERT/UPDATE"].Index)
            {
                bool currentStatus = (bool)dt.Rows[e.RowIndex]["INSERT/UPDATE"];

                bool newStatus = (currentStatus == true) ? false : true;

                dt.Rows[e.RowIndex]["INSERT/UPDATE"] = newStatus;
                dt.Rows[e.RowIndex]["GET/GETALL"] = ((bool)dt.Rows[e.RowIndex]["INSERT/UPDATE"] == true) ? false : dt.Rows[e.RowIndex]["INSERT/UPDATE"];

                dgSP[e.ColumnIndex, e.RowIndex].Value = (newStatus == true) ? true : false;
            }

            dgSP.Refresh();
        }
        private void dgTable_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //if ((bool)dt.Rows[e.RowIndex]["Insert"] && (bool)dt.Rows[e.RowIndex]["Delete"])
            //{
            //    dgTable.Columns[1].ReadOnly = true;
            //}

            if (e.RowIndex >= 0 && e.ColumnIndex == dgTable.Columns["Get"].Index)
            {
                bool currentStatus = (bool)dt.Rows[e.RowIndex]["Get"];



                bool newStatus = (currentStatus == true) ? false : true;

                dt.Rows[e.RowIndex]["Get"] = newStatus;

                dgTable[e.ColumnIndex, e.RowIndex].Value = (newStatus == true) ? true : false;


            }
            if (e.RowIndex >= 0 && e.ColumnIndex == dgTable.Columns["GetAll"].Index)
            {
                bool currentStatus = (bool)dt.Rows[e.RowIndex]["GetAll"];

                bool newStatus = (currentStatus == true) ? false : true;

                dt.Rows[e.RowIndex]["GetAll"] = newStatus;

                dgTable[e.ColumnIndex, e.RowIndex].Value = (newStatus == true) ? true : false;
            }
            if (e.RowIndex >= 0 && e.ColumnIndex == dgTable.Columns["Insert"].Index)
            {
                bool currentStatus = (bool)dt.Rows[e.RowIndex]["Insert"];

                bool newStatus = (currentStatus == true) ? false : true;
                dt.Rows[e.RowIndex]["Insert"] = newStatus;
                dt.Rows[e.RowIndex]["Get"] = ((bool)dt.Rows[e.RowIndex]["Insert"] == true) ? true : dt.Rows[e.RowIndex]["Get"];

                dgTable[e.ColumnIndex, e.RowIndex].Value = (newStatus == true) ? true : false;
            }
            if (e.RowIndex >= 0 && e.ColumnIndex == dgTable.Columns["Update"].Index)
            {
                bool currentStatus = (bool)dt.Rows[e.RowIndex]["Update"];

                bool newStatus = (currentStatus == true) ? false : true;

                dt.Rows[e.RowIndex]["Update"] = newStatus;

                dgTable[e.ColumnIndex, e.RowIndex].Value = (newStatus == true) ? true : false;
            }
            if (e.RowIndex >= 0 && e.ColumnIndex == dgTable.Columns["Delete"].Index)
            {
                bool currentStatus = (bool)dt.Rows[e.RowIndex]["Delete"];

                bool newStatus = (currentStatus == true) ? false : true;

                dt.Rows[e.RowIndex]["Delete"] = newStatus;
                dt.Rows[e.RowIndex]["Get"] = ((bool)dt.Rows[e.RowIndex]["Delete"] == true) ? true : dt.Rows[e.RowIndex]["Get"];

                dgTable[e.ColumnIndex, e.RowIndex].Value = (newStatus == true) ? true : false;
            }
            dgTable.Refresh();
        }


    }
}
