namespace DynCodeGen.CodeGeneration.Controller
{
    using global::DynCodeGen.CodeGeneration.CodeTemplate;
    using global::DynCodeGen.CodeGeneration.Project;
    using Microsoft.VisualBasic;
    using System.Reflection;
    using System.Resources;
    using System.Text;
    using System.Text.RegularExpressions;
    using static System.Windows.Forms.VisualStyles.VisualStyleElement;
    using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

    public class ControllerGenerator
    {

        public static void GenerateController(string apiName, string apiPath, string className, string IdName)
        {
            StringBuilder controllerContent = new StringBuilder(Regex.Unescape(TemplateHelper.Instance.ContollerHeader)+ Regex.Unescape(TemplateHelper.Instance.ContollerNamespace) + Regex.Unescape(TemplateHelper.Instance.ContollerClass) + Regex.Unescape(TemplateHelper.Instance.ContollerGetAll) + Regex.Unescape(TemplateHelper.Instance.ContollerGet) + Regex.Unescape(TemplateHelper.Instance.ContollerAdd) + Regex.Unescape(TemplateHelper.Instance.ContollerDelete) + Regex.Unescape(TemplateHelper.Instance.ContollerUpdate) + Regex.Unescape(TemplateHelper.Instance.ContollerClassEnd) + Regex.Unescape(TemplateHelper.Instance.ContollerNamespaceEnd));
            controllerContent.Replace("{apiName}", $"{apiName}").Replace("{className}", $"{className}").Replace("{IdName}", $"{IdName}");
            string controllerDirectory = Path.Combine(apiPath, $"{apiName}.WebAPI", "Controllers");
            Directory.CreateDirectory(controllerDirectory);
            string controllerPath = Path.Combine(controllerDirectory, $"{className}Controller.cs");
            File.WriteAllText(controllerPath, controllerContent.ToString());
        }
    }
}
