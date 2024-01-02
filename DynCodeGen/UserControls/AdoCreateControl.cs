using DynCodeGen.CodeGeneration.CodeTemplate;
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
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DynCodeGen.UserControls
{
    public partial class AdoCreateControl : UserControl
    {
        private AdoEnhanceControl adoEnhanceControlInstance;
        private Dictionary<string, List<Tuple<string, string, string, string>>> sheetsData = new Dictionary<string, List<Tuple<string, string, string, string>>>();
        private string folderPath = string.Empty;
        DataTable dt = new DataTable();

        /// <summary>
        /// AdoCreateControl.
        /// </summary>
        public AdoCreateControl()
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
            adoEnhanceControlInstance = new AdoEnhanceControl();
            BuildConnectionAdo frm = new BuildConnectionAdo(this, adoEnhanceControlInstance);
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
                    MessageBox.Show("Please Use the StoredProcedure template.\r\n\r\nIf dont have one download it from the home, update the StoredProcedure template and then try uploading it here ");
                }
            }
        }

        /// <summary>
        /// btnCreate_Click.
        /// </summary>
        /// <param name="sender">sender.</param>
        /// <param name="e">e.</param>
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
                    await Task.Run(() => GenerateWebAPI(apiName, apiPath, connectionString));
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
            else
            {
                MessageBox.Show("Please select any one value");
            }
        }

        /// <summary>
        /// DtValidation.
        /// </summary>
        /// <returns>bool.</returns>
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

        private void GenerateWebAPI(string apiName, string apiPath, string connectionString)
        {
            // Create a WebAPI project
            ExecuteCliCommand.ExecuteCommand(Regex.Unescape(TemplateHelper.Instance.CreateWebAPI).Replace("{apiName}", $"{apiName}").Replace("{apiPath}", $"{apiPath}"));

            // Set the connection string in appsettings.json
            string appSettingsPath = Path.Combine(apiPath, $"{apiName}.WebAPI", "appsettings.json");
            AddConnectionString.SetConnectionString(appSettingsPath, connectionString);

            // Set the connection string in appsettings.Development.json
            string appSettingsDevPath = Path.Combine(apiPath, $"{apiName}.WebAPI", "appsettings.Development.json");
            AddConnectionString.SetConnectionString(appSettingsDevPath, connectionString);

            // Create a solution
            ExecuteCliCommand.ExecuteCommand(Regex.Unescape(TemplateHelper.Instance.CreateSolution).Replace("{apiName}", $"{apiName}").Replace("{apiPath}", $"{apiPath}"));

            // Create Application, Domain, and Infrastructure projects
            ExecuteCliCommand.ExecuteCommand(Regex.Unescape(TemplateHelper.Instance.CreateApplication).Replace("{apiName}", $"{apiName}").Replace("{apiPath}", $"{apiPath}"));
            ExecuteCliCommand.ExecuteCommand(Regex.Unescape(TemplateHelper.Instance.CreateDomain).Replace("{apiName}", $"{apiName}").Replace("{apiPath}", $"{apiPath}"));
            ExecuteCliCommand.ExecuteCommand(Regex.Unescape(TemplateHelper.Instance.CreateInfrastructure).Replace("{apiName}", $"{apiName}").Replace("{apiPath}", $"{apiPath}"));

            Directory.CreateDirectory(Path.Combine(apiPath, $"{apiName}.Domain", "Entities"));
            Directory.CreateDirectory(Path.Combine(apiPath, $"{apiName}.Infrastructure", "Data"));

            // Add all projects to the solution
            ExecuteCliCommand.ExecuteCommand(Regex.Unescape(TemplateHelper.Instance.AddWebAPIProject).Replace("{apiName}", $"{apiName}").Replace("{apiPath}", $"{apiPath}"));
            ExecuteCliCommand.ExecuteCommand(Regex.Unescape(TemplateHelper.Instance.AddApplicationProject).Replace("{apiName}", $"{apiName}").Replace("{apiPath}", $"{apiPath}"));
            ExecuteCliCommand.ExecuteCommand(Regex.Unescape(TemplateHelper.Instance.AddDomainProject).Replace("{apiName}", $"{apiName}").Replace("{apiPath}", $"{apiPath}"));
            ExecuteCliCommand.ExecuteCommand(Regex.Unescape(TemplateHelper.Instance.AddInfrastructureProject).Replace("{apiName}", $"{apiName}").Replace("{apiPath}", $"{apiPath}"));

            UpdateProgressBar(25);
            UpdateLabel("adding project dependencies...");

            // Add project references
            ExecuteCliCommand.ExecuteCommand(Regex.Unescape(TemplateHelper.Instance.AddWebAPIReferringApplication).Replace("{apiName}", $"{apiName}").Replace("{apiPath}", $"{apiPath}"));
            ExecuteCliCommand.ExecuteCommand(Regex.Unescape(TemplateHelper.Instance.AddWebAPIReferringInfrastructure).Replace("{apiName}", $"{apiName}").Replace("{apiPath}", $"{apiPath}"));
            ExecuteCliCommand.ExecuteCommand(Regex.Unescape(TemplateHelper.Instance.AddApplicationReferringDomain).Replace("{apiName}", $"{apiName}").Replace("{apiPath}", $"{apiPath}"));
            ExecuteCliCommand.ExecuteCommand(Regex.Unescape(TemplateHelper.Instance.AddInfrastructureReferringDomain).Replace("{apiName}", $"{apiName}").Replace("{apiPath}", $"{apiPath}"));
            ExecuteCliCommand.ExecuteCommand(Regex.Unescape(TemplateHelper.Instance.AddInfrastructureReferringApplication).Replace("{apiName}", $"{apiName}").Replace("{apiPath}", $"{apiPath}"));

            UpdateLabel("generating classes...");

            string requestModelClassPath = Path.Combine(apiPath + $"\\{apiName}.Domain", "Entities", "Request");
            string responseModelClassPath = Path.Combine(apiPath + $"\\{apiName}.Domain", "Entities", "Response");
            ModelClassGenerator.GenerateModelClassesFromDataForSp(sheetsData, requestModelClassPath, responseModelClassPath);

            UpdateStartupFile.CreateStartupFile(apiName, apiPath);
            UpdateProgramFile.CreateOrUpdateProgramFile(apiName, apiPath);

            UpdateProgressBar(50);
            UpdateLabel("creating repositories...");


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
                InterfaceGenerator.GenerateRepositoryInterface(apiName, apiPath, className, IdName, dt);
                RepositoryGenerator.GenerateRepositoryImplementation(apiName, apiPath, className, IdName, dt);

                // Generate services
                InterfaceGenerator.GenerateServiceInterface(apiName, apiPath, className, IdName, dt);
                ServiceGenerator.GenerateServiceImplementation(apiName, apiPath, className, IdName, dt);

                // Generate controllers
                ControllerGenerator.GenerateController(apiName, apiPath, className, IdName, dt);
            }

            UpdateStartupFile.UpdateStartupForRepositoriesAndServices(apiName, apiPath, sheetsData, "Table");

            UpdateProgressBar(75);
            UpdateLabel("running migrations...");

            string migrationPath = Path.Combine(apiPath, $"{apiName}.WebAPI");
            string infrastructurePath = Path.Combine(apiPath, $"{apiName}.Infrastructure");
            Migrations.RunMigrationsAndUpdates(migrationPath, infrastructurePath, "InitialCreate", "ApplicationDbContext");
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

        public void ExternalAppendLog(string logText)
        {
            // Call AppendLog from here
            AppendLog(logText);
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

            btnValidate.Enabled = false;
            btnValidate.ForeColor = SystemColors.GrayText; ;

            btnCreate.Enabled = true;
        }

        private void dgTable_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.ColumnIndex == 0)
            {
                e.CellStyle.BackColor = Color.FromArgb(107, 125, 157);
            }
        }

        private void dgTable_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var dgv = sender as DataGridView;
            if (dgv == null || e.RowIndex < 0) return; // Early exit if casting failed or if the header row is clicked

            // Assuming "Get / GetAll" is at column index 1 and "Insert / Update" is at column index 2
            int getColumnIndex = dgv.Columns["Get / GetAll"].Index;
            int insertColumnIndex = dgv.Columns["Insert / Update"].Index;

            // Only proceed if the clicked cell is in one of the checkbox columns
            if (e.ColumnIndex == getColumnIndex || e.ColumnIndex == insertColumnIndex)
            {
                // Invert the value for the clicked checkbox
                bool currentStatus = (bool)dgv[e.ColumnIndex, e.RowIndex].Value;
                dgv[e.ColumnIndex, e.RowIndex].Value = !currentStatus;

                // Determine the index of the other checkbox in the same row and set it to false
                int otherColumnIndex = (e.ColumnIndex == getColumnIndex) ? insertColumnIndex : getColumnIndex;
                dgv[otherColumnIndex, e.RowIndex].Value = false; // Uncheck the other checkbox

                // Update the underlying DataTable
                dt.Rows[e.RowIndex]["Get / GetAll"] = dgv[getColumnIndex, e.RowIndex].Value;
                dt.Rows[e.RowIndex]["Insert / Update"] = dgv[insertColumnIndex, e.RowIndex].Value;

                // Commit the changes to the DataGridView to refresh the UI
                dgv.CommitEdit(DataGridViewDataErrorContexts.Commit);
                dgv.EndEdit();

                // Optionally, you can refresh the entire DataGridView, but it should not be necessary
                // dgv.Refresh();
            }
        }
    }
}
