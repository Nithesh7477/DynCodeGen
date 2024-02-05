using DynCodeGen.CodeGeneration.CodeTemplate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace DynCodeGen.CodeGeneration.Controller
{
    public class SqlHelperGenerator
    {
        public static void GenerateSqlHelperClass(string apiName, string apiPath)
        {
            StringBuilder sqlHelperClassContent = new StringBuilder();
            sqlHelperClassContent.AppendLine(Regex.Unescape(TemplateHelper.Instance.SqlHelperNamespace).Replace("{apiName}", apiName));
            sqlHelperClassContent.AppendLine(Regex.Unescape(TemplateHelper.Instance.SqlHelperUsings));
            sqlHelperClassContent.AppendLine(Regex.Unescape(TemplateHelper.Instance.SqlHelperClassStart));
            sqlHelperClassContent.AppendLine(Regex.Unescape(TemplateHelper.Instance.SqlHelperSetConnectionString));
            sqlHelperClassContent.AppendLine(Regex.Unescape(TemplateHelper.Instance.SqlHelperExecutionType));
            sqlHelperClassContent.AppendLine(Regex.Unescape(TemplateHelper.Instance.SqlHelperExecuteSelect));
            sqlHelperClassContent.AppendLine(Regex.Unescape(TemplateHelper.Instance.SqlHelperExecuteNonQuery));
            sqlHelperClassContent.AppendLine(Regex.Unescape(TemplateHelper.Instance.SqlHelperConvertDataTableToList));
            sqlHelperClassContent.AppendLine(Regex.Unescape(TemplateHelper.Instance.SqlHelperGetItem));
            sqlHelperClassContent.AppendLine(Regex.Unescape(TemplateHelper.Instance.SqlHelperClassEnd));

            string classDirectory = Path.Combine(apiPath, $"{apiName}.Infrastructure", "DataAccess");
            string classPath = Path.Combine(classDirectory, "SqlHelper.cs");

            Directory.CreateDirectory(classDirectory);
            File.WriteAllText(classPath, sqlHelperClassContent.ToString());
        }
    }
}
