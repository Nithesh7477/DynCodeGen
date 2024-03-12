using DynCodeGen.CodeGeneration.CodeTemplate;
using OfficeOpenXml.Packaging.Ionic.Zip;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace DynCodeGen.CodeGeneration.Project
{
    public class AddExceptionMiddleware
    {
        public static void CreateExceptionMiddlewareFile(string apiName, string apiPath)
        {
            string startupFilePath = Path.Combine(apiPath, $"{apiName}.WebAPI\\ExceptionMiddleWare", "Exception.cs");
            StringBuilder startupFileContent = new StringBuilder(Regex.Unescape(TemplateHelper.Instance.ExceptionMiddlewareClass));
            startupFileContent.Replace("{apiName}", $"{apiName}");
            File.WriteAllText(startupFilePath, startupFileContent.ToString());
        }
    }

    public class AddMiddleWareResponse
    {
        public static void CreateAPIExceptionFile(string apiName, string apiPath)
        {
            string startupFilePath = Path.Combine(apiPath, $"{apiName}.WebAPI\\ExceptionMiddleWare", "MiddleWareException.cs");
            StringBuilder startupFileContent = new StringBuilder(Regex.Unescape(TemplateHelper.Instance.ApiExceptionClass));
            startupFileContent.Replace("{apiName}", $"{apiName}");
            File.WriteAllText(startupFilePath, startupFileContent.ToString());
        }
        public static void CreateAPIResponseFile(string apiName, string apiPath)
        {
            string startupFilePath = Path.Combine(apiPath, $"{apiName}.WebAPI\\ExceptionMiddleWare", "MiddleWareResponse.cs");
            StringBuilder startupFileContent = new StringBuilder(Regex.Unescape(TemplateHelper.Instance.APIResponseClass));
            startupFileContent.Replace("{apiName}", $"{apiName}");
            File.WriteAllText(startupFilePath, startupFileContent.ToString());
        }
        public static void CreateAPIResponseBaseFile(string apiName, string apiPath)
        {
            string startupFilePath = Path.Combine(apiPath, $"{apiName}.WebAPI\\ExceptionMiddleWare", "MiddleWareResponseBase.cs");
            StringBuilder startupFileContent = new StringBuilder(Regex.Unescape(TemplateHelper.Instance.APIResponseBaseClass));
            startupFileContent.Replace("{apiName}", $"{apiName}");
            File.WriteAllText(startupFilePath, startupFileContent.ToString());
        }

        public static void CreateAPIValidationErrorResponseFile(string apiName, string apiPath)
        {
            string startupFilePath = Path.Combine(apiPath, $"{apiName}.WebAPI\\ExceptionMiddleWare", "MiddleWareValidationErrorResponse.cs");
            StringBuilder startupFileContent = new StringBuilder(Regex.Unescape(TemplateHelper.Instance.APIValidationErrorResponseClass));
            startupFileContent.Replace("{apiName}", $"{apiName}");
            File.WriteAllText(startupFilePath, startupFileContent.ToString());
        }

        public static void CreateBadRequestExceptionFile(string apiName, string apiPath)
        {
            string startupFilePath = Path.Combine(apiPath, $"{apiName}.WebAPI\\ExceptionMiddleWare", "BadRequestException.cs");
            StringBuilder startupFileContent = new StringBuilder(Regex.Unescape(TemplateHelper.Instance.BadRequestExceptionClass));
            startupFileContent.Replace("{apiName}", $"{apiName}");
            File.WriteAllText(startupFilePath, startupFileContent.ToString());
        }
    }
}
