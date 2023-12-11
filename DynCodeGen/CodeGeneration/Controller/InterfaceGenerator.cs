using DynCodeGen.CodeGeneration.CodeTemplate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace DynCodeGen.CodeGeneration.Controller
{
    public class InterfaceGenerator
    {
        public static void GenerateServiceInterface(string apiName, string apiPath, string className, string IdName)
        {
            StringBuilder interfaceContent = new StringBuilder(Regex.Unescape(TemplateHelper.Instance.IServiceNamespace)+ Regex.Unescape(TemplateHelper.Instance.IServiceInterface)+ Regex.Unescape(TemplateHelper.Instance.IServiceGetAll)+ Regex.Unescape(TemplateHelper.Instance.IServiceGet)+ Regex.Unescape(TemplateHelper.Instance.IServiceAdd)+ Regex.Unescape(TemplateHelper.Instance.IServiceUpdate)+ Regex.Unescape(TemplateHelper.Instance.IServiceDelete)+ Regex.Unescape(TemplateHelper.Instance.IServiceClassEnd)+ Regex.Unescape(TemplateHelper.Instance.IServiceNamespaceEnd));
            string interfaceDirectory = Path.Combine(apiPath, $"{apiName}.Application", "IService");
            Directory.CreateDirectory(interfaceDirectory);
            string interfacePath = Path.Combine(interfaceDirectory, $"I{className}Service.cs");
            interfaceContent.Replace("{apiName}", $"{apiName}").Replace("{className}", $"{className}").Replace("{IdName}", $"{IdName}");
            File.WriteAllText(interfacePath, interfaceContent.ToString());
        }

        public static void GenerateRepositoryInterface(string apiName, string apiPath, string className, string IdName)
         {
            StringBuilder interfaceContent = new StringBuilder(Regex.Unescape(TemplateHelper.Instance.IRepositoryNamespace) + Regex.Unescape(TemplateHelper.Instance.IRepositoryInterface) + Regex.Unescape(TemplateHelper.Instance.IRepositoryGetAll) + Regex.Unescape(TemplateHelper.Instance.IRepositoryGet) + Regex.Unescape(TemplateHelper.Instance.IRepositoryAdd) + Regex.Unescape(TemplateHelper.Instance.IRepositoryUpdate) + Regex.Unescape(TemplateHelper.Instance.IRepositoryDelete) + Regex.Unescape(TemplateHelper.Instance.IRepositoryInterfaceEnd) + Regex.Unescape(TemplateHelper.Instance.IRepositoryNamespaceEnd));
            string interfaceDirectory = Path.Combine(apiPath, $"{apiName}.Application", "IRepository");
            Directory.CreateDirectory(interfaceDirectory); // Create the directory if it doesn't exist
            string interfacePath = Path.Combine(interfaceDirectory, $"I{className}Repository.cs");
            interfaceContent.Replace("{apiName}", $"{apiName}").Replace("{className}", $"{className}").Replace("{IdName}", $"{IdName}");
            File.WriteAllText(interfacePath, interfaceContent.ToString());
        }
    }
}
