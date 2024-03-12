namespace DynCodeGen.UserControls
{
    using global::DynCodeGen.CodeGeneration.CodeTemplate;
    using global::DynCodeGen.CodeGeneration.Controller;
    using global::DynCodeGen.CodeGeneration.Entity;
    using global::DynCodeGen.CodeGeneration.Model;
    using global::DynCodeGen.CodeGeneration.Project;
    using Microsoft.Identity.Client;
    using OfficeOpenXml;
    using System.Data;
    using System.Diagnostics;
    using System.Diagnostics.Metrics;
    using System.Text.RegularExpressions;
    using System.Windows.Forms;
    using System.Xml.Linq;

    /// <summary>
    /// CreateControl.
    /// </summary>
    public partial class CreateControl : UserControl
    {
        //private SpControl spControlInstance;
        //private DynCodeGen dynCodeGenInstance;
        //public CreateModelControl createModelControlInstance;
        //public AdoCreateControl adoCreateControlInstance;
        //public AdoEnhanceControl adoEnhanceControlInstance;
        private Dictionary<string, List<Tuple<string, string, string, string>>> sheetsData = new Dictionary<string, List<Tuple<string, string, string, string>>>();
        private string folderPath = string.Empty;
        DataTable dt = new DataTable();

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
            DynCodeGen dynCodeGenInstance = new DynCodeGen();
            SpControl spControlInstance = new SpControl(dynCodeGenInstance);
            CreateModelControl createModelControlInstance = new CreateModelControl(dynCodeGenInstance);
            AdoCreateControl adoCreateControlInstance = new AdoCreateControl();
            AdoEnhanceControl adoEnhanceControlInstance = new AdoEnhanceControl();
            BuildConnection frm = new BuildConnection(this, spControlInstance, createModelControlInstance, adoCreateControlInstance, adoEnhanceControlInstance);
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
                if (openFileDialog.FileName.Contains("Table"))
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
        /// <summary>
        /// Validation.
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
        private void btnValidate_EnabledChanged(object sender, System.EventArgs e)
        {
            btnValidate.BackColor = Color.FromArgb(179, 187, 200); ;
        }
        private void btnCreate_EnabledChanged(object sender, System.EventArgs e)
        {
            btnCreate.BackColor = Color.FromArgb(179, 187, 200); ;
        }
        private void GenerateWebAPI(string apiName, string apiPath, string connectionString)
        {
            //Azure Instance with user Values
            var azureAdSettings = new AzureAdSettings
            {
                Instance = "https://login.microsoftonline.com/",
                Domain = "Domain",
                TenantId = "TenantID",
                ClientId = "ClientID",
                Audience = "Audience"
            };

            ExecuteCliCommand execmd = new ExecuteCliCommand();
            Migrations migrations = new Migrations();

                // Create a WebAPI project
                AppendLog(execmd.ExecuteCommand(Regex.Unescape(TemplateHelper.Instance.CreateWebAPI).Replace("{apiName}", $"{apiName}").Replace("{apiPath}", $"{apiPath}")).ToString());

                // Set the connection string in appsettings.json
                string appSettingsPath = Path.Combine(apiPath, $"{apiName}.WebAPI", "appsettings.json");
                AddConnectionString.SetConnectionString(appSettingsPath, connectionString);
                AddConnectionString.UpdateAzureAdSettings(appSettingsPath, azureAdSettings);

                // Set the connection string in appsettings.Development.json
                string appSettingsDevPath = Path.Combine(apiPath, $"{apiName}.WebAPI", "appsettings.Development.json");
                AddConnectionString.SetConnectionString(appSettingsDevPath, connectionString);
                AddConnectionString.UpdateAzureAdSettings(appSettingsPath, azureAdSettings);

                // Create a solution
                AppendLog(execmd.ExecuteCommand(Regex.Unescape(TemplateHelper.Instance.CreateSolution).Replace("{apiName}", $"{apiName}").Replace("{apiPath}", $"{apiPath}")));

                // Create Application, Domain, and Infrastructure projects
                AppendLog(execmd.ExecuteCommand(Regex.Unescape(TemplateHelper.Instance.CreateApplication).Replace("{apiName}", $"{apiName}").Replace("{apiPath}", $"{apiPath}")));
                AppendLog(execmd.ExecuteCommand(Regex.Unescape(TemplateHelper.Instance.CreateDomain).Replace("{apiName}", $"{apiName}").Replace("{apiPath}", $"{apiPath}")));
                AppendLog(execmd.ExecuteCommand(Regex.Unescape(TemplateHelper.Instance.CreateInfrastructure).Replace("{apiName}", $"{apiName}").Replace("{apiPath}", $"{apiPath}")));

                Directory.CreateDirectory(Path.Combine(apiPath, $"{apiName}.Domain", "Entities"));
                Directory.CreateDirectory(Path.Combine(apiPath, $"{apiName}.Infrastructure", "Data"));

                // Add all projects to the solution
                AppendLog(execmd.ExecuteCommand(Regex.Unescape(TemplateHelper.Instance.AddWebAPIProject).Replace("{apiName}", $"{apiName}").Replace("{apiPath}", $"{apiPath}")));
                AppendLog(execmd.ExecuteCommand(Regex.Unescape(TemplateHelper.Instance.AddApplicationProject).Replace("{apiName}", $"{apiName}").Replace("{apiPath}", $"{apiPath}")));
                AppendLog(execmd.ExecuteCommand(Regex.Unescape(TemplateHelper.Instance.AddDomainProject).Replace("{apiName}", $"{apiName}").Replace("{apiPath}", $"{apiPath}")));
                AppendLog(execmd.ExecuteCommand(Regex.Unescape(TemplateHelper.Instance.AddInfrastructureProject).Replace("{apiName}", $"{apiName}").Replace("{apiPath}", $"{apiPath}")));

                UpdateProgressBar(25);
                UpdateLabel("adding project dependencies...");

                // You can even add project references
                AppendLog(execmd.ExecuteCommand(Regex.Unescape(TemplateHelper.Instance.AddWebAPIReferringApplication).Replace("{apiName}", $"{apiName}").Replace("{apiPath}", $"{apiPath}")));
                AppendLog(execmd.ExecuteCommand(Regex.Unescape(TemplateHelper.Instance.AddWebAPIReferringInfrastructure).Replace("{apiName}", $"{apiName}").Replace("{apiPath}", $"{apiPath}")));
                AppendLog(execmd.ExecuteCommand(Regex.Unescape(TemplateHelper.Instance.AddApplicationReferringDomain).Replace("{apiName}", $"{apiName}").Replace("{apiPath}", $"{apiPath}")));
                AppendLog(execmd.ExecuteCommand(Regex.Unescape(TemplateHelper.Instance.AddInfrastructureReferringDomain).Replace("{apiName}", $"{apiName}").Replace("{apiPath}", $"{apiPath}")));
                AppendLog(execmd.ExecuteCommand(Regex.Unescape(TemplateHelper.Instance.AddInfrastructureReferringApplication).Replace("{apiName}", $"{apiName}").Replace("{apiPath}", $"{apiPath}")));

                // Add EF Core packages to the Infrastructure and WebAPI projects
                AppendLog(execmd.ExecuteCommand(Regex.Unescape(TemplateHelper.Instance.AddSqlServerPackage).Replace("{apiName}", $"{apiName}").Replace("{apiPath}", $"{apiPath}")));
                AppendLog(execmd.ExecuteCommand(Regex.Unescape(TemplateHelper.Instance.AddDesignPackage).Replace("{apiName}", $"{apiName}").Replace("{apiPath}", $"{apiPath}")));
                AppendLog(execmd.ExecuteCommand(Regex.Unescape(TemplateHelper.Instance.AddToolsPackage).Replace("{apiName}", $"{apiName}").Replace("{apiPath}", $"{apiPath}")));
                AppendLog(execmd.ExecuteCommand(Regex.Unescape(TemplateHelper.Instance.AddAspNetCoreHostingPackage).Replace("{apiName}", $"{apiName}").Replace("{apiPath}", $"{apiPath}")));
                AppendLog(execmd.ExecuteCommand(Regex.Unescape(TemplateHelper.Instance.AddExtensionsHostingPackage).Replace("{apiName}", $"{apiName}").Replace("{apiPath}", $"{apiPath}")));
                AppendLog(execmd.ExecuteCommand(Regex.Unescape(TemplateHelper.Instance.AddJwtBearer).Replace("{apiName}", $"{apiName}").Replace("{apiPath}", $"{apiPath}")));
                AppendLog(execmd.ExecuteCommand(Regex.Unescape(TemplateHelper.Instance.AddIdentityWeb).Replace("{apiName}", $"{apiName}").Replace("{apiPath}", $"{apiPath}")));

                //Add Serilog Packages under WebApiProjects            
                AppendLog(execmd.ExecuteCommand(Regex.Unescape(TemplateHelper.Instance.AddSeriLogPackage).Replace("{apiName}", $"{apiName}").Replace("{apiPath}", $"{apiPath}")));
                AppendLog(execmd.ExecuteCommand(Regex.Unescape(TemplateHelper.Instance.AddSeriLogConfigurationPackage).Replace("{apiName}", $"{apiName}").Replace("{apiPath}", $"{apiPath}")));
                AppendLog(execmd.ExecuteCommand(Regex.Unescape(TemplateHelper.Instance.AddSeriLogConsolePackage).Replace("{apiName}", $"{apiName}").Replace("{apiPath}", $"{apiPath}")));
                AppendLog(execmd.ExecuteCommand(Regex.Unescape(TemplateHelper.Instance.AddSeriLogSinksPackage).Replace("{apiName}", $"{apiName}").Replace("{apiPath}", $"{apiPath}")));
                AppendLog(execmd.ExecuteCommand(Regex.Unescape(TemplateHelper.Instance.AddSwashbucklePackage).Replace("{apiName}", $"{apiName}").Replace("{apiPath}", $"{apiPath}")));


                AppendLog(execmd.ExecuteCommand(Regex.Unescape(TemplateHelper.Instance.AdddotnetefPackage)));

                UpdateLabel("generating classes...");



                string dbContextPath = Path.Combine(apiPath, $"{apiName}.Infrastructure", "Data", "ApplicationDbContext.cs");
                DBContext.GenerateApplicationDbContext(apiName, dbContextPath, $"{apiName}.Infrastructure");

                string modelClassPath = Path.Combine(apiPath, $"{apiName}.Domain", "Entities");
                ModelClassGenerator.GenerateModelClassesFromData(apiName, sheetsData, modelClassPath);

                // Now update ApplicationDbContext with models
                DBContext.UpdateApplicationDbContextWithModels(sheetsData, dbContextPath);

            UpdateStartupFile.CreateStartupFile(apiName, apiPath);
            UpdateProgramFile.CreateOrUpdateProgramFile(apiName, apiPath);

            //Api Response 
            Directory.CreateDirectory(Path.Combine(apiPath, $"{apiName}.WebAPI", "ExceptionMiddleWare"));
            AddExceptionMiddleware.CreateExceptionMiddlewareFile(apiName, apiPath);
            AddMiddleWareResponse.CreateAPIExceptionFile(apiName, apiPath);
            AddMiddleWareResponse.CreateAPIResponseFile(apiName, apiPath);
            AddMiddleWareResponse.CreateAPIResponseBaseFile(apiName, apiPath);
            AddMiddleWareResponse.CreateAPIValidationErrorResponseFile(apiName, apiPath);
            AddMiddleWareResponse.CreateBadRequestExceptionFile(apiName, apiPath);


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
                AppendLog(migrations.RunMigrationsAndUpdates(migrationPath, infrastructurePath, "InitialCreate", "ApplicationDbContext").ToString());
            
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

            //Continue with the UI update on the UI thread

            try
            {
                string formattedLog = $"{DateTime.Now:yyyy-MM-dd HH:mm:ss} - {logText}";
                txtLog.AppendText(formattedLog + Environment.NewLine);
                txtLog.ScrollToCaret();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

        }

        private void CreateControl_Load(object sender, EventArgs e)
        {
            txtLog.Visible = true;
            dgTable.Visible = false;
            btnCreate.Enabled = false;
        }

        private void btnValidate_Click(object sender, EventArgs e)
        {

            //if (Validation())
            //{
            txtLog.Visible = false;
            dgTable.Visible = true;
            dt.Columns.Add("Table", typeof(string));
            dt.Columns.Add("Get", typeof(bool));
            dt.Columns.Add("GetAll", typeof(bool));
            dt.Columns.Add("Insert", typeof(bool));
            dt.Columns.Add("Update", typeof(bool));
            dt.Columns.Add("Delete", typeof(bool));


            foreach (var sheetEntry in sheetsData)
            {
                string tablenName = sheetEntry.Key.ToString();

                DataRow dataRow = dt.NewRow();
                dataRow["Table"] = tablenName;
                dataRow["Get"] = true;
                dataRow["GetAll"] = true;
                dataRow["Insert"] = true;
                dataRow["Update"] = true;
                dataRow["Delete"] = true;
                dt.Rows.Add(dataRow);
            }

            dgTable.DataSource = dt;
            dgTable.Columns[0].Width = 377;

            btnValidate.Enabled = false;
            btnValidate.ForeColor = SystemColors.GrayText; ;

            btnCreate.Enabled = true;
            //}
        }
        private void dgTable_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

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
