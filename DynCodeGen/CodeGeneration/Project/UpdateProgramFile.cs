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
    public class UpdateProgramFile
    {
        public static void CreateOrUpdateProgramFile(string apiName, string apiPath)
        {
            string programFilePath = Path.Combine(apiPath, $"{apiName}.WebAPI", "Program.cs");
            StringBuilder programFileContent = new(Regex.Unescape(TemplateHelper.Instance.ProgramUsing)+ Regex.Unescape(TemplateHelper.Instance.ProgramNamespace)+ Regex.Unescape(TemplateHelper.Instance.ProgramClassStart)+ Regex.Unescape(TemplateHelper.Instance.ProgramMainMethod)+ Regex.Unescape(TemplateHelper.Instance.ProgramCreateHostBuilderMethod)+ Regex.Unescape(TemplateHelper.Instance.ProgramClassEnd)+ Regex.Unescape(TemplateHelper.Instance.ProgramNamespaceEnd));
            programFileContent.Replace("{apiName}", $"{apiName}");
            File.WriteAllText(programFilePath, programFileContent.ToString());
        }
    }
}
