using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DynCodeGen.CodeGeneration.Controller
{
    public class ServiceGenerator
    {
        public static void GenerateServiceImplementation(string apiName, string apiPath, string className, string IdName)
        {
            StringBuilder classContent = new StringBuilder();
            classContent.AppendLine($"using {apiName}.Application.IRepository;");
            classContent.AppendLine($"using {apiName}.Application.IService;");
            classContent.AppendLine();
            classContent.AppendLine($"namespace {apiName}.Infrastructure.Service");
            classContent.AppendLine("{");
            classContent.AppendLine($"    public class {className}Service : I{className}Service");
            classContent.AppendLine("    {");
            classContent.AppendLine($"        private readonly I{className}Repository _repository;");
            classContent.AppendLine();
            classContent.AppendLine($"        public {className}Service(I{className}Repository repository)");
            classContent.AppendLine("        {");
            classContent.AppendLine("            _repository = repository;");
            classContent.AppendLine("        }");
            classContent.AppendLine();

            // GetAll Method
            classContent.AppendLine($"        public IEnumerable<{className}> GetAll()");
            classContent.AppendLine("        {");
            classContent.AppendLine("            return _repository.GetAll();");
            classContent.AppendLine("        }");

            // GetById Method
            classContent.AppendLine();
            classContent.AppendLine($"        public {className} GetById(int {IdName})");
            classContent.AppendLine("        {");
            classContent.AppendLine($"            return _repository.GetById({IdName});");
            classContent.AppendLine("        }");

            // Add Method
            classContent.AppendLine();
            classContent.AppendLine($"        public void Add({className} entity)");
            classContent.AppendLine("        {");
            classContent.AppendLine("            _repository.Add(entity);");
            classContent.AppendLine("        }");

            // Update Method
            classContent.AppendLine();
            classContent.AppendLine($"        public void Update({className} entity)");
            classContent.AppendLine("        {");
            classContent.AppendLine("            _repository.Update(entity);");
            classContent.AppendLine("        }");

            // Delete Method
            classContent.AppendLine();
            classContent.AppendLine($"        public void Delete(int {IdName})");
            classContent.AppendLine("        {");
            classContent.AppendLine($"            _repository.Delete({IdName});");
            classContent.AppendLine("        }");

            classContent.AppendLine("    }");
            classContent.AppendLine("}");

            string classDirectory = Path.Combine(apiPath, $"{apiName}.Infrastructure", "Service");
            Directory.CreateDirectory(classDirectory);
            string classPath = Path.Combine(classDirectory, $"{className}Service.cs");
            File.WriteAllText(classPath, classContent.ToString());
        }
    }
}
