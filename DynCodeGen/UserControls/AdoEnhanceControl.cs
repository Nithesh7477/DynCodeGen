using DynCodeGen.CodeGeneration.CodeTemplate;
using DynCodeGen.CodeGeneration.Controller;
using DynCodeGen.CodeGeneration.Entity;
using DynCodeGen.CodeGeneration.Project;
using OfficeOpenXml;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DynCodeGen.UserControls
{
    public partial class AdoEnhanceControl : UserControl
    {
        private AdoCreateControl adoCreateControlInstance;
        private Dictionary<string, List<Tuple<string, string, string>>> sheetsData = new Dictionary<string, List<Tuple<string, string, string>>>();
        private string folderPath = string.Empty;
        DataTable dt = new DataTable();
        int spExistCount = 0;

        /// <summary>
        /// AdoCreateControl.
        /// </summary>
        public AdoEnhanceControl()
        {
            InitializeComponent();

        }

        /// <summary>
        /// btnAdd_Click.
        /// </summary>
        /// <param name="sender">sender.</param>
        /// <param name="e">e.</param>
        private void btnAdd_Click(object sender, EventArgs e)
        {
            adoCreateControlInstance = new AdoCreateControl();
            BuildConnectionAdo frm = new BuildConnectionAdo(adoCreateControlInstance, this);
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

        // <summary>
        /// btnSourcefile_Click.
        /// </summary>
        /// <param name="sender">sender.</param>
        /// <param name="e">e.</param>
        private void btnSourcefile_Click(object sender, EventArgs e)
        {
            btnValidate.Enabled = true;

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                if (openFileDialog.FileName.Contains("StoredProcedure"))
                {
                    string filePath = openFileDialog.FileName;

                    using (ExcelPackage package = new ExcelPackage(new FileInfo(filePath)))
                    {
                        ExcelPackage.LicenseContext = OfficeOpenXml.LicenseContext.NonCommercial;

                        foreach (ExcelWorksheet worksheet in package.Workbook.Worksheets)
                        {
                            List<Tuple<string, string, string>> sheetData = new List<Tuple<string, string, string>>();

                            int rowCount = worksheet.Dimension.End.Row;

                            for (int row = 2; row <= rowCount; row++)
                            {
                                string valueA = worksheet.Cells[row, 1].Text; // VariableName
                                string valueB = worksheet.Cells[row, 2].Text; // DataType
                                string valueC = worksheet.Cells[row, 3].Text; // ParameterType

                                sheetData.Add(new Tuple<string, string, string>(valueA, valueB, valueC));
                            }

                            sheetsData.Add(worksheet.Name, sheetData);
                        }
                    }

                    txtSourceFilePath.Text = filePath;
                }
                else
                {
                    MessageBox.Show("Please Use the StoredProcedure template.\r\n\r\nIf you don't have one download it from the home, update the StoredProcedure template and then try uploading it here ");
                }
            }
        }

        private async void btnCreate_Click(object sender, EventArgs e)
        {
            if (DtValidation())
            {
                txtLog.Visible = true;
                dgTable.Visible = false;

                try
                {
                    ShowOrHideProgressBar("show");
                    //ShowOrHideLabel("show");
                    btnCreate.Enabled = false;  // Disable the button
                    UpdateLabel("validating input...");

                    string apiName = Path.GetFileName(folderPath);
                    string apiPath = folderPath;
                    string connectionString = txtConnectionString.Text;

                    if (string.IsNullOrEmpty(apiPath))
                    {
                        MessageBox.Show("Existing project Path must not be empty.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                    UpdateLabel("creating projects...");
                    await Task.Run(() => GenerateApiExistingProject(apiName, apiPath));
                    UpdateLabel("task completed...");
                    UpdateProgressBar(100);

                    if (sheetsData.Count == spExistCount)
                    {
                        MessageBox.Show("Stored Procedure implementations already exists, please upload new data...");
                    }
                    else
                    {
                        DialogResult result = MessageBox.Show($"API enhancement code has been generated successfully..! Do you want to navigate '{apiName}' Application? ", "Success", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);

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
        private void GenerateApiExistingProject(string apiName, string apiPath)
        {
            UpdateProgressBar(50);
            UpdateLabel("generating classes...");

            string requestModelClassPath = Path.Combine(apiPath + $"\\{apiName}.Domain", "Entities", "Request");
            string responseModelClassPath = Path.Combine(apiPath + $"\\{apiName}.Domain", "Entities", "Response");
            ModelClassGenerator.GenerateModelClassesFromDataAdo(sheetsData, requestModelClassPath, responseModelClassPath);

            UpdateProgressBar(75);
            UpdateLabel("creating repositories...");

            foreach (var sheetEntry in sheetsData)
            {
                string className = sheetEntry.Key;
                string controllerPath = Path.Combine(apiPath + $"\\{apiName}.WebAPI", "Controllers", className + "Controller.cs");
                var temp = dt.Rows.Cast<DataRow>().FirstOrDefault(x => x.Field<string>("Stored Procedure") == className);
                Dictionary<string, string> inputParameters = new Dictionary<string, string>();

                foreach (var Value in sheetEntry.Value)
                {
                    if (Value.Item3.Contains("INPUT"))
                    {
                        inputParameters.Add(Value.Item1, Value.Item2);
                    }
                }

                if (!File.Exists(controllerPath))
                {
                    if (((bool)temp[1] == true) || ((bool)temp[2] == true))
                    {
                        // Generate controllers
                        ControllerGenerator.GenerateControllerAdo(apiName, apiPath, className, dt);

                        // Generate services
                        InterfaceGenerator.GenerateServiceInterfaceAdo(apiName, apiPath, className, dt);
                        ServiceGenerator.GenerateServiceImplementationAdo(apiName, apiPath, className, dt);

                        // Generate repositories
                        InterfaceGenerator.GenerateRepositoryInterfaceAdo(apiName, apiPath, className, dt);
                        RepositoryGenerator.GenerateRepositoryImplementationAdo(apiName, apiPath, className, dt, inputParameters);

                        UpdateStartupFile.UpdateStartupForRepositoriesAndServicesAdo(apiName, apiPath, className);
                    }
                }
                else
                {
                    spExistCount = spExistCount + 1;
                }
            }
        }
        private void btnValidate_Click(object sender, EventArgs e)
        {
            txtLog.Visible = false;
            dgTable.Visible = true;



            dt.Columns.Add("Stored Procedure", typeof(string));
            dt.Columns.Add("Get / GetAll", typeof(bool));
            dt.Columns.Add("Insert / Update", typeof(bool));


            foreach (var sheetEntry in sheetsData)
            {
                string tablenName = sheetEntry.Key.ToString();

                DataRow dataRow = dt.NewRow();
                dataRow["Stored Procedure"] = tablenName;
                dataRow["Get / GetAll"] = false;
                dataRow["Insert / Update"] = false;
                dt.Rows.Add(dataRow);
            }

            dgTable.DataSource = dt;
            dgTable.Columns[0].Width = 377;
            dgTable.Columns[1].Width = 313;
            dgTable.Columns[2].Width = 313;

            btnValidate.ForeColor = Color.FromArgb(227, 227, 227);
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

        private void dgTable_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var dgv = sender as DataGridView;
            if (dgv == null || e.RowIndex < 0) return; // Early exit if casting failed or if the header row is clicked

            int getColumnIndex = dgv.Columns["Get / GetAll"].Index;
            int insertColumnIndex = dgv.Columns["Insert / Update"].Index;

            if (e.ColumnIndex == getColumnIndex || e.ColumnIndex == insertColumnIndex)
            {
                bool currentStatus = (bool)dgv[e.ColumnIndex, e.RowIndex].Value;
                dgv[e.ColumnIndex, e.RowIndex].Value = !currentStatus;

                int otherColumnIndex = (e.ColumnIndex == getColumnIndex) ? insertColumnIndex : getColumnIndex;
                dgv[otherColumnIndex, e.RowIndex].Value = false; // Uncheck the other checkbox

                dt.Rows[e.RowIndex]["Get / GetAll"] = dgv[getColumnIndex, e.RowIndex].Value;
                dt.Rows[e.RowIndex]["Insert / Update"] = dgv[insertColumnIndex, e.RowIndex].Value;

                dgv.CommitEdit(DataGridViewDataErrorContexts.Commit);
                dgv.EndEdit();
            }
        }

        private void ExecuteCommandAdo(string command, string? workingDirectory = null)
        {
            var process = new Process
            {
                StartInfo = new ProcessStartInfo
                {
                    FileName = "dotnet",
                    Arguments = command,
                    RedirectStandardOutput = true,
                    RedirectStandardError = true,
                    UseShellExecute = false,
                    CreateNoWindow = true,
                    WorkingDirectory = workingDirectory != null ? workingDirectory : Directory.GetCurrentDirectory() // use the provided directory or the current one
                }
            };

            process.Start();

            string output = process.StandardOutput.ReadToEnd();
            string error = process.StandardError.ReadToEnd(); // Capture error output

            process.WaitForExit();

            if (!string.IsNullOrWhiteSpace(error))
            {
                Debug.WriteLine("Error: " + error);
            }
            Debug.WriteLine(output);
            AppendLog(output);
        }

        public void AppendLog(string logText)
        {
            // Check if invoking is required and, if so, invoke the method on the UI thread
            if (txtLog.InvokeRequired)
            {
                txtLog.Invoke(new Action<string>(AppendLog), logText);
                return;
            }

            // Continue with the UI update on the UI thread
            string formattedLog = $"{DateTime.Now:yyyy-MM-dd HH:mm:ss} - {logText}";
            txtLog.AppendText(formattedLog + Environment.NewLine);
            txtLog.ScrollToCaret();
        }
    }
}
