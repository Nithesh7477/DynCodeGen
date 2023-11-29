namespace DynCodeGen.UserControls
{
    using global::DynCodeGen.CodeGeneration.Controller;
    using global::DynCodeGen.CodeGeneration.Entity;
    using global::DynCodeGen.CodeGeneration.Project;
    using OfficeOpenXml;

    /// <summary>
    /// CreateControl.
    /// </summary>
    public partial class CreateControl : UserControl
    {
        private Dictionary<string, List<Tuple<string, string, string, string>>> sheetsData = new Dictionary<string, List<Tuple<string, string, string, string>>>();
        private string folderPath = string.Empty;

        /// <summary>
        /// CreateControl.
        /// </summary>
        public CreateControl()
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
            BuildConnection frm = new BuildConnection(this);
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
                // Set the initial directory (optional)
                // folderDialog.SelectedPath = "C:\\";

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
        }

        /// <summary>
        /// btnCreate_Click.
        /// </summary>
        /// <param name="sender">sender.</param>
        /// <param name="e">e.</param>
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

        /// <summary>
        /// Validation.
        /// </summary>
        /// <returns>bool.</returns>
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

        private void GenerateWebAPI(string apiName, string apiPath, string connectionString)
        {
            // Create a WebAPI project
            ExecuteCliCommand.ExecuteCommand($"new webapi -n {apiName} -o {apiPath}\\{apiName}.WebAPI");

            // Set the connection string in appsettings.json
            string appSettingsPath = Path.Combine(apiPath, $"{apiName}.WebAPI", "appsettings.json");
            AddConnectionString.SetConnectionString(appSettingsPath, connectionString);

            // Set the connection string in appsettings.Development.json
            string appSettingsDevPath = Path.Combine(apiPath, $"{apiName}.WebAPI", "appsettings.Development.json");
            AddConnectionString.SetConnectionString(appSettingsDevPath, connectionString);

            // Create a solution
            ExecuteCliCommand.ExecuteCommand($"new sln -n {apiName} -o {apiPath}");

            // Create Application, Domain, and Infrastructure projects
            ExecuteCliCommand.ExecuteCommand($"new classlib -n {apiName}.Application -o {apiPath}/{apiName}.Application");
            ExecuteCliCommand.ExecuteCommand($"new classlib -n {apiName}.Domain -o {apiPath}/{apiName}.Domain");
            ExecuteCliCommand.ExecuteCommand($"new classlib -n {apiName}.Infrastructure -o {apiPath}/{apiName}.Infrastructure");

            Directory.CreateDirectory(Path.Combine(apiPath, $"{apiName}.Domain", "Entities"));
            Directory.CreateDirectory(Path.Combine(apiPath, $"{apiName}.Infrastructure", "Data"));

            // Add all projects to the solution
            ExecuteCliCommand.ExecuteCommand($"sln {apiPath}/{apiName}.sln add {apiPath}/{apiName}.WebAPI/{apiName}.csproj");
            ExecuteCliCommand.ExecuteCommand($"sln {apiPath}/{apiName}.sln add {apiPath}/{apiName}.Application/{apiName}.Application.csproj");
            ExecuteCliCommand.ExecuteCommand($"sln {apiPath}/{apiName}.sln add {apiPath}/{apiName}.Domain/{apiName}.Domain.csproj");
            ExecuteCliCommand.ExecuteCommand($"sln {apiPath}/{apiName}.sln add {apiPath}/{apiName}.Infrastructure/{apiName}.Infrastructure.csproj");

            UpdateProgressBar(25);
            UpdateLabel("adding project dependencies...");

            // You can even add project references
            ExecuteCliCommand.ExecuteCommand($"add {apiPath}/{apiName}.WebAPI/{apiName}.csproj reference {apiPath}/{apiName}.Application/{apiName}.Application.csproj");
            ExecuteCliCommand.ExecuteCommand($"add {apiPath}/{apiName}.WebAPI/{apiName}.csproj reference {apiPath}/{apiName}.Infrastructure/{apiName}.Infrastructure.csproj");
            ExecuteCliCommand.ExecuteCommand($"add {apiPath}/{apiName}.Application/{apiName}.Application.csproj reference {apiPath}/{apiName}.Domain/{apiName}.Domain.csproj");
            ExecuteCliCommand.ExecuteCommand($"add {apiPath}/{apiName}.Infrastructure/{apiName}.Infrastructure.csproj reference {apiPath}/{apiName}.Domain/{apiName}.Domain.csproj");
            ExecuteCliCommand.ExecuteCommand($"add {apiPath}/{apiName}.Infrastructure/{apiName}.Infrastructure.csproj reference {apiPath}/{apiName}.Application/{apiName}.Application.csproj");

            // Add EF Core packages to the Infrastructure and WebAPI projects
            ExecuteCliCommand.ExecuteCommand($"add {apiPath}/{apiName}.Infrastructure/{apiName}.Infrastructure.csproj package Microsoft.EntityFrameworkCore.SqlServer --version 7.0.11");
            ExecuteCliCommand.ExecuteCommand($"add {apiPath}/{apiName}.WebAPI/{apiName}.csproj package Microsoft.EntityFrameworkCore.Design --version 7.0.11");
            ExecuteCliCommand.ExecuteCommand($"add {apiPath}/{apiName}.WebAPI/{apiName}.csproj package Microsoft.EntityFrameworkCore.Tools --version 7.0.11");
            ExecuteCliCommand.ExecuteCommand($"add {apiPath}/{apiName}.WebAPI/{apiName}.csproj package Microsoft.AspNetCore.Hosting");
            ExecuteCliCommand.ExecuteCommand($"add {apiPath}/{apiName}.WebAPI/{apiName}.csproj package Microsoft.Extensions.Hosting");
            ExecuteCliCommand.ExecuteCommand("tool install --global dotnet-ef");

            UpdateLabel("generating classes...");

            string dbContextPath = Path.Combine(apiPath, $"{apiName}.Infrastructure", "Data", "ApplicationDbContext.cs");
            DBContext.GenerateApplicationDbContext(dbContextPath, $"{apiName}.Infrastructure");

            string modelClassPath = Path.Combine(apiPath, $"{apiName}.Domain", "Entities");
            ModelClassGenerator.GenerateModelClassesFromData(sheetsData, modelClassPath);

            // Now update ApplicationDbContext with models
            DBContext.UpdateApplicationDbContextWithModels(sheetsData, dbContextPath);

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
                InterfaceGenerator.GenerateRepositoryInterface(apiName, apiPath, className, IdName);
                RepositoryGenerator.GenerateRepositoryImplementation(apiName, apiPath, className, IdName);

                // Generate services
                InterfaceGenerator.GenerateServiceInterface(apiName, apiPath, className, IdName);
                ServiceGenerator.GenerateServiceImplementation(apiName, apiPath, className, IdName);

                // Generate controllers
                ControllerGenerator.GenerateController(apiName, apiPath, className, IdName);
            }

            UpdateStartupFile.UpdateStartupForRepositoriesAndServices(apiName, apiPath, sheetsData);

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

        private void lblValidProjLoc_Click(object sender, EventArgs e)
        {

        }
    }
}
