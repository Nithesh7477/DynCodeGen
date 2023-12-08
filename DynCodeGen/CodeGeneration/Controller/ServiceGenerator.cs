using DynCodeGen.CodeGeneration.CodeTemplate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace DynCodeGen.CodeGeneration.Controller
{
    public class ServiceGenerator
    {
        public static void GenerateServiceImplementation(string apiName, string apiPath, string className, string IdName)
        {
            StringBuilder classContent = new StringBuilder(Regex.Unescape(TemplateHelper.Instance.ServiceUsing) + Regex.Unescape(TemplateHelper.Instance.ServiceNamespace)  +Regex.Unescape(TemplateHelper.Instance.ServiceClassStart)+Regex.Unescape(TemplateHelper.Instance.ServiceConstructor)  + Regex.Unescape(TemplateHelper.Instance.ServiceGetAll) + Regex.Unescape(TemplateHelper.Instance.ServiceGetById) + Regex.Unescape(TemplateHelper.Instance.ServiceAdd) + Regex.Unescape(TemplateHelper.Instance.ServiceUpdate) + Regex.Unescape(TemplateHelper.Instance.ServiceDelete) + Regex.Unescape(TemplateHelper.Instance.ServiceClassEnd) + Regex.Unescape(TemplateHelper.Instance.ServiceNamespaceEnd));
            string classDirectory = Path.Combine(apiPath, $"{apiName}.Infrastructure", "Service");
            Directory.CreateDirectory(classDirectory);
            string classPath = Path.Combine(classDirectory, $"{className}Service.cs");
            classContent.Replace("{apiName}", $"{apiName}").Replace("{className}", $"{className}").Replace("{IdName}", $"{IdName}");
            File.WriteAllText(classPath, classContent.ToString());
        }
    }
}
