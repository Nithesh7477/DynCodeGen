using DynCodeGen.CodeGeneration.CodeTemplate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace DynCodeGen.CodeGeneration.Controller
{
    public class RepositoryGenerator
    {
        public static void GenerateRepositoryImplementation(string apiName, string apiPath, string className, string IdName)
        {
            StringBuilder classContent = new StringBuilder(Regex.Unescape(TemplateHelper.Instance.RepositoryUsing) + Regex.Unescape(TemplateHelper.Instance.RepositoryNamespace) + Regex.Unescape(TemplateHelper.Instance.RepositoryClassStart)+Regex.Unescape(TemplateHelper.Instance.RepositoryConstructor) + Regex.Unescape(TemplateHelper.Instance.RepositoryGetAll) + Regex.Unescape(TemplateHelper.Instance.RepositoryGetById) + Regex.Unescape(TemplateHelper.Instance.RepositoryAdd)+ Regex.Unescape(TemplateHelper.Instance.RepositoryUpdate)+ Regex.Unescape(TemplateHelper.Instance.RepositoryDelete)+ Regex.Unescape(TemplateHelper.Instance.RepositoryClassEnd)+ Regex.Unescape(TemplateHelper.Instance.RepositoryNamespaceEnd));        
            string classDirectory = Path.Combine(apiPath, $"{apiName}.Infrastructure", "Repository");
            Directory.CreateDirectory(classDirectory); // Create the directory if it doesn't exist
            string classPath = Path.Combine(classDirectory, $"{className}Repository.cs");
            classContent.Replace("{apiName}", $"{apiName}").Replace("{className}", $"{className}").Replace("{IdName}", $"{IdName}");
            File.WriteAllText(classPath, classContent.ToString());
        }
    }
}
