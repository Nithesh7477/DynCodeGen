﻿namespace DynCodeGen.CodeGeneration.Controller
{
    using global::DynCodeGen.CodeGeneration.CodeTemplate;
    using global::DynCodeGen.CodeGeneration.Project;
    using Microsoft.VisualBasic;
    using System.Data;
    using System.Reflection;
    using System.Resources;
    using System.Text;
    using System.Text.RegularExpressions;
    using static System.Windows.Forms.VisualStyles.VisualStyleElement;
    using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

    public class ControllerGenerator
    {


        public static void GenerateController(string apiName, string apiPath, string className, string IdName, DataTable dt)
        {
            string filePath = Path.Combine(apiPath, $"{className}Controller.cs");

            if (File.Exists(filePath))
            {
                MessageBox.Show($"The API code has alredy created in the given file path");
            }
            else
            {
                StringBuilder controllerContent = new StringBuilder(Regex.Unescape(TemplateHelper.Instance.ContollerHeader) + Regex.Unescape(TemplateHelper.Instance.ContollerNamespace) + Regex.Unescape(TemplateHelper.Instance.ContollerClass) + Regex.Unescape(TemplateHelper.Instance.ControllerMethodComments) + Regex.Unescape(TemplateHelper.Instance.ContollerClassEnd) + Regex.Unescape(TemplateHelper.Instance.ContollerNamespaceEnd));
                string controllerDirectory = Path.Combine(apiPath, $"{apiName}.WebAPI", "Controllers");
                string controllerPath = Path.Combine(controllerDirectory, $"{className}Controller.cs");
                var temp = dt.Rows.Cast<DataRow>()
                      .FirstOrDefault(x => x.Field<string>("Table") == className);
                if (temp[0] == className)
                {
                    if ((bool)temp[1] == true)
                    {
                        TemplateHelper.InsertCodeBeforeComments(controllerContent, Regex.Unescape(TemplateHelper.Instance.ContollerGet), "// Get");
                    }
                    if ((bool)temp[2] == true)
                    {
                        TemplateHelper.InsertCodeBeforeComments(controllerContent, Regex.Unescape(TemplateHelper.Instance.ContollerGetAll), "// GetAll");
                    }
                    if ((bool)temp[3] == true)
                    {
                        if ((bool)temp[1] == true)
                        {
                            TemplateHelper.InsertCodeBeforeComments(controllerContent, Regex.Unescape(TemplateHelper.Instance.ContollerAdd), "// Insert");
                        }
                        else
                        {
                            TemplateHelper.InsertCodeBeforeComments(controllerContent, Regex.Unescape(TemplateHelper.Instance.ContollerGet), "// Get");
                            TemplateHelper.InsertCodeBeforeComments(controllerContent, Regex.Unescape(TemplateHelper.Instance.ContollerAdd), "// Insert");
                        }
                    }
                    if ((bool)temp[4] == true)
                    {
                        TemplateHelper.InsertCodeBeforeComments(controllerContent, Regex.Unescape(TemplateHelper.Instance.ContollerUpdate), "// Update");
                    }
                    if ((bool)temp[5] == true)
                    {
                        if ((bool)temp[1] == false && (bool)temp[3] == true)
                        {
                            TemplateHelper.InsertCodeBeforeComments(controllerContent, Regex.Unescape(TemplateHelper.Instance.ContollerDelete), "// Delete");
                        }
                        else if ((bool)temp[1] == false && (bool)temp[3] == false)
                        {
                            TemplateHelper.InsertCodeBeforeComments(controllerContent, Regex.Unescape(TemplateHelper.Instance.ContollerGet), "// Get");
                            TemplateHelper.InsertCodeBeforeComments(controllerContent, Regex.Unescape(TemplateHelper.Instance.ContollerDelete), "// Delete");
                        }
                        else
                        {
                            TemplateHelper.InsertCodeBeforeComments(controllerContent, Regex.Unescape(TemplateHelper.Instance.ContollerDelete), "// Delete");
                        }
                    }
                }
                controllerContent.Replace("{apiName}", $"{apiName}").Replace("{className}", $"{className}").Replace("{IdName}", $"{IdName}");
                Directory.CreateDirectory(controllerDirectory);
                File.WriteAllText(controllerPath, controllerContent.ToString());
            }

        }
        public static void GenerateSPController(string apiName, string apiPath, string className, string IdName, DataTable dt)
        {
            string controllerDirectory = Path.Combine(apiPath, $"{apiName}.WebAPI", "Controllers");
            string filePath = Path.Combine(controllerDirectory, $"{className}Controller.cs");

            if (File.Exists(filePath))
            {
                throw new ApplicationException("Code Duplication");
            }
            else
            {
                StringBuilder controllerContent = new StringBuilder(Regex.Unescape(TemplateHelper.Instance.ContollerHeader) + Regex.Unescape(TemplateHelper.Instance.ContollerNamespace) + Regex.Unescape(TemplateHelper.Instance.ContollerSPClass) + Regex.Unescape(TemplateHelper.Instance.ControllerSPMethodComments) + Regex.Unescape(TemplateHelper.Instance.ContollerClassEnd) + Regex.Unescape(TemplateHelper.Instance.ContollerNamespaceEnd));
                string controllerPath = Path.Combine(controllerDirectory, $"{className}Controller.cs");
                var temp = dt.Rows.Cast<DataRow>()
                      .FirstOrDefault(x => x.Field<string>("SP_Name") == className);
                if (temp[0] == className)
                {
                    if ((bool)temp[1] == true)
                    {
                        TemplateHelper.InsertCodeBeforeComments(controllerContent, Regex.Unescape(TemplateHelper.Instance.ControllerGetMethod), "// GET/GETALL");
                    }
                    if ((bool)temp[2] == true)
                    {
                        TemplateHelper.InsertCodeBeforeComments(controllerContent, Regex.Unescape(TemplateHelper.Instance.ControllerPostMethod), "// INSERT/UPDATE");
                    }

                }
                controllerContent.Replace("{apiName}", $"{apiName}").Replace("{className}", $"{className}").Replace("{IdName}", $"{IdName}");
                Directory.CreateDirectory(controllerDirectory);
                File.WriteAllText(controllerPath, controllerContent.ToString());
            }
        }

        public static void GenerateControllerAdo(string apiName, string apiPath, string className, DataTable dt)
        {
            StringBuilder controllerContent = new StringBuilder(Regex.Unescape(TemplateHelper.Instance.ADOControllerHeader) + Regex.Unescape(TemplateHelper.Instance.ContollerNamespace) + Regex.Unescape(TemplateHelper.Instance.ContollerSPClass) + Regex.Unescape(TemplateHelper.Instance.ControllerSPMethodComments) + Regex.Unescape(TemplateHelper.Instance.ContollerClassEnd) + Regex.Unescape(TemplateHelper.Instance.ContollerNamespaceEnd));
            string controllerDirectory = Path.Combine(apiPath, $"{apiName}.WebAPI", "Controllers");
            string controllerPath = Path.Combine(controllerDirectory, $"{className}Controller.cs");
            var temp = dt.Rows.Cast<DataRow>()
                  .FirstOrDefault(x => x.Field<string>("Stored Procedure") == className);
            if (temp[0] == className)
            {
                if ((bool)temp[1] == true)
                {
                    TemplateHelper.InsertCodeBeforeComments(controllerContent, Regex.Unescape(TemplateHelper.Instance.ControllerGetMethod), "// GET/GETALL");
                }
                if ((bool)temp[2] == true)
                {
                    TemplateHelper.InsertCodeBeforeComments(controllerContent, Regex.Unescape(TemplateHelper.Instance.ControllerPostMethodAdo), "// INSERT/UPDATE");
                }

            }
            controllerContent.Replace("{apiName}", $"{apiName}").Replace("{className}", $"{className}");
            Directory.CreateDirectory(controllerDirectory);
            File.WriteAllText(controllerPath, controllerContent.ToString());
        }
    }
}
