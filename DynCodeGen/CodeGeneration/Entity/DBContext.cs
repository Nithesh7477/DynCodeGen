using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DynCodeGen.CodeGeneration.Entity
{
    public class DBContext
    {
        public static void GenerateApplicationDbContext(string dbContextPath, string namespaceName)
        {
            StringBuilder dbContextContent = new StringBuilder();

            dbContextContent.AppendLine("using Microsoft.EntityFrameworkCore;");
            dbContextContent.AppendLine();
            dbContextContent.AppendLine($"namespace {namespaceName}.Data");
            dbContextContent.AppendLine("{");
            dbContextContent.AppendLine("    public class ApplicationDbContext : DbContext");
            dbContextContent.AppendLine("    {");
            dbContextContent.AppendLine("        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)");
            dbContextContent.AppendLine("        {");
            dbContextContent.AppendLine("        }");
            dbContextContent.AppendLine();
            dbContextContent.AppendLine("        // DBSets go here");
            dbContextContent.AppendLine("    }");
            dbContextContent.AppendLine("}");

            File.WriteAllText(dbContextPath, dbContextContent.ToString());
        }

        public static void UpdateApplicationDbContextWithModels(Dictionary<string, List<Tuple<string, string, string, string>>> sheetsData, string dbContextPath)
        {
            StringBuilder dbContextAdditions = new StringBuilder();

            foreach (var sheetEntry in sheetsData)
            {
                string className = sheetEntry.Key;
                dbContextAdditions.AppendLine($"public DbSet<{className}> {className}Set {{ get; set; }}");
            }

            // Now, you can append these DbSet properties to the ApplicationDbContext
            string dbContextContent = File.ReadAllText(dbContextPath);
            int insertionIndex = dbContextContent.IndexOf("// DBSets go here");

            if (insertionIndex > -1)
            {
                dbContextContent = dbContextContent.Insert(insertionIndex, dbContextAdditions.ToString());
                File.WriteAllText(dbContextPath, dbContextContent);
            }
        }
    }
}
