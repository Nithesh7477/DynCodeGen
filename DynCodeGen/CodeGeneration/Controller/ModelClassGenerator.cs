using DynCodeGen.CodeGeneration.CodeTemplate;
using System;
using System.Collections.Generic;
using System.DirectoryServices.ActiveDirectory;
using System.Linq;
using System.Runtime;
using System.Text;
using System.Text.RegularExpressions;
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

                string filePath = Path.Combine(modelClassPath, $"{className}.cs");

                if (File.Exists(filePath))
                {
                    throw new ApplicationException("Code Duplication");
                }
                // Start building the class definition
                StringBuilder classDefinition = new StringBuilder();
                classDefinition.AppendLine(Regex.Unescape(TemplateHelper.Instance.ModelUsing) + Regex.Unescape(TemplateHelper.Instance.ModelClassStart).Replace("{className}", $"{className}"));

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
                        propertyType = Regex.Unescape(TemplateHelper.Instance.ModelOnetomany.Replace("{propertyType}", $"{propertyType}")); // Adjusting for one-to-many relationship
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
                    classDefinition.AppendLine(Regex.Unescape(TemplateHelper.Instance.ModelClassProperty.Replace("{propertyName}", $"{propertyName}").Replace("{propertyType}", $"{propertyType}")));
                }

                // Close the class definition
                classDefinition.AppendLine("}");

                // Write the class definition to a file
                File.WriteAllText(Path.Combine(modelClassPath, $"{className}.cs"), classDefinition.ToString());
            }
        }
        public static void GenerateModelClassesFromDataForSp(Dictionary<string, List<Tuple<string, string, string, string>>> sheetsData, string requestPath, string responsePath)
        {
            int counter = 0;

            if (!Directory.Exists(requestPath))
            {
                Directory.CreateDirectory(requestPath);
            }
            if (!Directory.Exists(responsePath))
            {
                Directory.CreateDirectory(responsePath);
            }
            foreach (var sheetEntry in sheetsData)
            {
                string className = $"{sheetEntry.Key}"; // Class name from the sheet name
                var properties = sheetEntry.Value; // List of tuples containing property details
                StringBuilder requestclassDefinition = new StringBuilder(Regex.Unescape(TemplateHelper.Instance.ModelUsing) + Regex.Unescape(TemplateHelper.Instance.ModelClassStart).Replace("{className}", $"Request{className}"));
                StringBuilder responseclassDefinition = new StringBuilder(Regex.Unescape(TemplateHelper.Instance.ModelUsing) +Regex.Unescape(TemplateHelper.Instance.ModelClassStart).Replace("{className}", $"Response{className}")+ Regex.Unescape(TemplateHelper.Instance.ModelClassStartKey));
                //List<string> propertyMode = new List<string>();
                // Iterate through each property (tuple) in the list
                foreach (var property in properties)
                {
                    string propertyName = property.Item1; // Property name
                    string propertyType = property.Item2; // Property Data type
                    if (property.Item3 == "INPUT")
                    {
                        requestclassDefinition.AppendLine(Regex.Unescape(TemplateHelper.Instance.ModelClassProperty.Replace("{propertyName}", $"{propertyName}").Replace("{propertyType}", $"{propertyType}")));
                        counter++;
                    }

                    else if (property.Item3 == "OUTPUT")
                    {
                        responseclassDefinition.AppendLine(Regex.Unescape(TemplateHelper.Instance.ModelClassProperty.Replace("{propertyName}", $"{propertyName}").Replace("{propertyType}", $"{propertyType}")));
                    }
                    if (properties.Count() == counter)
                    {
                        responseclassDefinition.AppendLine(Regex.Unescape(TemplateHelper.Instance.ModelClassStartKeyProperty).Replace("{className}", $"Response{className}"));
                    }
                }
                counter = 0;
                requestclassDefinition.AppendLine("}");
                responseclassDefinition.AppendLine("}");
                File.WriteAllText(Path.Combine(requestPath, $"Request{className}.cs"), requestclassDefinition.ToString());
                File.WriteAllText(Path.Combine(responsePath, $"Response{className}.cs"), responseclassDefinition.ToString());

            }
        }

        public static void GenerateModelClassesFromDataAdo(Dictionary<string, List<Tuple<string, string, string>>> sheetsData, string requestPath, string responsePath)
        {
            if (!Directory.Exists(requestPath))
            {
                Directory.CreateDirectory(requestPath);
            }
            if (!Directory.Exists(responsePath))
            {
                Directory.CreateDirectory(responsePath);
            }

            foreach (var sheetEntry in sheetsData)
            {
                string className = sheetEntry.Key; // Class name from the sheet name
                var properties = sheetEntry.Value; // List of tuples containing property details

                StringBuilder requestClassDefinition = new StringBuilder();
                StringBuilder responseClassDefinition = new StringBuilder();

                bool hasInput = false;
                bool hasOutput = false;

                foreach (var property in properties)
                {
                    string propertyName = property.Item1; // Property name
                    string propertyType = property.Item2; // Property type
                    string parameterType = property.Item3; // ParameterType

                    if (parameterType.Equals("INPUT", StringComparison.OrdinalIgnoreCase))
                    {
                        hasInput = true;
                        requestClassDefinition.AppendLine(Regex.Unescape(TemplateHelper.Instance.ModelClassProperty.Replace("{propertyName}", $"{propertyName}").Replace("{propertyType}", $"{propertyType}")));
                    }
                    else if (parameterType.Equals("OUTPUT", StringComparison.OrdinalIgnoreCase))
                    {
                        hasOutput = true;
                        responseClassDefinition.AppendLine(Regex.Unescape(TemplateHelper.Instance.ModelClassProperty.Replace("{propertyName}", $"{propertyName}").Replace("{propertyType}", $"{propertyType}")));
                    }
                }

                if (hasInput)
                {
                    requestClassDefinition.Insert(0, Regex.Unescape(TemplateHelper.Instance.ModelUsing) + Regex.Unescape(TemplateHelper.Instance.ModelClassStart).Replace("{className}", $"Request{className}"));
                    requestClassDefinition.AppendLine("}");
                    File.WriteAllText(Path.Combine(requestPath, $"Request{className}.cs"), requestClassDefinition.ToString());
                }

                if (hasOutput)
                {
                    responseClassDefinition.Insert(0, Regex.Unescape(TemplateHelper.Instance.ModelUsing) + Regex.Unescape(TemplateHelper.Instance.ModelClassStart).Replace("{className}", $"Response{className}"));
                    responseClassDefinition.AppendLine("}");
                    File.WriteAllText(Path.Combine(responsePath, $"Response{className}.cs"), responseClassDefinition.ToString());
                }
            }
        }

        public static void GenerateDBSettingsModelClass(string modelPath)
        {
            if (!Directory.Exists(modelPath))
            {
                Directory.CreateDirectory(modelPath);
            }

            string className = "ConnectionStrings";

            StringBuilder ClassDefinition = new StringBuilder();

            string propertyName = "DefaultConnection";
            string propertyType = "string";

            ClassDefinition.AppendLine(Regex.Unescape(TemplateHelper.Instance.ModelClassProperty.Replace("{propertyName}", $"{propertyName}").Replace("{propertyType}", $"{propertyType}")));

            ClassDefinition.Insert(0, Regex.Unescape(TemplateHelper.Instance.ModelUsing) + Regex.Unescape(TemplateHelper.Instance.ModelClassStart).Replace("{className}", $"{className}"));
            ClassDefinition.AppendLine("}");
            File.WriteAllText(Path.Combine(modelPath, $"{className}.cs"), ClassDefinition.ToString());
        }
    }
}
