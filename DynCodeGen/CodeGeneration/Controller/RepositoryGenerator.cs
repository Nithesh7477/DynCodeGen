using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DynCodeGen.CodeGeneration.Controller
{
    public class RepositoryGenerator
    {
        public static void GenerateRepositoryImplementation(string apiName, string apiPath, string className, string IdName)
        {
            StringBuilder classContent = new StringBuilder();
            classContent.AppendLine($"using {apiName}.Infrastructure.Data;");
            classContent.AppendLine($"using {apiName}.Application.IRepository;");
            classContent.AppendLine();
            classContent.AppendLine($"namespace {apiName}.Infrastructure.Repository");
            classContent.AppendLine("{");
            classContent.AppendLine($"    public class {className}Repository : I{className}Repository");
            classContent.AppendLine("    {");
            classContent.AppendLine("        private readonly ApplicationDbContext _context;");
            classContent.AppendLine();
            classContent.AppendLine($"        public {className}Repository(ApplicationDbContext context)");
            classContent.AppendLine("        {");
            classContent.AppendLine("            _context = context;");
            classContent.AppendLine("        }");
            classContent.AppendLine();
            classContent.AppendLine($"        public IEnumerable<{className}> GetAll()");
            classContent.AppendLine("        {");
            classContent.AppendLine($"            return _context.{className}Set.ToList();");
            classContent.AppendLine("        }");

            // Add method
            classContent.AppendLine();
            classContent.AppendLine($"        public void Add({className} entity)");
            classContent.AppendLine("        {");
            classContent.AppendLine($"            _context.{className}Set.Add(entity);");
            classContent.AppendLine($"            _context.SaveChanges();");
            classContent.AppendLine("        }");

            // Update method
            classContent.AppendLine();
            classContent.AppendLine($"        public void Update({className} entity)");
            classContent.AppendLine("        {");
            classContent.AppendLine($"            _context.{className}Set.Update(entity);");
            classContent.AppendLine($"            _context.SaveChanges();");
            classContent.AppendLine("        }");

            // Delete method
            classContent.AppendLine();
            classContent.AppendLine($"        public void Delete(int {IdName})");
            classContent.AppendLine("        {");
            classContent.AppendLine($"            var entityToDelete = _context.{className}Set.FirstOrDefault(e => e.{IdName} == {IdName});");
            classContent.AppendLine($"            if (entityToDelete != null)");
            classContent.AppendLine("            {");
            classContent.AppendLine($"                _context.{className}Set.Remove(entityToDelete);");
            classContent.AppendLine($"            _context.SaveChanges();");
            classContent.AppendLine("            }");
            classContent.AppendLine("        }");

            // GetById method
            classContent.AppendLine();
            classContent.AppendLine($"        public {className} GetById(int {IdName})");
            classContent.AppendLine("        {");
            classContent.AppendLine($"            return _context.{className}Set.FirstOrDefault(e => e.{IdName} == {IdName});");
            classContent.AppendLine("        }");

            classContent.AppendLine("    }");
            classContent.AppendLine("}");

            string classDirectory = Path.Combine(apiPath, $"{apiName}.Infrastructure", "Repository");
            Directory.CreateDirectory(classDirectory); // Create the directory if it doesn't exist
            string classPath = Path.Combine(classDirectory, $"{className}Repository.cs");
            File.WriteAllText(classPath, classContent.ToString());
        }
    }
}
