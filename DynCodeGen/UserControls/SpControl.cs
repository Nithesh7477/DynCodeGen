using DynCodeGen.CodeGeneration.Controller;
using DynCodeGen.CodeGeneration.Entity;
using DynCodeGen.CodeGeneration.Project;
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
using System.Xml.Linq;

namespace DynCodeGen.UserControls
{
    public partial class SpControl : UserControl
    {
        private CreateControl createControlInstance;
        private Dictionary<string, List<Tuple<string, string, string, string>>> sheetsData = new Dictionary<string, List<Tuple<string, string, string, string>>>();
        private string folderPath = string.Empty;
        DataTable dt = new DataTable();

        /// <summary>
        /// SpControl.
        /// </summary>
        public SpControl()
        {
            InitializeComponent();

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            createControlInstance = new CreateControl();
            BuildConnection frm = new BuildConnection(createControlInstance, this);
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

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                if (openFileDialog.FileName.Contains("StoredProcedure"))
                {
                    string filePath = openFileDialog.FileName;

                    using (ExcelPackage package = new ExcelPackage(new FileInfo(filePath)))
                    {
                        ExcelPackage.LicenseContext = OfficeOpenXml.LicenseContext.NonCommercial;

                        // Iterate through all worksheets in the Excel package
                        foreach (ExcelWorksheet worksheet in package.Workbook.Worksheets)
                        {
                            List<Tuple<string, string, string, string>> sheetData = new List<Tuple<string, string, string, string>>();

                            int rowCount = worksheet.Dimension.End.Row;

                            for (int row = 2; row <= rowCount; row++)
                            {
                                string valueA = worksheet.Cells[row, 1].Text; // Column A
                                string valueB = worksheet.Cells[row, 2].Text; // Column B
                                string valueC = worksheet.Cells[row, 3].Text; // Column C (Annotations)
                                string valueD = worksheet.Cells[row, 4].Text; // Column D (Relationship)

                                sheetData.Add(new Tuple<string, string, string, string>(valueA, valueB, valueC, valueD));
                            }

                            sheetsData.Add(worksheet.Name, sheetData);
                        }
                    }

                    txtSourceFilePath.Text = filePath;
                }
                else
                {
                    MessageBox.Show("Please Use the Table template.\r\n\r\nIf dont have one download it from the home, update the table template and then try uploading it here ");
                }
            }
        }
        private async void btnCreate_Click(object sender, EventArgs e)
        {
            if (DtValidation())
            {
                txtLog.Visible = true;
                dgSP.Visible = false;

                try
                {
                    ShowOrHideProgressBar("show");
                    //ShowOrHideLabel("show");
                    btnCreate.Enabled = false;  // Disable the button
                    UpdateLabel("validating input...");

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
                    UpdateLabel("creating projects...");
                    await Task.Run(() => GenerateSpExistingProject(apiName, apiPath, connectionString));
                    UpdateLabel("task completed...");
                    UpdateProgressBar(100);

                    DialogResult result = MessageBox.Show($"API generated successfully..! Do you want to navigate '{apiName}' Application? ", "Success", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);

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
            else
            {
                MessageBox.Show("Please select any one value");
            }
        }
        private void GenerateSpExistingProject(string apiName, string apiPath, string connectionString)
        {
            string dbContextPath = Path.Combine(apiPath, $"{apiName}.Infrastructure", "Data", "ApplicationDbContext.cs");

            string requestModelClassPath = Path.Combine(apiPath + $"\\{apiName}.Domain", "Entities", "Request");
            string responseModelClassPath = Path.Combine(apiPath + $"\\{apiName}.Domain", "Entities", "Response");
            ModelClassGenerator.GenerateModelClassesFromDataForSp(sheetsData, requestModelClassPath, responseModelClassPath);
            DBContext.UpdateApplicationDbContextWithSPModels(sheetsData, dbContextPath);

            UpdateProgramFile.CreateOrUpdateProgramFile(apiName, apiPath);
            foreach (var sheetEntry in sheetsData)
            {
                string IdName = "";
                foreach (var Value in sheetEntry.Value)
                {
                    if (/*Value.Item1.Contains("Id") && */Value.Item3.Contains("INPUT"))
                    {
                        IdName = Value.Item1;
                    }
                }

                // Generate repositories
                string className = sheetEntry.Key;
                InterfaceGenerator.GenerateSPRepositoryInterface(apiName, apiPath, className, IdName, dt);
                RepositoryGenerator.GenerateSPRepositoryImplementation(sheetsData ,apiName, apiPath, className, IdName, dt);

                // Generate services
                InterfaceGenerator.GenerateSPServiceInterface(apiName, apiPath, className, IdName, dt);
                ServiceGenerator.GenerateSPServiceImplementation(apiName, apiPath, className, IdName, dt);

                // Generate controllers
                ControllerGenerator.GenerateSPController(apiName, apiPath, className, IdName, dt);
                
            }
            UpdateStartupFile.UpdateStartupForRepositoriesAndServices(apiName, apiPath, sheetsData, "SP");

            //UpdateProgressBar(75);
            //UpdateLabel("running migrations...");
            //string migrationPath = Path.Combine(apiPath, $"{apiName}.WebAPI");
            //string infrastructurePath = Path.Combine(apiPath, $"{apiName}.Infrastructure");
            //Migrations.RunMigrationsAndUpdates(migrationPath, infrastructurePath, "CreateStoredProcedure", "ApplicationDbContext");

        }
        private void btnValidate_Click(object sender, EventArgs e)
        {
            txtLog.Visible = false;
            dgSP.Visible = true;
            dt.Columns.Add("SP_Name", typeof(string));
            dt.Columns.Add("GET/GETALL", typeof(bool));
            dt.Columns.Add("INSERT/UPDATE", typeof(bool));

            foreach (var sheetEntry in sheetsData)
            {

                DataRow dataRow = dt.NewRow();
                dataRow["SP_Name"] = sheetEntry.Key.ToString();
                dataRow["GET/GETALL"] = false;
                dataRow["INSERT/UPDATE"] = false;

                dt.Rows.Add(dataRow);
            }

            dgSP.DataSource = dt;
            dgSP.Columns["SP_Name"].Width = 377;


            btnValidate.Enabled = false;
            btnCreate.Enabled = true;
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


    }
}
