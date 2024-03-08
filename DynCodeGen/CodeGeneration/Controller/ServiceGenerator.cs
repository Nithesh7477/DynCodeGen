using DynCodeGen.CodeGeneration.CodeTemplate;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace DynCodeGen.CodeGeneration.Controller
{
    public class ServiceGenerator
    {
        public static void GenerateServiceImplementation(string apiName, string apiPath, string className, string IdName, DataTable dt)
        {
            StringBuilder classContent = new StringBuilder(Regex.Unescape(TemplateHelper.Instance.ServiceUsing) + Regex.Unescape(TemplateHelper.Instance.ServiceNamespace)  +Regex.Unescape(TemplateHelper.Instance.ServiceClassStart)+Regex.Unescape(TemplateHelper.Instance.ServiceConstructor)+Regex.Unescape(TemplateHelper.Instance.ServiceMethodComments) + Regex.Unescape(TemplateHelper.Instance.ServiceClassEnd) + Regex.Unescape(TemplateHelper.Instance.ServiceNamespaceEnd));
            string classDirectory = Path.Combine(apiPath, $"{apiName}.Infrastructure", "Service");
            string classPath = Path.Combine(classDirectory, $"{className}Service.cs");
            var temp = dt.Rows.Cast<DataRow>()
                  .FirstOrDefault(x => x.Field<string>("Table") == className);
            if (temp[0] == className)
            {
                if ((bool)temp[1] == true)
                {
                    TemplateHelper.InsertCodeBeforeComments(classContent, Regex.Unescape(TemplateHelper.Instance.ServiceGetById), "// Get");
                }
                if ((bool)temp[2] == true)
                {
                    TemplateHelper.InsertCodeBeforeComments(classContent, Regex.Unescape(TemplateHelper.Instance.ServiceGetAll), "// GetAll");
                }
                if ((bool)temp[3] == true)
                {
                    if ((bool)temp[1] == true)
                    {
                        TemplateHelper.InsertCodeBeforeComments(classContent, Regex.Unescape(TemplateHelper.Instance.ServiceAdd), "// Insert");
                    }
                    else
                    {
                        TemplateHelper.InsertCodeBeforeComments(classContent, Regex.Unescape(TemplateHelper.Instance.ServiceGetById), "// Get");
                        TemplateHelper.InsertCodeBeforeComments(classContent, Regex.Unescape(TemplateHelper.Instance.ServiceAdd), "// Insert");
                    }
                }
                if ((bool)temp[4] == true)
                {
                    TemplateHelper.InsertCodeBeforeComments(classContent, Regex.Unescape(TemplateHelper.Instance.ServiceUpdate), "// Update");
                }
                if ((bool)temp[5] == true)
                {
                    if ((bool)temp[1] == false && (bool)temp[3] == true)
                    {
                        TemplateHelper.InsertCodeBeforeComments(classContent, Regex.Unescape(TemplateHelper.Instance.ServiceDelete), "// Delete");
                    }
                    else if ((bool)temp[1] == false && (bool)temp[3] == false)
                    {
                        TemplateHelper.InsertCodeBeforeComments(classContent, Regex.Unescape(TemplateHelper.Instance.ServiceGetById), "// Get");
                        TemplateHelper.InsertCodeBeforeComments(classContent, Regex.Unescape(TemplateHelper.Instance.ServiceDelete), "// Delete");
                    }
                    else
                    {
                        TemplateHelper.InsertCodeBeforeComments(classContent, Regex.Unescape(TemplateHelper.Instance.ServiceDelete), "// Delete");
                    }
                }
            }
            Directory.CreateDirectory(classDirectory);
            classContent.Replace("{apiName}", $"{apiName}").Replace("{className}", $"{className}").Replace("{IdName}", $"{IdName}");
            File.WriteAllText(classPath, classContent.ToString());
        }
        public static void GenerateSPServiceImplementation(string apiName, string apiPath, string className, string IdName, DataTable dt)
        {
            StringBuilder classContent = new StringBuilder(Regex.Unescape(TemplateHelper.Instance.ServiceUsing) + Regex.Unescape(TemplateHelper.Instance.ServiceNamespace) + Regex.Unescape(TemplateHelper.Instance.ServiceSPClassStart) + Regex.Unescape(TemplateHelper.Instance.ServiceSPConstructor) + Regex.Unescape(TemplateHelper.Instance.ServiceSPMethodComments) + Regex.Unescape(TemplateHelper.Instance.ServiceClassEnd) + Regex.Unescape(TemplateHelper.Instance.ServiceNamespaceEnd));
            string classDirectory = Path.Combine(apiPath, $"{apiName}.Infrastructure", "Service");
            string classPath = Path.Combine(classDirectory, $"{className}Service.cs");
            var temp = dt.Rows.Cast<DataRow>()
                  .FirstOrDefault(x => x.Field<string>("SP_Name") == className);
            if (temp[0] == className)
            {
                if ((bool)temp[1] == true)
                {
                    TemplateHelper.InsertCodeBeforeComments(classContent, Regex.Unescape(TemplateHelper.Instance.ServiceGetMethod), "// GET/GETALL");
                }
                if ((bool)temp[2] == true)
                {
                    TemplateHelper.InsertCodeBeforeComments(classContent, Regex.Unescape(TemplateHelper.Instance.ServicePostMethod), "// INSERT/UPDATE");
                }
            }
            Directory.CreateDirectory(classDirectory);
            classContent.Replace("{apiName}", $"{apiName}").Replace("{className}", $"{className}").Replace("{IdName}", $"{IdName}");
            File.WriteAllText(classPath, classContent.ToString());
        }

        public static void GenerateServiceImplementationAdo(string apiName, string apiPath, string className, DataTable dt)
        {
            StringBuilder classContent = new StringBuilder(Regex.Unescape(TemplateHelper.Instance.ADOServiceUsing) + Regex.Unescape(TemplateHelper.Instance.ServiceNamespace) + Regex.Unescape(TemplateHelper.Instance.ServiceSPClassStart) + Regex.Unescape(TemplateHelper.Instance.ServiceSPConstructor) + Regex.Unescape(TemplateHelper.Instance.ServiceSPMethodComments) + Regex.Unescape(TemplateHelper.Instance.ServiceClassEnd) + Regex.Unescape(TemplateHelper.Instance.ServiceNamespaceEnd));
            string classDirectory = Path.Combine(apiPath, $"{apiName}.Infrastructure", "Service");
            string classPath = Path.Combine(classDirectory, $"{className}Service.cs");
            var temp = dt.Rows.Cast<DataRow>()
                  .FirstOrDefault(x => x.Field<string>("Stored Procedure") == className);
            if (temp[0] == className)
            {
                if ((bool)temp[1] == true)
                {
                    TemplateHelper.InsertCodeBeforeComments(classContent, Regex.Unescape(TemplateHelper.Instance.ServiceGetMethod), "// GET/GETALL");
                }
                if ((bool)temp[2] == true)
                {
                    TemplateHelper.InsertCodeBeforeComments(classContent, Regex.Unescape(TemplateHelper.Instance.ServicePostMethodAdo), "// INSERT/UPDATE");
                }
            }
            Directory.CreateDirectory(classDirectory);
            classContent.Replace("{apiName}", $"{apiName}").Replace("{className}", $"{className}");
            File.WriteAllText(classPath, classContent.ToString());
        }
    }
}
