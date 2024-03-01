using DynCodeGen.CodeGeneration.CodeTemplate;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace DynCodeGen.CodeGeneration.Controller
{
    public class InterfaceGenerator
    {
        public static void GenerateServiceInterface(string apiName, string apiPath, string className, string IdName,DataTable dt)
        {
            StringBuilder interfaceContent = new StringBuilder(Regex.Unescape(TemplateHelper.Instance.IServiceNamespace)+ Regex.Unescape(TemplateHelper.Instance.IServiceInterface)+Regex.Unescape(TemplateHelper.Instance.IServiceMethodComments)+ Regex.Unescape(TemplateHelper.Instance.IServiceClassEnd)+ Regex.Unescape(TemplateHelper.Instance.IServiceNamespaceEnd));
            string interfaceDirectory = Path.Combine(apiPath, $"{apiName}.Application", "IService");
            string interfacePath = Path.Combine(interfaceDirectory, $"I{className}Service.cs");
            var temp = dt.Rows.Cast<DataRow>()
                  .FirstOrDefault(x => x.Field<string>("Table") == className);
            if (temp[0] == className)
            {
                if ((bool)temp[1] == true)
                {
                    TemplateHelper.InsertCodeBeforeComments(interfaceContent, Regex.Unescape(TemplateHelper.Instance.IServiceGet), "// Get");
                }
                if ((bool)temp[2] == true)
                {
                    TemplateHelper.InsertCodeBeforeComments(interfaceContent, Regex.Unescape(TemplateHelper.Instance.IServiceGetAll), "// GetAll");
                }
                if ((bool)temp[3] == true)
                {
                    if ((bool)temp[1] == true)
                    {
                        TemplateHelper.InsertCodeBeforeComments(interfaceContent, Regex.Unescape(TemplateHelper.Instance.IServiceAdd), "// Insert");
                    }
                    else
                    {
                        TemplateHelper.InsertCodeBeforeComments(interfaceContent, Regex.Unescape(TemplateHelper.Instance.IServiceGet), "// Get");
                        TemplateHelper.InsertCodeBeforeComments(interfaceContent, Regex.Unescape(TemplateHelper.Instance.IServiceAdd), "// Insert");
                    }
                }
                if ((bool)temp[4] == true)
                {
                    TemplateHelper.InsertCodeBeforeComments(interfaceContent, Regex.Unescape(TemplateHelper.Instance.IServiceUpdate), "// Update");
                }
                if ((bool)temp[5] == true)
                {
                    if ((bool)temp[1] ==false && (bool)temp[3] == true)
                    {
                        TemplateHelper.InsertCodeBeforeComments(interfaceContent, Regex.Unescape(TemplateHelper.Instance.IServiceDelete), "// Delete");
                    }
                    else if ((bool)temp[1] == false && (bool)temp[3] == false)
                    {
                        TemplateHelper.InsertCodeBeforeComments(interfaceContent, Regex.Unescape(TemplateHelper.Instance.IServiceGet), "// Get");
                        TemplateHelper.InsertCodeBeforeComments(interfaceContent, Regex.Unescape(TemplateHelper.Instance.IServiceDelete), "// Delete");
                    }
                    else
                    {
                        TemplateHelper.InsertCodeBeforeComments(interfaceContent, Regex.Unescape(TemplateHelper.Instance.IServiceDelete), "// Delete");
                    }
                }
            }
            Directory.CreateDirectory(interfaceDirectory);
            interfaceContent.Replace("{apiName}", $"{apiName}").Replace("{className}", $"{className}").Replace("{IdName}", $"{IdName}");
            File.WriteAllText(interfacePath, interfaceContent.ToString());
        }
        public static void GenerateSPServiceInterface(string apiName, string apiPath, string className, string IdName, DataTable dt)
        {
            StringBuilder interfaceContent = new StringBuilder(Regex.Unescape(TemplateHelper.Instance.IServiceNamespace) + Regex.Unescape(TemplateHelper.Instance.IServiceSPInterface) + Regex.Unescape(TemplateHelper.Instance.IServiceSPMethodComments) + Regex.Unescape(TemplateHelper.Instance.IServiceClassEnd) + Regex.Unescape(TemplateHelper.Instance.IServiceNamespaceEnd));
            string interfaceDirectory = Path.Combine(apiPath, $"{apiName}.Application", "IService");
            string interfacePath = Path.Combine(interfaceDirectory, $"I{className}Service.cs");
            var temp = dt.Rows.Cast<DataRow>()
                  .FirstOrDefault(x => x.Field<string>("SP_Name") == className);
            if (temp[0] == className)
            {
                if ((bool)temp[1] == true)
                {
                    TemplateHelper.InsertCodeBeforeComments(interfaceContent, Regex.Unescape(TemplateHelper.Instance.IServiceGetMethod), "// GET/GETALL");
                }
                if ((bool)temp[2] == true)
                {
                    TemplateHelper.InsertCodeBeforeComments(interfaceContent, Regex.Unescape(TemplateHelper.Instance.IServicePostMethod), "// INSERT/UPDATE");
                }
            }
            Directory.CreateDirectory(interfaceDirectory);
            interfaceContent.Replace("{apiName}", $"{apiName}").Replace("{className}", $"{className}").Replace("{IdName}", $"{IdName}");
            File.WriteAllText(interfacePath, interfaceContent.ToString());
        }

        public static void GenerateRepositoryInterface(string apiName, string apiPath, string className, string IdName, DataTable dt)
            {
            StringBuilder interfaceContent = new StringBuilder(Regex.Unescape(TemplateHelper.Instance.IRepositoryNamespace) + Regex.Unescape(TemplateHelper.Instance.IRepositoryInterface) + Regex.Unescape(TemplateHelper.Instance.IRepositoryMethodComments)+  Regex.Unescape(TemplateHelper.Instance.IRepositoryInterfaceEnd) + Regex.Unescape(TemplateHelper.Instance.IRepositoryNamespaceEnd));
            string interfaceDirectory = Path.Combine(apiPath, $"{apiName}.Application", "IRepository");
            string interfacePath = Path.Combine(interfaceDirectory, $"I{className}Repository.cs");
            var temp = dt.Rows.Cast<DataRow>()
                    .FirstOrDefault(x => x.Field<string>("Table") == className);
            if (temp[0] == className)
            {
                if ((bool)temp[1] == true)
                {
                    TemplateHelper.InsertCodeBeforeComments(interfaceContent, Regex.Unescape(TemplateHelper.Instance.IRepositoryGet), "// Get");
                }
                if ((bool)temp[2] == true)
                {
                    TemplateHelper.InsertCodeBeforeComments(interfaceContent, Regex.Unescape(TemplateHelper.Instance.IRepositoryGetAll), "// GetAll");
                }
                if ((bool)temp[3] == true)
                {
                    if ((bool)temp[1] == true)
                    {
                        TemplateHelper.InsertCodeBeforeComments(interfaceContent, Regex.Unescape(TemplateHelper.Instance.IRepositoryAdd), "// Insert");
                    }
                    else
                    {
                        TemplateHelper.InsertCodeBeforeComments(interfaceContent, Regex.Unescape(TemplateHelper.Instance.IRepositoryGet), "// Get");
                        TemplateHelper.InsertCodeBeforeComments(interfaceContent, Regex.Unescape(TemplateHelper.Instance.IRepositoryAdd), "// Insert");
                    }
                }
                if ((bool)temp[4] == true)
                {
                    TemplateHelper.InsertCodeBeforeComments(interfaceContent, Regex.Unescape(TemplateHelper.Instance.IRepositoryUpdate), "// Update");
                }
                if ((bool)temp[5] == true)
                {
                    if ((bool)temp[1] == false && (bool)temp[3] == true)
                    {
                        TemplateHelper.InsertCodeBeforeComments(interfaceContent, Regex.Unescape(TemplateHelper.Instance.IRepositoryDelete), "// Delete");
                    }
                    else if ((bool)temp[1] == false && (bool)temp[3] == false)
                    {
                        TemplateHelper.InsertCodeBeforeComments(interfaceContent, Regex.Unescape(TemplateHelper.Instance.IRepositoryGet), "// Get");
                        TemplateHelper.InsertCodeBeforeComments(interfaceContent, Regex.Unescape(TemplateHelper.Instance.IRepositoryDelete), "// Delete");
                    }
                    else
                    {
                        TemplateHelper.InsertCodeBeforeComments(interfaceContent, Regex.Unescape(TemplateHelper.Instance.IRepositoryDelete), "// Delete");
                    }
                }
            }
            Directory.CreateDirectory(interfaceDirectory); // Create the directory if it doesn't exist
            interfaceContent.Replace("{apiName}", $"{apiName}").Replace("{className}", $"{className}").Replace("{IdName}", $"{IdName}");
            File.WriteAllText(interfacePath, interfaceContent.ToString());
        }
        public static void GenerateSPRepositoryInterface(string apiName, string apiPath, string className, string IdName, DataTable dt)
        {
            StringBuilder interfaceContent = new StringBuilder(Regex.Unescape(TemplateHelper.Instance.IRepositoryNamespace) + Regex.Unescape(TemplateHelper.Instance.IRepositorySPInterface) + Regex.Unescape(TemplateHelper.Instance.IRepositorySPMethodComments) + Regex.Unescape(TemplateHelper.Instance.IRepositoryInterfaceEnd) + Regex.Unescape(TemplateHelper.Instance.IRepositoryNamespaceEnd));
            string interfaceDirectory = Path.Combine(apiPath, $"{apiName}.Application", "IRepository");
            string interfacePath = Path.Combine(interfaceDirectory, $"I{className}Repository.cs");
            string classLower = className.ToLower();
            var temp = dt.Rows.Cast<DataRow>()
                    .FirstOrDefault(x => x.Field<string>("SP_Name") == className);
            if (temp[0] == className)
            {
                if ((bool)temp[1] == true)
                {
                    TemplateHelper.InsertCodeBeforeComments(interfaceContent, Regex.Unescape(TemplateHelper.Instance.IRepositoryGetMethod), "// GET/GETALL");
                }
                if ((bool)temp[2] == true)
                {
                    TemplateHelper.InsertCodeBeforeComments(interfaceContent, Regex.Unescape(TemplateHelper.Instance.IRepositoryPostMethod), "// INSERT/UPDATE");
                }
            }
            Directory.CreateDirectory(interfaceDirectory); // Create the directory if it doesn't exist
            interfaceContent.Replace("{apiName}", $"{apiName}").Replace("{className}", $"{className}").Replace("{IdName}", $"{IdName}");
            File.WriteAllText(interfacePath, interfaceContent.ToString());
        }

        public static void GenerateServiceInterfaceAdo(string apiName, string apiPath, string className, DataTable dt)
        {
            StringBuilder interfaceContent = new StringBuilder(Regex.Unescape(TemplateHelper.Instance.IServiceNamespace) + Regex.Unescape(TemplateHelper.Instance.IServiceSPInterface) + Regex.Unescape(TemplateHelper.Instance.IServiceSPMethodComments) + Regex.Unescape(TemplateHelper.Instance.IServiceClassEnd) + Regex.Unescape(TemplateHelper.Instance.IServiceNamespaceEnd));
            string interfaceDirectory = Path.Combine(apiPath, $"{apiName}.Application", "IService");
            string interfacePath = Path.Combine(interfaceDirectory, $"I{className}Service.cs");
            var temp = dt.Rows.Cast<DataRow>()
                  .FirstOrDefault(x => x.Field<string>("Stored Procedure") == className);
            if (temp[0] == className)
            {
                if ((bool)temp[1] == true)
                {
                    TemplateHelper.InsertCodeBeforeComments(interfaceContent, Regex.Unescape(TemplateHelper.Instance.IServiceGetMethod), "// GET/GETALL");
                }
                if ((bool)temp[2] == true)
                {
                    TemplateHelper.InsertCodeBeforeComments(interfaceContent, Regex.Unescape(TemplateHelper.Instance.IServicePostMethodAdo), "// INSERT/UPDATE");
                }
            }
            Directory.CreateDirectory(interfaceDirectory);
            interfaceContent.Replace("{apiName}", $"{apiName}").Replace("{className}", $"{className}");
            File.WriteAllText(interfacePath, interfaceContent.ToString());
        }


        public static void GenerateRepositoryInterfaceAdo(string apiName, string apiPath, string className, DataTable dt)
        {
            StringBuilder interfaceContent = new StringBuilder(Regex.Unescape(TemplateHelper.Instance.IRepositoryNamespace) + Regex.Unescape(TemplateHelper.Instance.IRepositorySPInterface) + Regex.Unescape(TemplateHelper.Instance.IRepositorySPMethodComments) + Regex.Unescape(TemplateHelper.Instance.IRepositoryInterfaceEnd) + Regex.Unescape(TemplateHelper.Instance.IRepositoryNamespaceEnd));
            string interfaceDirectory = Path.Combine(apiPath, $"{apiName}.Application", "IRepository");
            string interfacePath = Path.Combine(interfaceDirectory, $"I{className}Repository.cs");
            string classLower = className.ToLower();
            var temp = dt.Rows.Cast<DataRow>()
                    .FirstOrDefault(x => x.Field<string>("Stored Procedure") == className);
            if (temp[0] == className)
            {
                if ((bool)temp[1] == true)
                {
                    TemplateHelper.InsertCodeBeforeComments(interfaceContent, Regex.Unescape(TemplateHelper.Instance.IRepositoryGetMethod), "// GET/GETALL");
                }
                if ((bool)temp[2] == true)
                {
                    TemplateHelper.InsertCodeBeforeComments(interfaceContent, Regex.Unescape(TemplateHelper.Instance.IRepositoryPostMethodAdo), "// INSERT/UPDATE");
                }
            }
            Directory.CreateDirectory(interfaceDirectory); // Create the directory if it doesn't exist
            interfaceContent.Replace("{apiName}", $"{apiName}").Replace("{className}", $"{className}");
            File.WriteAllText(interfacePath, interfaceContent.ToString());
        }
    }
}
