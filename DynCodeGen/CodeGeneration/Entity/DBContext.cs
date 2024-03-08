using DynCodeGen.CodeGeneration.CodeTemplate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace DynCodeGen.CodeGeneration.Entity
{
    public class DBContext
    {
        public static void GenerateApplicationDbContext(string apiName, string dbContextPath, string namespaceName)
        {
            StringBuilder dbContextContent = new StringBuilder(Regex.Unescape(TemplateHelper.Instance.DBcontextUsing.Replace("{apiName}", $"{apiName}")) + Regex.Unescape(TemplateHelper.Instance.DBcontextNamespace)+ Regex.Unescape(TemplateHelper.Instance.DBcontextClass));
            dbContextContent.Replace("{namespaceName}", $"{namespaceName}");
            File.WriteAllText(dbContextPath, dbContextContent.ToString());
        }

        public static void UpdateApplicationDbContextWithModels(Dictionary<string, List<Tuple<string, string, string, string>>> sheetsData, string dbContextPath)
        {
            StringBuilder dbContextAdditions = new StringBuilder();

            foreach (var sheetEntry in sheetsData)
            {
                string className = sheetEntry.Key;
                dbContextAdditions.AppendLine(Regex.Unescape(TemplateHelper.Instance.DBContextWithModels));
                dbContextAdditions.Replace("{className}", $"{className}");
            }

            // Now, you can append these DbSet properties to the ApplicationDbContext
            string dbContextContent = File.ReadAllText(dbContextPath);
            int insertionIndex = dbContextContent.IndexOf("//DBSets go here");

            if (insertionIndex > -1)
            {
                dbContextContent = dbContextContent.Insert(insertionIndex, dbContextAdditions.ToString());

                File.WriteAllText(dbContextPath, dbContextContent.ToString());
            }
        }
        public static void UpdateApplicationDbContextWithSPModels(Dictionary<string, List<Tuple<string, string, string, string>>> sheetsData, string dbContextPath)
        {
            StringBuilder dbContextAdditions = new StringBuilder();

            foreach (var sheetEntry in sheetsData)
            {
                string className = sheetEntry.Key;
                dbContextAdditions.AppendLine(Regex.Unescape(TemplateHelper.Instance.SpDBContext));
                dbContextAdditions.Replace("{className}", $"{className}");
            }

            // Now, you can append these DbSet properties to the ApplicationDbContext
            string dbContextContent = File.ReadAllText(dbContextPath);
            int insertionIndex = dbContextContent.IndexOf("//DBSets go here");

            if (insertionIndex > -1)
            {
                dbContextContent = dbContextContent.Insert(insertionIndex, dbContextAdditions.ToString());

                File.WriteAllText(dbContextPath, dbContextContent.ToString());
            }
        }
    }
}
