using DynCodeGen.CodeGeneration.CodeTemplate;
using Microsoft.Extensions.Primitives;
using OfficeOpenXml.Drawing.Chart.ChartEx;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace DynCodeGen.CodeGeneration.Controller
{
    public class RepositoryGenerator
    {
        public static void GenerateRepositoryImplementation(string apiName, string apiPath, string className, string IdName, DataTable dt)
        {
            StringBuilder classContent = new StringBuilder(Regex.Unescape(TemplateHelper.Instance.RepositoryUsing) + Regex.Unescape(TemplateHelper.Instance.RepositoryNamespace) + Regex.Unescape(TemplateHelper.Instance.RepositoryClassStart) + Regex.Unescape(TemplateHelper.Instance.RepositoryConstructor) + Regex.Unescape(TemplateHelper.Instance.RepositoryMethodComments) + Regex.Unescape(TemplateHelper.Instance.RepositoryClassEnd) + Regex.Unescape(TemplateHelper.Instance.RepositoryNamespaceEnd));
            string classDirectory = Path.Combine(apiPath, $"{apiName}.Infrastructure", "Repository");
            string classPath = Path.Combine(classDirectory, $"{className}Repository.cs");
            var temp = dt.Rows.Cast<DataRow>()
                  .FirstOrDefault(x => x.Field<string>("Table") == className);
            if (temp[0] == className)
            {
                if ((bool)temp[1] == true)
                {
                    TemplateHelper.InsertCodeBeforeComments(classContent, Regex.Unescape(TemplateHelper.Instance.RepositoryGetById), "// Get");
                }
                if ((bool)temp[2] == true)
                {
                    TemplateHelper.InsertCodeBeforeComments(classContent, Regex.Unescape(TemplateHelper.Instance.RepositoryGetAll), "// GetAll");
                }
                if ((bool)temp[3] == true)
                {
                    if ((bool)temp[1] == true)
                    {
                        TemplateHelper.InsertCodeBeforeComments(classContent, Regex.Unescape(TemplateHelper.Instance.RepositoryAdd), "// Insert");
                    }
                    else
                    {
                        TemplateHelper.InsertCodeBeforeComments(classContent, Regex.Unescape(TemplateHelper.Instance.RepositoryGetById), "// Get");
                        TemplateHelper.InsertCodeBeforeComments(classContent, Regex.Unescape(TemplateHelper.Instance.RepositoryAdd), "// Insert");
                    }
                }
                if ((bool)temp[4] == true)
                {
                    TemplateHelper.InsertCodeBeforeComments(classContent, Regex.Unescape(TemplateHelper.Instance.RepositoryUpdate), "// Update");
                }
                if ((bool)temp[5] == true)
                {
                    if ((bool)temp[1] == false && (bool)temp[3] == true)
                    {
                        TemplateHelper.InsertCodeBeforeComments(classContent, Regex.Unescape(TemplateHelper.Instance.RepositoryDelete), "// Delete");
                    }
                    else if ((bool)temp[1] == false && (bool)temp[3] == false)
                    {
                        TemplateHelper.InsertCodeBeforeComments(classContent, Regex.Unescape(TemplateHelper.Instance.RepositoryGetById), "// Get");
                        TemplateHelper.InsertCodeBeforeComments(classContent, Regex.Unescape(TemplateHelper.Instance.RepositoryDelete), "// Delete");
                    }
                }
            }
            Directory.CreateDirectory(classDirectory); // Create the directory if it doesn't exist
            classContent.Replace("{apiName}", $"{apiName}").Replace("{className}", $"{className}").Replace("{IdName}", $"{IdName}");
            File.WriteAllText(classPath, classContent.ToString());
        }
        public static void GenerateSPRepositoryImplementation(Dictionary<string, List<Tuple<string, string, string, string>>> sheetsData, string apiName, string apiPath, string className, string IdName, DataTable dt)
        {
            StringBuilder classContent = new StringBuilder(Regex.Unescape(TemplateHelper.Instance.RepositoryUsing) + Regex.Unescape(TemplateHelper.Instance.RepositoryNamespace) + Regex.Unescape(TemplateHelper.Instance.RepositorySPClassStart) + Regex.Unescape(TemplateHelper.Instance.RepositorySPConstructor) + Regex.Unescape(TemplateHelper.Instance.RepositorySPMethodComments) + Regex.Unescape(TemplateHelper.Instance.RepositoryClassEnd) + Regex.Unescape(TemplateHelper.Instance.RepositoryNamespaceEnd));
            StringBuilder sqlStringBuilder = new StringBuilder("EXEC {className} ").Replace("{className}", $"{className}");
            StringBuilder paramStringBuilder = new StringBuilder();
            string classDirectory = Path.Combine(apiPath, $"{apiName}.Infrastructure", "Repository");
            string classPath = Path.Combine(classDirectory, $"{className}Repository.cs");
            var temp = dt.Rows.Cast<DataRow>()
                  .FirstOrDefault(x => x.Field<string>("SP_Name") == className);
            if (temp[0] == className)
            {
                if ((bool)temp[1] == true)
                {
                    TemplateHelper.InsertCodeBeforeComments(classContent, Regex.Unescape(TemplateHelper.Instance.RepositoryGetMethod), "// GET/GETALL");
                    foreach (var sheetEntry in sheetsData)
                    {
                        if (sheetEntry.Key == className)
                        {
                            var properties = sheetEntry.Value;
                            foreach (var property in properties)
                            {
                                string propertyName = property.Item1; // Property name
                                string propertyType = property.Item2; // Property Data type
                                if (property.Item3 == "INPUT")
                                {
                                    TemplateHelper.InsertCodeBeforeComments(classContent, Regex.Unescape(TemplateHelper.Instance.SPInput.Replace("{IdName}", $"{propertyName}")), "// Input");
                                    sqlStringBuilder.Append($"@{propertyName},");
                                    paramStringBuilder.Append($"{propertyName},");

                                    sqlStringBuilder.Length -= 0;

                                }
                            }
                        }
                    }
                }
                if ((bool)temp[2] == true)
                {
                    TemplateHelper.InsertCodeBeforeComments(classContent, Regex.Unescape(TemplateHelper.Instance.RepositoryPostMethod), "// INSERT/UPDATE");
                    foreach (var sheetEntry in sheetsData)
                    {
                        if (sheetEntry.Key == className)
                        {
                            var properties = sheetEntry.Value;
                            foreach (var property in properties)
                            {
                                string propertyName = property.Item1; // Property name
                                string propertyType = property.Item2; // Property Data type
                                if (property.Item3 == "INPUT")
                                {
                                    TemplateHelper.InsertCodeBeforeComments(classContent, Regex.Unescape(TemplateHelper.Instance.SPInput.Replace("{IdName}", $"{propertyName}")), "// Input");
                                    sqlStringBuilder.Append($"@{propertyName},");
                                    paramStringBuilder.Append($"{propertyName},");

                                    sqlStringBuilder.Length -= 0;                                  

                                }
                            }
                        }
                    }
                }
            }
            if (sqlStringBuilder.Length > 0)
            {
                sqlStringBuilder.Length--;
            }

            if (paramStringBuilder.Length > 0)
            {
                paramStringBuilder.Length--;
            }
            Directory.CreateDirectory(classDirectory); // Create the directory if it doesn't exist
            classContent.Replace("{apiName}", $"{apiName}").Replace("{className}", $"{className}").Replace("{Execute Statement}", sqlStringBuilder.ToString()).Replace("{Parameters}", paramStringBuilder.ToString());
            File.WriteAllText(classPath, classContent.ToString());
        }

        public static void GenerateRepositoryImplementationAdo(string apiName, string apiPath, string className, DataTable dt, Dictionary<string, string> inputParameters)
        {
            StringBuilder classContent = new StringBuilder(Regex.Unescape(TemplateHelper.Instance.RepositoryUsingAdo).Replace("{apiName}", apiName)
                + Regex.Unescape(TemplateHelper.Instance.RepositoryNamespace).Replace("{apiName}", apiName)
                + Regex.Unescape(TemplateHelper.Instance.RepositoryClassStartAdo).Replace("{className}", className));

            // Add constructor
            string constructor = Regex.Unescape(TemplateHelper.Instance.RepositoryConstructorAdo).Replace("{className}", className);
            classContent.AppendLine(constructor);

            var temp = dt.Rows.Cast<DataRow>()
                  .FirstOrDefault(x => x.Field<string>("Stored Procedure") == className);
            if (temp[0] == className)
            {
                if ((bool)temp[1] == true)
                {
                    if (inputParameters.Count == 0)
                    {
                        string getMethodStart = Regex.Unescape(TemplateHelper.Instance.RepositoryGetMethodStartAdo).Replace("{className}", className).Replace("{Request}", "").Replace("{classNameInput}", "");
                        classContent.AppendLine(getMethodStart);
                    }
                    else
                    {
                        string getMethodStart = Regex.Unescape(TemplateHelper.Instance.RepositoryGetMethodStartAdo).Replace("{className}", className).Replace("{Request}", "Request").Replace("{classNameInput}", className);
                        classContent.AppendLine(getMethodStart);
                    }

                    foreach (KeyValuePair<string, string> parameter in inputParameters)
                    {
                        string type = parameter.Value;
                        if (type == "string")
                        {
                            type = "VarChar";
                        }
                        else if (type == "int")
                        {
                            type = "Int";
                        }
                        string getMethodMiddle = Regex.Unescape(TemplateHelper.Instance.RepositoryGetMethodMiddleAdo).Replace("{parameterName}", parameter.Key).Replace("{parameterType}", type).Replace("{className}", className);
                        classContent.AppendLine(getMethodMiddle);
                    }

                    string getMethodEnd = Regex.Unescape(TemplateHelper.Instance.RepositoryGetMethodEndAdo).Replace("{className}", className);
                    classContent.AppendLine(getMethodEnd);
                }
                if ((bool)temp[2] == true)
                {
                    string postMethodStart = Regex.Unescape(TemplateHelper.Instance.RepositoryPostMethodStartAdo).Replace("{className}", className);
                    classContent.AppendLine(postMethodStart);

                    foreach (KeyValuePair<string, string> parameter in inputParameters)
                    {
                        string type = parameter.Value;
                        if (type == "string")
                        {
                            type = "VarChar";
                        }
                        else if (type == "int")
                        {
                            type = "Int";
                        }
                        string PostMethodMiddle = Regex.Unescape(TemplateHelper.Instance.RepositoryPostMethodMiddleAdo).Replace("{parameterName}", parameter.Key).Replace("{parameterType}", type).Replace("{className}", className);
                        classContent.AppendLine(PostMethodMiddle);
                    }

                    string postMethodEnd = Regex.Unescape(TemplateHelper.Instance.RepositoryPostMethodEndAdo).Replace("{className}", className);
                    classContent.AppendLine(postMethodEnd);
                }

            }

            classContent.Append(Regex.Unescape(TemplateHelper.Instance.RepositoryClassEnd)
                + Regex.Unescape(TemplateHelper.Instance.RepositoryNamespaceEnd));

            string classDirectory = Path.Combine(apiPath, $"{apiName}.Infrastructure", "Repository");
            string classPath = Path.Combine(classDirectory, $"usp{className}Repository.cs");

            Directory.CreateDirectory(classDirectory);
            File.WriteAllText(classPath, classContent.ToString());
        }

        public static void GenerateBaseRepositoryClass(string apiName, string apiPath)
        {
            StringBuilder baseRepositoryClassContent = new StringBuilder();
            baseRepositoryClassContent.AppendLine(Regex.Unescape(TemplateHelper.Instance.BaseRepository).Replace("{apiName}", apiName));

            string classDirectory = Path.Combine(apiPath, $"{apiName}.Infrastructure", "Repository");
            string classPath = Path.Combine(classDirectory, "BaseRepository.cs");

            Directory.CreateDirectory(classDirectory);
            File.WriteAllText(classPath, baseRepositoryClassContent.ToString());
        }

    }
}
