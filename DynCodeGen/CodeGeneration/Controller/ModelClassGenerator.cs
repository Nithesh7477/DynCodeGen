using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DynCodeGen.CodeGeneration.Controller
{
    public class ModelClassGenerator
    {
        public static void GenerateModelClassesFromData(Dictionary<string, List<Tuple<string, string, string, string>>> sheetsData, string modelClassPath)
        {
            // Check if the directory exists, create if not
            if (!Directory.Exists(modelClassPath))
            {
                Directory.CreateDirectory(modelClassPath);
            }

            // Iterate through each entry in the dictionary
            foreach (var sheetEntry in sheetsData)
            {
                string className = sheetEntry.Key; // Class name from the sheet name
                var properties = sheetEntry.Value; // List of tuples containing property details

                // Start building the class definition
                StringBuilder classDefinition = new StringBuilder();
                classDefinition.AppendLine($"using System.ComponentModel.DataAnnotations;");
                classDefinition.AppendLine($"using System.ComponentModel.DataAnnotations.Schema;");
                classDefinition.AppendLine();
                classDefinition.AppendLine($"public class {className}");
                classDefinition.AppendLine("{");

                // Iterate through each property (tuple) in the list
                foreach (var property in properties)
                {
                    string propertyName = property.Item1; // Property name
                    string propertyType = property.Item2; // Property type
                    string annotations = property.Item3; // Annotations
                    string relationship = property.Item4; // Relationship

                    // Modify property type based on relationship
                    if (relationship.Equals("one to many", StringComparison.OrdinalIgnoreCase))
                    {
                        propertyType = $"virtual ICollection<{propertyType}>"; // Adjusting for one-to-many relationship
                    }

                    // Annotations as comments - Alternatively, these can be transformed into data annotations
                    if (!string.IsNullOrWhiteSpace(annotations))
                    {
                        var annotationsList = annotations.Split(',').ToList();
                        foreach (var annotation in annotationsList)
                        {
                            classDefinition.AppendLine($"[{annotation}]");
                        }
                    }

                    // Append property definition to the class
                    classDefinition.AppendLine($"    public {propertyType} {propertyName} {{ get; set; }}");
                    classDefinition.AppendLine();

                }

                // Close the class definition
                classDefinition.AppendLine("}");

                // Write the class definition to a file
                File.WriteAllText(Path.Combine(modelClassPath, $"{className}.cs"), classDefinition.ToString());
            }
        }
    }
}
