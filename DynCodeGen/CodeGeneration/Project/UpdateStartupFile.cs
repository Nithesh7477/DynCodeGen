using DynCodeGen.CodeGeneration.CodeTemplate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace DynCodeGen.CodeGeneration.Project
{
    public class UpdateStartupFile
    {
        public static void CreateStartupFile(string apiName, string apiPath)
        {
            string startupFilePath = Path.Combine(apiPath, $"{apiName}.WebAPI", "Startup.cs");
            StringBuilder startupFileContent = new StringBuilder(Regex.Unescape(TemplateHelper.Instance.StartupUsing) + Regex.Unescape(TemplateHelper.Instance.StartupNamespaceStart) + Regex.Unescape(TemplateHelper.Instance.StartupClassStart) + Regex.Unescape(TemplateHelper.Instance.StartupConstructor) + Regex.Unescape(TemplateHelper.Instance.StartupConfigureServicesMethod) + Regex.Unescape(TemplateHelper.Instance.StartupConfigureMethod) + Regex.Unescape(TemplateHelper.Instance.StartupRegisterDependenciesMethod) + Regex.Unescape(TemplateHelper.Instance.StartupAddCorsMethod) + Regex.Unescape(TemplateHelper.Instance.StartupConfigureHealthCheckMethod) + Regex.Unescape(TemplateHelper.Instance.StartupConfigureSwaggerMethod) + Regex.Unescape(TemplateHelper.Instance.StartupNamespaceEnd));
            startupFileContent.Replace("{apiName}", $"{apiName}");
            File.WriteAllText(startupFilePath, startupFileContent.ToString());
        }

        public static void UpdateStartupForRepositoriesAndServices(string apiName, string apiPath, Dictionary<string, List<Tuple<string, string, string, string>>> sheetsData, string UpdationType)
        {
            string startupPath = Path.Combine(apiPath, $"{apiName}.WebAPI", "Startup.cs");
            StringBuilder sb = new StringBuilder();

            foreach (var sheetEntry in sheetsData)
            {
                if (UpdationType == "Table")
                {
                    string className = sheetEntry.Key;
                    sb.AppendLine(Regex.Unescape(TemplateHelper.Instance.StartupForRepositoriesAndServices));
                    sb.Replace("{className}", $"{className}");
                }
                else if (UpdationType == "SP")
                {
                    string className = sheetEntry.Key;
                    sb.AppendLine(Regex.Unescape(TemplateHelper.Instance.SPStartupForRepositoriesAndServices));
                    sb.Replace("{className}", $"{className}");
                }

            }

            string existingContent = File.ReadAllText(startupPath);
            int insertionIndex = existingContent.IndexOf("// Add dependency injection registrations here.");

            if (insertionIndex > -1)
            {
                existingContent = existingContent.Insert(insertionIndex, sb.ToString());
                existingContent.Replace("{apiName}", $"{apiName}");
                File.WriteAllText(startupPath, existingContent);
            }
        }
    }
}
