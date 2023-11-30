using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DynCodeGen.CodeGeneration.Controller
{
    public class InterfaceGenerator
    {
        public static void GenerateServiceInterface(string apiName, string apiPath, string className, string IdName)
        {
            StringBuilder interfaceContent = new StringBuilder();
            interfaceContent.AppendLine($"namespace {apiName}.Application.IService");
            interfaceContent.AppendLine("{");
            interfaceContent.AppendLine($"    public interface I{className}Service");
            interfaceContent.AppendLine("    {");
            interfaceContent.AppendLine($"        IEnumerable<{className}> GetAll();");
            interfaceContent.AppendLine($"        {className} GetById(int {IdName});");
            interfaceContent.AppendLine($"        void Add({className} entity);");
            interfaceContent.AppendLine($"        void Update({className} entity);");
            interfaceContent.AppendLine($"        void Delete(int {IdName});");
            interfaceContent.AppendLine("    }");
            interfaceContent.AppendLine("}");
            string interfaceDirectory = Path.Combine(apiPath, $"{apiName}.Application", "IService");
            Directory.CreateDirectory(interfaceDirectory);
            string interfacePath = Path.Combine(interfaceDirectory, $"I{className}Service.cs");
            File.WriteAllText(interfacePath, interfaceContent.ToString());
        }

        public static void GenerateRepositoryInterface(string apiName, string apiPath, string className, string IdName)
        {
            StringBuilder interfaceContent = new StringBuilder();
            interfaceContent.AppendLine($"namespace {apiName}.Application.IRepository");
            interfaceContent.AppendLine("{");
            interfaceContent.AppendLine($"    public interface I{className}Repository");
            interfaceContent.AppendLine("    {");
            interfaceContent.AppendLine($"        IEnumerable<{className}> GetAll();");
            interfaceContent.AppendLine($"        {className} GetById(int {IdName});");
            interfaceContent.AppendLine($"        void Add({className} entity);");
            interfaceContent.AppendLine($"        void Update({className} entity);");
            interfaceContent.AppendLine($"        void Delete(int {IdName});");
            interfaceContent.AppendLine("    }");
            interfaceContent.AppendLine("}");
            string interfaceDirectory = Path.Combine(apiPath, $"{apiName}.Application", "IRepository");
            Directory.CreateDirectory(interfaceDirectory); // Create the directory if it doesn't exist
            string interfacePath = Path.Combine(interfaceDirectory, $"I{className}Repository.cs");
            File.WriteAllText(interfacePath, interfaceContent.ToString());
        }
    }
}
